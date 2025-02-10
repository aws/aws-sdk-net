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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DLM
{

    /// <summary>
    /// Constants used for properties of type DefaultPoliciesTypeValues.
    /// </summary>
    public class DefaultPoliciesTypeValues : ConstantClass
    {

        /// <summary>
        /// Constant ALL for DefaultPoliciesTypeValues
        /// </summary>
        public static readonly DefaultPoliciesTypeValues ALL = new DefaultPoliciesTypeValues("ALL");
        /// <summary>
        /// Constant INSTANCE for DefaultPoliciesTypeValues
        /// </summary>
        public static readonly DefaultPoliciesTypeValues INSTANCE = new DefaultPoliciesTypeValues("INSTANCE");
        /// <summary>
        /// Constant VOLUME for DefaultPoliciesTypeValues
        /// </summary>
        public static readonly DefaultPoliciesTypeValues VOLUME = new DefaultPoliciesTypeValues("VOLUME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultPoliciesTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultPoliciesTypeValues FindValue(string value)
        {
            return FindValue<DefaultPoliciesTypeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultPoliciesTypeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultPolicyTypeValues.
    /// </summary>
    public class DefaultPolicyTypeValues : ConstantClass
    {

        /// <summary>
        /// Constant INSTANCE for DefaultPolicyTypeValues
        /// </summary>
        public static readonly DefaultPolicyTypeValues INSTANCE = new DefaultPolicyTypeValues("INSTANCE");
        /// <summary>
        /// Constant VOLUME for DefaultPolicyTypeValues
        /// </summary>
        public static readonly DefaultPolicyTypeValues VOLUME = new DefaultPolicyTypeValues("VOLUME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultPolicyTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultPolicyTypeValues FindValue(string value)
        {
            return FindValue<DefaultPolicyTypeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultPolicyTypeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSourceValues.
    /// </summary>
    public class EventSourceValues : ConstantClass
    {

        /// <summary>
        /// Constant MANAGED_CWE for EventSourceValues
        /// </summary>
        public static readonly EventSourceValues MANAGED_CWE = new EventSourceValues("MANAGED_CWE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSourceValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSourceValues FindValue(string value)
        {
            return FindValue<EventSourceValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSourceValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventTypeValues.
    /// </summary>
    public class EventTypeValues : ConstantClass
    {

        /// <summary>
        /// Constant ShareSnapshot for EventTypeValues
        /// </summary>
        public static readonly EventTypeValues ShareSnapshot = new EventTypeValues("shareSnapshot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventTypeValues FindValue(string value)
        {
            return FindValue<EventTypeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventTypeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionHandlerServiceValues.
    /// </summary>
    public class ExecutionHandlerServiceValues : ConstantClass
    {

        /// <summary>
        /// Constant AWS_SYSTEMS_MANAGER for ExecutionHandlerServiceValues
        /// </summary>
        public static readonly ExecutionHandlerServiceValues AWS_SYSTEMS_MANAGER = new ExecutionHandlerServiceValues("AWS_SYSTEMS_MANAGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionHandlerServiceValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionHandlerServiceValues FindValue(string value)
        {
            return FindValue<ExecutionHandlerServiceValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionHandlerServiceValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GettablePolicyStateValues.
    /// </summary>
    public class GettablePolicyStateValues : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for GettablePolicyStateValues
        /// </summary>
        public static readonly GettablePolicyStateValues DISABLED = new GettablePolicyStateValues("DISABLED");
        /// <summary>
        /// Constant ENABLED for GettablePolicyStateValues
        /// </summary>
        public static readonly GettablePolicyStateValues ENABLED = new GettablePolicyStateValues("ENABLED");
        /// <summary>
        /// Constant ERROR for GettablePolicyStateValues
        /// </summary>
        public static readonly GettablePolicyStateValues ERROR = new GettablePolicyStateValues("ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GettablePolicyStateValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GettablePolicyStateValues FindValue(string value)
        {
            return FindValue<GettablePolicyStateValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GettablePolicyStateValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntervalUnitValues.
    /// </summary>
    public class IntervalUnitValues : ConstantClass
    {

        /// <summary>
        /// Constant HOURS for IntervalUnitValues
        /// </summary>
        public static readonly IntervalUnitValues HOURS = new IntervalUnitValues("HOURS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntervalUnitValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntervalUnitValues FindValue(string value)
        {
            return FindValue<IntervalUnitValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntervalUnitValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocationValues.
    /// </summary>
    public class LocationValues : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD for LocationValues
        /// </summary>
        public static readonly LocationValues CLOUD = new LocationValues("CLOUD");
        /// <summary>
        /// Constant LOCAL_ZONE for LocationValues
        /// </summary>
        public static readonly LocationValues LOCAL_ZONE = new LocationValues("LOCAL_ZONE");
        /// <summary>
        /// Constant OUTPOST_LOCAL for LocationValues
        /// </summary>
        public static readonly LocationValues OUTPOST_LOCAL = new LocationValues("OUTPOST_LOCAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocationValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationValues FindValue(string value)
        {
            return FindValue<LocationValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyLanguageValues.
    /// </summary>
    public class PolicyLanguageValues : ConstantClass
    {

        /// <summary>
        /// Constant SIMPLIFIED for PolicyLanguageValues
        /// </summary>
        public static readonly PolicyLanguageValues SIMPLIFIED = new PolicyLanguageValues("SIMPLIFIED");
        /// <summary>
        /// Constant STANDARD for PolicyLanguageValues
        /// </summary>
        public static readonly PolicyLanguageValues STANDARD = new PolicyLanguageValues("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyLanguageValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyLanguageValues FindValue(string value)
        {
            return FindValue<PolicyLanguageValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyLanguageValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyTypeValues.
    /// </summary>
    public class PolicyTypeValues : ConstantClass
    {

        /// <summary>
        /// Constant EBS_SNAPSHOT_MANAGEMENT for PolicyTypeValues
        /// </summary>
        public static readonly PolicyTypeValues EBS_SNAPSHOT_MANAGEMENT = new PolicyTypeValues("EBS_SNAPSHOT_MANAGEMENT");
        /// <summary>
        /// Constant EVENT_BASED_POLICY for PolicyTypeValues
        /// </summary>
        public static readonly PolicyTypeValues EVENT_BASED_POLICY = new PolicyTypeValues("EVENT_BASED_POLICY");
        /// <summary>
        /// Constant IMAGE_MANAGEMENT for PolicyTypeValues
        /// </summary>
        public static readonly PolicyTypeValues IMAGE_MANAGEMENT = new PolicyTypeValues("IMAGE_MANAGEMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyTypeValues FindValue(string value)
        {
            return FindValue<PolicyTypeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyTypeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceLocationValues.
    /// </summary>
    public class ResourceLocationValues : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD for ResourceLocationValues
        /// </summary>
        public static readonly ResourceLocationValues CLOUD = new ResourceLocationValues("CLOUD");
        /// <summary>
        /// Constant LOCAL_ZONE for ResourceLocationValues
        /// </summary>
        public static readonly ResourceLocationValues LOCAL_ZONE = new ResourceLocationValues("LOCAL_ZONE");
        /// <summary>
        /// Constant OUTPOST for ResourceLocationValues
        /// </summary>
        public static readonly ResourceLocationValues OUTPOST = new ResourceLocationValues("OUTPOST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceLocationValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceLocationValues FindValue(string value)
        {
            return FindValue<ResourceLocationValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceLocationValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceTypeValues.
    /// </summary>
    public class ResourceTypeValues : ConstantClass
    {

        /// <summary>
        /// Constant INSTANCE for ResourceTypeValues
        /// </summary>
        public static readonly ResourceTypeValues INSTANCE = new ResourceTypeValues("INSTANCE");
        /// <summary>
        /// Constant VOLUME for ResourceTypeValues
        /// </summary>
        public static readonly ResourceTypeValues VOLUME = new ResourceTypeValues("VOLUME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceTypeValues FindValue(string value)
        {
            return FindValue<ResourceTypeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceTypeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetentionIntervalUnitValues.
    /// </summary>
    public class RetentionIntervalUnitValues : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for RetentionIntervalUnitValues
        /// </summary>
        public static readonly RetentionIntervalUnitValues DAYS = new RetentionIntervalUnitValues("DAYS");
        /// <summary>
        /// Constant MONTHS for RetentionIntervalUnitValues
        /// </summary>
        public static readonly RetentionIntervalUnitValues MONTHS = new RetentionIntervalUnitValues("MONTHS");
        /// <summary>
        /// Constant WEEKS for RetentionIntervalUnitValues
        /// </summary>
        public static readonly RetentionIntervalUnitValues WEEKS = new RetentionIntervalUnitValues("WEEKS");
        /// <summary>
        /// Constant YEARS for RetentionIntervalUnitValues
        /// </summary>
        public static readonly RetentionIntervalUnitValues YEARS = new RetentionIntervalUnitValues("YEARS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetentionIntervalUnitValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetentionIntervalUnitValues FindValue(string value)
        {
            return FindValue<RetentionIntervalUnitValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetentionIntervalUnitValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SettablePolicyStateValues.
    /// </summary>
    public class SettablePolicyStateValues : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for SettablePolicyStateValues
        /// </summary>
        public static readonly SettablePolicyStateValues DISABLED = new SettablePolicyStateValues("DISABLED");
        /// <summary>
        /// Constant ENABLED for SettablePolicyStateValues
        /// </summary>
        public static readonly SettablePolicyStateValues ENABLED = new SettablePolicyStateValues("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SettablePolicyStateValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SettablePolicyStateValues FindValue(string value)
        {
            return FindValue<SettablePolicyStateValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SettablePolicyStateValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StageValues.
    /// </summary>
    public class StageValues : ConstantClass
    {

        /// <summary>
        /// Constant POST for StageValues
        /// </summary>
        public static readonly StageValues POST = new StageValues("POST");
        /// <summary>
        /// Constant PRE for StageValues
        /// </summary>
        public static readonly StageValues PRE = new StageValues("PRE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StageValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StageValues FindValue(string value)
        {
            return FindValue<StageValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StageValues(string value)
        {
            return FindValue(value);
        }
    }

}