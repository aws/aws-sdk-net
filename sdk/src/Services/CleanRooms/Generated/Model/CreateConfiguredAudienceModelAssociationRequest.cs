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
    /// Container for the parameters to the CreateConfiguredAudienceModelAssociation operation.
    /// Provides the details necessary to create a configured audience model association.
    /// </summary>
    public partial class CreateConfiguredAudienceModelAssociationRequest : AmazonCleanRoomsRequest
    {
        private string _configuredAudienceModelArn;
        private string _configuredAudienceModelAssociationName;
        private string _description;
        private bool? _manageResourcePolicies;
        private string _membershipIdentifier;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelArn. 
        /// <para>
        /// A unique identifier for the configured audience model that you want to associate.
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
        /// Gets and sets the property ConfiguredAudienceModelAssociationName. 
        /// <para>
        /// The name of the configured audience model association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ConfiguredAudienceModelAssociationName
        {
            get { return this._configuredAudienceModelAssociationName; }
            set { this._configuredAudienceModelAssociationName = value; }
        }

        // Check to see if ConfiguredAudienceModelAssociationName property is set
        internal bool IsSetConfiguredAudienceModelAssociationName()
        {
            return this._configuredAudienceModelAssociationName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the configured audience model association.
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
        /// Gets and sets the property ManageResourcePolicies. 
        /// <para>
        /// When <c>TRUE</c>, indicates that the resource policy for the configured audience model
        /// resource being associated is configured for Clean Rooms to manage permissions related
        /// to the given collaboration. When <c>FALSE</c>, indicates that the configured audience
        /// model resource owner will manage permissions related to the given collaboration.
        /// </para>
        ///  
        /// <para>
        /// Setting this to <c>TRUE</c> requires you to have permissions to create, update, and
        /// delete the resource policy for the <c>cleanrooms-ml</c> resource when you call the
        /// <a>DeleteConfiguredAudienceModelAssociation</a> resource. In addition, if you are
        /// the collaboration creator and specify <c>TRUE</c>, you must have the same permissions
        /// when you call the <a>DeleteMember</a> and <a>DeleteCollaboration</a> APIs.
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
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for one of your memberships for a collaboration. The configured
        /// audience model is associated to the collaboration that this membership belongs to.
        /// Accepts a membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}