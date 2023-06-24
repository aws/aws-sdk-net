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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LocationService
{

    /// <summary>
    /// Constants used for properties of type BatchItemErrorCode.
    /// </summary>
    public class BatchItemErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDeniedError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode AccessDeniedError = new BatchItemErrorCode("AccessDeniedError");
        /// <summary>
        /// Constant ConflictError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode ConflictError = new BatchItemErrorCode("ConflictError");
        /// <summary>
        /// Constant InternalServerError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode InternalServerError = new BatchItemErrorCode("InternalServerError");
        /// <summary>
        /// Constant ResourceNotFoundError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode ResourceNotFoundError = new BatchItemErrorCode("ResourceNotFoundError");
        /// <summary>
        /// Constant ThrottlingError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode ThrottlingError = new BatchItemErrorCode("ThrottlingError");
        /// <summary>
        /// Constant ValidationError for BatchItemErrorCode
        /// </summary>
        public static readonly BatchItemErrorCode ValidationError = new BatchItemErrorCode("ValidationError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchItemErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchItemErrorCode FindValue(string value)
        {
            return FindValue<BatchItemErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchItemErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DimensionUnit.
    /// </summary>
    public class DimensionUnit : ConstantClass
    {

        /// <summary>
        /// Constant Feet for DimensionUnit
        /// </summary>
        public static readonly DimensionUnit Feet = new DimensionUnit("Feet");
        /// <summary>
        /// Constant Meters for DimensionUnit
        /// </summary>
        public static readonly DimensionUnit Meters = new DimensionUnit("Meters");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DimensionUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DimensionUnit FindValue(string value)
        {
            return FindValue<DimensionUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DimensionUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DistanceUnit.
    /// </summary>
    public class DistanceUnit : ConstantClass
    {

        /// <summary>
        /// Constant Kilometers for DistanceUnit
        /// </summary>
        public static readonly DistanceUnit Kilometers = new DistanceUnit("Kilometers");
        /// <summary>
        /// Constant Miles for DistanceUnit
        /// </summary>
        public static readonly DistanceUnit Miles = new DistanceUnit("Miles");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DistanceUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DistanceUnit FindValue(string value)
        {
            return FindValue<DistanceUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DistanceUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntendedUse.
    /// </summary>
    public class IntendedUse : ConstantClass
    {

        /// <summary>
        /// Constant SingleUse for IntendedUse
        /// </summary>
        public static readonly IntendedUse SingleUse = new IntendedUse("SingleUse");
        /// <summary>
        /// Constant Storage for IntendedUse
        /// </summary>
        public static readonly IntendedUse Storage = new IntendedUse("Storage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntendedUse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntendedUse FindValue(string value)
        {
            return FindValue<IntendedUse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntendedUse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PositionFiltering.
    /// </summary>
    public class PositionFiltering : ConstantClass
    {

        /// <summary>
        /// Constant AccuracyBased for PositionFiltering
        /// </summary>
        public static readonly PositionFiltering AccuracyBased = new PositionFiltering("AccuracyBased");
        /// <summary>
        /// Constant DistanceBased for PositionFiltering
        /// </summary>
        public static readonly PositionFiltering DistanceBased = new PositionFiltering("DistanceBased");
        /// <summary>
        /// Constant TimeBased for PositionFiltering
        /// </summary>
        public static readonly PositionFiltering TimeBased = new PositionFiltering("TimeBased");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PositionFiltering(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PositionFiltering FindValue(string value)
        {
            return FindValue<PositionFiltering>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PositionFiltering(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PricingPlan.
    /// </summary>
    public class PricingPlan : ConstantClass
    {

        /// <summary>
        /// Constant MobileAssetManagement for PricingPlan
        /// </summary>
        public static readonly PricingPlan MobileAssetManagement = new PricingPlan("MobileAssetManagement");
        /// <summary>
        /// Constant MobileAssetTracking for PricingPlan
        /// </summary>
        public static readonly PricingPlan MobileAssetTracking = new PricingPlan("MobileAssetTracking");
        /// <summary>
        /// Constant RequestBasedUsage for PricingPlan
        /// </summary>
        public static readonly PricingPlan RequestBasedUsage = new PricingPlan("RequestBasedUsage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PricingPlan(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PricingPlan FindValue(string value)
        {
            return FindValue<PricingPlan>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PricingPlan(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteMatrixErrorCode.
    /// </summary>
    public class RouteMatrixErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant DeparturePositionNotFound for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode DeparturePositionNotFound = new RouteMatrixErrorCode("DeparturePositionNotFound");
        /// <summary>
        /// Constant DestinationPositionNotFound for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode DestinationPositionNotFound = new RouteMatrixErrorCode("DestinationPositionNotFound");
        /// <summary>
        /// Constant OtherValidationError for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode OtherValidationError = new RouteMatrixErrorCode("OtherValidationError");
        /// <summary>
        /// Constant PositionsNotFound for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode PositionsNotFound = new RouteMatrixErrorCode("PositionsNotFound");
        /// <summary>
        /// Constant RouteNotFound for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode RouteNotFound = new RouteMatrixErrorCode("RouteNotFound");
        /// <summary>
        /// Constant RouteTooLong for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode RouteTooLong = new RouteMatrixErrorCode("RouteTooLong");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteMatrixErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteMatrixErrorCode FindValue(string value)
        {
            return FindValue<RouteMatrixErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteMatrixErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant Active for Status
        /// </summary>
        public static readonly Status Active = new Status("Active");
        /// <summary>
        /// Constant Expired for Status
        /// </summary>
        public static readonly Status Expired = new Status("Expired");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TravelMode.
    /// </summary>
    public class TravelMode : ConstantClass
    {

        /// <summary>
        /// Constant Bicycle for TravelMode
        /// </summary>
        public static readonly TravelMode Bicycle = new TravelMode("Bicycle");
        /// <summary>
        /// Constant Car for TravelMode
        /// </summary>
        public static readonly TravelMode Car = new TravelMode("Car");
        /// <summary>
        /// Constant Motorcycle for TravelMode
        /// </summary>
        public static readonly TravelMode Motorcycle = new TravelMode("Motorcycle");
        /// <summary>
        /// Constant Truck for TravelMode
        /// </summary>
        public static readonly TravelMode Truck = new TravelMode("Truck");
        /// <summary>
        /// Constant Walking for TravelMode
        /// </summary>
        public static readonly TravelMode Walking = new TravelMode("Walking");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TravelMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TravelMode FindValue(string value)
        {
            return FindValue<TravelMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TravelMode(string value)
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
    /// Constants used for properties of type VehicleWeightUnit.
    /// </summary>
    public class VehicleWeightUnit : ConstantClass
    {

        /// <summary>
        /// Constant Kilograms for VehicleWeightUnit
        /// </summary>
        public static readonly VehicleWeightUnit Kilograms = new VehicleWeightUnit("Kilograms");
        /// <summary>
        /// Constant Pounds for VehicleWeightUnit
        /// </summary>
        public static readonly VehicleWeightUnit Pounds = new VehicleWeightUnit("Pounds");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VehicleWeightUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VehicleWeightUnit FindValue(string value)
        {
            return FindValue<VehicleWeightUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VehicleWeightUnit(string value)
        {
            return FindValue(value);
        }
    }

}