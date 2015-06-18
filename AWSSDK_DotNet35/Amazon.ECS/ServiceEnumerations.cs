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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ECS
{

    /// <summary>
    /// Constants used for properties of type AgentUpdateStatus.
    /// </summary>
    public class AgentUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus FAILED = new AgentUpdateStatus("FAILED");
        /// <summary>
        /// Constant PENDING for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus PENDING = new AgentUpdateStatus("PENDING");
        /// <summary>
        /// Constant STAGED for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus STAGED = new AgentUpdateStatus("STAGED");
        /// <summary>
        /// Constant STAGING for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus STAGING = new AgentUpdateStatus("STAGING");
        /// <summary>
        /// Constant UPDATED for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus UPDATED = new AgentUpdateStatus("UPDATED");
        /// <summary>
        /// Constant UPDATING for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus UPDATING = new AgentUpdateStatus("UPDATING");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AgentUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentUpdateStatus FindValue(string value)
        {
            return FindValue<AgentUpdateStatus>(value);
        }

        public static implicit operator AgentUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DesiredStatus.
    /// </summary>
    public class DesiredStatus : ConstantClass
    {

        /// <summary>
        /// Constant PENDING for DesiredStatus
        /// </summary>
        public static readonly DesiredStatus PENDING = new DesiredStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for DesiredStatus
        /// </summary>
        public static readonly DesiredStatus RUNNING = new DesiredStatus("RUNNING");
        /// <summary>
        /// Constant STOPPED for DesiredStatus
        /// </summary>
        public static readonly DesiredStatus STOPPED = new DesiredStatus("STOPPED");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DesiredStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DesiredStatus FindValue(string value)
        {
            return FindValue<DesiredStatus>(value);
        }

        public static implicit operator DesiredStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortOrder
        /// </summary>
        public static readonly SortOrder ASC = new SortOrder("ASC");
        /// <summary>
        /// Constant DESC for SortOrder
        /// </summary>
        public static readonly SortOrder DESC = new SortOrder("DESC");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskDefinitionStatus.
    /// </summary>
    public class TaskDefinitionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TaskDefinitionStatus
        /// </summary>
        public static readonly TaskDefinitionStatus ACTIVE = new TaskDefinitionStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for TaskDefinitionStatus
        /// </summary>
        public static readonly TaskDefinitionStatus INACTIVE = new TaskDefinitionStatus("INACTIVE");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TaskDefinitionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskDefinitionStatus FindValue(string value)
        {
            return FindValue<TaskDefinitionStatus>(value);
        }

        public static implicit operator TaskDefinitionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransportProtocol.
    /// </summary>
    public class TransportProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Tcp for TransportProtocol
        /// </summary>
        public static readonly TransportProtocol Tcp = new TransportProtocol("tcp");
        /// <summary>
        /// Constant Udp for TransportProtocol
        /// </summary>
        public static readonly TransportProtocol Udp = new TransportProtocol("udp");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TransportProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransportProtocol FindValue(string value)
        {
            return FindValue<TransportProtocol>(value);
        }

        public static implicit operator TransportProtocol(string value)
        {
            return FindValue(value);
        }
    }

}