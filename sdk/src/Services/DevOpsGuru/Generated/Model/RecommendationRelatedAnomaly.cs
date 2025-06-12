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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about an anomaly that is related to a recommendation.
    /// </summary>
    public partial class RecommendationRelatedAnomaly
    {
        private string _anomalyId;
        private List<RecommendationRelatedAnomalyResource> _resources = AWSConfigs.InitializeCollections ? new List<RecommendationRelatedAnomalyResource>() : null;
        private List<RecommendationRelatedAnomalySourceDetail> _sourceDetails = AWSConfigs.InitializeCollections ? new List<RecommendationRelatedAnomalySourceDetail>() : null;

        /// <summary>
        /// Gets and sets the property AnomalyId. 
        /// <para>
        /// The ID of an anomaly that generated the insight with this recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AnomalyId
        {
            get { return this._anomalyId; }
            set { this._anomalyId = value; }
        }

        // Check to see if AnomalyId property is set
        internal bool IsSetAnomalyId()
        {
            return this._anomalyId != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        ///  An array of objects that represent resources in which DevOps Guru detected anomalous
        /// behavior. Each object contains the name and type of the resource. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendationRelatedAnomalyResource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceDetails. 
        /// <para>
        ///  Information about where the anomalous behavior related the recommendation was found.
        /// For example, details in Amazon CloudWatch metrics. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendationRelatedAnomalySourceDetail> SourceDetails
        {
            get { return this._sourceDetails; }
            set { this._sourceDetails = value; }
        }

        // Check to see if SourceDetails property is set
        internal bool IsSetSourceDetails()
        {
            return this._sourceDetails != null && (this._sourceDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}