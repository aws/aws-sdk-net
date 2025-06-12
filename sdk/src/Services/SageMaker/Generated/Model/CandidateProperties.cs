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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The properties of an AutoML candidate job.
    /// </summary>
    public partial class CandidateProperties
    {
        private CandidateArtifactLocations _candidateArtifactLocations;
        private List<MetricDatum> _candidateMetrics = AWSConfigs.InitializeCollections ? new List<MetricDatum>() : null;

        /// <summary>
        /// Gets and sets the property CandidateArtifactLocations. 
        /// <para>
        /// The Amazon S3 prefix to the artifacts generated for an AutoML candidate.
        /// </para>
        /// </summary>
        public CandidateArtifactLocations CandidateArtifactLocations
        {
            get { return this._candidateArtifactLocations; }
            set { this._candidateArtifactLocations = value; }
        }

        // Check to see if CandidateArtifactLocations property is set
        internal bool IsSetCandidateArtifactLocations()
        {
            return this._candidateArtifactLocations != null;
        }

        /// <summary>
        /// Gets and sets the property CandidateMetrics. 
        /// <para>
        /// Information about the candidate metrics for an AutoML job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public List<MetricDatum> CandidateMetrics
        {
            get { return this._candidateMetrics; }
            set { this._candidateMetrics = value; }
        }

        // Check to see if CandidateMetrics property is set
        internal bool IsSetCandidateMetrics()
        {
            return this._candidateMetrics != null && (this._candidateMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}