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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// This is the response object from the GetEngagement operation.
    /// </summary>
    public partial class GetEngagementResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the engagement retrieved.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Contexts. 
        /// <para>
        /// A list of context objects associated with the engagement. Each context provides additional
        /// information related to the Engagement, such as customer projects or documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<EngagementContextDetails> Contexts { get; set; } = AWSConfigs.InitializeCollections ? new List<EngagementContextDetails>() : null;

        /// <summary>
        /// Checks to see if the Contexts property is set.
        /// </summary>
        internal bool IsSetContexts() => this.Contexts != null && (this.Contexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Engagement was created, presented in ISO 8601 format (UTC).
        /// For example: "2023-05-01T20:37:46Z". This timestamp helps track the lifecycle of the
        /// Engagement.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The AWS account ID of the user who originally created the engagement. This field helps
        /// in tracking the origin of the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A more detailed description of the engagement. This provides additional context or
        /// information about the engagement's purpose or scope.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique resource identifier of the engagement retrieved.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MemberCount. 
        /// <para>
        /// Specifies the current count of members participating in the Engagement. This count
        /// includes all active members regardless of their roles or permissions within the Engagement.
        /// </para>
        /// </summary>
        public int? MemberCount { get; set; }

        /// <summary>
        /// Checks to see if the MemberCount property is set.
        /// </summary>
        internal bool IsSetMemberCount() => this.MemberCount.HasValue;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp indicating when the engagement was last modified, in ISO 8601 format
        /// (UTC). Example: "2023-05-01T20:37:46Z". This helps track the most recent changes to
        /// the engagement.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ModifiedBy. 
        /// <para>
        /// The AWS account ID of the user who last modified the engagement. This field helps
        /// track who made the most recent changes to the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedBy property is set.
        /// </summary>
        internal bool IsSetModifiedBy() => this.ModifiedBy != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the engagement. It provides a brief, descriptive name for the engagement
        /// that is meaningful and easily recognizable.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
