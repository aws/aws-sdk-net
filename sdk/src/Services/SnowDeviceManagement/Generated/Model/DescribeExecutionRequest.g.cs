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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeExecution operation. Checks the status
    /// of a remote task running on one or more target devices.
    /// </summary>
    public partial class DescribeExecutionRequest : AmazonSnowDeviceManagementRequest
    {
        /// <summary>
        /// Gets and sets the property ManagedDeviceId. 
        /// <para>
        /// The ID of the managed device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ManagedDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedDeviceId property is set.
        /// </summary>
        internal bool IsSetManagedDeviceId() => this.ManagedDeviceId != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the task that the action is describing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;
    }
}
