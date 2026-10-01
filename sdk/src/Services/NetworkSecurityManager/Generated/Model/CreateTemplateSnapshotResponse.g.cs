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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// This is the response object from the CreateTemplateSnapshot operation.
    /// </summary>
    public partial class CreateTemplateSnapshotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociatedRuleList. 
        /// <para>
        /// The rules associated with the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<AssociatedRule> AssociatedRuleList { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedRule>() : null;

        /// <summary>
        /// Checks to see if the AssociatedRuleList property is set.
        /// </summary>
        internal bool IsSetAssociatedRuleList() => this.AssociatedRuleList != null && (this.AssociatedRuleList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirewallType. 
        /// <para>
        /// The firewall type associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TemplateFirewallType FirewallType { get; set; }

        /// <summary>
        /// Checks to see if the FirewallType property is set.
        /// </summary>
        internal bool IsSetFirewallType() => this.FirewallType != null;

        /// <summary>
        /// Gets and sets the property HasPublishedVersion. 
        /// <para>
        /// Specifies whether a published version of the resource exists.
        /// </para>
        /// </summary>
        public bool? HasPublishedVersion { get; set; }

        /// <summary>
        /// Checks to see if the HasPublishedVersion property is set.
        /// </summary>
        internal bool IsSetHasPublishedVersion() => this.HasPublishedVersion.HasValue;

        /// <summary>
        /// Gets and sets the property IsSnapshot. 
        /// <para>
        /// Specifies whether the resource is a snapshot of a published version.
        /// </para>
        /// </summary>
        public bool? IsSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the IsSnapshot property is set.
        /// </summary>
        internal bool IsSetIsSnapshot() => this.IsSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the resource: <c>DRAFT</c> (unpublished, editable) or <c>ACTIVE</c>
        /// (published, in use).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1010)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property TemplateDescription. 
        /// <para>
        /// A description of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// Checks to see if the TemplateDescription property is set.
        /// </summary>
        internal bool IsSetTemplateDescription() => this.TemplateDescription != null;

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The service-generated id of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic concurrency control. Each read and write returns an <c>updateToken</c>.
        /// Provide the most recent value on your next update to detect and prevent conflicting
        /// concurrent modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the snapshot was created.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
