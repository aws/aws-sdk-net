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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the SubmitAttachmentStateChanges operation.
    /// <note> 
    /// <para>
    /// This action is only used by the Amazon ECS agent, and it is not intended for use outside
    /// of the agent.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sent to acknowledge that an attachment changed states.
    /// </para>
    /// </summary>
    public partial class SubmitAttachmentStateChangesRequest : AmazonECSRequest
    {
        private List<AttachmentStateChange> _attachments = new List<AttachmentStateChange>();
        private string _cluster;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// Any attachments associated with the state change request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AttachmentStateChange> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && this._attachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full ARN of the cluster that hosts the container instance the attachment
        /// belongs to.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

    }
}