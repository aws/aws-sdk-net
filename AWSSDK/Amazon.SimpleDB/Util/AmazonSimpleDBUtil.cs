/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-04-15
 */

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Amazon.SimpleDB.Util
{
    /// <summary>
    /// Provides a collection of static functions to:
    /// 1. Convert various values into strings that may be compared lexicographically
    /// 2. Decode a Base64 Encoded string
    /// 3. Decode an Amazon SimpleDB Attribute's properties
    /// 4. Decode an Amazon SimpleDB Item's properties and constituent Item(s)
    /// </summary>
    public static class AmazonSimpleDBUtil
    {
        /// <summary>
        /// Date format String, e.g. 2007-12-06T10:32:43.141-08:00
        /// </summary>
        private static string dateFormat = "yyyy-MM-ddTHH:mm:ss.fffzzzz";
        private static string base64Str = "base64";

        /// <summary>
        /// Encodes positive integer value into a string by zero-padding it up to the specified number of digits.
        /// </summary>
        /// <remarks>
        /// For example, the integer 123 encoded with a 6 digit maximum would be represented as 000123
        /// </remarks>
        /// <param name="number">positive integer to be encoded</param>
        /// <param name="maxNumDigits">maximum number of digits in the largest value in the data set</param>
        /// <returns>A string representation of the zero-padded integer</returns>
        public static string EncodeZeroPadding(int number, int maxNumDigits)
        {
            return number.ToString(CultureInfo.InvariantCulture).PadLeft(maxNumDigits, '0');
        }

        /// <summary>
        /// Encodes positive single-precision floating point value into a string by zero-padding it to the specified number of digits.
        /// </summary>
        /// <remarks>
        /// This function only zero-pads digits to the left of the decimal point.
        ///
        /// For example, the value 123.456 encoded with a 6 digit maximum would be represented as 000123.456
        /// </remarks>
        /// <param name="number">positive floating point value to be encoded</param>
        /// <param name="maxNumDigits">maximum number of digits in the largest value in the data set</param>
        /// <returns>A string representation of the zero-padded floating point value</returns>
        public static string EncodeZeroPadding(float number, int maxNumDigits)
        {
            string fltStr = number.ToString(CultureInfo.InvariantCulture);
            int decPt = fltStr.IndexOf('.');
            if (decPt == -1)
            {
                return fltStr.PadLeft(maxNumDigits, '0');
            }
            else
            {
                return fltStr.PadLeft(maxNumDigits + (fltStr.Length - decPt), '0');
            }
        }

        /// <summary>
        /// Encodes real integer value into a string by offsetting and zero-padding
        /// number up to the specified number of digits.  Use this encoding method if the data
        /// range set includes both positive and negative values.
        /// </summary>
        /// <remarks>
        /// For example, the integer value -123 offset by 1000 with a maximum of 6 digits would be:
        /// -123 + 1000, padded to 6 digits: 000877
        /// </remarks>
        /// <param name="number">integer to be encoded</param>
        /// <param name="maxNumDigits">maximum number of digits in the largest absolute value in the data set</param>
        /// <param name="offsetValue">offset value, has to be greater than absolute value of any negative number in the data set.</param>
        /// <returns>A string representation of the integer</returns>
        public static string EncodeRealNumberRange(int number, int maxNumDigits, int offsetValue)
        {
            return (number + offsetValue).ToString(CultureInfo.InvariantCulture).PadLeft(maxNumDigits, '0');
        }

        /// <summary>
        /// Encodes real float value into a string by offsetting and zero-padding
        /// number up to the specified number of digits.  Use this encoding method if the data
        /// range set includes both positive and negative values.
        /// </summary>
        /// <remarks>
        /// For example, the floating point value -123.456 offset by 1000 with
        /// a maximum of 6 digits to the left, and 4 to the right would be:
        /// 0008765440
        /// </remarks>
        /// <param name="number">floating point value to be encoded</param>
        /// <param name="maxDigitsLeft">maximum number of digits left of the decimal point in the largest absolute value in the data set</param>
        /// <param name="maxDigitsRight">maximum number of digits right of the decimal point in the largest absolute value in the data set, i.e. precision</param>
        /// <param name="offsetValue">offset value, has to be greater than absolute value of any negative number in the data set.</param>
        /// <returns>A string representation of the integer</returns>
        public static string EncodeRealNumberRange(float number, int maxDigitsLeft, int maxDigitsRight, int offsetValue)
        {
            long shiftMultiplier = (long)Math.Pow(10, maxDigitsRight);
            long shiftedNumber = (long)Math.Round((number + offsetValue) * shiftMultiplier);
            return shiftedNumber.ToString(CultureInfo.InvariantCulture).PadLeft(maxDigitsLeft + maxDigitsRight, '0');
        }

        /// <summary>
        /// Decodes zero-padded positive float value from the string representation
        /// </summary>
        /// <param name="value">zero-padded string representation of the float value</param>
        /// <returns>original float value</returns>
        public static float DecodeZeroPaddingFloat(string value)
        {
            return float.Parse(value, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Decodes zero-padded positive integer value from the string representation
        /// </summary>
        /// <param name="value">zero-padded string representation of the integer</param>
        /// <returns>original integer value</returns>
        public static int DecodeZeroPaddingInt(string value)
        {
            return int.Parse(value, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Decodes float value from the string representation that was created by using encodeRealNumberRange(..) function.
        /// </summary>
        /// <param name="value">string representation of the integer value</param>
        /// <param name="offsetValue">offset value that was used in the original encoding</param>
        /// <returns>original integer value</returns>
        public static int DecodeRealNumberRangeInt(string value, int offsetValue)
        {
            return (int)(long.Parse(value, CultureInfo.InvariantCulture) - offsetValue);
        }

        /// <summary>
        /// Decodes float value from the string representation that was created by using encodeRealNumberRange(..) function.
        /// </summary>
        /// <param name="value">string representation of the integer value</param>
        /// <param name="maxDigitsRight">maximum number of digits left of the decimal point in the largest absolute
        /// value in the data set (must be the same as the one used for encoding).</param>
        /// <param name="offsetValue">offset value that was used in the original encoding</param>
        /// <returns>original float value</returns>
        public static float DecodeRealNumberRangeFloat(string value, int maxDigitsRight, int offsetValue)
        {
            return (float)(long.Parse(value, CultureInfo.InvariantCulture) / Math.Pow(10, maxDigitsRight) - offsetValue);
        }

        /// <summary>
        /// Encodes date value into string format that can be compared lexicographically
        /// </summary>
        /// <param name="date">date value to be encoded</param>
        /// <returns>string representation of the date value</returns>
        public static string EncodeDate(DateTime date)
        {
            return date.ToString(dateFormat);
        }

        /// <summary>
        /// Decodes date value from the string representation created using encodeDate(..) function.
        /// </summary>
        /// <param name="value">string representation of the date value</param>
        /// <returns>original date value</returns>
        public static DateTime DecodeDate(string value)
        {
            return DateTime.ParseExact(value, dateFormat, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets the Current Date as an ISO8601 formatted Timestamp
        /// </summary>
        /// <returns>ISO8601 formatted current timestamp String</returns>
        public static string FormattedCurrentTimestamp
        {
            get
            {
                return Amazon.Util.AWSSDKUtils.FormattedCurrentTimestampISO8601;
            }
        }

        /// <summary>
        /// Decodes the base64 encoded properties of the Attribute.
        /// The Name and/or Value properties of an Attribute can be base64 encoded.
        /// </summary>
        /// <param name="inputAttribute">The properties of this Attribute will be decoded</param>
        /// <seealso cref="P:Amazon.SimpleDB.Model.Attribute.NameEncoding" />
        /// <seealso cref="P:Amazon.SimpleDB.Model.Attribute.ValueEncoding" />
        public static void DecodeAttribute(Amazon.SimpleDB.Model.Attribute inputAttribute)
        {
            if (null == inputAttribute)
            {
                throw new ArgumentNullException("inputAttribute", "The Attribute passed in was null");
            }

            string encoding = inputAttribute.NameEncoding;
            if (null != encoding)
            {
                if (String.Compare(encoding, base64Str, true) == 0)
                {
                    // The Name is base64 encoded
                    inputAttribute.Name = AmazonSimpleDBUtil.DecodeBase64String(inputAttribute.Name);
                    inputAttribute.NameEncoding = "";
                }
            }

            encoding = inputAttribute.ValueEncoding;
            if (null != encoding)
            {
                if (String.Compare(encoding, base64Str, true) == 0)
                {
                    // The Value is base64 encoded
                    inputAttribute.Value = AmazonSimpleDBUtil.DecodeBase64String(inputAttribute.Value);
                    inputAttribute.ValueEncoding = "";
                }
            }
        }

        /// <summary>
        /// Decodes the base64 properties of every SimpleDB Attribute specified in
        /// list of attributes specified as input.
        /// </summary>
        /// <param name="attributes">The Attributes in this list will be decoded</param>
        /// <seealso cref="P:Amazon.SimpleDB.Model.Attribute.NameEncoding" />
        /// <seealso cref="P:Amazon.SimpleDB.Model.Attribute.ValueEncoding" />
        /// <seealso cref="P:Amazon.SimpleDB.Util.AmazonSimpleDBUtil.DecodeAttribute" />
        public static void DecodeAttributes(List<Amazon.SimpleDB.Model.Attribute> attributes)
        {
            if (attributes != null &&
                attributes.Count > 0)
            {
                foreach (Amazon.SimpleDB.Model.Attribute at in attributes)
                {
                    AmazonSimpleDBUtil.DecodeAttribute(at);
                }
            }
        }

        /// <summary>
        /// Decodes the base64 encoded members of the Item if necessary.
        /// The Name property of an Item can be base64 encoded.
        /// This method also decodes any encoded properties of the Attributes
        /// associated with the Input Item.
        /// </summary>
        /// <param name="inputItem">The Item to be decoded</param>
        /// <seealso cref="P:Amazon.SimpleDB.Model.Item.NameEncoding" />
        /// <seealso cref="P:Amazon.SimpleDB.Util.AmazonSimpleDBUtil.DecodeAttributes" />
        public static void DecodeItem(Amazon.SimpleDB.Model.Item inputItem)
        {
            if (null == inputItem)
            {
                throw new ArgumentNullException("inputItem", "The Item passed in was null");
            }

            string encoding = inputItem.NameEncoding;
            if (null != encoding)
            {
                if (String.Compare(encoding, base64Str, true) == 0)
                {
                    // The Name is base64 encoded
                    inputItem.Name = AmazonSimpleDBUtil.DecodeBase64String(inputItem.Name);
                    inputItem.NameEncoding = "";
                }
            }

            AmazonSimpleDBUtil.DecodeAttributes(inputItem.Attribute);
        }

        /// <summary>
        /// Decodes the base64 encoded members of the Item List.
        /// </summary>
        /// <param name="inputItems">The Item List to be decoded</param>
        /// <seealso cref="P:Amazon.SimpleDB.Model.Item.NameEncoding" />
        /// <seealso cref="P:Amazon.SimpleDB.Util.AmazonSimpleDBUtil.DecodeAttributes" />
        /// <seealso cref="P:Amazon.SimpleDB.Util.AmazonSimpleDBUtil.DecodeItem" />
        public static void DecodeItems(List<Amazon.SimpleDB.Model.Item> inputItems)
        {
            if (inputItems != null &&
                inputItems.Count > 0)
            {
                foreach (Amazon.SimpleDB.Model.Item it in inputItems)
                {
                    AmazonSimpleDBUtil.DecodeItem(it);
                }
            }
        }

        /// <summary>
        /// Returns the Base64 decoded version of the input string.
        /// </summary>
        /// <param name="encoded">The Base64 encoded string</param>
        /// <returns>Decoded version of the Base64 input string</returns>
        public static string DecodeBase64String(string encoded)
        {
            if (null == encoded)
            {
                throw new ArgumentNullException("encoded", "The Encoded String passed in was null");
            }

            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encoded);
            return System.Text.UTF8Encoding.UTF8.GetString(encodedDataAsBytes);
        }
    }
}
