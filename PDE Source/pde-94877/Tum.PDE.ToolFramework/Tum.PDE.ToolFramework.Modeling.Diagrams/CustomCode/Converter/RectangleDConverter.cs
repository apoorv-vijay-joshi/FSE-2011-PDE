﻿using System;
using System.ComponentModel;
using System.Globalization;

namespace Tum.PDE.ToolFramework.Modeling.Diagrams.Converters
{   
    /// <remarks>
    /// Based on Dsl-Tools Diagrams RectangleDConverter implementation.
    /// </remarks>
    public class RectangleDConverter : System.ComponentModel.TypeConverter
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public RectangleDConverter()
        {
        }

        /// <summary>
        /// Can convert from logic.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;

            return base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// Can convert to logic.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
                return true;

            return base.CanConvertTo(context, destinationType);
        }

        /// <summary>
        /// Convert from logic.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string s = value as string;
            if (s != null)
            {
                s = s.Trim();

                if (s.Length == 0)
                    return null;
                
                if (culture == null)
                    culture = CultureInfo.CurrentCulture;
                
                char ch = culture.TextInfo.ListSeparator[0];
                char[] chArr = new char[] { ch };
                string[] sArr = s.Split(chArr);
                double[] dArr = new double[sArr.Length];

                TypeConverter typeConverter = TypeDescriptor.GetConverter(typeof(double));
                for (int i = 0; i < dArr.Length; i++)
                {
                    dArr[i] = (double)typeConverter.ConvertFromString(context, culture, sArr[i]);
                }

                if (dArr.Length == 4)
                    return new RectangleD(dArr[0], dArr[1], dArr[2], dArr[3]);

                throw new System.ArgumentException("FailedParseTextFormatXYWidthHeight from " + s, "value");
            }
            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// Convert to logic.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && (value is RectangleD))
            {
                RectangleD rectangleD = (RectangleD)value;

                if (culture == null)
                    culture = CultureInfo.CurrentCulture;

                string s = culture.TextInfo.ListSeparator + " ";
                
                TypeConverter typeConverter = TypeDescriptor.GetConverter(typeof(double));
                string[] sArr = new string[] {
                                               typeConverter.ConvertToString(context, culture, rectangleD.X), 
                                               typeConverter.ConvertToString(context, culture, rectangleD.Y), 
                                               typeConverter.ConvertToString(context, culture, rectangleD.Width), 
                                               typeConverter.ConvertToString(context, culture, rectangleD.Height) };
                return System.String.Join(s, sArr);
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

    } 
}
