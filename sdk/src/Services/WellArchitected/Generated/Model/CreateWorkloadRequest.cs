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
    /// Container for the parameters to the CreateWorkload operation.
    /// Create a new workload.
    /// 
    ///  
    /// <para>
    /// The owner of a workload can share the workload with other Amazon Web Services accounts,
    /// users, an organization, and organizational units (OUs) in the same Amazon Web Services
    /// Region. Only the owner of a workload can delete it.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/define-workload.html">Defining
    /// a Workload</a> in the <i>Well-Architected Tool User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// Either <c>AwsRegions</c>, <c>NonAwsRegions</c>, or both must be specified when creating
    /// a workload.
    /// </para>
    ///  
    /// <para>
    /// You also must specify <c>ReviewOwner</c>, even though the parameter is listed as not
    /// being required in the following section. 
    /// </para>
    ///  </important> 
    /// <para>
    /// When creating a workload using a review template, you must have the following IAM
    /// permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>wellarchitected:GetReviewTemplate</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>wellarchitected:GetReviewTemplateAnswer</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>wellarchitected:ListReviewTemplateAnswers</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>wellarchitected:GetReviewTemplateLensReview</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateWorkloadRequest : AmazonWellArchitectedRequest
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _applications = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _architecturalDesign;
        private List<string> _awsRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientRequestToken;
        private string _description;
        private WorkloadDiscoveryConfig _discoveryConfig;
        private WorkloadEnvironment _environment;
        private string _industry;
        private string _industryType;
        private WorkloadJiraConfigurationInput _jiraConfiguration;
        private List<string> _lenses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _nonAwsRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _notes;
        private List<string> _pillarPriorities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _profileArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _reviewOwner;
        private List<string> _reviewTemplateArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _workloadName;

        /// <summary>
        /// Gets and sets the property AccountIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// List of AppRegistry application ARNs associated to the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && (this._applications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ArchitecturalDesign.
        /// </summary>
        [AWSProperty(Max=2048)]
        public string ArchitecturalDesign
        {
            get { return this._architecturalDesign; }
            set { this._architecturalDesign = value; }
        }

        // Check to see if ArchitecturalDesign property is set
        internal bool IsSetArchitecturalDesign()
        {
            return this._architecturalDesign != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRegions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> AwsRegions
        {
            get { return this._awsRegions; }
            set { this._awsRegions = value; }
        }

        // Check to see if AwsRegions property is set
        internal bool IsSetAwsRegions()
        {
            return this._awsRegions != null && (this._awsRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=250)]
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
        /// Gets and sets the property DiscoveryConfig. 
        /// <para>
        /// Well-Architected discovery configuration settings associated to the workload.
        /// </para>
        /// </summary>
        public WorkloadDiscoveryConfig DiscoveryConfig
        {
            get { return this._discoveryConfig; }
            set { this._discoveryConfig = value; }
        }

        // Check to see if DiscoveryConfig property is set
        internal bool IsSetDiscoveryConfig()
        {
            return this._discoveryConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Environment.
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkloadEnvironment Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property Industry.
        /// </summary>
        [AWSProperty(Max=100)]
        public string Industry
        {
            get { return this._industry; }
            set { this._industry = value; }
        }

        // Check to see if Industry property is set
        internal bool IsSetIndustry()
        {
            return this._industry != null;
        }

        /// <summary>
        /// Gets and sets the property IndustryType.
        /// </summary>
        [AWSProperty(Max=100)]
        public string IndustryType
        {
            get { return this._industryType; }
            set { this._industryType = value; }
        }

        // Check to see if IndustryType property is set
        internal bool IsSetIndustryType()
        {
            return this._industryType != null;
        }

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Jira configuration settings when creating a workload.
        /// </para>
        /// </summary>
        public WorkloadJiraConfigurationInput JiraConfiguration
        {
            get { return this._jiraConfiguration; }
            set { this._jiraConfiguration = value; }
        }

        // Check to see if JiraConfiguration property is set
        internal bool IsSetJiraConfiguration()
        {
            return this._jiraConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Lenses.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Lenses
        {
            get { return this._lenses; }
            set { this._lenses = value; }
        }

        // Check to see if Lenses property is set
        internal bool IsSetLenses()
        {
            return this._lenses != null && (this._lenses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NonAwsRegions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> NonAwsRegions
        {
            get { return this._nonAwsRegions; }
            set { this._nonAwsRegions = value; }
        }

        // Check to see if NonAwsRegions property is set
        internal bool IsSetNonAwsRegions()
        {
            return this._nonAwsRegions != null && (this._nonAwsRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Notes.
        /// </summary>
        [AWSProperty(Max=2084)]
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
        /// Gets and sets the property PillarPriorities.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PillarPriorities
        {
            get { return this._pillarPriorities; }
            set { this._pillarPriorities = value; }
        }

        // Check to see if PillarPriorities property is set
        internal bool IsSetPillarPriorities()
        {
            return this._pillarPriorities != null && (this._pillarPriorities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProfileArns. 
        /// <para>
        /// The list of profile ARNs associated with the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> ProfileArns
        {
            get { return this._profileArns; }
            set { this._profileArns = value; }
        }

        // Check to see if ProfileArns property is set
        internal bool IsSetProfileArns()
        {
            return this._profileArns != null && (this._profileArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReviewOwner.
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string ReviewOwner
        {
            get { return this._reviewOwner; }
            set { this._reviewOwner = value; }
        }

        // Check to see if ReviewOwner property is set
        internal bool IsSetReviewOwner()
        {
            return this._reviewOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewTemplateArns. 
        /// <para>
        /// The list of review template ARNs to associate with the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> ReviewTemplateArns
        {
            get { return this._reviewTemplateArns; }
            set { this._reviewTemplateArns = value; }
        }

        // Check to see if ReviewTemplateArns property is set
        internal bool IsSetReviewTemplateArns()
        {
            return this._reviewTemplateArns != null && (this._reviewTemplateArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be associated with the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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

        /// <summary>
        /// Gets and sets the property WorkloadName.
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=100)]
        public string WorkloadName
        {
            get { return this._workloadName; }
            set { this._workloadName = value; }
        }

        // Check to see if WorkloadName property is set
        internal bool IsSetWorkloadName()
        {
            return this._workloadName != null;
        }

    }
}