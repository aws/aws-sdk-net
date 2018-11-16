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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Route53Resolver
{

    /// <summary>
    /// Constants used for properties of type IpAddressStatus.
    /// </summary>
    public class IpAddressStatus : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHED for IpAddressStatus
        /// </summary>
        public static readonly IpAddressStatus ATTACHED = new IpAddressStatus("ATTACHED");
        /// <summary>
        /// Constant ATTACHING for IpAddressStatus
        /// </summary>
        public static readonly IpAddressStatus ATTACHING = new IpAddressStatus("ATTACHING");
        /// <summary>
        /// Constant CREATING for IpAddressStatus
        /// </summary>
        public static readonly IpAddressStatus CREATING = new IpAddressStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED_FAS_EXPIRED for IpAddressStatus
        /// </summary>
        public static readonly IpAddressStatus DELETE_FAILED_FAS_EXPIRED = new IpAddressStatus("DELETE_FAILED_FAS_EXPIRED");
        /// <summary>
        /// Constant DELETING for IpAddressStatus
        /// </summary>
        public static readonly IpAddressStatus DELETING = new IpAddressStatus("DELETING");
        /// <summary>
        /// Constant DETACHING for IpAddressStatus
        /// </summary>
        public static readonly IpAddressStatus DETACHING = new IpAddressStatus("DETACHING");
        /// <summary>
        /// Constant FAILED_CREATION for IpAddressStatus
        /// </summary>
        public static readonly IpAddressStatus FAILED_CREATION = new IpAddressStatus("FAILED_CREATION");
        /// <summary>
        /// Constant FAILED_RESOURCE_GONE for IpAddressStatus
        /// </summary>
        public static readonly IpAddressStatus FAILED_RESOURCE_GONE = new IpAddressStatus("FAILED_RESOURCE_GONE");
        /// <summary>
        /// Constant REMAP_ATTACHING for IpAddressStatus
        /// </summary>
        public static readonly IpAddressStatus REMAP_ATTACHING = new IpAddressStatus("REMAP_ATTACHING");
        /// <summary>
        /// Constant REMAP_DETACHING for IpAddressStatus
        /// </summary>
        public static readonly IpAddressStatus REMAP_DETACHING = new IpAddressStatus("REMAP_DETACHING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpAddressStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpAddressStatus FindValue(string value)
        {
            return FindValue<IpAddressStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpAddressStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolverEndpointDirection.
    /// </summary>
    public class ResolverEndpointDirection : ConstantClass
    {

        /// <summary>
        /// Constant INBOUND for ResolverEndpointDirection
        /// </summary>
        public static readonly ResolverEndpointDirection INBOUND = new ResolverEndpointDirection("INBOUND");
        /// <summary>
        /// Constant OUTBOUND for ResolverEndpointDirection
        /// </summary>
        public static readonly ResolverEndpointDirection OUTBOUND = new ResolverEndpointDirection("OUTBOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolverEndpointDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolverEndpointDirection FindValue(string value)
        {
            return FindValue<ResolverEndpointDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolverEndpointDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolverEndpointStatus.
    /// </summary>
    public class ResolverEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_NEEDED for ResolverEndpointStatus
        /// </summary>
        public static readonly ResolverEndpointStatus ACTION_NEEDED = new ResolverEndpointStatus("ACTION_NEEDED");
        /// <summary>
        /// Constant AUTO_RECOVERING for ResolverEndpointStatus
        /// </summary>
        public static readonly ResolverEndpointStatus AUTO_RECOVERING = new ResolverEndpointStatus("AUTO_RECOVERING");
        /// <summary>
        /// Constant CREATING for ResolverEndpointStatus
        /// </summary>
        public static readonly ResolverEndpointStatus CREATING = new ResolverEndpointStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ResolverEndpointStatus
        /// </summary>
        public static readonly ResolverEndpointStatus DELETING = new ResolverEndpointStatus("DELETING");
        /// <summary>
        /// Constant OPERATIONAL for ResolverEndpointStatus
        /// </summary>
        public static readonly ResolverEndpointStatus OPERATIONAL = new ResolverEndpointStatus("OPERATIONAL");
        /// <summary>
        /// Constant UPDATING for ResolverEndpointStatus
        /// </summary>
        public static readonly ResolverEndpointStatus UPDATING = new ResolverEndpointStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolverEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolverEndpointStatus FindValue(string value)
        {
            return FindValue<ResolverEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolverEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolverRuleAssociationStatus.
    /// </summary>
    public class ResolverRuleAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ResolverRuleAssociationStatus
        /// </summary>
        public static readonly ResolverRuleAssociationStatus COMPLETE = new ResolverRuleAssociationStatus("COMPLETE");
        /// <summary>
        /// Constant CREATING for ResolverRuleAssociationStatus
        /// </summary>
        public static readonly ResolverRuleAssociationStatus CREATING = new ResolverRuleAssociationStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ResolverRuleAssociationStatus
        /// </summary>
        public static readonly ResolverRuleAssociationStatus DELETING = new ResolverRuleAssociationStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ResolverRuleAssociationStatus
        /// </summary>
        public static readonly ResolverRuleAssociationStatus FAILED = new ResolverRuleAssociationStatus("FAILED");
        /// <summary>
        /// Constant OVERRIDDEN for ResolverRuleAssociationStatus
        /// </summary>
        public static readonly ResolverRuleAssociationStatus OVERRIDDEN = new ResolverRuleAssociationStatus("OVERRIDDEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolverRuleAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolverRuleAssociationStatus FindValue(string value)
        {
            return FindValue<ResolverRuleAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolverRuleAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolverRuleStatus.
    /// </summary>
    public class ResolverRuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ResolverRuleStatus
        /// </summary>
        public static readonly ResolverRuleStatus COMPLETE = new ResolverRuleStatus("COMPLETE");
        /// <summary>
        /// Constant DELETING for ResolverRuleStatus
        /// </summary>
        public static readonly ResolverRuleStatus DELETING = new ResolverRuleStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ResolverRuleStatus
        /// </summary>
        public static readonly ResolverRuleStatus FAILED = new ResolverRuleStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for ResolverRuleStatus
        /// </summary>
        public static readonly ResolverRuleStatus UPDATING = new ResolverRuleStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolverRuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolverRuleStatus FindValue(string value)
        {
            return FindValue<ResolverRuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolverRuleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleTypeOption.
    /// </summary>
    public class RuleTypeOption : ConstantClass
    {

        /// <summary>
        /// Constant FORWARD for RuleTypeOption
        /// </summary>
        public static readonly RuleTypeOption FORWARD = new RuleTypeOption("FORWARD");
        /// <summary>
        /// Constant RECURSIVE for RuleTypeOption
        /// </summary>
        public static readonly RuleTypeOption RECURSIVE = new RuleTypeOption("RECURSIVE");
        /// <summary>
        /// Constant SYSTEM for RuleTypeOption
        /// </summary>
        public static readonly RuleTypeOption SYSTEM = new RuleTypeOption("SYSTEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleTypeOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleTypeOption FindValue(string value)
        {
            return FindValue<RuleTypeOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleTypeOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareStatus.
    /// </summary>
    public class ShareStatus : ConstantClass
    {

        /// <summary>
        /// Constant NOT_SHARED for ShareStatus
        /// </summary>
        public static readonly ShareStatus NOT_SHARED = new ShareStatus("NOT_SHARED");
        /// <summary>
        /// Constant SHARED_BY_ME for ShareStatus
        /// </summary>
        public static readonly ShareStatus SHARED_BY_ME = new ShareStatus("SHARED_BY_ME");
        /// <summary>
        /// Constant SHARED_WITH_ME for ShareStatus
        /// </summary>
        public static readonly ShareStatus SHARED_WITH_ME = new ShareStatus("SHARED_WITH_ME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareStatus FindValue(string value)
        {
            return FindValue<ShareStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareStatus(string value)
        {
            return FindValue(value);
        }
    }

}