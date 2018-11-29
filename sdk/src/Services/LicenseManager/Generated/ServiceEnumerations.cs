/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

}