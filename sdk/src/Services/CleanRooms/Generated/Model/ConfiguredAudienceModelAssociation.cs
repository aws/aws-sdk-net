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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Details about the configured audience model association.
    /// </summary>
    public partial class ConfiguredAudienceModelAssociation
    {
        private string _arn;
        private string _collaborationArn;
        private string _collaborationId;
        private string _configuredAudienceModelArn;
        private DateTime? _createTime;
        private string _description;
        private string _id;
        private bool? _manageResourcePolicies;
        private string _membershipArn;
        private string _membershipId;
        private string _name;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured audience model association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collaboration that contains this configured
        /// audience model association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string CollaborationArn
        {
            get { return this._collaborationArn; }
            set { this._collaborationArn = value; }
        }

        // Check to see if CollaborationArn property is set
        internal bool IsSetCollaborationArn()
        {
            return this._collaborationArn != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// A unique identifier of the collaboration that contains this configured audience model
        /// association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationId
        {
            get { return this._collaborationId; }
            set { this._collaborationId = value; }
        }

        // Check to see if CollaborationId property is set
        internal bool IsSetCollaborationId()
        {
            return this._collaborationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured audience model that was used for
        /// this configured audience model association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ConfiguredAudienceModelArn
        {
            get { return this._configuredAudienceModelArn; }
            set { this._configuredAudienceModelArn = value; }
        }

        // Check to see if ConfiguredAudienceModelArn property is set
        internal bool IsSetConfiguredAudienceModelArn()
        {
            return this._configuredAudienceModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the configured audience model association was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the configured audience model association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier of the configured audience model association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ManageResourcePolicies. 
        /// <para>
        /// When <c>TRUE</c>, indicates that the resource policy for the configured audience model
        /// resource being associated is configured for Clean Rooms to manage permissions related
        /// to the given collaboration. When <c>FALSE</c>, indicates that the configured audience
        /// model resource owner will manage permissions related to the given collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ManageResourcePolicies
        {
            get { return this._manageResourcePolicies; }
            set { this._manageResourcePolicies = value; }
        }

        // Check to see if ManageResourcePolicies property is set
        internal bool IsSetManageResourcePolicies()
        {
            return this._manageResourcePolicies.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the membership that contains this configured audience
        /// model association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string MembershipArn
        {
            get { return this._membershipArn; }
            set { this._membershipArn = value; }
        }

        // Check to see if MembershipArn property is set
        internal bool IsSetMembershipArn()
        {
            return this._membershipArn != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// A unique identifier for the membership that contains this configured audience model
        /// association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipId
        {
            get { return this._membershipId; }
            set { this._membershipId = value; }
        }

        // Check to see if MembershipId property is set
        internal bool IsSetMembershipId()
        {
            return this._membershipId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configured audience model association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the configured audience model association was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}