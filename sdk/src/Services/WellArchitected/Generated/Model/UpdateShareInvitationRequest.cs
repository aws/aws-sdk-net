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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateShareInvitation operation.
    /// Update a workload or custom lens share invitation.
    /// 
    ///  <note> 
    /// <para>
    /// This API operation can be called independently of any resource. Previous documentation
    /// implied that a workload ARN must be specified.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateShareInvitationRequest : AmazonWellArchitectedRequest
    {
        private ShareInvitationAction _shareInvitationAction;
        private string _shareInvitationId;

        /// <summary>
        /// Gets and sets the property ShareInvitationAction.
        /// </summary>
        [AWSProperty(Required=true)]
        public ShareInvitationAction ShareInvitationAction
        {
            get { return this._shareInvitationAction; }
            set { this._shareInvitationAction = value; }
        }

        // Check to see if ShareInvitationAction property is set
        internal bool IsSetShareInvitationAction()
        {
            return this._shareInvitationAction != null;
        }

        /// <summary>
        /// Gets and sets the property ShareInvitationId. 
        /// <para>
        /// The ID assigned to the share invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ShareInvitationId
        {
            get { return this._shareInvitationId; }
            set { this._shareInvitationId = value; }
        }

        // Check to see if ShareInvitationId property is set
        internal bool IsSetShareInvitationId()
        {
            return this._shareInvitationId != null;
        }

    }
}