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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GeoPlaces
{

    /// <summary>
    /// Constants used for properties of type AccessPointType.
    /// </summary>
    public class AccessPointType : ConstantClass
    {

        /// <summary>
        /// Constant Delivery for AccessPointType
        /// </summary>
        public static readonly AccessPointType Delivery = new AccessPointType("Delivery");
        /// <summary>
        /// Constant Emergency for AccessPointType
        /// </summary>
        public static readonly AccessPointType Emergency = new AccessPointType("Emergency");
        /// <summary>
        /// Constant Entrance for AccessPointType
        /// </summary>
        public static readonly AccessPointType Entrance = new AccessPointType("Entrance");
        /// <summary>
        /// Constant Loading for AccessPointType
        /// </summary>
        public static readonly AccessPointType Loading = new AccessPointType("Loading");
        /// <summary>
        /// Constant Other for AccessPointType
        /// </summary>
        public static readonly AccessPointType Other = new AccessPointType("Other");
        /// <summary>
        /// Constant Parking for AccessPointType
        /// </summary>
        public static readonly AccessPointType Parking = new AccessPointType("Parking");
        /// <summary>
        /// Constant Taxi for AccessPointType
        /// </summary>
        public static readonly AccessPointType Taxi = new AccessPointType("Taxi");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessPointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessPointType FindValue(string value)
        {
            return FindValue<AccessPointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessPointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AddressTranslationComponent.
    /// </summary>
    public class AddressTranslationComponent : ConstantClass
    {

        /// <summary>
        /// Constant District for AddressTranslationComponent
        /// </summary>
        public static readonly AddressTranslationComponent District = new AddressTranslationComponent("District");
        /// <summary>
        /// Constant Locality for AddressTranslationComponent
        /// </summary>
        public static readonly AddressTranslationComponent Locality = new AddressTranslationComponent("Locality");
        /// <summary>
        /// Constant Region for AddressTranslationComponent
        /// </summary>
        public static readonly AddressTranslationComponent Region = new AddressTranslationComponent("Region");
        /// <summary>
        /// Constant SubRegion for AddressTranslationComponent
        /// </summary>
        public static readonly AddressTranslationComponent SubRegion = new AddressTranslationComponent("SubRegion");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AddressTranslationComponent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AddressTranslationComponent FindValue(string value)
        {
            return FindValue<AddressTranslationComponent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AddressTranslationComponent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdminNamesPreference.
    /// </summary>
    public class AdminNamesPreference : ConstantClass
    {

        /// <summary>
        /// Constant Alternative for AdminNamesPreference
        /// </summary>
        public static readonly AdminNamesPreference Alternative = new AdminNamesPreference("Alternative");
        /// <summary>
        /// Constant Primary for AdminNamesPreference
        /// </summary>
        public static readonly AdminNamesPreference Primary = new AdminNamesPreference("Primary");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdminNamesPreference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdminNamesPreference FindValue(string value)
        {
            return FindValue<AdminNamesPreference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdminNamesPreference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutocompleteAdditionalFeature.
    /// </summary>
    public class AutocompleteAdditionalFeature : ConstantClass
    {

        /// <summary>
        /// Constant Core for AutocompleteAdditionalFeature
        /// </summary>
        public static readonly AutocompleteAdditionalFeature Core = new AutocompleteAdditionalFeature("Core");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutocompleteAdditionalFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutocompleteAdditionalFeature FindValue(string value)
        {
            return FindValue<AutocompleteAdditionalFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutocompleteAdditionalFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutocompleteFilterPlaceType.
    /// </summary>
    public class AutocompleteFilterPlaceType : ConstantClass
    {

        /// <summary>
        /// Constant Country for AutocompleteFilterPlaceType
        /// </summary>
        public static readonly AutocompleteFilterPlaceType Country = new AutocompleteFilterPlaceType("Country");
        /// <summary>
        /// Constant InterpolatedAddress for AutocompleteFilterPlaceType
        /// </summary>
        public static readonly AutocompleteFilterPlaceType InterpolatedAddress = new AutocompleteFilterPlaceType("InterpolatedAddress");
        /// <summary>
        /// Constant Intersection for AutocompleteFilterPlaceType
        /// </summary>
        public static readonly AutocompleteFilterPlaceType Intersection = new AutocompleteFilterPlaceType("Intersection");
        /// <summary>
        /// Constant Locality for AutocompleteFilterPlaceType
        /// </summary>
        public static readonly AutocompleteFilterPlaceType Locality = new AutocompleteFilterPlaceType("Locality");
        /// <summary>
        /// Constant PointAddress for AutocompleteFilterPlaceType
        /// </summary>
        public static readonly AutocompleteFilterPlaceType PointAddress = new AutocompleteFilterPlaceType("PointAddress");
        /// <summary>
        /// Constant PostalCode for AutocompleteFilterPlaceType
        /// </summary>
        public static readonly AutocompleteFilterPlaceType PostalCode = new AutocompleteFilterPlaceType("PostalCode");
        /// <summary>
        /// Constant Region for AutocompleteFilterPlaceType
        /// </summary>
        public static readonly AutocompleteFilterPlaceType Region = new AutocompleteFilterPlaceType("Region");
        /// <summary>
        /// Constant Street for AutocompleteFilterPlaceType
        /// </summary>
        public static readonly AutocompleteFilterPlaceType Street = new AutocompleteFilterPlaceType("Street");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutocompleteFilterPlaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutocompleteFilterPlaceType FindValue(string value)
        {
            return FindValue<AutocompleteFilterPlaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutocompleteFilterPlaceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutocompleteIntendedUse.
    /// </summary>
    public class AutocompleteIntendedUse : ConstantClass
    {

        /// <summary>
        /// Constant SingleUse for AutocompleteIntendedUse
        /// </summary>
        public static readonly AutocompleteIntendedUse SingleUse = new AutocompleteIntendedUse("SingleUse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutocompleteIntendedUse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutocompleteIntendedUse FindValue(string value)
        {
            return FindValue<AutocompleteIntendedUse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutocompleteIntendedUse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeocodeAdditionalFeature.
    /// </summary>
    public class GeocodeAdditionalFeature : ConstantClass
    {

        /// <summary>
        /// Constant Access for GeocodeAdditionalFeature
        /// </summary>
        public static readonly GeocodeAdditionalFeature Access = new GeocodeAdditionalFeature("Access");
        /// <summary>
        /// Constant Intersections for GeocodeAdditionalFeature
        /// </summary>
        public static readonly GeocodeAdditionalFeature Intersections = new GeocodeAdditionalFeature("Intersections");
        /// <summary>
        /// Constant SecondaryAddresses for GeocodeAdditionalFeature
        /// </summary>
        public static readonly GeocodeAdditionalFeature SecondaryAddresses = new GeocodeAdditionalFeature("SecondaryAddresses");
        /// <summary>
        /// Constant TimeZone for GeocodeAdditionalFeature
        /// </summary>
        public static readonly GeocodeAdditionalFeature TimeZone = new GeocodeAdditionalFeature("TimeZone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeocodeAdditionalFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeocodeAdditionalFeature FindValue(string value)
        {
            return FindValue<GeocodeAdditionalFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeocodeAdditionalFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeocodeAddressNamesMode.
    /// </summary>
    public class GeocodeAddressNamesMode : ConstantClass
    {

        /// <summary>
        /// Constant Administrative for GeocodeAddressNamesMode
        /// </summary>
        public static readonly GeocodeAddressNamesMode Administrative = new GeocodeAddressNamesMode("Administrative");
        /// <summary>
        /// Constant Matched for GeocodeAddressNamesMode
        /// </summary>
        public static readonly GeocodeAddressNamesMode Matched = new GeocodeAddressNamesMode("Matched");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeocodeAddressNamesMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeocodeAddressNamesMode FindValue(string value)
        {
            return FindValue<GeocodeAddressNamesMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeocodeAddressNamesMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeocodeFilterPlaceType.
    /// </summary>
    public class GeocodeFilterPlaceType : ConstantClass
    {

        /// <summary>
        /// Constant Country for GeocodeFilterPlaceType
        /// </summary>
        public static readonly GeocodeFilterPlaceType Country = new GeocodeFilterPlaceType("Country");
        /// <summary>
        /// Constant InterpolatedAddress for GeocodeFilterPlaceType
        /// </summary>
        public static readonly GeocodeFilterPlaceType InterpolatedAddress = new GeocodeFilterPlaceType("InterpolatedAddress");
        /// <summary>
        /// Constant Intersection for GeocodeFilterPlaceType
        /// </summary>
        public static readonly GeocodeFilterPlaceType Intersection = new GeocodeFilterPlaceType("Intersection");
        /// <summary>
        /// Constant Locality for GeocodeFilterPlaceType
        /// </summary>
        public static readonly GeocodeFilterPlaceType Locality = new GeocodeFilterPlaceType("Locality");
        /// <summary>
        /// Constant PointAddress for GeocodeFilterPlaceType
        /// </summary>
        public static readonly GeocodeFilterPlaceType PointAddress = new GeocodeFilterPlaceType("PointAddress");
        /// <summary>
        /// Constant PointOfInterest for GeocodeFilterPlaceType
        /// </summary>
        public static readonly GeocodeFilterPlaceType PointOfInterest = new GeocodeFilterPlaceType("PointOfInterest");
        /// <summary>
        /// Constant PostalCode for GeocodeFilterPlaceType
        /// </summary>
        public static readonly GeocodeFilterPlaceType PostalCode = new GeocodeFilterPlaceType("PostalCode");
        /// <summary>
        /// Constant Region for GeocodeFilterPlaceType
        /// </summary>
        public static readonly GeocodeFilterPlaceType Region = new GeocodeFilterPlaceType("Region");
        /// <summary>
        /// Constant SecondaryAddress for GeocodeFilterPlaceType
        /// </summary>
        public static readonly GeocodeFilterPlaceType SecondaryAddress = new GeocodeFilterPlaceType("SecondaryAddress");
        /// <summary>
        /// Constant Street for GeocodeFilterPlaceType
        /// </summary>
        public static readonly GeocodeFilterPlaceType Street = new GeocodeFilterPlaceType("Street");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeocodeFilterPlaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeocodeFilterPlaceType FindValue(string value)
        {
            return FindValue<GeocodeFilterPlaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeocodeFilterPlaceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeocodeIntendedUse.
    /// </summary>
    public class GeocodeIntendedUse : ConstantClass
    {

        /// <summary>
        /// Constant SingleUse for GeocodeIntendedUse
        /// </summary>
        public static readonly GeocodeIntendedUse SingleUse = new GeocodeIntendedUse("SingleUse");
        /// <summary>
        /// Constant Storage for GeocodeIntendedUse
        /// </summary>
        public static readonly GeocodeIntendedUse Storage = new GeocodeIntendedUse("Storage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeocodeIntendedUse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeocodeIntendedUse FindValue(string value)
        {
            return FindValue<GeocodeIntendedUse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeocodeIntendedUse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GetPlaceAdditionalFeature.
    /// </summary>
    public class GetPlaceAdditionalFeature : ConstantClass
    {

        /// <summary>
        /// Constant Access for GetPlaceAdditionalFeature
        /// </summary>
        public static readonly GetPlaceAdditionalFeature Access = new GetPlaceAdditionalFeature("Access");
        /// <summary>
        /// Constant Contact for GetPlaceAdditionalFeature
        /// </summary>
        public static readonly GetPlaceAdditionalFeature Contact = new GetPlaceAdditionalFeature("Contact");
        /// <summary>
        /// Constant CrossReferences for GetPlaceAdditionalFeature
        /// </summary>
        public static readonly GetPlaceAdditionalFeature CrossReferences = new GetPlaceAdditionalFeature("CrossReferences");
        /// <summary>
        /// Constant Phonemes for GetPlaceAdditionalFeature
        /// </summary>
        public static readonly GetPlaceAdditionalFeature Phonemes = new GetPlaceAdditionalFeature("Phonemes");
        /// <summary>
        /// Constant SecondaryAddresses for GetPlaceAdditionalFeature
        /// </summary>
        public static readonly GetPlaceAdditionalFeature SecondaryAddresses = new GetPlaceAdditionalFeature("SecondaryAddresses");
        /// <summary>
        /// Constant TimeZone for GetPlaceAdditionalFeature
        /// </summary>
        public static readonly GetPlaceAdditionalFeature TimeZone = new GetPlaceAdditionalFeature("TimeZone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GetPlaceAdditionalFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GetPlaceAdditionalFeature FindValue(string value)
        {
            return FindValue<GetPlaceAdditionalFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GetPlaceAdditionalFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GetPlaceAddressNamesMode.
    /// </summary>
    public class GetPlaceAddressNamesMode : ConstantClass
    {

        /// <summary>
        /// Constant Administrative for GetPlaceAddressNamesMode
        /// </summary>
        public static readonly GetPlaceAddressNamesMode Administrative = new GetPlaceAddressNamesMode("Administrative");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GetPlaceAddressNamesMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GetPlaceAddressNamesMode FindValue(string value)
        {
            return FindValue<GetPlaceAddressNamesMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GetPlaceAddressNamesMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GetPlaceIntendedUse.
    /// </summary>
    public class GetPlaceIntendedUse : ConstantClass
    {

        /// <summary>
        /// Constant SingleUse for GetPlaceIntendedUse
        /// </summary>
        public static readonly GetPlaceIntendedUse SingleUse = new GetPlaceIntendedUse("SingleUse");
        /// <summary>
        /// Constant Storage for GetPlaceIntendedUse
        /// </summary>
        public static readonly GetPlaceIntendedUse Storage = new GetPlaceIntendedUse("Storage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GetPlaceIntendedUse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GetPlaceIntendedUse FindValue(string value)
        {
            return FindValue<GetPlaceIntendedUse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GetPlaceIntendedUse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlaceAttribute.
    /// </summary>
    public class PlaceAttribute : ConstantClass
    {

        /// <summary>
        /// Constant DriveThrough for PlaceAttribute
        /// </summary>
        public static readonly PlaceAttribute DriveThrough = new PlaceAttribute("DriveThrough");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlaceAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlaceAttribute FindValue(string value)
        {
            return FindValue<PlaceAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlaceAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlaceType.
    /// </summary>
    public class PlaceType : ConstantClass
    {

        /// <summary>
        /// Constant Block for PlaceType
        /// </summary>
        public static readonly PlaceType Block = new PlaceType("Block");
        /// <summary>
        /// Constant Country for PlaceType
        /// </summary>
        public static readonly PlaceType Country = new PlaceType("Country");
        /// <summary>
        /// Constant District for PlaceType
        /// </summary>
        public static readonly PlaceType District = new PlaceType("District");
        /// <summary>
        /// Constant InferredSecondaryAddress for PlaceType
        /// </summary>
        public static readonly PlaceType InferredSecondaryAddress = new PlaceType("InferredSecondaryAddress");
        /// <summary>
        /// Constant InterpolatedAddress for PlaceType
        /// </summary>
        public static readonly PlaceType InterpolatedAddress = new PlaceType("InterpolatedAddress");
        /// <summary>
        /// Constant Intersection for PlaceType
        /// </summary>
        public static readonly PlaceType Intersection = new PlaceType("Intersection");
        /// <summary>
        /// Constant Locality for PlaceType
        /// </summary>
        public static readonly PlaceType Locality = new PlaceType("Locality");
        /// <summary>
        /// Constant PointAddress for PlaceType
        /// </summary>
        public static readonly PlaceType PointAddress = new PlaceType("PointAddress");
        /// <summary>
        /// Constant PointOfInterest for PlaceType
        /// </summary>
        public static readonly PlaceType PointOfInterest = new PlaceType("PointOfInterest");
        /// <summary>
        /// Constant PostalCode for PlaceType
        /// </summary>
        public static readonly PlaceType PostalCode = new PlaceType("PostalCode");
        /// <summary>
        /// Constant Region for PlaceType
        /// </summary>
        public static readonly PlaceType Region = new PlaceType("Region");
        /// <summary>
        /// Constant SecondaryAddress for PlaceType
        /// </summary>
        public static readonly PlaceType SecondaryAddress = new PlaceType("SecondaryAddress");
        /// <summary>
        /// Constant Street for PlaceType
        /// </summary>
        public static readonly PlaceType Street = new PlaceType("Street");
        /// <summary>
        /// Constant SubBlock for PlaceType
        /// </summary>
        public static readonly PlaceType SubBlock = new PlaceType("SubBlock");
        /// <summary>
        /// Constant SubDistrict for PlaceType
        /// </summary>
        public static readonly PlaceType SubDistrict = new PlaceType("SubDistrict");
        /// <summary>
        /// Constant SubRegion for PlaceType
        /// </summary>
        public static readonly PlaceType SubRegion = new PlaceType("SubRegion");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlaceType FindValue(string value)
        {
            return FindValue<PlaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlaceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PostalAuthority.
    /// </summary>
    public class PostalAuthority : ConstantClass
    {

        /// <summary>
        /// Constant Usps for PostalAuthority
        /// </summary>
        public static readonly PostalAuthority Usps = new PostalAuthority("Usps");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PostalAuthority(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PostalAuthority FindValue(string value)
        {
            return FindValue<PostalAuthority>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PostalAuthority(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PostalCodeMode.
    /// </summary>
    public class PostalCodeMode : ConstantClass
    {

        /// <summary>
        /// Constant EnumerateSpannedDistricts for PostalCodeMode
        /// </summary>
        public static readonly PostalCodeMode EnumerateSpannedDistricts = new PostalCodeMode("EnumerateSpannedDistricts");
        /// <summary>
        /// Constant EnumerateSpannedLocalities for PostalCodeMode
        /// </summary>
        public static readonly PostalCodeMode EnumerateSpannedLocalities = new PostalCodeMode("EnumerateSpannedLocalities");
        /// <summary>
        /// Constant MergeAllSpannedLocalities for PostalCodeMode
        /// </summary>
        public static readonly PostalCodeMode MergeAllSpannedLocalities = new PostalCodeMode("MergeAllSpannedLocalities");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PostalCodeMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PostalCodeMode FindValue(string value)
        {
            return FindValue<PostalCodeMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PostalCodeMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PostalCodeType.
    /// </summary>
    public class PostalCodeType : ConstantClass
    {

        /// <summary>
        /// Constant UspsZip for PostalCodeType
        /// </summary>
        public static readonly PostalCodeType UspsZip = new PostalCodeType("UspsZip");
        /// <summary>
        /// Constant UspsZipPlus4 for PostalCodeType
        /// </summary>
        public static readonly PostalCodeType UspsZipPlus4 = new PostalCodeType("UspsZipPlus4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PostalCodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PostalCodeType FindValue(string value)
        {
            return FindValue<PostalCodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PostalCodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryType.
    /// </summary>
    public class QueryType : ConstantClass
    {

        /// <summary>
        /// Constant BusinessChain for QueryType
        /// </summary>
        public static readonly QueryType BusinessChain = new QueryType("BusinessChain");
        /// <summary>
        /// Constant Category for QueryType
        /// </summary>
        public static readonly QueryType Category = new QueryType("Category");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryType FindValue(string value)
        {
            return FindValue<QueryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordTypeCode.
    /// </summary>
    public class RecordTypeCode : ConstantClass
    {

        /// <summary>
        /// Constant Firm for RecordTypeCode
        /// </summary>
        public static readonly RecordTypeCode Firm = new RecordTypeCode("Firm");
        /// <summary>
        /// Constant General for RecordTypeCode
        /// </summary>
        public static readonly RecordTypeCode General = new RecordTypeCode("General");
        /// <summary>
        /// Constant HighRise for RecordTypeCode
        /// </summary>
        public static readonly RecordTypeCode HighRise = new RecordTypeCode("HighRise");
        /// <summary>
        /// Constant PostOfficeBox for RecordTypeCode
        /// </summary>
        public static readonly RecordTypeCode PostOfficeBox = new RecordTypeCode("PostOfficeBox");
        /// <summary>
        /// Constant Rural for RecordTypeCode
        /// </summary>
        public static readonly RecordTypeCode Rural = new RecordTypeCode("Rural");
        /// <summary>
        /// Constant Street for RecordTypeCode
        /// </summary>
        public static readonly RecordTypeCode Street = new RecordTypeCode("Street");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordTypeCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordTypeCode FindValue(string value)
        {
            return FindValue<RecordTypeCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordTypeCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReverseGeocodeAdditionalFeature.
    /// </summary>
    public class ReverseGeocodeAdditionalFeature : ConstantClass
    {

        /// <summary>
        /// Constant Access for ReverseGeocodeAdditionalFeature
        /// </summary>
        public static readonly ReverseGeocodeAdditionalFeature Access = new ReverseGeocodeAdditionalFeature("Access");
        /// <summary>
        /// Constant Intersections for ReverseGeocodeAdditionalFeature
        /// </summary>
        public static readonly ReverseGeocodeAdditionalFeature Intersections = new ReverseGeocodeAdditionalFeature("Intersections");
        /// <summary>
        /// Constant TimeZone for ReverseGeocodeAdditionalFeature
        /// </summary>
        public static readonly ReverseGeocodeAdditionalFeature TimeZone = new ReverseGeocodeAdditionalFeature("TimeZone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReverseGeocodeAdditionalFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReverseGeocodeAdditionalFeature FindValue(string value)
        {
            return FindValue<ReverseGeocodeAdditionalFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReverseGeocodeAdditionalFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReverseGeocodeAddressNamesMode.
    /// </summary>
    public class ReverseGeocodeAddressNamesMode : ConstantClass
    {

        /// <summary>
        /// Constant Administrative for ReverseGeocodeAddressNamesMode
        /// </summary>
        public static readonly ReverseGeocodeAddressNamesMode Administrative = new ReverseGeocodeAddressNamesMode("Administrative");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReverseGeocodeAddressNamesMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReverseGeocodeAddressNamesMode FindValue(string value)
        {
            return FindValue<ReverseGeocodeAddressNamesMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReverseGeocodeAddressNamesMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReverseGeocodeFilterPlaceType.
    /// </summary>
    public class ReverseGeocodeFilterPlaceType : ConstantClass
    {

        /// <summary>
        /// Constant InterpolatedAddress for ReverseGeocodeFilterPlaceType
        /// </summary>
        public static readonly ReverseGeocodeFilterPlaceType InterpolatedAddress = new ReverseGeocodeFilterPlaceType("InterpolatedAddress");
        /// <summary>
        /// Constant Intersection for ReverseGeocodeFilterPlaceType
        /// </summary>
        public static readonly ReverseGeocodeFilterPlaceType Intersection = new ReverseGeocodeFilterPlaceType("Intersection");
        /// <summary>
        /// Constant Locality for ReverseGeocodeFilterPlaceType
        /// </summary>
        public static readonly ReverseGeocodeFilterPlaceType Locality = new ReverseGeocodeFilterPlaceType("Locality");
        /// <summary>
        /// Constant PointAddress for ReverseGeocodeFilterPlaceType
        /// </summary>
        public static readonly ReverseGeocodeFilterPlaceType PointAddress = new ReverseGeocodeFilterPlaceType("PointAddress");
        /// <summary>
        /// Constant PointOfInterest for ReverseGeocodeFilterPlaceType
        /// </summary>
        public static readonly ReverseGeocodeFilterPlaceType PointOfInterest = new ReverseGeocodeFilterPlaceType("PointOfInterest");
        /// <summary>
        /// Constant SecondaryAddress for ReverseGeocodeFilterPlaceType
        /// </summary>
        public static readonly ReverseGeocodeFilterPlaceType SecondaryAddress = new ReverseGeocodeFilterPlaceType("SecondaryAddress");
        /// <summary>
        /// Constant Street for ReverseGeocodeFilterPlaceType
        /// </summary>
        public static readonly ReverseGeocodeFilterPlaceType Street = new ReverseGeocodeFilterPlaceType("Street");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReverseGeocodeFilterPlaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReverseGeocodeFilterPlaceType FindValue(string value)
        {
            return FindValue<ReverseGeocodeFilterPlaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReverseGeocodeFilterPlaceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReverseGeocodeIntendedUse.
    /// </summary>
    public class ReverseGeocodeIntendedUse : ConstantClass
    {

        /// <summary>
        /// Constant SingleUse for ReverseGeocodeIntendedUse
        /// </summary>
        public static readonly ReverseGeocodeIntendedUse SingleUse = new ReverseGeocodeIntendedUse("SingleUse");
        /// <summary>
        /// Constant Storage for ReverseGeocodeIntendedUse
        /// </summary>
        public static readonly ReverseGeocodeIntendedUse Storage = new ReverseGeocodeIntendedUse("Storage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReverseGeocodeIntendedUse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReverseGeocodeIntendedUse FindValue(string value)
        {
            return FindValue<ReverseGeocodeIntendedUse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReverseGeocodeIntendedUse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchNearbyAdditionalFeature.
    /// </summary>
    public class SearchNearbyAdditionalFeature : ConstantClass
    {

        /// <summary>
        /// Constant Access for SearchNearbyAdditionalFeature
        /// </summary>
        public static readonly SearchNearbyAdditionalFeature Access = new SearchNearbyAdditionalFeature("Access");
        /// <summary>
        /// Constant Contact for SearchNearbyAdditionalFeature
        /// </summary>
        public static readonly SearchNearbyAdditionalFeature Contact = new SearchNearbyAdditionalFeature("Contact");
        /// <summary>
        /// Constant CrossReferences for SearchNearbyAdditionalFeature
        /// </summary>
        public static readonly SearchNearbyAdditionalFeature CrossReferences = new SearchNearbyAdditionalFeature("CrossReferences");
        /// <summary>
        /// Constant Phonemes for SearchNearbyAdditionalFeature
        /// </summary>
        public static readonly SearchNearbyAdditionalFeature Phonemes = new SearchNearbyAdditionalFeature("Phonemes");
        /// <summary>
        /// Constant TimeZone for SearchNearbyAdditionalFeature
        /// </summary>
        public static readonly SearchNearbyAdditionalFeature TimeZone = new SearchNearbyAdditionalFeature("TimeZone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchNearbyAdditionalFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchNearbyAdditionalFeature FindValue(string value)
        {
            return FindValue<SearchNearbyAdditionalFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchNearbyAdditionalFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchNearbyIntendedUse.
    /// </summary>
    public class SearchNearbyIntendedUse : ConstantClass
    {

        /// <summary>
        /// Constant SingleUse for SearchNearbyIntendedUse
        /// </summary>
        public static readonly SearchNearbyIntendedUse SingleUse = new SearchNearbyIntendedUse("SingleUse");
        /// <summary>
        /// Constant Storage for SearchNearbyIntendedUse
        /// </summary>
        public static readonly SearchNearbyIntendedUse Storage = new SearchNearbyIntendedUse("Storage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchNearbyIntendedUse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchNearbyIntendedUse FindValue(string value)
        {
            return FindValue<SearchNearbyIntendedUse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchNearbyIntendedUse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchTextAdditionalFeature.
    /// </summary>
    public class SearchTextAdditionalFeature : ConstantClass
    {

        /// <summary>
        /// Constant Access for SearchTextAdditionalFeature
        /// </summary>
        public static readonly SearchTextAdditionalFeature Access = new SearchTextAdditionalFeature("Access");
        /// <summary>
        /// Constant Contact for SearchTextAdditionalFeature
        /// </summary>
        public static readonly SearchTextAdditionalFeature Contact = new SearchTextAdditionalFeature("Contact");
        /// <summary>
        /// Constant CrossReferences for SearchTextAdditionalFeature
        /// </summary>
        public static readonly SearchTextAdditionalFeature CrossReferences = new SearchTextAdditionalFeature("CrossReferences");
        /// <summary>
        /// Constant Phonemes for SearchTextAdditionalFeature
        /// </summary>
        public static readonly SearchTextAdditionalFeature Phonemes = new SearchTextAdditionalFeature("Phonemes");
        /// <summary>
        /// Constant TimeZone for SearchTextAdditionalFeature
        /// </summary>
        public static readonly SearchTextAdditionalFeature TimeZone = new SearchTextAdditionalFeature("TimeZone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchTextAdditionalFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchTextAdditionalFeature FindValue(string value)
        {
            return FindValue<SearchTextAdditionalFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchTextAdditionalFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchTextIntendedUse.
    /// </summary>
    public class SearchTextIntendedUse : ConstantClass
    {

        /// <summary>
        /// Constant SingleUse for SearchTextIntendedUse
        /// </summary>
        public static readonly SearchTextIntendedUse SingleUse = new SearchTextIntendedUse("SingleUse");
        /// <summary>
        /// Constant Storage for SearchTextIntendedUse
        /// </summary>
        public static readonly SearchTextIntendedUse Storage = new SearchTextIntendedUse("Storage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchTextIntendedUse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchTextIntendedUse FindValue(string value)
        {
            return FindValue<SearchTextIntendedUse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchTextIntendedUse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchTextTravelMode.
    /// </summary>
    public class SearchTextTravelMode : ConstantClass
    {

        /// <summary>
        /// Constant Car for SearchTextTravelMode
        /// </summary>
        public static readonly SearchTextTravelMode Car = new SearchTextTravelMode("Car");
        /// <summary>
        /// Constant Scooter for SearchTextTravelMode
        /// </summary>
        public static readonly SearchTextTravelMode Scooter = new SearchTextTravelMode("Scooter");
        /// <summary>
        /// Constant Truck for SearchTextTravelMode
        /// </summary>
        public static readonly SearchTextTravelMode Truck = new SearchTextTravelMode("Truck");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchTextTravelMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchTextTravelMode FindValue(string value)
        {
            return FindValue<SearchTextTravelMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchTextTravelMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuggestAdditionalFeature.
    /// </summary>
    public class SuggestAdditionalFeature : ConstantClass
    {

        /// <summary>
        /// Constant Access for SuggestAdditionalFeature
        /// </summary>
        public static readonly SuggestAdditionalFeature Access = new SuggestAdditionalFeature("Access");
        /// <summary>
        /// Constant Core for SuggestAdditionalFeature
        /// </summary>
        public static readonly SuggestAdditionalFeature Core = new SuggestAdditionalFeature("Core");
        /// <summary>
        /// Constant CrossReferences for SuggestAdditionalFeature
        /// </summary>
        public static readonly SuggestAdditionalFeature CrossReferences = new SuggestAdditionalFeature("CrossReferences");
        /// <summary>
        /// Constant Phonemes for SuggestAdditionalFeature
        /// </summary>
        public static readonly SuggestAdditionalFeature Phonemes = new SuggestAdditionalFeature("Phonemes");
        /// <summary>
        /// Constant TimeZone for SuggestAdditionalFeature
        /// </summary>
        public static readonly SuggestAdditionalFeature TimeZone = new SuggestAdditionalFeature("TimeZone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuggestAdditionalFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuggestAdditionalFeature FindValue(string value)
        {
            return FindValue<SuggestAdditionalFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuggestAdditionalFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuggestIntendedUse.
    /// </summary>
    public class SuggestIntendedUse : ConstantClass
    {

        /// <summary>
        /// Constant SingleUse for SuggestIntendedUse
        /// </summary>
        public static readonly SuggestIntendedUse SingleUse = new SuggestIntendedUse("SingleUse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuggestIntendedUse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuggestIntendedUse FindValue(string value)
        {
            return FindValue<SuggestIntendedUse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuggestIntendedUse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuggestResultItemType.
    /// </summary>
    public class SuggestResultItemType : ConstantClass
    {

        /// <summary>
        /// Constant Place for SuggestResultItemType
        /// </summary>
        public static readonly SuggestResultItemType Place = new SuggestResultItemType("Place");
        /// <summary>
        /// Constant Query for SuggestResultItemType
        /// </summary>
        public static readonly SuggestResultItemType Query = new SuggestResultItemType("Query");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuggestResultItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuggestResultItemType FindValue(string value)
        {
            return FindValue<SuggestResultItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuggestResultItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuggestTravelMode.
    /// </summary>
    public class SuggestTravelMode : ConstantClass
    {

        /// <summary>
        /// Constant Car for SuggestTravelMode
        /// </summary>
        public static readonly SuggestTravelMode Car = new SuggestTravelMode("Car");
        /// <summary>
        /// Constant Scooter for SuggestTravelMode
        /// </summary>
        public static readonly SuggestTravelMode Scooter = new SuggestTravelMode("Scooter");
        /// <summary>
        /// Constant Truck for SuggestTravelMode
        /// </summary>
        public static readonly SuggestTravelMode Truck = new SuggestTravelMode("Truck");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuggestTravelMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuggestTravelMode FindValue(string value)
        {
            return FindValue<SuggestTravelMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuggestTravelMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranslationNameType.
    /// </summary>
    public class TranslationNameType : ConstantClass
    {

        /// <summary>
        /// Constant Abbreviation for TranslationNameType
        /// </summary>
        public static readonly TranslationNameType Abbreviation = new TranslationNameType("Abbreviation");
        /// <summary>
        /// Constant AreaCode for TranslationNameType
        /// </summary>
        public static readonly TranslationNameType AreaCode = new TranslationNameType("AreaCode");
        /// <summary>
        /// Constant BaseName for TranslationNameType
        /// </summary>
        public static readonly TranslationNameType BaseName = new TranslationNameType("BaseName");
        /// <summary>
        /// Constant Exonym for TranslationNameType
        /// </summary>
        public static readonly TranslationNameType Exonym = new TranslationNameType("Exonym");
        /// <summary>
        /// Constant Shortened for TranslationNameType
        /// </summary>
        public static readonly TranslationNameType Shortened = new TranslationNameType("Shortened");
        /// <summary>
        /// Constant Synonym for TranslationNameType
        /// </summary>
        public static readonly TranslationNameType Synonym = new TranslationNameType("Synonym");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranslationNameType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranslationNameType FindValue(string value)
        {
            return FindValue<TranslationNameType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranslationNameType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TypePlacement.
    /// </summary>
    public class TypePlacement : ConstantClass
    {

        /// <summary>
        /// Constant AfterBaseName for TypePlacement
        /// </summary>
        public static readonly TypePlacement AfterBaseName = new TypePlacement("AfterBaseName");
        /// <summary>
        /// Constant BeforeBaseName for TypePlacement
        /// </summary>
        public static readonly TypePlacement BeforeBaseName = new TypePlacement("BeforeBaseName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TypePlacement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TypePlacement FindValue(string value)
        {
            return FindValue<TypePlacement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TypePlacement(string value)
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
    /// Constants used for properties of type ZipClassificationCode.
    /// </summary>
    public class ZipClassificationCode : ConstantClass
    {

        /// <summary>
        /// Constant Military for ZipClassificationCode
        /// </summary>
        public static readonly ZipClassificationCode Military = new ZipClassificationCode("Military");
        /// <summary>
        /// Constant PostOfficeBoxes for ZipClassificationCode
        /// </summary>
        public static readonly ZipClassificationCode PostOfficeBoxes = new ZipClassificationCode("PostOfficeBoxes");
        /// <summary>
        /// Constant Unique for ZipClassificationCode
        /// </summary>
        public static readonly ZipClassificationCode Unique = new ZipClassificationCode("Unique");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ZipClassificationCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ZipClassificationCode FindValue(string value)
        {
            return FindValue<ZipClassificationCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ZipClassificationCode(string value)
        {
            return FindValue(value);
        }
    }

}