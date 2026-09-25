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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfiguredAudienceModelAssociation operation.
    /// Provides the details necessary to create a configured audience model association.
    /// </summary>
    public partial class CreateConfiguredAudienceModelAssociationRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelArn. 
        /// <para>
        /// A unique identifier for the configured audience model that you want to associate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ConfiguredAudienceModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredAudienceModelArn property is set.
        /// </summary>
        internal bool IsSetConfiguredAudienceModelArn() => this.ConfiguredAudienceModelArn != null;

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelAssociationName. 
        /// <para>
        /// The name of the configured audience model association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ConfiguredAudienceModelAssociationName { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredAudienceModelAssociationName property is set.
        /// </summary>
        internal bool IsSetConfiguredAudienceModelAssociationName() => this.ConfiguredAudienceModelAssociationName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the configured audience model association.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        [AWSProperty(Required = true)]
        public bool? ManageResourcePolicies { get; set; }

        /// <summary>
        /// Checks to see if the ManageResourcePolicies property is set.
        /// </summary>
        internal bool IsSetManageResourcePolicies() => this.ManageResourcePolicies.HasValue;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for one of your memberships for a collaboration. The configured
        /// audience model is associated to the collaboration that this membership belongs to.
        /// Accepts a membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
