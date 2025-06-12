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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// A check that provides recommendations to remedy potential upgrade-impacting issues.
    /// </summary>
    public partial class Insight
    {
        private Dictionary<string, string> _additionalInfo = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Category _category;
        private InsightCategorySpecificSummary _categorySpecificSummary;
        private string _description;
        private string _id;
        private InsightStatus _insightStatus;
        private string _kubernetesVersion;
        private DateTime? _lastRefreshTime;
        private DateTime? _lastTransitionTime;
        private string _name;
        private string _recommendation;
        private List<InsightResourceDetail> _resources = AWSConfigs.InitializeCollections ? new List<InsightResourceDetail>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Links to sources that provide additional context on the insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null && (this._additionalInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the insight.
        /// </para>
        /// </summary>
        public Category Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CategorySpecificSummary. 
        /// <para>
        /// Summary information that relates to the category of the insight. Currently only returned
        /// with certain insights having category <c>UPGRADE_READINESS</c>.
        /// </para>
        /// </summary>
        public InsightCategorySpecificSummary CategorySpecificSummary
        {
            get { return this._categorySpecificSummary; }
            set { this._categorySpecificSummary = value; }
        }

        // Check to see if CategorySpecificSummary property is set
        internal bool IsSetCategorySpecificSummary()
        {
            return this._categorySpecificSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the insight which includes alert criteria, remediation recommendation,
        /// and additional resources (contains Markdown).
        /// </para>
        /// </summary>
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
        /// The ID of the insight.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InsightStatus. 
        /// <para>
        /// An object containing more detail on the status of the insight resource.
        /// </para>
        /// </summary>
        public InsightStatus InsightStatus
        {
            get { return this._insightStatus; }
            set { this._insightStatus = value; }
        }

        // Check to see if InsightStatus property is set
        internal bool IsSetInsightStatus()
        {
            return this._insightStatus != null;
        }

        /// <summary>
        /// Gets and sets the property KubernetesVersion. 
        /// <para>
        /// The Kubernetes minor version associated with an insight if applicable.
        /// </para>
        /// </summary>
        public string KubernetesVersion
        {
            get { return this._kubernetesVersion; }
            set { this._kubernetesVersion = value; }
        }

        // Check to see if KubernetesVersion property is set
        internal bool IsSetKubernetesVersion()
        {
            return this._kubernetesVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LastRefreshTime. 
        /// <para>
        /// The time Amazon EKS last successfully completed a refresh of this insight check on
        /// the cluster.
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTime
        {
            get { return this._lastRefreshTime; }
            set { this._lastRefreshTime = value; }
        }

        // Check to see if LastRefreshTime property is set
        internal bool IsSetLastRefreshTime()
        {
            return this._lastRefreshTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastTransitionTime. 
        /// <para>
        /// The time the status of the insight last changed.
        /// </para>
        /// </summary>
        public DateTime? LastTransitionTime
        {
            get { return this._lastTransitionTime; }
            set { this._lastTransitionTime = value; }
        }

        // Check to see if LastTransitionTime property is set
        internal bool IsSetLastTransitionTime()
        {
            return this._lastTransitionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the insight.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// A summary of how to remediate the finding of this insight if applicable. 
        /// </para>
        /// </summary>
        public string Recommendation
        {
            get { return this._recommendation; }
            set { this._recommendation = value; }
        }

        // Check to see if Recommendation property is set
        internal bool IsSetRecommendation()
        {
            return this._recommendation != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The details about each resource listed in the insight check result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsightResourceDetail> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}