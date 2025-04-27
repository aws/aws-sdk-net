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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.RedshiftServerless
{

    /// <summary>
    /// Constants used for properties of type LogExport.
    /// </summary>
    public class LogExport : ConstantClass
    {

        /// <summary>
        /// Constant Connectionlog for LogExport
        /// </summary>
        public static readonly LogExport Connectionlog = new LogExport("connectionlog");
        /// <summary>
        /// Constant Useractivitylog for LogExport
        /// </summary>
        public static readonly LogExport Useractivitylog = new LogExport("useractivitylog");
        /// <summary>
        /// Constant Userlog for LogExport
        /// </summary>
        public static readonly LogExport Userlog = new LogExport("userlog");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogExport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogExport FindValue(string value)
        {
            return FindValue<LogExport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogExport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagedWorkgroupStatus.
    /// </summary>
    public class ManagedWorkgroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ManagedWorkgroupStatus
        /// </summary>
        public static readonly ManagedWorkgroupStatus AVAILABLE = new ManagedWorkgroupStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for ManagedWorkgroupStatus
        /// </summary>
        public static readonly ManagedWorkgroupStatus CREATING = new ManagedWorkgroupStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ManagedWorkgroupStatus
        /// </summary>
        public static readonly ManagedWorkgroupStatus DELETING = new ManagedWorkgroupStatus("DELETING");
        /// <summary>
        /// Constant MODIFYING for ManagedWorkgroupStatus
        /// </summary>
        public static readonly ManagedWorkgroupStatus MODIFYING = new ManagedWorkgroupStatus("MODIFYING");
        /// <summary>
        /// Constant NOT_AVAILABLE for ManagedWorkgroupStatus
        /// </summary>
        public static readonly ManagedWorkgroupStatus NOT_AVAILABLE = new ManagedWorkgroupStatus("NOT_AVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagedWorkgroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedWorkgroupStatus FindValue(string value)
        {
            return FindValue<ManagedWorkgroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedWorkgroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamespaceStatus.
    /// </summary>
    public class NamespaceStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus AVAILABLE = new NamespaceStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETING for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus DELETING = new NamespaceStatus("DELETING");
        /// <summary>
        /// Constant MODIFYING for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus MODIFYING = new NamespaceStatus("MODIFYING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamespaceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamespaceStatus FindValue(string value)
        {
            return FindValue<NamespaceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamespaceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferingType.
    /// </summary>
    public class OfferingType : ConstantClass
    {

        /// <summary>
        /// Constant ALL_UPFRONT for OfferingType
        /// </summary>
        public static readonly OfferingType ALL_UPFRONT = new OfferingType("ALL_UPFRONT");
        /// <summary>
        /// Constant NO_UPFRONT for OfferingType
        /// </summary>
        public static readonly OfferingType NO_UPFRONT = new OfferingType("NO_UPFRONT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferingType FindValue(string value)
        {
            return FindValue<OfferingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PerformanceTargetStatus.
    /// </summary>
    public class PerformanceTargetStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for PerformanceTargetStatus
        /// </summary>
        public static readonly PerformanceTargetStatus DISABLED = new PerformanceTargetStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for PerformanceTargetStatus
        /// </summary>
        public static readonly PerformanceTargetStatus ENABLED = new PerformanceTargetStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PerformanceTargetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PerformanceTargetStatus FindValue(string value)
        {
            return FindValue<PerformanceTargetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PerformanceTargetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotStatus.
    /// </summary>
    public class SnapshotStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus AVAILABLE = new SnapshotStatus("AVAILABLE");
        /// <summary>
        /// Constant CANCELLED for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus CANCELLED = new SnapshotStatus("CANCELLED");
        /// <summary>
        /// Constant COPYING for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus COPYING = new SnapshotStatus("COPYING");
        /// <summary>
        /// Constant CREATING for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus CREATING = new SnapshotStatus("CREATING");
        /// <summary>
        /// Constant DELETED for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus DELETED = new SnapshotStatus("DELETED");
        /// <summary>
        /// Constant FAILED for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus FAILED = new SnapshotStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotStatus FindValue(string value)
        {
            return FindValue<SnapshotStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for State
        /// </summary>
        public static readonly State ACTIVE = new State("ACTIVE");
        /// <summary>
        /// Constant DISABLED for State
        /// </summary>
        public static readonly State DISABLED = new State("DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageLimitBreachAction.
    /// </summary>
    public class UsageLimitBreachAction : ConstantClass
    {

        /// <summary>
        /// Constant Deactivate for UsageLimitBreachAction
        /// </summary>
        public static readonly UsageLimitBreachAction Deactivate = new UsageLimitBreachAction("deactivate");
        /// <summary>
        /// Constant EmitMetric for UsageLimitBreachAction
        /// </summary>
        public static readonly UsageLimitBreachAction EmitMetric = new UsageLimitBreachAction("emit-metric");
        /// <summary>
        /// Constant Log for UsageLimitBreachAction
        /// </summary>
        public static readonly UsageLimitBreachAction Log = new UsageLimitBreachAction("log");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageLimitBreachAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageLimitBreachAction FindValue(string value)
        {
            return FindValue<UsageLimitBreachAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageLimitBreachAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageLimitPeriod.
    /// </summary>
    public class UsageLimitPeriod : ConstantClass
    {

        /// <summary>
        /// Constant Daily for UsageLimitPeriod
        /// </summary>
        public static readonly UsageLimitPeriod Daily = new UsageLimitPeriod("daily");
        /// <summary>
        /// Constant Monthly for UsageLimitPeriod
        /// </summary>
        public static readonly UsageLimitPeriod Monthly = new UsageLimitPeriod("monthly");
        /// <summary>
        /// Constant Weekly for UsageLimitPeriod
        /// </summary>
        public static readonly UsageLimitPeriod Weekly = new UsageLimitPeriod("weekly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageLimitPeriod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageLimitPeriod FindValue(string value)
        {
            return FindValue<UsageLimitPeriod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageLimitPeriod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageLimitUsageType.
    /// </summary>
    public class UsageLimitUsageType : ConstantClass
    {

        /// <summary>
        /// Constant CrossRegionDatasharing for UsageLimitUsageType
        /// </summary>
        public static readonly UsageLimitUsageType CrossRegionDatasharing = new UsageLimitUsageType("cross-region-datasharing");
        /// <summary>
        /// Constant ServerlessCompute for UsageLimitUsageType
        /// </summary>
        public static readonly UsageLimitUsageType ServerlessCompute = new UsageLimitUsageType("serverless-compute");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageLimitUsageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageLimitUsageType FindValue(string value)
        {
            return FindValue<UsageLimitUsageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageLimitUsageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkgroupStatus.
    /// </summary>
    public class WorkgroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for WorkgroupStatus
        /// </summary>
        public static readonly WorkgroupStatus AVAILABLE = new WorkgroupStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for WorkgroupStatus
        /// </summary>
        public static readonly WorkgroupStatus CREATING = new WorkgroupStatus("CREATING");
        /// <summary>
        /// Constant DELETING for WorkgroupStatus
        /// </summary>
        public static readonly WorkgroupStatus DELETING = new WorkgroupStatus("DELETING");
        /// <summary>
        /// Constant MODIFYING for WorkgroupStatus
        /// </summary>
        public static readonly WorkgroupStatus MODIFYING = new WorkgroupStatus("MODIFYING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkgroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkgroupStatus FindValue(string value)
        {
            return FindValue<WorkgroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkgroupStatus(string value)
        {
            return FindValue(value);
        }
    }

}