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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Shield
{

    /// <summary>
    /// Constants used for properties of type AttackLayer.
    /// </summary>
    public class AttackLayer : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION for AttackLayer
        /// </summary>
        public static readonly AttackLayer APPLICATION = new AttackLayer("APPLICATION");
        /// <summary>
        /// Constant NETWORK for AttackLayer
        /// </summary>
        public static readonly AttackLayer NETWORK = new AttackLayer("NETWORK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttackLayer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttackLayer FindValue(string value)
        {
            return FindValue<AttackLayer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttackLayer(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttackPropertyIdentifier.
    /// </summary>
    public class AttackPropertyIdentifier : ConstantClass
    {

        /// <summary>
        /// Constant DESTINATION_URL for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier DESTINATION_URL = new AttackPropertyIdentifier("DESTINATION_URL");
        /// <summary>
        /// Constant REFERRER for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier REFERRER = new AttackPropertyIdentifier("REFERRER");
        /// <summary>
        /// Constant SOURCE_ASN for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier SOURCE_ASN = new AttackPropertyIdentifier("SOURCE_ASN");
        /// <summary>
        /// Constant SOURCE_COUNTRY for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier SOURCE_COUNTRY = new AttackPropertyIdentifier("SOURCE_COUNTRY");
        /// <summary>
        /// Constant SOURCE_IP_ADDRESS for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier SOURCE_IP_ADDRESS = new AttackPropertyIdentifier("SOURCE_IP_ADDRESS");
        /// <summary>
        /// Constant SOURCE_USER_AGENT for AttackPropertyIdentifier
        /// </summary>
        public static readonly AttackPropertyIdentifier SOURCE_USER_AGENT = new AttackPropertyIdentifier("SOURCE_USER_AGENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttackPropertyIdentifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttackPropertyIdentifier FindValue(string value)
        {
            return FindValue<AttackPropertyIdentifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttackPropertyIdentifier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoRenew.
    /// </summary>
    public class AutoRenew : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AutoRenew
        /// </summary>
        public static readonly AutoRenew DISABLED = new AutoRenew("DISABLED");
        /// <summary>
        /// Constant ENABLED for AutoRenew
        /// </summary>
        public static readonly AutoRenew ENABLED = new AutoRenew("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoRenew(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoRenew FindValue(string value)
        {
            return FindValue<AutoRenew>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoRenew(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubResourceType.
    /// </summary>
    public class SubResourceType : ConstantClass
    {

        /// <summary>
        /// Constant IP for SubResourceType
        /// </summary>
        public static readonly SubResourceType IP = new SubResourceType("IP");
        /// <summary>
        /// Constant URL for SubResourceType
        /// </summary>
        public static readonly SubResourceType URL = new SubResourceType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubResourceType FindValue(string value)
        {
            return FindValue<SubResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionState.
    /// </summary>
    public class SubscriptionState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for SubscriptionState
        /// </summary>
        public static readonly SubscriptionState ACTIVE = new SubscriptionState("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for SubscriptionState
        /// </summary>
        public static readonly SubscriptionState INACTIVE = new SubscriptionState("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionState FindValue(string value)
        {
            return FindValue<SubscriptionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Unit.
    /// </summary>
    public class Unit : ConstantClass
    {

        /// <summary>
        /// Constant BITS for Unit
        /// </summary>
        public static readonly Unit BITS = new Unit("BITS");
        /// <summary>
        /// Constant BYTES for Unit
        /// </summary>
        public static readonly Unit BYTES = new Unit("BYTES");
        /// <summary>
        /// Constant PACKETS for Unit
        /// </summary>
        public static readonly Unit PACKETS = new Unit("PACKETS");
        /// <summary>
        /// Constant REQUESTS for Unit
        /// </summary>
        public static readonly Unit REQUESTS = new Unit("REQUESTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Unit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Unit FindValue(string value)
        {
            return FindValue<Unit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Unit(string value)
        {
            return FindValue(value);
        }
    }

}