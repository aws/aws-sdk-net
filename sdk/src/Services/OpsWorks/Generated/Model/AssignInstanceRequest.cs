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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the AssignInstance operation.
    /// Assign a registered instance to a layer.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You can assign registered on-premises instances to any layer type.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can assign registered Amazon EC2 instances only to custom layers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot use this action with instances that were created with AWS OpsWorks Stacks.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an AWS Identity and Access Management
    /// (IAM) user must have a Manage permissions level for the stack or an attached policy
    /// that explicitly grants permissions. For more information on user permissions, see
    /// <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class AssignInstanceRequest : AmazonOpsWorksRequest
    {
        private string _instanceId;
        private List<string> _layerIds = new List<string>();

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property LayerIds. 
        /// <para>
        /// The layer ID, which must correspond to a custom layer. You cannot assign a registered
        /// instance to a built-in layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> LayerIds
        {
            get { return this._layerIds; }
            set { this._layerIds = value; }
        }

        // Check to see if LayerIds property is set
        internal bool IsSetLayerIds()
        {
            return this._layerIds != null && this._layerIds.Count > 0; 
        }

    }
}