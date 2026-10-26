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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for an Amazon EFS access point filesystem mounted into the AgentCore
    /// Runtime. EFS access points provide shared file storage accessible from your AgentCore
    /// Runtime sessions.
    /// </summary>
    public partial class EfsAccessPointConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The ARN of the EFS access point to mount into the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string AccessPointArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointArn property is set.
        /// </summary>
        internal bool IsSetAccessPointArn() => this.AccessPointArn != null;

        /// <summary>
        /// Gets and sets the property MountPath. 
        /// <para>
        /// The mount path for the EFS access point inside the AgentCore Runtime. The path must
        /// be under <c>/mnt</c> with exactly one subdirectory level (for example, <c>/mnt/data</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 200)]
        public string MountPath { get; set; }

        /// <summary>
        /// Checks to see if the MountPath property is set.
        /// </summary>
        internal bool IsSetMountPath() => this.MountPath != null;
    }
}
