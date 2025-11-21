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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContactFlowModuleVersion operation.
    /// Creates an immutable snapshot of a contact flow module, preserving its content and
    /// settings at a specific point in time for version control and rollback capabilities.
    /// </summary>
    public partial class CreateContactFlowModuleVersionRequest : AmazonConnectRequest
    {
        private string _contactFlowModuleId;
        private string _description;
        private string _flowModuleContentSha256;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ContactFlowModuleId. 
        /// <para>
        /// The identifier of the flow module.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContactFlowModuleId
        {
            get { return this._contactFlowModuleId; }
            set { this._contactFlowModuleId = value; }
        }

        // Check to see if ContactFlowModuleId property is set
        internal bool IsSetContactFlowModuleId()
        {
            return this._contactFlowModuleId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the flow module version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FlowModuleContentSha256. 
        /// <para>
        /// Indicates the checksum value of the flow module content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FlowModuleContentSha256
        {
            get { return this._flowModuleContentSha256; }
            set { this._flowModuleContentSha256 = value; }
        }

        // Check to see if FlowModuleContentSha256 property is set
        internal bool IsSetFlowModuleContentSha256()
        {
            return this._flowModuleContentSha256 != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}