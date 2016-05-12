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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ApplicationDiscoveryService
{

    /// <summary>
    /// Constants used for properties of type AgentStatus.
    /// </summary>
    public class AgentStatus : ConstantClass
    {

        /// <summary>
        /// Constant BLACKLISTED for AgentStatus
        /// </summary>
        public static readonly AgentStatus BLACKLISTED = new AgentStatus("BLACKLISTED");
        /// <summary>
        /// Constant HEALTHY for AgentStatus
        /// </summary>
        public static readonly AgentStatus HEALTHY = new AgentStatus("HEALTHY");
        /// <summary>
        /// Constant RUNNING for AgentStatus
        /// </summary>
        public static readonly AgentStatus RUNNING = new AgentStatus("RUNNING");
        /// <summary>
        /// Constant SHUTDOWN for AgentStatus
        /// </summary>
        public static readonly AgentStatus SHUTDOWN = new AgentStatus("SHUTDOWN");
        /// <summary>
        /// Constant UNHEALTHY for AgentStatus
        /// </summary>
        public static readonly AgentStatus UNHEALTHY = new AgentStatus("UNHEALTHY");
        /// <summary>
        /// Constant UNKNOWN for AgentStatus
        /// </summary>
        public static readonly AgentStatus UNKNOWN = new AgentStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentStatus FindValue(string value)
        {
            return FindValue<AgentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationItemType.
    /// </summary>
    public class ConfigurationItemType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTION for ConfigurationItemType
        /// </summary>
        public static readonly ConfigurationItemType CONNECTION = new ConfigurationItemType("CONNECTION");
        /// <summary>
        /// Constant PROCESS for ConfigurationItemType
        /// </summary>
        public static readonly ConfigurationItemType PROCESS = new ConfigurationItemType("PROCESS");
        /// <summary>
        /// Constant SERVER for ConfigurationItemType
        /// </summary>
        public static readonly ConfigurationItemType SERVER = new ConfigurationItemType("SERVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationItemType FindValue(string value)
        {
            return FindValue<ConfigurationItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationItemType(string value)
        {
            return FindValue(value);
        }
    }

}