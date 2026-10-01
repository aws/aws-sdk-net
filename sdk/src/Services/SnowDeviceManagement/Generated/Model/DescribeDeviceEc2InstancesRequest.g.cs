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
    /// Container for the parameters to the DescribeDeviceEc2Instances operation. Checks the
    /// current state of the Amazon EC2 instances. The output is similar to <c>describeDevice</c>,
    /// but the results are sourced from the device cache in the Amazon Web Services Cloud
    /// and include a subset of the available fields.
    /// </summary>
    public partial class DescribeDeviceEc2InstancesRequest : AmazonSnowDeviceManagementRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// A list of instance IDs associated with the managed device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> InstanceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceIds property is set.
        /// </summary>
        internal bool IsSetInstanceIds() => this.InstanceIds != null && (this.InstanceIds.Count > 0 || !AWSConfigs.InitializeCollections);

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
    }
}
