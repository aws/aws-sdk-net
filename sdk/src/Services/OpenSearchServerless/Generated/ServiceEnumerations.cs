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
    /// Constants used for properties of type SecurityConfigType.
    /// </summary>
    public class SecurityConfigType : ConstantClass
    {

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