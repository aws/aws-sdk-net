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

namespace Amazon.LambdaWeb
{
    /// <summary>
    /// Constants used for properties of type ApplicationLogLevel.
    /// </summary>
    public class ApplicationLogLevel : ConstantClass
    {
        /// <summary>
        /// Constant DEBUG for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel DEBUG = new ApplicationLogLevel("DEBUG");

        /// <summary>
        /// Constant ERROR for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel ERROR = new ApplicationLogLevel("ERROR");

        /// <summary>
        /// Constant FATAL for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel FATAL = new ApplicationLogLevel("FATAL");

        /// <summary>
        /// Constant INFO for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel INFO = new ApplicationLogLevel("INFO");

        /// <summary>
        /// Constant TRACE for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel TRACE = new ApplicationLogLevel("TRACE");

        /// <summary>
        /// Constant WARN for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel WARN = new ApplicationLogLevel("WARN");

        /// <summary>
        /// Constructs a custom ApplicationLogLevel for a value not among the defined constants.
        /// </summary>
        public ApplicationLogLevel(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationLogLevel FindValue(string value)
        {
            return FindValue<ApplicationLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationLogLevel(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AuthType.
    /// </summary>
    public class AuthType : ConstantClass
    {
        /// <summary>
        /// Constant ApplicationManaged for AuthType
        /// </summary>
        public static readonly AuthType ApplicationManaged = new AuthType("ApplicationManaged");

        /// <summary>
        /// Constant IamAuth for AuthType
        /// </summary>
        public static readonly AuthType IamAuth = new AuthType("IamAuth");

        /// <summary>
        /// Constructs a custom AuthType for a value not among the defined constants.
        /// </summary>
        public AuthType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthType FindValue(string value)
        {
            return FindValue<AuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AutoDeploymentMode.
    /// </summary>
    public class AutoDeploymentMode : ConstantClass
    {
        /// <summary>
        /// Constant Disabled for AutoDeploymentMode
        /// </summary>
        public static readonly AutoDeploymentMode Disabled = new AutoDeploymentMode("Disabled");

        /// <summary>
        /// Constant LatestRevision for AutoDeploymentMode
        /// </summary>
        public static readonly AutoDeploymentMode LatestRevision = new AutoDeploymentMode("LatestRevision");

        /// <summary>
        /// Constructs a custom AutoDeploymentMode for a value not among the defined constants.
        /// </summary>
        public AutoDeploymentMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoDeploymentMode FindValue(string value)
        {
            return FindValue<AutoDeploymentMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoDeploymentMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EndpointState.
    /// </summary>
    public class EndpointState : ConstantClass
    {
        /// <summary>
        /// Constant Active for EndpointState
        /// </summary>
        public static readonly EndpointState Active = new EndpointState("Active");

        /// <summary>
        /// Constant Deleting for EndpointState
        /// </summary>
        public static readonly EndpointState Deleting = new EndpointState("Deleting");

        /// <summary>
        /// Constant Failed for EndpointState
        /// </summary>
        public static readonly EndpointState Failed = new EndpointState("Failed");

        /// <summary>
        /// Constant Pending for EndpointState
        /// </summary>
        public static readonly EndpointState Pending = new EndpointState("Pending");

        /// <summary>
        /// Constructs a custom EndpointState for a value not among the defined constants.
        /// </summary>
        public EndpointState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointState FindValue(string value)
        {
            return FindValue<EndpointState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EndpointType.
    /// </summary>
    public class EndpointType : ConstantClass
    {
        /// <summary>
        /// Constant HomeRegion for EndpointType
        /// </summary>
        public static readonly EndpointType HomeRegion = new EndpointType("HomeRegion");

        /// <summary>
        /// Constant MultiRegion for EndpointType
        /// </summary>
        public static readonly EndpointType MultiRegion = new EndpointType("MultiRegion");

        /// <summary>
        /// Constant PerRegion for EndpointType
        /// </summary>
        public static readonly EndpointType PerRegion = new EndpointType("PerRegion");

        /// <summary>
        /// Constructs a custom EndpointType for a value not among the defined constants.
        /// </summary>
        public EndpointType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointType FindValue(string value)
        {
            return FindValue<EndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EndpointUpdateStatus.
    /// </summary>
    public class EndpointUpdateStatus : ConstantClass
    {
        /// <summary>
        /// Constant Failed for EndpointUpdateStatus
        /// </summary>
        public static readonly EndpointUpdateStatus Failed = new EndpointUpdateStatus("Failed");

        /// <summary>
        /// Constant InProgress for EndpointUpdateStatus
        /// </summary>
        public static readonly EndpointUpdateStatus InProgress = new EndpointUpdateStatus("InProgress");

        /// <summary>
        /// Constant Successful for EndpointUpdateStatus
        /// </summary>
        public static readonly EndpointUpdateStatus Successful = new EndpointUpdateStatus("Successful");

        /// <summary>
        /// Constructs a custom EndpointUpdateStatus for a value not among the defined constants.
        /// </summary>
        public EndpointUpdateStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointUpdateStatus FindValue(string value)
        {
            return FindValue<EndpointUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FunctionState.
    /// </summary>
    public class FunctionState : ConstantClass
    {
        /// <summary>
        /// Constant Active for FunctionState
        /// </summary>
        public static readonly FunctionState Active = new FunctionState("Active");

        /// <summary>
        /// Constant Deleting for FunctionState
        /// </summary>
        public static readonly FunctionState Deleting = new FunctionState("Deleting");

        /// <summary>
        /// Constant Failed for FunctionState
        /// </summary>
        public static readonly FunctionState Failed = new FunctionState("Failed");

        /// <summary>
        /// Constant Pending for FunctionState
        /// </summary>
        public static readonly FunctionState Pending = new FunctionState("Pending");

        /// <summary>
        /// Constructs a custom FunctionState for a value not among the defined constants.
        /// </summary>
        public FunctionState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionState FindValue(string value)
        {
            return FindValue<FunctionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RevisionState.
    /// </summary>
    public class RevisionState : ConstantClass
    {
        /// <summary>
        /// Constant Active for RevisionState
        /// </summary>
        public static readonly RevisionState Active = new RevisionState("Active");

        /// <summary>
        /// Constant Failed for RevisionState
        /// </summary>
        public static readonly RevisionState Failed = new RevisionState("Failed");

        /// <summary>
        /// Constant Pending for RevisionState
        /// </summary>
        public static readonly RevisionState Pending = new RevisionState("Pending");

        /// <summary>
        /// Constructs a custom RevisionState for a value not among the defined constants.
        /// </summary>
        public RevisionState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevisionState FindValue(string value)
        {
            return FindValue<RevisionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevisionState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SystemLogLevel.
    /// </summary>
    public class SystemLogLevel : ConstantClass
    {
        /// <summary>
        /// Constant DEBUG for SystemLogLevel
        /// </summary>
        public static readonly SystemLogLevel DEBUG = new SystemLogLevel("DEBUG");

        /// <summary>
        /// Constant INFO for SystemLogLevel
        /// </summary>
        public static readonly SystemLogLevel INFO = new SystemLogLevel("INFO");

        /// <summary>
        /// Constant WARN for SystemLogLevel
        /// </summary>
        public static readonly SystemLogLevel WARN = new SystemLogLevel("WARN");

        /// <summary>
        /// Constructs a custom SystemLogLevel for a value not among the defined constants.
        /// </summary>
        public SystemLogLevel(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SystemLogLevel FindValue(string value)
        {
            return FindValue<SystemLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SystemLogLevel(string value)
        {
            return FindValue(value);
        }
    }
}
