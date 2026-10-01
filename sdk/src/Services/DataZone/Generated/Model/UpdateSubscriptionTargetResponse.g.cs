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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the UpdateSubscriptionTarget operation.
    /// </summary>
    public partial class UpdateSubscriptionTargetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicableAssetTypes. 
        /// <para>
        /// The applicable asset types to be updated as part of the <c>UpdateSubscriptionTarget</c>
        /// action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ApplicableAssetTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApplicableAssetTypes property is set.
        /// </summary>
        internal bool IsSetApplicableAssetTypes() => this.ApplicableAssetTypes != null && (this.ApplicableAssetTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorizedPrincipals. 
        /// <para>
        /// The authorized principals to be updated as part of the <c>UpdateSubscriptionTarget</c>
        /// action. Updates are supported in batches of 5 at a time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<string> AuthorizedPrincipals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthorizedPrincipals property is set.
        /// </summary>
        internal bool IsSetAuthorizedPrincipals() => this.AuthorizedPrincipals != null && (this.AuthorizedPrincipals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when a subscription target was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon DataZone user who created the subscription target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which a subscription target is to
        /// be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The identifier of the environment in which a subscription target is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Identifier of the subscription target that is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ManageAccessRole. 
        /// <para>
        /// The manage access role to be updated as part of the <c>UpdateSubscriptionTarget</c>
        /// action.
        /// </para>
        /// </summary>
        public string ManageAccessRole { get; set; }

        /// <summary>
        /// Checks to see if the ManageAccessRole property is set.
        /// </summary>
        internal bool IsSetManageAccessRole() => this.ManageAccessRole != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be updated as part of the <c>UpdateSubscriptionTarget</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The identifier of the project in which a subscription target is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectId property is set.
        /// </summary>
        internal bool IsSetProjectId() => this.ProjectId != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider to be updated as part of the <c>UpdateSubscriptionTarget</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property SubscriptionGrantCreationMode. 
        /// <para>
        ///  Determines the subscription grant creation mode for this target, defining if grants
        /// are auto-created upon subscription approval or managed manually. 
        /// </para>
        /// </summary>
        public SubscriptionGrantCreationMode SubscriptionGrantCreationMode { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionGrantCreationMode property is set.
        /// </summary>
        internal bool IsSetSubscriptionGrantCreationMode() => this.SubscriptionGrantCreationMode != null;

        /// <summary>
        /// Gets and sets the property SubscriptionTargetConfig. 
        /// <para>
        /// The configuration to be updated as part of the <c>UpdateSubscriptionTarget</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<SubscriptionTargetForm> SubscriptionTargetConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<SubscriptionTargetForm>() : null;

        /// <summary>
        /// Checks to see if the SubscriptionTargetConfig property is set.
        /// </summary>
        internal bool IsSetSubscriptionTargetConfig() => this.SubscriptionTargetConfig != null && (this.SubscriptionTargetConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type to be updated as part of the <c>UpdateSubscriptionTarget</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the subscription target was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The Amazon DataZone user who updated the subscription target.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
