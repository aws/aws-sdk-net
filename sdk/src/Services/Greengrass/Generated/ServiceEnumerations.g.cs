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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.Greengrass
{
    /// <summary>
    /// Constants used for properties of type BulkDeploymentStatus.
    /// </summary>
    public class BulkDeploymentStatus : ConstantClass
    {
        /// <summary>
        /// Constant Completed for BulkDeploymentStatus
        /// </summary>
        public static readonly BulkDeploymentStatus Completed = new BulkDeploymentStatus("Completed");

        /// <summary>
        /// Constant Failed for BulkDeploymentStatus
        /// </summary>
        public static readonly BulkDeploymentStatus Failed = new BulkDeploymentStatus("Failed");

        /// <summary>
        /// Constant Initializing for BulkDeploymentStatus
        /// </summary>
        public static readonly BulkDeploymentStatus Initializing = new BulkDeploymentStatus("Initializing");

        /// <summary>
        /// Constant Running for BulkDeploymentStatus
        /// </summary>
        public static readonly BulkDeploymentStatus Running = new BulkDeploymentStatus("Running");

        /// <summary>
        /// Constant Stopped for BulkDeploymentStatus
        /// </summary>
        public static readonly BulkDeploymentStatus Stopped = new BulkDeploymentStatus("Stopped");

        /// <summary>
        /// Constant Stopping for BulkDeploymentStatus
        /// </summary>
        public static readonly BulkDeploymentStatus Stopping = new BulkDeploymentStatus("Stopping");

        /// <summary>
        /// Constructs a custom BulkDeploymentStatus for a value not among the defined constants.
        /// </summary>
        public BulkDeploymentStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BulkDeploymentStatus FindValue(string value)
        {
            return FindValue<BulkDeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BulkDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ConfigurationSyncStatus.
    /// </summary>
    public class ConfigurationSyncStatus : ConstantClass
    {
        /// <summary>
        /// Constant InSync for ConfigurationSyncStatus
        /// </summary>
        public static readonly ConfigurationSyncStatus InSync = new ConfigurationSyncStatus("InSync");

        /// <summary>
        /// Constant OutOfSync for ConfigurationSyncStatus
        /// </summary>
        public static readonly ConfigurationSyncStatus OutOfSync = new ConfigurationSyncStatus("OutOfSync");

        /// <summary>
        /// Constructs a custom ConfigurationSyncStatus for a value not among the defined constants.
        /// </summary>
        public ConfigurationSyncStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationSyncStatus FindValue(string value)
        {
            return FindValue<ConfigurationSyncStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationSyncStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DeploymentType.
    /// </summary>
    public class DeploymentType : ConstantClass
    {
        /// <summary>
        /// Constant ForceResetDeployment for DeploymentType
        /// </summary>
        public static readonly DeploymentType ForceResetDeployment = new DeploymentType("ForceResetDeployment");

        /// <summary>
        /// Constant NewDeployment for DeploymentType
        /// </summary>
        public static readonly DeploymentType NewDeployment = new DeploymentType("NewDeployment");

        /// <summary>
        /// Constant Redeployment for DeploymentType
        /// </summary>
        public static readonly DeploymentType Redeployment = new DeploymentType("Redeployment");

        /// <summary>
        /// Constant ResetDeployment for DeploymentType
        /// </summary>
        public static readonly DeploymentType ResetDeployment = new DeploymentType("ResetDeployment");

        /// <summary>
        /// Constructs a custom DeploymentType for a value not among the defined constants.
        /// </summary>
        public DeploymentType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentType FindValue(string value)
        {
            return FindValue<DeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EncodingType.
    /// </summary>
    public class EncodingType : ConstantClass
    {
        /// <summary>
        /// Constant Binary for EncodingType
        /// </summary>
        public static readonly EncodingType Binary = new EncodingType("binary");

        /// <summary>
        /// Constant Json for EncodingType
        /// </summary>
        public static readonly EncodingType Json = new EncodingType("json");

        /// <summary>
        /// Constructs a custom EncodingType for a value not among the defined constants.
        /// </summary>
        public EncodingType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncodingType FindValue(string value)
        {
            return FindValue<EncodingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncodingType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FunctionIsolationMode.
    /// </summary>
    public class FunctionIsolationMode : ConstantClass
    {
        /// <summary>
        /// Constant GreengrassContainer for FunctionIsolationMode
        /// </summary>
        public static readonly FunctionIsolationMode GreengrassContainer = new FunctionIsolationMode("GreengrassContainer");

        /// <summary>
        /// Constant NoContainer for FunctionIsolationMode
        /// </summary>
        public static readonly FunctionIsolationMode NoContainer = new FunctionIsolationMode("NoContainer");

        /// <summary>
        /// Constructs a custom FunctionIsolationMode for a value not among the defined constants.
        /// </summary>
        public FunctionIsolationMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionIsolationMode FindValue(string value)
        {
            return FindValue<FunctionIsolationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionIsolationMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LoggerComponent.
    /// </summary>
    public class LoggerComponent : ConstantClass
    {
        /// <summary>
        /// Constant GreengrassSystem for LoggerComponent
        /// </summary>
        public static readonly LoggerComponent GreengrassSystem = new LoggerComponent("GreengrassSystem");

        /// <summary>
        /// Constant Lambda for LoggerComponent
        /// </summary>
        public static readonly LoggerComponent Lambda = new LoggerComponent("Lambda");

        /// <summary>
        /// Constructs a custom LoggerComponent for a value not among the defined constants.
        /// </summary>
        public LoggerComponent(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggerComponent FindValue(string value)
        {
            return FindValue<LoggerComponent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggerComponent(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LoggerLevel.
    /// </summary>
    public class LoggerLevel : ConstantClass
    {
        /// <summary>
        /// Constant DEBUG for LoggerLevel
        /// </summary>
        public static readonly LoggerLevel DEBUG = new LoggerLevel("DEBUG");

        /// <summary>
        /// Constant ERROR for LoggerLevel
        /// </summary>
        public static readonly LoggerLevel ERROR = new LoggerLevel("ERROR");

        /// <summary>
        /// Constant FATAL for LoggerLevel
        /// </summary>
        public static readonly LoggerLevel FATAL = new LoggerLevel("FATAL");

        /// <summary>
        /// Constant INFO for LoggerLevel
        /// </summary>
        public static readonly LoggerLevel INFO = new LoggerLevel("INFO");

        /// <summary>
        /// Constant WARN for LoggerLevel
        /// </summary>
        public static readonly LoggerLevel WARN = new LoggerLevel("WARN");

        /// <summary>
        /// Constructs a custom LoggerLevel for a value not among the defined constants.
        /// </summary>
        public LoggerLevel(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggerLevel FindValue(string value)
        {
            return FindValue<LoggerLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggerLevel(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LoggerType.
    /// </summary>
    public class LoggerType : ConstantClass
    {
        /// <summary>
        /// Constant AWSCloudWatch for LoggerType
        /// </summary>
        public static readonly LoggerType AWSCloudWatch = new LoggerType("AWSCloudWatch");

        /// <summary>
        /// Constant FileSystem for LoggerType
        /// </summary>
        public static readonly LoggerType FileSystem = new LoggerType("FileSystem");

        /// <summary>
        /// Constructs a custom LoggerType for a value not among the defined constants.
        /// </summary>
        public LoggerType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggerType FindValue(string value)
        {
            return FindValue<LoggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggerType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Permission.
    /// </summary>
    public class Permission : ConstantClass
    {
        /// <summary>
        /// Constant Ro for Permission
        /// </summary>
        public static readonly Permission Ro = new Permission("ro");

        /// <summary>
        /// Constant Rw for Permission
        /// </summary>
        public static readonly Permission Rw = new Permission("rw");

        /// <summary>
        /// Constructs a custom Permission for a value not among the defined constants.
        /// </summary>
        public Permission(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Permission FindValue(string value)
        {
            return FindValue<Permission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Permission(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SoftwareToUpdate.
    /// </summary>
    public class SoftwareToUpdate : ConstantClass
    {
        /// <summary>
        /// Constant Core for SoftwareToUpdate
        /// </summary>
        public static readonly SoftwareToUpdate Core = new SoftwareToUpdate("core");

        /// <summary>
        /// Constant Ota_agent for SoftwareToUpdate
        /// </summary>
        public static readonly SoftwareToUpdate Ota_agent = new SoftwareToUpdate("ota_agent");

        /// <summary>
        /// Constructs a custom SoftwareToUpdate for a value not among the defined constants.
        /// </summary>
        public SoftwareToUpdate(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SoftwareToUpdate FindValue(string value)
        {
            return FindValue<SoftwareToUpdate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SoftwareToUpdate(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Telemetry.
    /// </summary>
    public class Telemetry : ConstantClass
    {
        /// <summary>
        /// Constant Off for Telemetry
        /// </summary>
        public static readonly Telemetry Off = new Telemetry("Off");

        /// <summary>
        /// Constant On for Telemetry
        /// </summary>
        public static readonly Telemetry On = new Telemetry("On");

        /// <summary>
        /// Constructs a custom Telemetry for a value not among the defined constants.
        /// </summary>
        public Telemetry(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Telemetry FindValue(string value)
        {
            return FindValue<Telemetry>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Telemetry(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type UpdateAgentLogLevel.
    /// </summary>
    public class UpdateAgentLogLevel : ConstantClass
    {
        /// <summary>
        /// Constant DEBUG for UpdateAgentLogLevel
        /// </summary>
        public static readonly UpdateAgentLogLevel DEBUG = new UpdateAgentLogLevel("DEBUG");

        /// <summary>
        /// Constant ERROR for UpdateAgentLogLevel
        /// </summary>
        public static readonly UpdateAgentLogLevel ERROR = new UpdateAgentLogLevel("ERROR");

        /// <summary>
        /// Constant FATAL for UpdateAgentLogLevel
        /// </summary>
        public static readonly UpdateAgentLogLevel FATAL = new UpdateAgentLogLevel("FATAL");

        /// <summary>
        /// Constant INFO for UpdateAgentLogLevel
        /// </summary>
        public static readonly UpdateAgentLogLevel INFO = new UpdateAgentLogLevel("INFO");

        /// <summary>
        /// Constant NONE for UpdateAgentLogLevel
        /// </summary>
        public static readonly UpdateAgentLogLevel NONE = new UpdateAgentLogLevel("NONE");

        /// <summary>
        /// Constant TRACE for UpdateAgentLogLevel
        /// </summary>
        public static readonly UpdateAgentLogLevel TRACE = new UpdateAgentLogLevel("TRACE");

        /// <summary>
        /// Constant VERBOSE for UpdateAgentLogLevel
        /// </summary>
        public static readonly UpdateAgentLogLevel VERBOSE = new UpdateAgentLogLevel("VERBOSE");

        /// <summary>
        /// Constant WARN for UpdateAgentLogLevel
        /// </summary>
        public static readonly UpdateAgentLogLevel WARN = new UpdateAgentLogLevel("WARN");

        /// <summary>
        /// Constructs a custom UpdateAgentLogLevel for a value not among the defined constants.
        /// </summary>
        public UpdateAgentLogLevel(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateAgentLogLevel FindValue(string value)
        {
            return FindValue<UpdateAgentLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateAgentLogLevel(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type UpdateTargetsArchitecture.
    /// </summary>
    public class UpdateTargetsArchitecture : ConstantClass
    {
        /// <summary>
        /// Constant Aarch64 for UpdateTargetsArchitecture
        /// </summary>
        public static readonly UpdateTargetsArchitecture Aarch64 = new UpdateTargetsArchitecture("aarch64");

        /// <summary>
        /// Constant Armv6l for UpdateTargetsArchitecture
        /// </summary>
        public static readonly UpdateTargetsArchitecture Armv6l = new UpdateTargetsArchitecture("armv6l");

        /// <summary>
        /// Constant Armv7l for UpdateTargetsArchitecture
        /// </summary>
        public static readonly UpdateTargetsArchitecture Armv7l = new UpdateTargetsArchitecture("armv7l");

        /// <summary>
        /// Constant X86_64 for UpdateTargetsArchitecture
        /// </summary>
        public static readonly UpdateTargetsArchitecture X86_64 = new UpdateTargetsArchitecture("x86_64");

        /// <summary>
        /// Constructs a custom UpdateTargetsArchitecture for a value not among the defined constants.
        /// </summary>
        public UpdateTargetsArchitecture(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateTargetsArchitecture FindValue(string value)
        {
            return FindValue<UpdateTargetsArchitecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateTargetsArchitecture(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type UpdateTargetsOperatingSystem.
    /// </summary>
    public class UpdateTargetsOperatingSystem : ConstantClass
    {
        /// <summary>
        /// Constant Amazon_linux for UpdateTargetsOperatingSystem
        /// </summary>
        public static readonly UpdateTargetsOperatingSystem Amazon_linux = new UpdateTargetsOperatingSystem("amazon_linux");

        /// <summary>
        /// Constant Openwrt for UpdateTargetsOperatingSystem
        /// </summary>
        public static readonly UpdateTargetsOperatingSystem Openwrt = new UpdateTargetsOperatingSystem("openwrt");

        /// <summary>
        /// Constant Raspbian for UpdateTargetsOperatingSystem
        /// </summary>
        public static readonly UpdateTargetsOperatingSystem Raspbian = new UpdateTargetsOperatingSystem("raspbian");

        /// <summary>
        /// Constant Ubuntu for UpdateTargetsOperatingSystem
        /// </summary>
        public static readonly UpdateTargetsOperatingSystem Ubuntu = new UpdateTargetsOperatingSystem("ubuntu");

        /// <summary>
        /// Constructs a custom UpdateTargetsOperatingSystem for a value not among the defined constants.
        /// </summary>
        public UpdateTargetsOperatingSystem(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateTargetsOperatingSystem FindValue(string value)
        {
            return FindValue<UpdateTargetsOperatingSystem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateTargetsOperatingSystem(string value)
        {
            return FindValue(value);
        }
    }
}
