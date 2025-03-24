/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the geo-maps-2020-11-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GeoMaps
{

    /// <summary>
    /// Constants used for properties of type ColorScheme.
    /// </summary>
    public class ColorScheme : ConstantClass
    {

        /// <summary>
        /// Constant Dark for ColorScheme
        /// </summary>
        public static readonly ColorScheme Dark = new ColorScheme("Dark");
        /// <summary>
        /// Constant Light for ColorScheme
        /// </summary>
        public static readonly ColorScheme Light = new ColorScheme("Light");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColorScheme(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColorScheme FindValue(string value)
        {
            return FindValue<ColorScheme>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColorScheme(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LabelSize.
    /// </summary>
    public class LabelSize : ConstantClass
    {

        /// <summary>
        /// Constant Large for LabelSize
        /// </summary>
        public static readonly LabelSize Large = new LabelSize("Large");
        /// <summary>
        /// Constant Small for LabelSize
        /// </summary>
        public static readonly LabelSize Small = new LabelSize("Small");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LabelSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LabelSize FindValue(string value)
        {
            return FindValue<LabelSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LabelSize(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MapFeatureMode.
    /// </summary>
    public class MapFeatureMode : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for MapFeatureMode
        /// </summary>
        public static readonly MapFeatureMode Disabled = new MapFeatureMode("Disabled");
        /// <summary>
        /// Constant Enabled for MapFeatureMode
        /// </summary>
        public static readonly MapFeatureMode Enabled = new MapFeatureMode("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MapFeatureMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MapFeatureMode FindValue(string value)
        {
            return FindValue<MapFeatureMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MapFeatureMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MapStyle.
    /// </summary>
    public class MapStyle : ConstantClass
    {

        /// <summary>
        /// Constant Hybrid for MapStyle
        /// </summary>
        public static readonly MapStyle Hybrid = new MapStyle("Hybrid");
        /// <summary>
        /// Constant Monochrome for MapStyle
        /// </summary>
        public static readonly MapStyle Monochrome = new MapStyle("Monochrome");
        /// <summary>
        /// Constant Satellite for MapStyle
        /// </summary>
        public static readonly MapStyle Satellite = new MapStyle("Satellite");
        /// <summary>
        /// Constant Standard for MapStyle
        /// </summary>
        public static readonly MapStyle Standard = new MapStyle("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MapStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MapStyle FindValue(string value)
        {
            return FindValue<MapStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MapStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScaleBarUnit.
    /// </summary>
    public class ScaleBarUnit : ConstantClass
    {

        /// <summary>
        /// Constant Kilometers for ScaleBarUnit
        /// </summary>
        public static readonly ScaleBarUnit Kilometers = new ScaleBarUnit("Kilometers");
        /// <summary>
        /// Constant KilometersMiles for ScaleBarUnit
        /// </summary>
        public static readonly ScaleBarUnit KilometersMiles = new ScaleBarUnit("KilometersMiles");
        /// <summary>
        /// Constant Miles for ScaleBarUnit
        /// </summary>
        public static readonly ScaleBarUnit Miles = new ScaleBarUnit("Miles");
        /// <summary>
        /// Constant MilesKilometers for ScaleBarUnit
        /// </summary>
        public static readonly ScaleBarUnit MilesKilometers = new ScaleBarUnit("MilesKilometers");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScaleBarUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScaleBarUnit FindValue(string value)
        {
            return FindValue<ScaleBarUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScaleBarUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StaticMapStyle.
    /// </summary>
    public class StaticMapStyle : ConstantClass
    {

        /// <summary>
        /// Constant Satellite for StaticMapStyle
        /// </summary>
        public static readonly StaticMapStyle Satellite = new StaticMapStyle("Satellite");
        /// <summary>
        /// Constant Standard for StaticMapStyle
        /// </summary>
        public static readonly StaticMapStyle Standard = new StaticMapStyle("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StaticMapStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StaticMapStyle FindValue(string value)
        {
            return FindValue<StaticMapStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StaticMapStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("CannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("FieldValidationFailed");
        /// <summary>
        /// Constant Missing for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Missing = new ValidationExceptionReason("Missing");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("Other");
        /// <summary>
        /// Constant UnknownField for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownField = new ValidationExceptionReason("UnknownField");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("UnknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Variant.
    /// </summary>
    public class Variant : ConstantClass
    {

        /// <summary>
        /// Constant Default for Variant
        /// </summary>
        public static readonly Variant Default = new Variant("Default");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Variant(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Variant FindValue(string value)
        {
            return FindValue<Variant>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Variant(string value)
        {
            return FindValue(value);
        }
    }

}