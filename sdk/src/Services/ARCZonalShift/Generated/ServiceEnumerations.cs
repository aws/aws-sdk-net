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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ARCZonalShift
{

    /// <summary>
    /// Constants used for properties of type AppliedStatus.
    /// </summary>
    public class AppliedStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPLIED for AppliedStatus
        /// </summary>
        public static readonly AppliedStatus APPLIED = new AppliedStatus("APPLIED");
        /// <summary>
        /// Constant NOT_APPLIED for AppliedStatus
        /// </summary>
        public static readonly AppliedStatus NOT_APPLIED = new AppliedStatus("NOT_APPLIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppliedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppliedStatus FindValue(string value)
        {
            return FindValue<AppliedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppliedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictExceptionReason.
    /// </summary>
    public class ConflictExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant SimultaneousZonalShiftsConflict for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason SimultaneousZonalShiftsConflict = new ConflictExceptionReason("SimultaneousZonalShiftsConflict");
        /// <summary>
        /// Constant ZonalShiftAlreadyExists for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason ZonalShiftAlreadyExists = new ConflictExceptionReason("ZonalShiftAlreadyExists");
        /// <summary>
        /// Constant ZonalShiftStatusNotActive for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason ZonalShiftStatusNotActive = new ConflictExceptionReason("ZonalShiftStatusNotActive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictExceptionReason FindValue(string value)
        {
            return FindValue<ConflictExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictExceptionReason(string value)
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
        /// Constant InvalidAz for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidAz = new ValidationExceptionReason("InvalidAz");
        /// <summary>
        /// Constant InvalidExpiresIn for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidExpiresIn = new ValidationExceptionReason("InvalidExpiresIn");
        /// <summary>
        /// Constant InvalidResourceIdentifier for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidResourceIdentifier = new ValidationExceptionReason("InvalidResourceIdentifier");
        /// <summary>
        /// Constant InvalidStatus for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidStatus = new ValidationExceptionReason("InvalidStatus");
        /// <summary>
        /// Constant InvalidToken for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidToken = new ValidationExceptionReason("InvalidToken");
        /// <summary>
        /// Constant MissingValue for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MissingValue = new ValidationExceptionReason("MissingValue");
        /// <summary>
        /// Constant UnsupportedAz for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnsupportedAz = new ValidationExceptionReason("UnsupportedAz");

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
    /// Constants used for properties of type ZonalShiftStatus.
    /// </summary>
    public class ZonalShiftStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ZonalShiftStatus
        /// </summary>
        public static readonly ZonalShiftStatus ACTIVE = new ZonalShiftStatus("ACTIVE");
        /// <summary>
        /// Constant CANCELED for ZonalShiftStatus
        /// </summary>
        public static readonly ZonalShiftStatus CANCELED = new ZonalShiftStatus("CANCELED");
        /// <summary>
        /// Constant EXPIRED for ZonalShiftStatus
        /// </summary>
        public static readonly ZonalShiftStatus EXPIRED = new ZonalShiftStatus("EXPIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ZonalShiftStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ZonalShiftStatus FindValue(string value)
        {
            return FindValue<ZonalShiftStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ZonalShiftStatus(string value)
        {
            return FindValue(value);
        }
    }

}