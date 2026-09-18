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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWorkload operation. Create a new workload.
    /// <para> The owner of a workload can share the workload with other Amazon Web Services
    /// accounts, users, an organization, and organizational units (OUs) in the same Amazon
    /// Web Services Region. Only the owner of a workload can delete it. </para> <para> For
    /// more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/define-workload.html">Defining
    /// a Workload</a> in the <i>Well-Architected Tool User Guide</i>. </para> <important>
    /// <para> Either <c>AwsRegions</c>, <c>NonAwsRegions</c>, or both must be specified when
    /// creating a workload. </para> <para> You also must specify <c>ReviewOwner</c>, even
    /// though the parameter is listed as not being required in the following section. </para>
    /// </important> <para> When creating a workload using a review template, you must have
    /// the following IAM permissions: </para> <ul> <li> <para> <c>wellarchitected:GetReviewTemplate</c>
    /// </para> </li> <li> <para> <c>wellarchitected:GetReviewTemplateAnswer</c> </para> </li>
    /// <li> <para> <c>wellarchitected:ListReviewTemplateAnswers</c> </para> </li> <li> <para>
    /// <c>wellarchitected:GetReviewTemplateLensReview</c> </para> </li> </ul>
    /// </summary>
    public partial class CreateWorkloadRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property AccountIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// List of AppRegistry application ARNs associated to the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> Applications { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Applications property is set.
        /// </summary>
        internal bool IsSetApplications() => this.Applications != null && (this.Applications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ArchitecturalDesign.
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string ArchitecturalDesign { get; set; }

        /// <summary>
        /// Checks to see if the ArchitecturalDesign property is set.
        /// </summary>
        internal bool IsSetArchitecturalDesign() => this.ArchitecturalDesign != null;

        /// <summary>
        /// Gets and sets the property AwsRegions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> AwsRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsRegions property is set.
        /// </summary>
        internal bool IsSetAwsRegions() => this.AwsRegions != null && (this.AwsRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DiscoveryConfig. 
        /// <para>
        /// Well-Architected discovery configuration settings associated to the workload.
        /// </para>
        /// </summary>
        public WorkloadDiscoveryConfig DiscoveryConfig { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryConfig property is set.
        /// </summary>
        internal bool IsSetDiscoveryConfig() => this.DiscoveryConfig != null;

        /// <summary>
        /// Gets and sets the property Environment.
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkloadEnvironment Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property Industry.
        /// </summary>
        [AWSProperty(Max = 100)]
        public string Industry { get; set; }

        /// <summary>
        /// Checks to see if the Industry property is set.
        /// </summary>
        internal bool IsSetIndustry() => this.Industry != null;

        /// <summary>
        /// Gets and sets the property IndustryType.
        /// </summary>
        [AWSProperty(Max = 100)]
        public string IndustryType { get; set; }

        /// <summary>
        /// Checks to see if the IndustryType property is set.
        /// </summary>
        internal bool IsSetIndustryType() => this.IndustryType != null;

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Jira configuration settings when creating a workload.
        /// </para>
        /// </summary>
        public WorkloadJiraConfigurationInput JiraConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the JiraConfiguration property is set.
        /// </summary>
        internal bool IsSetJiraConfiguration() => this.JiraConfiguration != null;

        /// <summary>
        /// Gets and sets the property Lenses.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Lenses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Lenses property is set.
        /// </summary>
        internal bool IsSetLenses() => this.Lenses != null && (this.Lenses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NonAwsRegions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<string> NonAwsRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NonAwsRegions property is set.
        /// </summary>
        internal bool IsSetNonAwsRegions() => this.NonAwsRegions != null && (this.NonAwsRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Notes.
        /// </summary>
        [AWSProperty(Max = 2084)]
        public string Notes { get; set; }

        /// <summary>
        /// Checks to see if the Notes property is set.
        /// </summary>
        internal bool IsSetNotes() => this.Notes != null;

        /// <summary>
        /// Gets and sets the property PillarPriorities.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PillarPriorities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PillarPriorities property is set.
        /// </summary>
        internal bool IsSetPillarPriorities() => this.PillarPriorities != null && (this.PillarPriorities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProfileArns. 
        /// <para>
        /// The list of profile ARNs associated with the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> ProfileArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProfileArns property is set.
        /// </summary>
        internal bool IsSetProfileArns() => this.ProfileArns != null && (this.ProfileArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReviewOwner.
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string ReviewOwner { get; set; }

        /// <summary>
        /// Checks to see if the ReviewOwner property is set.
        /// </summary>
        internal bool IsSetReviewOwner() => this.ReviewOwner != null;

        /// <summary>
        /// Gets and sets the property ReviewTemplateArns. 
        /// <para>
        /// The list of review template ARNs to associate with the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> ReviewTemplateArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReviewTemplateArns property is set.
        /// </summary>
        internal bool IsSetReviewTemplateArns() => this.ReviewTemplateArns != null && (this.ReviewTemplateArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be associated with the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkloadName.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 100)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;
    }
}
