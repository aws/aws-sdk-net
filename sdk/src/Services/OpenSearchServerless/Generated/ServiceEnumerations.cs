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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.OpenSearchServerless
{

    /// <summary>
    /// Constants used for properties of type AccessPolicyType.
    /// </summary>
    public class AccessPolicyType : ConstantClass
    {

        /// <summary>
        /// Constant Data for AccessPolicyType
        /// </summary>
        public static readonly AccessPolicyType Data = new AccessPolicyType("data");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessPolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessPolicyType FindValue(string value)
        {
            return FindValue<AccessPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessPolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CollectionStatus.
    /// </summary>
    public class CollectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CollectionStatus
        /// </summary>
        public static readonly CollectionStatus ACTIVE = new CollectionStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for CollectionStatus
        /// </summary>
        public static readonly CollectionStatus CREATING = new CollectionStatus("CREATING");
        /// <summary>
        /// Constant DELETING for CollectionStatus
        /// </summary>
        public static readonly CollectionStatus DELETING = new CollectionStatus("DELETING");
        /// <summary>
        /// Constant FAILED for CollectionStatus
        /// </summary>
        public static readonly CollectionStatus FAILED = new CollectionStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CollectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CollectionStatus FindValue(string value)
        {
            return FindValue<CollectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CollectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CollectionType.
    /// </summary>
    public class CollectionType : ConstantClass
    {

        /// <summary>
        /// Constant SEARCH for CollectionType
        /// </summary>
        public static readonly CollectionType SEARCH = new CollectionType("SEARCH");
        /// <summary>
        /// Constant TIMESERIES for CollectionType
        /// </summary>
        public static readonly CollectionType TIMESERIES = new CollectionType("TIMESERIES");
        /// <summary>
        /// Constant VECTORSEARCH for CollectionType
        /// </summary>
        public static readonly CollectionType VECTORSEARCH = new CollectionType("VECTORSEARCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CollectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CollectionType FindValue(string value)
        {
            return FindValue<CollectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CollectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IamIdentityCenterGroupAttribute.
    /// </summary>
    public class IamIdentityCenterGroupAttribute : ConstantClass
    {

        /// <summary>
        /// Constant GroupId for IamIdentityCenterGroupAttribute
        /// </summary>
        public static readonly IamIdentityCenterGroupAttribute GroupId = new IamIdentityCenterGroupAttribute("GroupId");
        /// <summary>
        /// Constant GroupName for IamIdentityCenterGroupAttribute
        /// </summary>
        public static readonly IamIdentityCenterGroupAttribute GroupName = new IamIdentityCenterGroupAttribute("GroupName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IamIdentityCenterGroupAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IamIdentityCenterGroupAttribute FindValue(string value)
        {
            return FindValue<IamIdentityCenterGroupAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IamIdentityCenterGroupAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IamIdentityCenterUserAttribute.
    /// </summary>
    public class IamIdentityCenterUserAttribute : ConstantClass
    {

        /// <summary>
        /// Constant Email for IamIdentityCenterUserAttribute
        /// </summary>
        public static readonly IamIdentityCenterUserAttribute Email = new IamIdentityCenterUserAttribute("Email");
        /// <summary>
        /// Constant UserId for IamIdentityCenterUserAttribute
        /// </summary>
        public static readonly IamIdentityCenterUserAttribute UserId = new IamIdentityCenterUserAttribute("UserId");
        /// <summary>
        /// Constant UserName for IamIdentityCenterUserAttribute
        /// </summary>
        public static readonly IamIdentityCenterUserAttribute UserName = new IamIdentityCenterUserAttribute("UserName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IamIdentityCenterUserAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IamIdentityCenterUserAttribute FindValue(string value)
        {
            return FindValue<IamIdentityCenterUserAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IamIdentityCenterUserAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecyclePolicyType.
    /// </summary>
    public class LifecyclePolicyType : ConstantClass
    {

        /// <summary>
        /// Constant Retention for LifecyclePolicyType
        /// </summary>
        public static readonly LifecyclePolicyType Retention = new LifecyclePolicyType("retention");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecyclePolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecyclePolicyType FindValue(string value)
        {
            return FindValue<LifecyclePolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecyclePolicyType(string value)
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
        /// Constant Index for ResourceType
        /// </summary>
        public static readonly ResourceType Index = new ResourceType("index");

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
    /// Constants used for properties of type SecurityConfigType.
    /// </summary>
    public class SecurityConfigType : ConstantClass
    {

        /// <summary>
        /// Constant Iamfederation for SecurityConfigType
        /// </summary>
        public static readonly SecurityConfigType Iamfederation = new SecurityConfigType("iamfederation");
        /// <summary>
        /// Constant Iamidentitycenter for SecurityConfigType
        /// </summary>
        public static readonly SecurityConfigType Iamidentitycenter = new SecurityConfigType("iamidentitycenter");
        /// <summary>
        /// Constant Saml for SecurityConfigType
        /// </summary>
        public static readonly SecurityConfigType Saml = new SecurityConfigType("saml");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityConfigType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityConfigType FindValue(string value)
        {
            return FindValue<SecurityConfigType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityConfigType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecurityPolicyType.
    /// </summary>
    public class SecurityPolicyType : ConstantClass
    {

        /// <summary>
        /// Constant Encryption for SecurityPolicyType
        /// </summary>
        public static readonly SecurityPolicyType Encryption = new SecurityPolicyType("encryption");
        /// <summary>
        /// Constant Network for SecurityPolicyType
        /// </summary>
        public static readonly SecurityPolicyType Network = new SecurityPolicyType("network");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityPolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityPolicyType FindValue(string value)
        {
            return FindValue<SecurityPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityPolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StandbyReplicas.
    /// </summary>
    public class StandbyReplicas : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for StandbyReplicas
        /// </summary>
        public static readonly StandbyReplicas DISABLED = new StandbyReplicas("DISABLED");
        /// <summary>
        /// Constant ENABLED for StandbyReplicas
        /// </summary>
        public static readonly StandbyReplicas ENABLED = new StandbyReplicas("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandbyReplicas(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandbyReplicas FindValue(string value)
        {
            return FindValue<StandbyReplicas>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandbyReplicas(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcEndpointStatus.
    /// </summary>
    public class VpcEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus ACTIVE = new VpcEndpointStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus DELETING = new VpcEndpointStatus("DELETING");
        /// <summary>
        /// Constant FAILED for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus FAILED = new VpcEndpointStatus("FAILED");
        /// <summary>
        /// Constant PENDING for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus PENDING = new VpcEndpointStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcEndpointStatus FindValue(string value)
        {
            return FindValue<VpcEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }

}