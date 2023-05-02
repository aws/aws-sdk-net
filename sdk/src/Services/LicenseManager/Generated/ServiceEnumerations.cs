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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LicenseManager
{

    /// <summary>
    /// Constants used for properties of type ActivationOverrideBehavior.
    /// </summary>
    public class ActivationOverrideBehavior : ConstantClass
    {

        /// <summary>
        /// Constant ALL_GRANTS_PERMITTED_BY_ISSUER for ActivationOverrideBehavior
        /// </summary>
        public static readonly ActivationOverrideBehavior ALL_GRANTS_PERMITTED_BY_ISSUER = new ActivationOverrideBehavior("ALL_GRANTS_PERMITTED_BY_ISSUER");
        /// <summary>
        /// Constant DISTRIBUTED_GRANTS_ONLY for ActivationOverrideBehavior
        /// </summary>
        public static readonly ActivationOverrideBehavior DISTRIBUTED_GRANTS_ONLY = new ActivationOverrideBehavior("DISTRIBUTED_GRANTS_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivationOverrideBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivationOverrideBehavior FindValue(string value)
        {
            return FindValue<ActivationOverrideBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivationOverrideBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AllowedOperation.
    /// </summary>
    public class AllowedOperation : ConstantClass
    {

        /// <summary>
        /// Constant CheckInLicense for AllowedOperation
        /// </summary>
        public static readonly AllowedOperation CheckInLicense = new AllowedOperation("CheckInLicense");
        /// <summary>
        /// Constant CheckoutBorrowLicense for AllowedOperation
        /// </summary>
        public static readonly AllowedOperation CheckoutBorrowLicense = new AllowedOperation("CheckoutBorrowLicense");
        /// <summary>
        /// Constant CheckoutLicense for AllowedOperation
        /// </summary>
        public static readonly AllowedOperation CheckoutLicense = new AllowedOperation("CheckoutLicense");
        /// <summary>
        /// Constant CreateGrant for AllowedOperation
        /// </summary>
        public static readonly AllowedOperation CreateGrant = new AllowedOperation("CreateGrant");
        /// <summary>
        /// Constant CreateToken for AllowedOperation
        /// </summary>
        public static readonly AllowedOperation CreateToken = new AllowedOperation("CreateToken");
        /// <summary>
        /// Constant ExtendConsumptionLicense for AllowedOperation
        /// </summary>
        public static readonly AllowedOperation ExtendConsumptionLicense = new AllowedOperation("ExtendConsumptionLicense");
        /// <summary>
        /// Constant ListPurchasedLicenses for AllowedOperation
        /// </summary>
        public static readonly AllowedOperation ListPurchasedLicenses = new AllowedOperation("ListPurchasedLicenses");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllowedOperation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllowedOperation FindValue(string value)
        {
            return FindValue<AllowedOperation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllowedOperation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CheckoutType.
    /// </summary>
    public class CheckoutType : ConstantClass
    {

        /// <summary>
        /// Constant PERPETUAL for CheckoutType
        /// </summary>
        public static readonly CheckoutType PERPETUAL = new CheckoutType("PERPETUAL");
        /// <summary>
        /// Constant PROVISIONAL for CheckoutType
        /// </summary>
        public static readonly CheckoutType PROVISIONAL = new CheckoutType("PROVISIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CheckoutType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckoutType FindValue(string value)
        {
            return FindValue<CheckoutType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckoutType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DigitalSignatureMethod.
    /// </summary>
    public class DigitalSignatureMethod : ConstantClass
    {

        /// <summary>
        /// Constant JWT_PS384 for DigitalSignatureMethod
        /// </summary>
        public static readonly DigitalSignatureMethod JWT_PS384 = new DigitalSignatureMethod("JWT_PS384");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DigitalSignatureMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DigitalSignatureMethod FindValue(string value)
        {
            return FindValue<DigitalSignatureMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DigitalSignatureMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntitlementDataUnit.
    /// </summary>
    public class EntitlementDataUnit : ConstantClass
    {

        /// <summary>
        /// Constant Bits for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Bits = new EntitlementDataUnit("Bits");
        /// <summary>
        /// Constant BitsSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit BitsSecond = new EntitlementDataUnit("Bits/Second");
        /// <summary>
        /// Constant Bytes for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Bytes = new EntitlementDataUnit("Bytes");
        /// <summary>
        /// Constant BytesSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit BytesSecond = new EntitlementDataUnit("Bytes/Second");
        /// <summary>
        /// Constant Count for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Count = new EntitlementDataUnit("Count");
        /// <summary>
        /// Constant CountSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit CountSecond = new EntitlementDataUnit("Count/Second");
        /// <summary>
        /// Constant Gigabits for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Gigabits = new EntitlementDataUnit("Gigabits");
        /// <summary>
        /// Constant GigabitsSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit GigabitsSecond = new EntitlementDataUnit("Gigabits/Second");
        /// <summary>
        /// Constant Gigabytes for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Gigabytes = new EntitlementDataUnit("Gigabytes");
        /// <summary>
        /// Constant GigabytesSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit GigabytesSecond = new EntitlementDataUnit("Gigabytes/Second");
        /// <summary>
        /// Constant Kilobits for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Kilobits = new EntitlementDataUnit("Kilobits");
        /// <summary>
        /// Constant KilobitsSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit KilobitsSecond = new EntitlementDataUnit("Kilobits/Second");
        /// <summary>
        /// Constant Kilobytes for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Kilobytes = new EntitlementDataUnit("Kilobytes");
        /// <summary>
        /// Constant KilobytesSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit KilobytesSecond = new EntitlementDataUnit("Kilobytes/Second");
        /// <summary>
        /// Constant Megabits for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Megabits = new EntitlementDataUnit("Megabits");
        /// <summary>
        /// Constant MegabitsSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit MegabitsSecond = new EntitlementDataUnit("Megabits/Second");
        /// <summary>
        /// Constant Megabytes for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Megabytes = new EntitlementDataUnit("Megabytes");
        /// <summary>
        /// Constant MegabytesSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit MegabytesSecond = new EntitlementDataUnit("Megabytes/Second");
        /// <summary>
        /// Constant Microseconds for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Microseconds = new EntitlementDataUnit("Microseconds");
        /// <summary>
        /// Constant Milliseconds for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Milliseconds = new EntitlementDataUnit("Milliseconds");
        /// <summary>
        /// Constant None for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit None = new EntitlementDataUnit("None");
        /// <summary>
        /// Constant Percent for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Percent = new EntitlementDataUnit("Percent");
        /// <summary>
        /// Constant Seconds for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Seconds = new EntitlementDataUnit("Seconds");
        /// <summary>
        /// Constant Terabits for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Terabits = new EntitlementDataUnit("Terabits");
        /// <summary>
        /// Constant TerabitsSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit TerabitsSecond = new EntitlementDataUnit("Terabits/Second");
        /// <summary>
        /// Constant Terabytes for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit Terabytes = new EntitlementDataUnit("Terabytes");
        /// <summary>
        /// Constant TerabytesSecond for EntitlementDataUnit
        /// </summary>
        public static readonly EntitlementDataUnit TerabytesSecond = new EntitlementDataUnit("Terabytes/Second");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntitlementDataUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntitlementDataUnit FindValue(string value)
        {
            return FindValue<EntitlementDataUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntitlementDataUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntitlementUnit.
    /// </summary>
    public class EntitlementUnit : ConstantClass
    {

        /// <summary>
        /// Constant Bits for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Bits = new EntitlementUnit("Bits");
        /// <summary>
        /// Constant BitsSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit BitsSecond = new EntitlementUnit("Bits/Second");
        /// <summary>
        /// Constant Bytes for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Bytes = new EntitlementUnit("Bytes");
        /// <summary>
        /// Constant BytesSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit BytesSecond = new EntitlementUnit("Bytes/Second");
        /// <summary>
        /// Constant Count for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Count = new EntitlementUnit("Count");
        /// <summary>
        /// Constant CountSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit CountSecond = new EntitlementUnit("Count/Second");
        /// <summary>
        /// Constant Gigabits for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Gigabits = new EntitlementUnit("Gigabits");
        /// <summary>
        /// Constant GigabitsSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit GigabitsSecond = new EntitlementUnit("Gigabits/Second");
        /// <summary>
        /// Constant Gigabytes for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Gigabytes = new EntitlementUnit("Gigabytes");
        /// <summary>
        /// Constant GigabytesSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit GigabytesSecond = new EntitlementUnit("Gigabytes/Second");
        /// <summary>
        /// Constant Kilobits for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Kilobits = new EntitlementUnit("Kilobits");
        /// <summary>
        /// Constant KilobitsSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit KilobitsSecond = new EntitlementUnit("Kilobits/Second");
        /// <summary>
        /// Constant Kilobytes for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Kilobytes = new EntitlementUnit("Kilobytes");
        /// <summary>
        /// Constant KilobytesSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit KilobytesSecond = new EntitlementUnit("Kilobytes/Second");
        /// <summary>
        /// Constant Megabits for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Megabits = new EntitlementUnit("Megabits");
        /// <summary>
        /// Constant MegabitsSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit MegabitsSecond = new EntitlementUnit("Megabits/Second");
        /// <summary>
        /// Constant Megabytes for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Megabytes = new EntitlementUnit("Megabytes");
        /// <summary>
        /// Constant MegabytesSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit MegabytesSecond = new EntitlementUnit("Megabytes/Second");
        /// <summary>
        /// Constant Microseconds for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Microseconds = new EntitlementUnit("Microseconds");
        /// <summary>
        /// Constant Milliseconds for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Milliseconds = new EntitlementUnit("Milliseconds");
        /// <summary>
        /// Constant None for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit None = new EntitlementUnit("None");
        /// <summary>
        /// Constant Percent for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Percent = new EntitlementUnit("Percent");
        /// <summary>
        /// Constant Seconds for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Seconds = new EntitlementUnit("Seconds");
        /// <summary>
        /// Constant Terabits for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Terabits = new EntitlementUnit("Terabits");
        /// <summary>
        /// Constant TerabitsSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit TerabitsSecond = new EntitlementUnit("Terabits/Second");
        /// <summary>
        /// Constant Terabytes for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit Terabytes = new EntitlementUnit("Terabytes");
        /// <summary>
        /// Constant TerabytesSecond for EntitlementUnit
        /// </summary>
        public static readonly EntitlementUnit TerabytesSecond = new EntitlementUnit("Terabytes/Second");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntitlementUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntitlementUnit FindValue(string value)
        {
            return FindValue<EntitlementUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntitlementUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GrantStatus.
    /// </summary>
    public class GrantStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for GrantStatus
        /// </summary>
        public static readonly GrantStatus ACTIVE = new GrantStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for GrantStatus
        /// </summary>
        public static readonly GrantStatus DELETED = new GrantStatus("DELETED");
        /// <summary>
        /// Constant DISABLED for GrantStatus
        /// </summary>
        public static readonly GrantStatus DISABLED = new GrantStatus("DISABLED");
        /// <summary>
        /// Constant FAILED_WORKFLOW for GrantStatus
        /// </summary>
        public static readonly GrantStatus FAILED_WORKFLOW = new GrantStatus("FAILED_WORKFLOW");
        /// <summary>
        /// Constant PENDING_ACCEPT for GrantStatus
        /// </summary>
        public static readonly GrantStatus PENDING_ACCEPT = new GrantStatus("PENDING_ACCEPT");
        /// <summary>
        /// Constant PENDING_DELETE for GrantStatus
        /// </summary>
        public static readonly GrantStatus PENDING_DELETE = new GrantStatus("PENDING_DELETE");
        /// <summary>
        /// Constant PENDING_WORKFLOW for GrantStatus
        /// </summary>
        public static readonly GrantStatus PENDING_WORKFLOW = new GrantStatus("PENDING_WORKFLOW");
        /// <summary>
        /// Constant REJECTED for GrantStatus
        /// </summary>
        public static readonly GrantStatus REJECTED = new GrantStatus("REJECTED");
        /// <summary>
        /// Constant WORKFLOW_COMPLETED for GrantStatus
        /// </summary>
        public static readonly GrantStatus WORKFLOW_COMPLETED = new GrantStatus("WORKFLOW_COMPLETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GrantStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GrantStatus FindValue(string value)
        {
            return FindValue<GrantStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GrantStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryFilterCondition.
    /// </summary>
    public class InventoryFilterCondition : ConstantClass
    {

        /// <summary>
        /// Constant BEGINS_WITH for InventoryFilterCondition
        /// </summary>
        public static readonly InventoryFilterCondition BEGINS_WITH = new InventoryFilterCondition("BEGINS_WITH");
        /// <summary>
        /// Constant CONTAINS for InventoryFilterCondition
        /// </summary>
        public static readonly InventoryFilterCondition CONTAINS = new InventoryFilterCondition("CONTAINS");
        /// <summary>
        /// Constant EQUALS for InventoryFilterCondition
        /// </summary>
        public static readonly InventoryFilterCondition EQUALS = new InventoryFilterCondition("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for InventoryFilterCondition
        /// </summary>
        public static readonly InventoryFilterCondition NOT_EQUALS = new InventoryFilterCondition("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryFilterCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryFilterCondition FindValue(string value)
        {
            return FindValue<InventoryFilterCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryFilterCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseConfigurationStatus.
    /// </summary>
    public class LicenseConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for LicenseConfigurationStatus
        /// </summary>
        public static readonly LicenseConfigurationStatus AVAILABLE = new LicenseConfigurationStatus("AVAILABLE");
        /// <summary>
        /// Constant DISABLED for LicenseConfigurationStatus
        /// </summary>
        public static readonly LicenseConfigurationStatus DISABLED = new LicenseConfigurationStatus("DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseConfigurationStatus FindValue(string value)
        {
            return FindValue<LicenseConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseConversionTaskStatus.
    /// </summary>
    public class LicenseConversionTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LicenseConversionTaskStatus
        /// </summary>
        public static readonly LicenseConversionTaskStatus FAILED = new LicenseConversionTaskStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for LicenseConversionTaskStatus
        /// </summary>
        public static readonly LicenseConversionTaskStatus IN_PROGRESS = new LicenseConversionTaskStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for LicenseConversionTaskStatus
        /// </summary>
        public static readonly LicenseConversionTaskStatus SUCCEEDED = new LicenseConversionTaskStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseConversionTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseConversionTaskStatus FindValue(string value)
        {
            return FindValue<LicenseConversionTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseConversionTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseCountingType.
    /// </summary>
    public class LicenseCountingType : ConstantClass
    {

        /// <summary>
        /// Constant Core for LicenseCountingType
        /// </summary>
        public static readonly LicenseCountingType Core = new LicenseCountingType("Core");
        /// <summary>
        /// Constant Instance for LicenseCountingType
        /// </summary>
        public static readonly LicenseCountingType Instance = new LicenseCountingType("Instance");
        /// <summary>
        /// Constant Socket for LicenseCountingType
        /// </summary>
        public static readonly LicenseCountingType Socket = new LicenseCountingType("Socket");
        /// <summary>
        /// Constant VCPU for LicenseCountingType
        /// </summary>
        public static readonly LicenseCountingType VCPU = new LicenseCountingType("vCPU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseCountingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseCountingType FindValue(string value)
        {
            return FindValue<LicenseCountingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseCountingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseDeletionStatus.
    /// </summary>
    public class LicenseDeletionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for LicenseDeletionStatus
        /// </summary>
        public static readonly LicenseDeletionStatus DELETED = new LicenseDeletionStatus("DELETED");
        /// <summary>
        /// Constant PENDING_DELETE for LicenseDeletionStatus
        /// </summary>
        public static readonly LicenseDeletionStatus PENDING_DELETE = new LicenseDeletionStatus("PENDING_DELETE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseDeletionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseDeletionStatus FindValue(string value)
        {
            return FindValue<LicenseDeletionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseDeletionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseStatus.
    /// </summary>
    public class LicenseStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for LicenseStatus
        /// </summary>
        public static readonly LicenseStatus AVAILABLE = new LicenseStatus("AVAILABLE");
        /// <summary>
        /// Constant DEACTIVATED for LicenseStatus
        /// </summary>
        public static readonly LicenseStatus DEACTIVATED = new LicenseStatus("DEACTIVATED");
        /// <summary>
        /// Constant DELETED for LicenseStatus
        /// </summary>
        public static readonly LicenseStatus DELETED = new LicenseStatus("DELETED");
        /// <summary>
        /// Constant EXPIRED for LicenseStatus
        /// </summary>
        public static readonly LicenseStatus EXPIRED = new LicenseStatus("EXPIRED");
        /// <summary>
        /// Constant PENDING_AVAILABLE for LicenseStatus
        /// </summary>
        public static readonly LicenseStatus PENDING_AVAILABLE = new LicenseStatus("PENDING_AVAILABLE");
        /// <summary>
        /// Constant PENDING_DELETE for LicenseStatus
        /// </summary>
        public static readonly LicenseStatus PENDING_DELETE = new LicenseStatus("PENDING_DELETE");
        /// <summary>
        /// Constant SUSPENDED for LicenseStatus
        /// </summary>
        public static readonly LicenseStatus SUSPENDED = new LicenseStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseStatus FindValue(string value)
        {
            return FindValue<LicenseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReceivedStatus.
    /// </summary>
    public class ReceivedStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReceivedStatus
        /// </summary>
        public static readonly ReceivedStatus ACTIVE = new ReceivedStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for ReceivedStatus
        /// </summary>
        public static readonly ReceivedStatus DELETED = new ReceivedStatus("DELETED");
        /// <summary>
        /// Constant DISABLED for ReceivedStatus
        /// </summary>
        public static readonly ReceivedStatus DISABLED = new ReceivedStatus("DISABLED");
        /// <summary>
        /// Constant FAILED_WORKFLOW for ReceivedStatus
        /// </summary>
        public static readonly ReceivedStatus FAILED_WORKFLOW = new ReceivedStatus("FAILED_WORKFLOW");
        /// <summary>
        /// Constant PENDING_ACCEPT for ReceivedStatus
        /// </summary>
        public static readonly ReceivedStatus PENDING_ACCEPT = new ReceivedStatus("PENDING_ACCEPT");
        /// <summary>
        /// Constant PENDING_WORKFLOW for ReceivedStatus
        /// </summary>
        public static readonly ReceivedStatus PENDING_WORKFLOW = new ReceivedStatus("PENDING_WORKFLOW");
        /// <summary>
        /// Constant REJECTED for ReceivedStatus
        /// </summary>
        public static readonly ReceivedStatus REJECTED = new ReceivedStatus("REJECTED");
        /// <summary>
        /// Constant WORKFLOW_COMPLETED for ReceivedStatus
        /// </summary>
        public static readonly ReceivedStatus WORKFLOW_COMPLETED = new ReceivedStatus("WORKFLOW_COMPLETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReceivedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReceivedStatus FindValue(string value)
        {
            return FindValue<ReceivedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReceivedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RenewType.
    /// </summary>
    public class RenewType : ConstantClass
    {

        /// <summary>
        /// Constant Monthly for RenewType
        /// </summary>
        public static readonly RenewType Monthly = new RenewType("Monthly");
        /// <summary>
        /// Constant None for RenewType
        /// </summary>
        public static readonly RenewType None = new RenewType("None");
        /// <summary>
        /// Constant Weekly for RenewType
        /// </summary>
        public static readonly RenewType Weekly = new RenewType("Weekly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RenewType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RenewType FindValue(string value)
        {
            return FindValue<RenewType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RenewType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportFrequencyType.
    /// </summary>
    public class ReportFrequencyType : ConstantClass
    {

        /// <summary>
        /// Constant DAY for ReportFrequencyType
        /// </summary>
        public static readonly ReportFrequencyType DAY = new ReportFrequencyType("DAY");
        /// <summary>
        /// Constant MONTH for ReportFrequencyType
        /// </summary>
        public static readonly ReportFrequencyType MONTH = new ReportFrequencyType("MONTH");
        /// <summary>
        /// Constant WEEK for ReportFrequencyType
        /// </summary>
        public static readonly ReportFrequencyType WEEK = new ReportFrequencyType("WEEK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportFrequencyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportFrequencyType FindValue(string value)
        {
            return FindValue<ReportFrequencyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportFrequencyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportType.
    /// </summary>
    public class ReportType : ConstantClass
    {

        /// <summary>
        /// Constant LicenseConfigurationSummaryReport for ReportType
        /// </summary>
        public static readonly ReportType LicenseConfigurationSummaryReport = new ReportType("LicenseConfigurationSummaryReport");
        /// <summary>
        /// Constant LicenseConfigurationUsageReport for ReportType
        /// </summary>
        public static readonly ReportType LicenseConfigurationUsageReport = new ReportType("LicenseConfigurationUsageReport");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportType FindValue(string value)
        {
            return FindValue<ReportType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant EC2_AMI for ResourceType
        /// </summary>
        public static readonly ResourceType EC2_AMI = new ResourceType("EC2_AMI");
        /// <summary>
        /// Constant EC2_HOST for ResourceType
        /// </summary>
        public static readonly ResourceType EC2_HOST = new ResourceType("EC2_HOST");
        /// <summary>
        /// Constant EC2_INSTANCE for ResourceType
        /// </summary>
        public static readonly ResourceType EC2_INSTANCE = new ResourceType("EC2_INSTANCE");
        /// <summary>
        /// Constant RDS for ResourceType
        /// </summary>
        public static readonly ResourceType RDS = new ResourceType("RDS");
        /// <summary>
        /// Constant SYSTEMS_MANAGER_MANAGED_INSTANCE for ResourceType
        /// </summary>
        public static readonly ResourceType SYSTEMS_MANAGER_MANAGED_INSTANCE = new ResourceType("SYSTEMS_MANAGER_MANAGED_INSTANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TokenType.
    /// </summary>
    public class TokenType : ConstantClass
    {

        /// <summary>
        /// Constant REFRESH_TOKEN for TokenType
        /// </summary>
        public static readonly TokenType REFRESH_TOKEN = new TokenType("REFRESH_TOKEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TokenType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TokenType FindValue(string value)
        {
            return FindValue<TokenType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TokenType(string value)
        {
            return FindValue(value);
        }
    }

}