/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.ElasticBeanstalk
{


    /// <summary>Configuration Deployment Status
    /// </summary>
    public class ConfigurationDeploymentStatus : ConstantClass
    {


       /// <summary>Constant Deployed for ConfigurationDeploymentStatus
       /// </summary>
        public static readonly ConfigurationDeploymentStatus Deployed = new ConfigurationDeploymentStatus("deployed");
    

       /// <summary>Constant Failed for ConfigurationDeploymentStatus
       /// </summary>
        public static readonly ConfigurationDeploymentStatus Failed = new ConfigurationDeploymentStatus("failed");
    

       /// <summary>Constant Pending for ConfigurationDeploymentStatus
       /// </summary>
        public static readonly ConfigurationDeploymentStatus Pending = new ConfigurationDeploymentStatus("pending");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ConfigurationDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationDeploymentStatus FindValue(string value)
        {
            return FindValue<ConfigurationDeploymentStatus>(value);
        }

        public static implicit operator ConfigurationDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Configuration Option Value Type
    /// </summary>
    public class ConfigurationOptionValueType : ConstantClass
    {


       /// <summary>Constant List for ConfigurationOptionValueType
       /// </summary>
        public static readonly ConfigurationOptionValueType List = new ConfigurationOptionValueType("List");
    

       /// <summary>Constant Scalar for ConfigurationOptionValueType
       /// </summary>
        public static readonly ConfigurationOptionValueType Scalar = new ConfigurationOptionValueType("Scalar");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ConfigurationOptionValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationOptionValueType FindValue(string value)
        {
            return FindValue<ConfigurationOptionValueType>(value);
        }

        public static implicit operator ConfigurationOptionValueType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Environment Health
    /// </summary>
    public class EnvironmentHealth : ConstantClass
    {


       /// <summary>Constant Green for EnvironmentHealth
       /// </summary>
        public static readonly EnvironmentHealth Green = new EnvironmentHealth("Green");
    

       /// <summary>Constant Grey for EnvironmentHealth
       /// </summary>
        public static readonly EnvironmentHealth Grey = new EnvironmentHealth("Grey");
    

       /// <summary>Constant Red for EnvironmentHealth
       /// </summary>
        public static readonly EnvironmentHealth Red = new EnvironmentHealth("Red");
    

       /// <summary>Constant Yellow for EnvironmentHealth
       /// </summary>
        public static readonly EnvironmentHealth Yellow = new EnvironmentHealth("Yellow");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EnvironmentHealth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentHealth FindValue(string value)
        {
            return FindValue<EnvironmentHealth>(value);
        }

        public static implicit operator EnvironmentHealth(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Environment Info Type
    /// </summary>
    public class EnvironmentInfoType : ConstantClass
    {


       /// <summary>Constant Tail for EnvironmentInfoType
       /// </summary>
        public static readonly EnvironmentInfoType Tail = new EnvironmentInfoType("tail");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EnvironmentInfoType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentInfoType FindValue(string value)
        {
            return FindValue<EnvironmentInfoType>(value);
        }

        public static implicit operator EnvironmentInfoType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Environment Status
    /// </summary>
    public class EnvironmentStatus : ConstantClass
    {


       /// <summary>Constant Launching for EnvironmentStatus
       /// </summary>
        public static readonly EnvironmentStatus Launching = new EnvironmentStatus("Launching");
    

       /// <summary>Constant Ready for EnvironmentStatus
       /// </summary>
        public static readonly EnvironmentStatus Ready = new EnvironmentStatus("Ready");
    

       /// <summary>Constant Terminated for EnvironmentStatus
       /// </summary>
        public static readonly EnvironmentStatus Terminated = new EnvironmentStatus("Terminated");
    

       /// <summary>Constant Terminating for EnvironmentStatus
       /// </summary>
        public static readonly EnvironmentStatus Terminating = new EnvironmentStatus("Terminating");
    

       /// <summary>Constant Updating for EnvironmentStatus
       /// </summary>
        public static readonly EnvironmentStatus Updating = new EnvironmentStatus("Updating");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EnvironmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentStatus FindValue(string value)
        {
            return FindValue<EnvironmentStatus>(value);
        }

        public static implicit operator EnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Event Severity
    /// </summary>
    public class EventSeverity : ConstantClass
    {


       /// <summary>Constant DEBUG for EventSeverity
       /// </summary>
        public static readonly EventSeverity DEBUG = new EventSeverity("DEBUG");
    

       /// <summary>Constant ERROR for EventSeverity
       /// </summary>
        public static readonly EventSeverity ERROR = new EventSeverity("ERROR");
    

       /// <summary>Constant FATAL for EventSeverity
       /// </summary>
        public static readonly EventSeverity FATAL = new EventSeverity("FATAL");
    

       /// <summary>Constant INFO for EventSeverity
       /// </summary>
        public static readonly EventSeverity INFO = new EventSeverity("INFO");
    

       /// <summary>Constant TRACE for EventSeverity
       /// </summary>
        public static readonly EventSeverity TRACE = new EventSeverity("TRACE");
    

       /// <summary>Constant WARN for EventSeverity
       /// </summary>
        public static readonly EventSeverity WARN = new EventSeverity("WARN");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EventSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSeverity FindValue(string value)
        {
            return FindValue<EventSeverity>(value);
        }

        public static implicit operator EventSeverity(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Validation Severity
    /// </summary>
    public class ValidationSeverity : ConstantClass
    {


       /// <summary>Constant Error for ValidationSeverity
       /// </summary>
        public static readonly ValidationSeverity Error = new ValidationSeverity("error");
    

       /// <summary>Constant Warning for ValidationSeverity
       /// </summary>
        public static readonly ValidationSeverity Warning = new ValidationSeverity("warning");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ValidationSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationSeverity FindValue(string value)
        {
            return FindValue<ValidationSeverity>(value);
        }

        public static implicit operator ValidationSeverity(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
