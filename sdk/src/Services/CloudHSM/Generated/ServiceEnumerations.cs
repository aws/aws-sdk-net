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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudHSM
{

    /// <summary>
    /// Constants used for properties of type ClientVersion.
    /// </summary>
    public class ClientVersion : ConstantClass
    {

        /// <summary>
        /// Constant v5_1 for ClientVersion
        /// </summary>
        public static readonly ClientVersion v5_1 = new ClientVersion("5.1");
        /// <summary>
        /// Constant v5_3 for ClientVersion
        /// </summary>
        public static readonly ClientVersion v5_3 = new ClientVersion("5.3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientVersion FindValue(string value)
        {
            return FindValue<ClientVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudHsmObjectState.
    /// </summary>
    public class CloudHsmObjectState : ConstantClass
    {

        /// <summary>
        /// Constant DEGRADED for CloudHsmObjectState
        /// </summary>
        public static readonly CloudHsmObjectState DEGRADED = new CloudHsmObjectState("DEGRADED");
        /// <summary>
        /// Constant READY for CloudHsmObjectState
        /// </summary>
        public static readonly CloudHsmObjectState READY = new CloudHsmObjectState("READY");
        /// <summary>
        /// Constant UPDATING for CloudHsmObjectState
        /// </summary>
        public static readonly CloudHsmObjectState UPDATING = new CloudHsmObjectState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudHsmObjectState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudHsmObjectState FindValue(string value)
        {
            return FindValue<CloudHsmObjectState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudHsmObjectState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HsmStatus.
    /// </summary>
    public class HsmStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEGRADED for HsmStatus
        /// </summary>
        public static readonly HsmStatus DEGRADED = new HsmStatus("DEGRADED");
        /// <summary>
        /// Constant PENDING for HsmStatus
        /// </summary>
        public static readonly HsmStatus PENDING = new HsmStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for HsmStatus
        /// </summary>
        public static readonly HsmStatus RUNNING = new HsmStatus("RUNNING");
        /// <summary>
        /// Constant SUSPENDED for HsmStatus
        /// </summary>
        public static readonly HsmStatus SUSPENDED = new HsmStatus("SUSPENDED");
        /// <summary>
        /// Constant TERMINATED for HsmStatus
        /// </summary>
        public static readonly HsmStatus TERMINATED = new HsmStatus("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for HsmStatus
        /// </summary>
        public static readonly HsmStatus TERMINATING = new HsmStatus("TERMINATING");
        /// <summary>
        /// Constant UPDATING for HsmStatus
        /// </summary>
        public static readonly HsmStatus UPDATING = new HsmStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HsmStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HsmStatus FindValue(string value)
        {
            return FindValue<HsmStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HsmStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionType.
    /// </summary>
    public class SubscriptionType : ConstantClass
    {

        /// <summary>
        /// Constant PRODUCTION for SubscriptionType
        /// </summary>
        public static readonly SubscriptionType PRODUCTION = new SubscriptionType("PRODUCTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionType FindValue(string value)
        {
            return FindValue<SubscriptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionType(string value)
        {
            return FindValue(value);
        }
    }

}