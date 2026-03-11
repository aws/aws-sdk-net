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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the InviteOrganizationToTransferResponsibility operation.
    /// Sends an invitation to another organization's management account to designate your
    /// account with the specified responsibilities for their organization. The invitation
    /// is implemented as a <a>Handshake</a> whose details are in the response.
    /// 
    ///  
    /// <para>
    /// You can only call this operation from the management account.
    /// </para>
    /// </summary>
    public partial class InviteOrganizationToTransferResponsibilityRequest : AmazonOrganizationsRequest
    {
        private string _notes;
        private string _sourceName;
        private DateTime? _startTimestamp;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private HandshakeParty _target;
        private ResponsibilityTransferType _type;

        /// <summary>
        /// Gets and sets the property Notes. 
        /// <para>
        /// Additional information that you want to include in the invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1024)]
        public string Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }

        // Check to see if Notes property is set
        internal bool IsSetNotes()
        {
            return this._notes != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// Name you want to assign to the transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// Timestamp when the recipient will begin managing the specified responsibilities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that you want to attach to the transfer. For each tag in the list,
        /// you must specify both a tag key and a value. You can set the value to an empty string,
        /// but you can't set it to <c>null</c>. For more information about tagging, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_tagging.html">Tagging
        /// Organizations resources</a> in the Organizations User Guide.
        /// </para>
        ///  <important> 
        /// <para>
        /// Any tags in the request are checked for compliance with any applicable tag policies
        /// when the request is made. The request is rejected if the tags in the request don't
        /// match the requirements of the policy at that time. Tag policy compliance is <i> <b>not</b>
        /// </i> checked again when the invitation is accepted and the tags are actually attached
        /// to the transfer. That means that if the tag policy changes between the invitation
        /// and the acceptance, then that tags could potentially be non-compliant.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// If any one of the tags is not valid or if you exceed the allowed number of tags for
        /// a transfer, then the entire request fails and invitations are not sent.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// A <c>HandshakeParty</c> object. Contains details for the account you want to invite.
        /// Currently, only <c>ACCOUNT</c> and <c>EMAIL</c> are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HandshakeParty Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of responsibility you want to designate to your organization. Currently,
        /// only <c>BILLING</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponsibilityTransferType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}