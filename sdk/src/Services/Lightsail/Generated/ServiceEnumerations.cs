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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Lightsail
{

    /// <summary>
    /// Constants used for properties of type AccessDirection.
    /// </summary>
    public class AccessDirection : ConstantClass
    {

        /// <summary>
        /// Constant Inbound for AccessDirection
        /// </summary>
        public static readonly AccessDirection Inbound = new AccessDirection("inbound");
        /// <summary>
        /// Constant Outbound for AccessDirection
        /// </summary>
        public static readonly AccessDirection Outbound = new AccessDirection("outbound");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDirection FindValue(string value)
        {
            return FindValue<AccessDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlueprintType.
    /// </summary>
    public class BlueprintType : ConstantClass
    {

        /// <summary>
        /// Constant App for BlueprintType
        /// </summary>
        public static readonly BlueprintType App = new BlueprintType("app");
        /// <summary>
        /// Constant Os for BlueprintType
        /// </summary>
        public static readonly BlueprintType Os = new BlueprintType("os");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlueprintType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlueprintType FindValue(string value)
        {
            return FindValue<BlueprintType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlueprintType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiskSnapshotState.
    /// </summary>
    public class DiskSnapshotState : ConstantClass
    {

        /// <summary>
        /// Constant Completed for DiskSnapshotState
        /// </summary>
        public static readonly DiskSnapshotState Completed = new DiskSnapshotState("completed");
        /// <summary>
        /// Constant Error for DiskSnapshotState
        /// </summary>
        public static readonly DiskSnapshotState Error = new DiskSnapshotState("error");
        /// <summary>
        /// Constant Pending for DiskSnapshotState
        /// </summary>
        public static readonly DiskSnapshotState Pending = new DiskSnapshotState("pending");
        /// <summary>
        /// Constant Unknown for DiskSnapshotState
        /// </summary>
        public static readonly DiskSnapshotState Unknown = new DiskSnapshotState("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiskSnapshotState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskSnapshotState FindValue(string value)
        {
            return FindValue<DiskSnapshotState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiskSnapshotState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiskState.
    /// </summary>
    public class DiskState : ConstantClass
    {

        /// <summary>
        /// Constant Available for DiskState
        /// </summary>
        public static readonly DiskState Available = new DiskState("available");
        /// <summary>
        /// Constant Error for DiskState
        /// </summary>
        public static readonly DiskState Error = new DiskState("error");
        /// <summary>
        /// Constant InUse for DiskState
        /// </summary>
        public static readonly DiskState InUse = new DiskState("in-use");
        /// <summary>
        /// Constant Pending for DiskState
        /// </summary>
        public static readonly DiskState Pending = new DiskState("pending");
        /// <summary>
        /// Constant Unknown for DiskState
        /// </summary>
        public static readonly DiskState Unknown = new DiskState("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiskState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskState FindValue(string value)
        {
            return FindValue<DiskState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiskState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceAccessProtocol.
    /// </summary>
    public class InstanceAccessProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Rdp for InstanceAccessProtocol
        /// </summary>
        public static readonly InstanceAccessProtocol Rdp = new InstanceAccessProtocol("rdp");
        /// <summary>
        /// Constant Ssh for InstanceAccessProtocol
        /// </summary>
        public static readonly InstanceAccessProtocol Ssh = new InstanceAccessProtocol("ssh");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceAccessProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceAccessProtocol FindValue(string value)
        {
            return FindValue<InstanceAccessProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceAccessProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceHealthReason.
    /// </summary>
    public class InstanceHealthReason : ConstantClass
    {

        /// <summary>
        /// Constant InstanceDeregistrationInProgress for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceDeregistrationInProgress = new InstanceHealthReason("Instance.DeregistrationInProgress");
        /// <summary>
        /// Constant InstanceFailedHealthChecks for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceFailedHealthChecks = new InstanceHealthReason("Instance.FailedHealthChecks");
        /// <summary>
        /// Constant InstanceInvalidState for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceInvalidState = new InstanceHealthReason("Instance.InvalidState");
        /// <summary>
        /// Constant InstanceIpUnusable for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceIpUnusable = new InstanceHealthReason("Instance.IpUnusable");
        /// <summary>
        /// Constant InstanceNotInUse for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceNotInUse = new InstanceHealthReason("Instance.NotInUse");
        /// <summary>
        /// Constant InstanceNotRegistered for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceNotRegistered = new InstanceHealthReason("Instance.NotRegistered");
        /// <summary>
        /// Constant InstanceResponseCodeMismatch for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceResponseCodeMismatch = new InstanceHealthReason("Instance.ResponseCodeMismatch");
        /// <summary>
        /// Constant InstanceTimeout for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceTimeout = new InstanceHealthReason("Instance.Timeout");
        /// <summary>
        /// Constant LbInitialHealthChecking for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason LbInitialHealthChecking = new InstanceHealthReason("Lb.InitialHealthChecking");
        /// <summary>
        /// Constant LbInternalError for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason LbInternalError = new InstanceHealthReason("Lb.InternalError");
        /// <summary>
        /// Constant LbRegistrationInProgress for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason LbRegistrationInProgress = new InstanceHealthReason("Lb.RegistrationInProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceHealthReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceHealthReason FindValue(string value)
        {
            return FindValue<InstanceHealthReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceHealthReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceHealthState.
    /// </summary>
    public class InstanceHealthState : ConstantClass
    {

        /// <summary>
        /// Constant Draining for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Draining = new InstanceHealthState("draining");
        /// <summary>
        /// Constant Healthy for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Healthy = new InstanceHealthState("healthy");
        /// <summary>
        /// Constant Initial for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Initial = new InstanceHealthState("initial");
        /// <summary>
        /// Constant Unavailable for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Unavailable = new InstanceHealthState("unavailable");
        /// <summary>
        /// Constant Unhealthy for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Unhealthy = new InstanceHealthState("unhealthy");
        /// <summary>
        /// Constant Unused for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Unused = new InstanceHealthState("unused");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceHealthState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceHealthState FindValue(string value)
        {
            return FindValue<InstanceHealthState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceHealthState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceMetricName.
    /// </summary>
    public class InstanceMetricName : ConstantClass
    {

        /// <summary>
        /// Constant CPUUtilization for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName CPUUtilization = new InstanceMetricName("CPUUtilization");
        /// <summary>
        /// Constant NetworkIn for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName NetworkIn = new InstanceMetricName("NetworkIn");
        /// <summary>
        /// Constant NetworkOut for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName NetworkOut = new InstanceMetricName("NetworkOut");
        /// <summary>
        /// Constant StatusCheckFailed for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName StatusCheckFailed = new InstanceMetricName("StatusCheckFailed");
        /// <summary>
        /// Constant StatusCheckFailed_Instance for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName StatusCheckFailed_Instance = new InstanceMetricName("StatusCheckFailed_Instance");
        /// <summary>
        /// Constant StatusCheckFailed_System for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName StatusCheckFailed_System = new InstanceMetricName("StatusCheckFailed_System");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceMetricName FindValue(string value)
        {
            return FindValue<InstanceMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstancePlatform.
    /// </summary>
    public class InstancePlatform : ConstantClass
    {

        /// <summary>
        /// Constant LINUX_UNIX for InstancePlatform
        /// </summary>
        public static readonly InstancePlatform LINUX_UNIX = new InstancePlatform("LINUX_UNIX");
        /// <summary>
        /// Constant WINDOWS for InstancePlatform
        /// </summary>
        public static readonly InstancePlatform WINDOWS = new InstancePlatform("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstancePlatform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstancePlatform FindValue(string value)
        {
            return FindValue<InstancePlatform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstancePlatform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceSnapshotState.
    /// </summary>
    public class InstanceSnapshotState : ConstantClass
    {

        /// <summary>
        /// Constant Available for InstanceSnapshotState
        /// </summary>
        public static readonly InstanceSnapshotState Available = new InstanceSnapshotState("available");
        /// <summary>
        /// Constant Error for InstanceSnapshotState
        /// </summary>
        public static readonly InstanceSnapshotState Error = new InstanceSnapshotState("error");
        /// <summary>
        /// Constant Pending for InstanceSnapshotState
        /// </summary>
        public static readonly InstanceSnapshotState Pending = new InstanceSnapshotState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceSnapshotState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceSnapshotState FindValue(string value)
        {
            return FindValue<InstanceSnapshotState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceSnapshotState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerAttributeName.
    /// </summary>
    public class LoadBalancerAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant HealthCheckPath for LoadBalancerAttributeName
        /// </summary>
        public static readonly LoadBalancerAttributeName HealthCheckPath = new LoadBalancerAttributeName("HealthCheckPath");
        /// <summary>
        /// Constant SessionStickiness_LB_CookieDurationSeconds for LoadBalancerAttributeName
        /// </summary>
        public static readonly LoadBalancerAttributeName SessionStickiness_LB_CookieDurationSeconds = new LoadBalancerAttributeName("SessionStickiness_LB_CookieDurationSeconds");
        /// <summary>
        /// Constant SessionStickinessEnabled for LoadBalancerAttributeName
        /// </summary>
        public static readonly LoadBalancerAttributeName SessionStickinessEnabled = new LoadBalancerAttributeName("SessionStickinessEnabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerAttributeName FindValue(string value)
        {
            return FindValue<LoadBalancerAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerMetricName.
    /// </summary>
    public class LoadBalancerMetricName : ConstantClass
    {

        /// <summary>
        /// Constant ClientTLSNegotiationErrorCount for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName ClientTLSNegotiationErrorCount = new LoadBalancerMetricName("ClientTLSNegotiationErrorCount");
        /// <summary>
        /// Constant HealthyHostCount for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HealthyHostCount = new LoadBalancerMetricName("HealthyHostCount");
        /// <summary>
        /// Constant HTTPCode_Instance_2XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_Instance_2XX_Count = new LoadBalancerMetricName("HTTPCode_Instance_2XX_Count");
        /// <summary>
        /// Constant HTTPCode_Instance_3XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_Instance_3XX_Count = new LoadBalancerMetricName("HTTPCode_Instance_3XX_Count");
        /// <summary>
        /// Constant HTTPCode_Instance_4XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_Instance_4XX_Count = new LoadBalancerMetricName("HTTPCode_Instance_4XX_Count");
        /// <summary>
        /// Constant HTTPCode_Instance_5XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_Instance_5XX_Count = new LoadBalancerMetricName("HTTPCode_Instance_5XX_Count");
        /// <summary>
        /// Constant HTTPCode_LB_4XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_LB_4XX_Count = new LoadBalancerMetricName("HTTPCode_LB_4XX_Count");
        /// <summary>
        /// Constant HTTPCode_LB_5XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_LB_5XX_Count = new LoadBalancerMetricName("HTTPCode_LB_5XX_Count");
        /// <summary>
        /// Constant InstanceResponseTime for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName InstanceResponseTime = new LoadBalancerMetricName("InstanceResponseTime");
        /// <summary>
        /// Constant RejectedConnectionCount for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName RejectedConnectionCount = new LoadBalancerMetricName("RejectedConnectionCount");
        /// <summary>
        /// Constant RequestCount for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName RequestCount = new LoadBalancerMetricName("RequestCount");
        /// <summary>
        /// Constant UnhealthyHostCount for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName UnhealthyHostCount = new LoadBalancerMetricName("UnhealthyHostCount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerMetricName FindValue(string value)
        {
            return FindValue<LoadBalancerMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerProtocol.
    /// </summary>
    public class LoadBalancerProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for LoadBalancerProtocol
        /// </summary>
        public static readonly LoadBalancerProtocol HTTP = new LoadBalancerProtocol("HTTP");
        /// <summary>
        /// Constant HTTP_HTTPS for LoadBalancerProtocol
        /// </summary>
        public static readonly LoadBalancerProtocol HTTP_HTTPS = new LoadBalancerProtocol("HTTP_HTTPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerProtocol FindValue(string value)
        {
            return FindValue<LoadBalancerProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerState.
    /// </summary>
    public class LoadBalancerState : ConstantClass
    {

        /// <summary>
        /// Constant Active for LoadBalancerState
        /// </summary>
        public static readonly LoadBalancerState Active = new LoadBalancerState("active");
        /// <summary>
        /// Constant Active_impaired for LoadBalancerState
        /// </summary>
        public static readonly LoadBalancerState Active_impaired = new LoadBalancerState("active_impaired");
        /// <summary>
        /// Constant Failed for LoadBalancerState
        /// </summary>
        public static readonly LoadBalancerState Failed = new LoadBalancerState("failed");
        /// <summary>
        /// Constant Provisioning for LoadBalancerState
        /// </summary>
        public static readonly LoadBalancerState Provisioning = new LoadBalancerState("provisioning");
        /// <summary>
        /// Constant Unknown for LoadBalancerState
        /// </summary>
        public static readonly LoadBalancerState Unknown = new LoadBalancerState("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerState FindValue(string value)
        {
            return FindValue<LoadBalancerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTlsCertificateDomainStatus.
    /// </summary>
    public class LoadBalancerTlsCertificateDomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LoadBalancerTlsCertificateDomainStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateDomainStatus FAILED = new LoadBalancerTlsCertificateDomainStatus("FAILED");
        /// <summary>
        /// Constant PENDING_VALIDATION for LoadBalancerTlsCertificateDomainStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateDomainStatus PENDING_VALIDATION = new LoadBalancerTlsCertificateDomainStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant SUCCESS for LoadBalancerTlsCertificateDomainStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateDomainStatus SUCCESS = new LoadBalancerTlsCertificateDomainStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTlsCertificateDomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTlsCertificateDomainStatus FindValue(string value)
        {
            return FindValue<LoadBalancerTlsCertificateDomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTlsCertificateDomainStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTlsCertificateFailureReason.
    /// </summary>
    public class LoadBalancerTlsCertificateFailureReason : ConstantClass
    {

        /// <summary>
        /// Constant ADDITIONAL_VERIFICATION_REQUIRED for LoadBalancerTlsCertificateFailureReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateFailureReason ADDITIONAL_VERIFICATION_REQUIRED = new LoadBalancerTlsCertificateFailureReason("ADDITIONAL_VERIFICATION_REQUIRED");
        /// <summary>
        /// Constant DOMAIN_NOT_ALLOWED for LoadBalancerTlsCertificateFailureReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateFailureReason DOMAIN_NOT_ALLOWED = new LoadBalancerTlsCertificateFailureReason("DOMAIN_NOT_ALLOWED");
        /// <summary>
        /// Constant INVALID_PUBLIC_DOMAIN for LoadBalancerTlsCertificateFailureReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateFailureReason INVALID_PUBLIC_DOMAIN = new LoadBalancerTlsCertificateFailureReason("INVALID_PUBLIC_DOMAIN");
        /// <summary>
        /// Constant NO_AVAILABLE_CONTACTS for LoadBalancerTlsCertificateFailureReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateFailureReason NO_AVAILABLE_CONTACTS = new LoadBalancerTlsCertificateFailureReason("NO_AVAILABLE_CONTACTS");
        /// <summary>
        /// Constant OTHER for LoadBalancerTlsCertificateFailureReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateFailureReason OTHER = new LoadBalancerTlsCertificateFailureReason("OTHER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTlsCertificateFailureReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTlsCertificateFailureReason FindValue(string value)
        {
            return FindValue<LoadBalancerTlsCertificateFailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTlsCertificateFailureReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTlsCertificateRenewalStatus.
    /// </summary>
    public class LoadBalancerTlsCertificateRenewalStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LoadBalancerTlsCertificateRenewalStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRenewalStatus FAILED = new LoadBalancerTlsCertificateRenewalStatus("FAILED");
        /// <summary>
        /// Constant PENDING_AUTO_RENEWAL for LoadBalancerTlsCertificateRenewalStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRenewalStatus PENDING_AUTO_RENEWAL = new LoadBalancerTlsCertificateRenewalStatus("PENDING_AUTO_RENEWAL");
        /// <summary>
        /// Constant PENDING_VALIDATION for LoadBalancerTlsCertificateRenewalStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRenewalStatus PENDING_VALIDATION = new LoadBalancerTlsCertificateRenewalStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant SUCCESS for LoadBalancerTlsCertificateRenewalStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRenewalStatus SUCCESS = new LoadBalancerTlsCertificateRenewalStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTlsCertificateRenewalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTlsCertificateRenewalStatus FindValue(string value)
        {
            return FindValue<LoadBalancerTlsCertificateRenewalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTlsCertificateRenewalStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTlsCertificateRevocationReason.
    /// </summary>
    public class LoadBalancerTlsCertificateRevocationReason : ConstantClass
    {

        /// <summary>
        /// Constant A_A_COMPROMISE for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason A_A_COMPROMISE = new LoadBalancerTlsCertificateRevocationReason("A_A_COMPROMISE");
        /// <summary>
        /// Constant AFFILIATION_CHANGED for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason AFFILIATION_CHANGED = new LoadBalancerTlsCertificateRevocationReason("AFFILIATION_CHANGED");
        /// <summary>
        /// Constant CA_COMPROMISE for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason CA_COMPROMISE = new LoadBalancerTlsCertificateRevocationReason("CA_COMPROMISE");
        /// <summary>
        /// Constant CERTIFICATE_HOLD for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason CERTIFICATE_HOLD = new LoadBalancerTlsCertificateRevocationReason("CERTIFICATE_HOLD");
        /// <summary>
        /// Constant CESSATION_OF_OPERATION for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason CESSATION_OF_OPERATION = new LoadBalancerTlsCertificateRevocationReason("CESSATION_OF_OPERATION");
        /// <summary>
        /// Constant KEY_COMPROMISE for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason KEY_COMPROMISE = new LoadBalancerTlsCertificateRevocationReason("KEY_COMPROMISE");
        /// <summary>
        /// Constant PRIVILEGE_WITHDRAWN for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason PRIVILEGE_WITHDRAWN = new LoadBalancerTlsCertificateRevocationReason("PRIVILEGE_WITHDRAWN");
        /// <summary>
        /// Constant REMOVE_FROM_CRL for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason REMOVE_FROM_CRL = new LoadBalancerTlsCertificateRevocationReason("REMOVE_FROM_CRL");
        /// <summary>
        /// Constant SUPERCEDED for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason SUPERCEDED = new LoadBalancerTlsCertificateRevocationReason("SUPERCEDED");
        /// <summary>
        /// Constant UNSPECIFIED for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason UNSPECIFIED = new LoadBalancerTlsCertificateRevocationReason("UNSPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTlsCertificateRevocationReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTlsCertificateRevocationReason FindValue(string value)
        {
            return FindValue<LoadBalancerTlsCertificateRevocationReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTlsCertificateRevocationReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTlsCertificateStatus.
    /// </summary>
    public class LoadBalancerTlsCertificateStatus : ConstantClass
    {

        /// <summary>
        /// Constant EXPIRED for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus EXPIRED = new LoadBalancerTlsCertificateStatus("EXPIRED");
        /// <summary>
        /// Constant FAILED for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus FAILED = new LoadBalancerTlsCertificateStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus INACTIVE = new LoadBalancerTlsCertificateStatus("INACTIVE");
        /// <summary>
        /// Constant ISSUED for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus ISSUED = new LoadBalancerTlsCertificateStatus("ISSUED");
        /// <summary>
        /// Constant PENDING_VALIDATION for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus PENDING_VALIDATION = new LoadBalancerTlsCertificateStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant REVOKED for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus REVOKED = new LoadBalancerTlsCertificateStatus("REVOKED");
        /// <summary>
        /// Constant UNKNOWN for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus UNKNOWN = new LoadBalancerTlsCertificateStatus("UNKNOWN");
        /// <summary>
        /// Constant VALIDATION_TIMED_OUT for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus VALIDATION_TIMED_OUT = new LoadBalancerTlsCertificateStatus("VALIDATION_TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTlsCertificateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTlsCertificateStatus FindValue(string value)
        {
            return FindValue<LoadBalancerTlsCertificateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTlsCertificateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricStatistic.
    /// </summary>
    public class MetricStatistic : ConstantClass
    {

        /// <summary>
        /// Constant Average for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Average = new MetricStatistic("Average");
        /// <summary>
        /// Constant Maximum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Maximum = new MetricStatistic("Maximum");
        /// <summary>
        /// Constant Minimum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Minimum = new MetricStatistic("Minimum");
        /// <summary>
        /// Constant SampleCount for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic SampleCount = new MetricStatistic("SampleCount");
        /// <summary>
        /// Constant Sum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Sum = new MetricStatistic("Sum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricStatistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricStatistic FindValue(string value)
        {
            return FindValue<MetricStatistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricStatistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricUnit.
    /// </summary>
    public class MetricUnit : ConstantClass
    {

        /// <summary>
        /// Constant Bits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Bits = new MetricUnit("Bits");
        /// <summary>
        /// Constant BitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit BitsSecond = new MetricUnit("Bits/Second");
        /// <summary>
        /// Constant Bytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Bytes = new MetricUnit("Bytes");
        /// <summary>
        /// Constant BytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit BytesSecond = new MetricUnit("Bytes/Second");
        /// <summary>
        /// Constant Count for MetricUnit
        /// </summary>
        public static readonly MetricUnit Count = new MetricUnit("Count");
        /// <summary>
        /// Constant CountSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit CountSecond = new MetricUnit("Count/Second");
        /// <summary>
        /// Constant Gigabits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Gigabits = new MetricUnit("Gigabits");
        /// <summary>
        /// Constant GigabitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit GigabitsSecond = new MetricUnit("Gigabits/Second");
        /// <summary>
        /// Constant Gigabytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Gigabytes = new MetricUnit("Gigabytes");
        /// <summary>
        /// Constant GigabytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit GigabytesSecond = new MetricUnit("Gigabytes/Second");
        /// <summary>
        /// Constant Kilobits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Kilobits = new MetricUnit("Kilobits");
        /// <summary>
        /// Constant KilobitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit KilobitsSecond = new MetricUnit("Kilobits/Second");
        /// <summary>
        /// Constant Kilobytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Kilobytes = new MetricUnit("Kilobytes");
        /// <summary>
        /// Constant KilobytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit KilobytesSecond = new MetricUnit("Kilobytes/Second");
        /// <summary>
        /// Constant Megabits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Megabits = new MetricUnit("Megabits");
        /// <summary>
        /// Constant MegabitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit MegabitsSecond = new MetricUnit("Megabits/Second");
        /// <summary>
        /// Constant Megabytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Megabytes = new MetricUnit("Megabytes");
        /// <summary>
        /// Constant MegabytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit MegabytesSecond = new MetricUnit("Megabytes/Second");
        /// <summary>
        /// Constant Microseconds for MetricUnit
        /// </summary>
        public static readonly MetricUnit Microseconds = new MetricUnit("Microseconds");
        /// <summary>
        /// Constant Milliseconds for MetricUnit
        /// </summary>
        public static readonly MetricUnit Milliseconds = new MetricUnit("Milliseconds");
        /// <summary>
        /// Constant None for MetricUnit
        /// </summary>
        public static readonly MetricUnit None = new MetricUnit("None");
        /// <summary>
        /// Constant Percent for MetricUnit
        /// </summary>
        public static readonly MetricUnit Percent = new MetricUnit("Percent");
        /// <summary>
        /// Constant Seconds for MetricUnit
        /// </summary>
        public static readonly MetricUnit Seconds = new MetricUnit("Seconds");
        /// <summary>
        /// Constant Terabits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Terabits = new MetricUnit("Terabits");
        /// <summary>
        /// Constant TerabitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit TerabitsSecond = new MetricUnit("Terabits/Second");
        /// <summary>
        /// Constant Terabytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Terabytes = new MetricUnit("Terabytes");
        /// <summary>
        /// Constant TerabytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit TerabytesSecond = new MetricUnit("Terabytes/Second");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricUnit FindValue(string value)
        {
            return FindValue<MetricUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkProtocol.
    /// </summary>
    public class NetworkProtocol : ConstantClass
    {

        /// <summary>
        /// Constant All for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol All = new NetworkProtocol("all");
        /// <summary>
        /// Constant Tcp for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol Tcp = new NetworkProtocol("tcp");
        /// <summary>
        /// Constant Udp for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol Udp = new NetworkProtocol("udp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkProtocol FindValue(string value)
        {
            return FindValue<NetworkProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationStatus.
    /// </summary>
    public class OperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for OperationStatus
        /// </summary>
        public static readonly OperationStatus Completed = new OperationStatus("Completed");
        /// <summary>
        /// Constant Failed for OperationStatus
        /// </summary>
        public static readonly OperationStatus Failed = new OperationStatus("Failed");
        /// <summary>
        /// Constant NotStarted for OperationStatus
        /// </summary>
        public static readonly OperationStatus NotStarted = new OperationStatus("NotStarted");
        /// <summary>
        /// Constant Started for OperationStatus
        /// </summary>
        public static readonly OperationStatus Started = new OperationStatus("Started");
        /// <summary>
        /// Constant Succeeded for OperationStatus
        /// </summary>
        public static readonly OperationStatus Succeeded = new OperationStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationStatus FindValue(string value)
        {
            return FindValue<OperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationType.
    /// </summary>
    public class OperationType : ConstantClass
    {

        /// <summary>
        /// Constant AllocateStaticIp for OperationType
        /// </summary>
        public static readonly OperationType AllocateStaticIp = new OperationType("AllocateStaticIp");
        /// <summary>
        /// Constant AttachDisk for OperationType
        /// </summary>
        public static readonly OperationType AttachDisk = new OperationType("AttachDisk");
        /// <summary>
        /// Constant AttachInstancesToLoadBalancer for OperationType
        /// </summary>
        public static readonly OperationType AttachInstancesToLoadBalancer = new OperationType("AttachInstancesToLoadBalancer");
        /// <summary>
        /// Constant AttachLoadBalancerTlsCertificate for OperationType
        /// </summary>
        public static readonly OperationType AttachLoadBalancerTlsCertificate = new OperationType("AttachLoadBalancerTlsCertificate");
        /// <summary>
        /// Constant AttachStaticIp for OperationType
        /// </summary>
        public static readonly OperationType AttachStaticIp = new OperationType("AttachStaticIp");
        /// <summary>
        /// Constant CloseInstancePublicPorts for OperationType
        /// </summary>
        public static readonly OperationType CloseInstancePublicPorts = new OperationType("CloseInstancePublicPorts");
        /// <summary>
        /// Constant CreateDisk for OperationType
        /// </summary>
        public static readonly OperationType CreateDisk = new OperationType("CreateDisk");
        /// <summary>
        /// Constant CreateDiskFromSnapshot for OperationType
        /// </summary>
        public static readonly OperationType CreateDiskFromSnapshot = new OperationType("CreateDiskFromSnapshot");
        /// <summary>
        /// Constant CreateDiskSnapshot for OperationType
        /// </summary>
        public static readonly OperationType CreateDiskSnapshot = new OperationType("CreateDiskSnapshot");
        /// <summary>
        /// Constant CreateDomain for OperationType
        /// </summary>
        public static readonly OperationType CreateDomain = new OperationType("CreateDomain");
        /// <summary>
        /// Constant CreateInstance for OperationType
        /// </summary>
        public static readonly OperationType CreateInstance = new OperationType("CreateInstance");
        /// <summary>
        /// Constant CreateInstancesFromSnapshot for OperationType
        /// </summary>
        public static readonly OperationType CreateInstancesFromSnapshot = new OperationType("CreateInstancesFromSnapshot");
        /// <summary>
        /// Constant CreateInstanceSnapshot for OperationType
        /// </summary>
        public static readonly OperationType CreateInstanceSnapshot = new OperationType("CreateInstanceSnapshot");
        /// <summary>
        /// Constant CreateLoadBalancer for OperationType
        /// </summary>
        public static readonly OperationType CreateLoadBalancer = new OperationType("CreateLoadBalancer");
        /// <summary>
        /// Constant CreateLoadBalancerTlsCertificate for OperationType
        /// </summary>
        public static readonly OperationType CreateLoadBalancerTlsCertificate = new OperationType("CreateLoadBalancerTlsCertificate");
        /// <summary>
        /// Constant DeleteDisk for OperationType
        /// </summary>
        public static readonly OperationType DeleteDisk = new OperationType("DeleteDisk");
        /// <summary>
        /// Constant DeleteDiskSnapshot for OperationType
        /// </summary>
        public static readonly OperationType DeleteDiskSnapshot = new OperationType("DeleteDiskSnapshot");
        /// <summary>
        /// Constant DeleteDomain for OperationType
        /// </summary>
        public static readonly OperationType DeleteDomain = new OperationType("DeleteDomain");
        /// <summary>
        /// Constant DeleteDomainEntry for OperationType
        /// </summary>
        public static readonly OperationType DeleteDomainEntry = new OperationType("DeleteDomainEntry");
        /// <summary>
        /// Constant DeleteInstance for OperationType
        /// </summary>
        public static readonly OperationType DeleteInstance = new OperationType("DeleteInstance");
        /// <summary>
        /// Constant DeleteInstanceSnapshot for OperationType
        /// </summary>
        public static readonly OperationType DeleteInstanceSnapshot = new OperationType("DeleteInstanceSnapshot");
        /// <summary>
        /// Constant DeleteLoadBalancer for OperationType
        /// </summary>
        public static readonly OperationType DeleteLoadBalancer = new OperationType("DeleteLoadBalancer");
        /// <summary>
        /// Constant DeleteLoadBalancerTlsCertificate for OperationType
        /// </summary>
        public static readonly OperationType DeleteLoadBalancerTlsCertificate = new OperationType("DeleteLoadBalancerTlsCertificate");
        /// <summary>
        /// Constant DetachDisk for OperationType
        /// </summary>
        public static readonly OperationType DetachDisk = new OperationType("DetachDisk");
        /// <summary>
        /// Constant DetachInstancesFromLoadBalancer for OperationType
        /// </summary>
        public static readonly OperationType DetachInstancesFromLoadBalancer = new OperationType("DetachInstancesFromLoadBalancer");
        /// <summary>
        /// Constant DetachStaticIp for OperationType
        /// </summary>
        public static readonly OperationType DetachStaticIp = new OperationType("DetachStaticIp");
        /// <summary>
        /// Constant OpenInstancePublicPorts for OperationType
        /// </summary>
        public static readonly OperationType OpenInstancePublicPorts = new OperationType("OpenInstancePublicPorts");
        /// <summary>
        /// Constant PutInstancePublicPorts for OperationType
        /// </summary>
        public static readonly OperationType PutInstancePublicPorts = new OperationType("PutInstancePublicPorts");
        /// <summary>
        /// Constant RebootInstance for OperationType
        /// </summary>
        public static readonly OperationType RebootInstance = new OperationType("RebootInstance");
        /// <summary>
        /// Constant ReleaseStaticIp for OperationType
        /// </summary>
        public static readonly OperationType ReleaseStaticIp = new OperationType("ReleaseStaticIp");
        /// <summary>
        /// Constant StartInstance for OperationType
        /// </summary>
        public static readonly OperationType StartInstance = new OperationType("StartInstance");
        /// <summary>
        /// Constant StopInstance for OperationType
        /// </summary>
        public static readonly OperationType StopInstance = new OperationType("StopInstance");
        /// <summary>
        /// Constant UpdateDomainEntry for OperationType
        /// </summary>
        public static readonly OperationType UpdateDomainEntry = new OperationType("UpdateDomainEntry");
        /// <summary>
        /// Constant UpdateLoadBalancerAttribute for OperationType
        /// </summary>
        public static readonly OperationType UpdateLoadBalancerAttribute = new OperationType("UpdateLoadBalancerAttribute");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationType FindValue(string value)
        {
            return FindValue<OperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PortAccessType.
    /// </summary>
    public class PortAccessType : ConstantClass
    {

        /// <summary>
        /// Constant Private for PortAccessType
        /// </summary>
        public static readonly PortAccessType Private = new PortAccessType("Private");
        /// <summary>
        /// Constant Public for PortAccessType
        /// </summary>
        public static readonly PortAccessType Public = new PortAccessType("Public");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortAccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortAccessType FindValue(string value)
        {
            return FindValue<PortAccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortAccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PortState.
    /// </summary>
    public class PortState : ConstantClass
    {

        /// <summary>
        /// Constant Closed for PortState
        /// </summary>
        public static readonly PortState Closed = new PortState("closed");
        /// <summary>
        /// Constant Open for PortState
        /// </summary>
        public static readonly PortState Open = new PortState("open");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortState FindValue(string value)
        {
            return FindValue<PortState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegionName.
    /// </summary>
    public class RegionName : ConstantClass
    {

        /// <summary>
        /// Constant ApNortheast1 for RegionName
        /// </summary>
        public static readonly RegionName ApNortheast1 = new RegionName("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for RegionName
        /// </summary>
        public static readonly RegionName ApNortheast2 = new RegionName("ap-northeast-2");
        /// <summary>
        /// Constant ApSouth1 for RegionName
        /// </summary>
        public static readonly RegionName ApSouth1 = new RegionName("ap-south-1");
        /// <summary>
        /// Constant ApSoutheast1 for RegionName
        /// </summary>
        public static readonly RegionName ApSoutheast1 = new RegionName("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for RegionName
        /// </summary>
        public static readonly RegionName ApSoutheast2 = new RegionName("ap-southeast-2");
        /// <summary>
        /// Constant EuCentral1 for RegionName
        /// </summary>
        public static readonly RegionName EuCentral1 = new RegionName("eu-central-1");
        /// <summary>
        /// Constant EuWest1 for RegionName
        /// </summary>
        public static readonly RegionName EuWest1 = new RegionName("eu-west-1");
        /// <summary>
        /// Constant EuWest2 for RegionName
        /// </summary>
        public static readonly RegionName EuWest2 = new RegionName("eu-west-2");
        /// <summary>
        /// Constant UsEast1 for RegionName
        /// </summary>
        public static readonly RegionName UsEast1 = new RegionName("us-east-1");
        /// <summary>
        /// Constant UsEast2 for RegionName
        /// </summary>
        public static readonly RegionName UsEast2 = new RegionName("us-east-2");
        /// <summary>
        /// Constant UsWest1 for RegionName
        /// </summary>
        public static readonly RegionName UsWest1 = new RegionName("us-west-1");
        /// <summary>
        /// Constant UsWest2 for RegionName
        /// </summary>
        public static readonly RegionName UsWest2 = new RegionName("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegionName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegionName FindValue(string value)
        {
            return FindValue<RegionName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegionName(string value)
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
        /// Constant Disk for ResourceType
        /// </summary>
        public static readonly ResourceType Disk = new ResourceType("Disk");
        /// <summary>
        /// Constant DiskSnapshot for ResourceType
        /// </summary>
        public static readonly ResourceType DiskSnapshot = new ResourceType("DiskSnapshot");
        /// <summary>
        /// Constant Domain for ResourceType
        /// </summary>
        public static readonly ResourceType Domain = new ResourceType("Domain");
        /// <summary>
        /// Constant Instance for ResourceType
        /// </summary>
        public static readonly ResourceType Instance = new ResourceType("Instance");
        /// <summary>
        /// Constant InstanceSnapshot for ResourceType
        /// </summary>
        public static readonly ResourceType InstanceSnapshot = new ResourceType("InstanceSnapshot");
        /// <summary>
        /// Constant KeyPair for ResourceType
        /// </summary>
        public static readonly ResourceType KeyPair = new ResourceType("KeyPair");
        /// <summary>
        /// Constant LoadBalancer for ResourceType
        /// </summary>
        public static readonly ResourceType LoadBalancer = new ResourceType("LoadBalancer");
        /// <summary>
        /// Constant LoadBalancerTlsCertificate for ResourceType
        /// </summary>
        public static readonly ResourceType LoadBalancerTlsCertificate = new ResourceType("LoadBalancerTlsCertificate");
        /// <summary>
        /// Constant PeeredVpc for ResourceType
        /// </summary>
        public static readonly ResourceType PeeredVpc = new ResourceType("PeeredVpc");
        /// <summary>
        /// Constant StaticIp for ResourceType
        /// </summary>
        public static readonly ResourceType StaticIp = new ResourceType("StaticIp");

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