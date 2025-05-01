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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.VerifiedPermissions
{

    /// <summary>
    /// Constants used for properties of type BatchGetPolicyErrorCode.
    /// </summary>
    public class BatchGetPolicyErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant POLICY_NOT_FOUND for BatchGetPolicyErrorCode
        /// </summary>
        public static readonly BatchGetPolicyErrorCode POLICY_NOT_FOUND = new BatchGetPolicyErrorCode("POLICY_NOT_FOUND");
        /// <summary>
        /// Constant POLICY_STORE_NOT_FOUND for BatchGetPolicyErrorCode
        /// </summary>
        public static readonly BatchGetPolicyErrorCode POLICY_STORE_NOT_FOUND = new BatchGetPolicyErrorCode("POLICY_STORE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchGetPolicyErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchGetPolicyErrorCode FindValue(string value)
        {
            return FindValue<BatchGetPolicyErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchGetPolicyErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CedarVersion.
    /// </summary>
    public class CedarVersion : ConstantClass
    {

        /// <summary>
        /// Constant CEDAR_2 for CedarVersion
        /// </summary>
        public static readonly CedarVersion CEDAR_2 = new CedarVersion("CEDAR_2");
        /// <summary>
        /// Constant CEDAR_4 for CedarVersion
        /// </summary>
        public static readonly CedarVersion CEDAR_4 = new CedarVersion("CEDAR_4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CedarVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CedarVersion FindValue(string value)
        {
            return FindValue<CedarVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CedarVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Decision.
    /// </summary>
    public class Decision : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for Decision
        /// </summary>
        public static readonly Decision ALLOW = new Decision("ALLOW");
        /// <summary>
        /// Constant DENY for Decision
        /// </summary>
        public static readonly Decision DENY = new Decision("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Decision(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Decision FindValue(string value)
        {
            return FindValue<Decision>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Decision(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeletionProtection.
    /// </summary>
    public class DeletionProtection : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DeletionProtection
        /// </summary>
        public static readonly DeletionProtection DISABLED = new DeletionProtection("DISABLED");
        /// <summary>
        /// Constant ENABLED for DeletionProtection
        /// </summary>
        public static readonly DeletionProtection ENABLED = new DeletionProtection("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeletionProtection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletionProtection FindValue(string value)
        {
            return FindValue<DeletionProtection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletionProtection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpenIdIssuer.
    /// </summary>
    public class OpenIdIssuer : ConstantClass
    {

        /// <summary>
        /// Constant COGNITO for OpenIdIssuer
        /// </summary>
        public static readonly OpenIdIssuer COGNITO = new OpenIdIssuer("COGNITO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenIdIssuer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenIdIssuer FindValue(string value)
        {
            return FindValue<OpenIdIssuer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenIdIssuer(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyEffect.
    /// </summary>
    public class PolicyEffect : ConstantClass
    {

        /// <summary>
        /// Constant Forbid for PolicyEffect
        /// </summary>
        public static readonly PolicyEffect Forbid = new PolicyEffect("Forbid");
        /// <summary>
        /// Constant Permit for PolicyEffect
        /// </summary>
        public static readonly PolicyEffect Permit = new PolicyEffect("Permit");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyEffect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyEffect FindValue(string value)
        {
            return FindValue<PolicyEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyEffect(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyType.
    /// </summary>
    public class PolicyType : ConstantClass
    {

        /// <summary>
        /// Constant STATIC for PolicyType
        /// </summary>
        public static readonly PolicyType STATIC = new PolicyType("STATIC");
        /// <summary>
        /// Constant TEMPLATE_LINKED for PolicyType
        /// </summary>
        public static readonly PolicyType TEMPLATE_LINKED = new PolicyType("TEMPLATE_LINKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyType FindValue(string value)
        {
            return FindValue<PolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyType(string value)
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
        /// Constant IDENTITY_SOURCE for ResourceType
        /// </summary>
        public static readonly ResourceType IDENTITY_SOURCE = new ResourceType("IDENTITY_SOURCE");
        /// <summary>
        /// Constant POLICY for ResourceType
        /// </summary>
        public static readonly ResourceType POLICY = new ResourceType("POLICY");
        /// <summary>
        /// Constant POLICY_STORE for ResourceType
        /// </summary>
        public static readonly ResourceType POLICY_STORE = new ResourceType("POLICY_STORE");
        /// <summary>
        /// Constant POLICY_TEMPLATE for ResourceType
        /// </summary>
        public static readonly ResourceType POLICY_TEMPLATE = new ResourceType("POLICY_TEMPLATE");
        /// <summary>
        /// Constant SCHEMA for ResourceType
        /// </summary>
        public static readonly ResourceType SCHEMA = new ResourceType("SCHEMA");

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
    /// Constants used for properties of type ValidationMode.
    /// </summary>
    public class ValidationMode : ConstantClass
    {

        /// <summary>
        /// Constant OFF for ValidationMode
        /// </summary>
        public static readonly ValidationMode OFF = new ValidationMode("OFF");
        /// <summary>
        /// Constant STRICT for ValidationMode
        /// </summary>
        public static readonly ValidationMode STRICT = new ValidationMode("STRICT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationMode FindValue(string value)
        {
            return FindValue<ValidationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationMode(string value)
        {
            return FindValue(value);
        }
    }

}