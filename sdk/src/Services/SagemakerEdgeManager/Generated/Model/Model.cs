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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
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
namespace Amazon.SagemakerEdgeManager.Model
{
    /// <summary>
    /// Information about a model deployed on an edge device that is registered with SageMaker
    /// Edge Manager.
    /// </summary>
    public partial class Model
    {
        private DateTime? _latestInference;
        private DateTime? _latestSampleTime;
        private List<EdgeMetric> _modelMetrics = AWSConfigs.InitializeCollections ? new List<EdgeMetric>() : null;
        private string _modelName;
        private string _modelVersion;

        /// <summary>
        /// Gets and sets the property LatestInference. 
        /// <para>
        /// The timestamp of the last inference that was made.
        /// </para>
        /// </summary>
        public DateTime? LatestInference
        {
            get { return this._latestInference; }
            set { this._latestInference = value; }
        }

        // Check to see if LatestInference property is set
        internal bool IsSetLatestInference()
        {
            return this._latestInference.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestSampleTime. 
        /// <para>
        /// The timestamp of the last data sample taken.
        /// </para>
        /// </summary>
        public DateTime? LatestSampleTime
        {
            get { return this._latestSampleTime; }
            set { this._latestSampleTime = value; }
        }

        // Check to see if LatestSampleTime property is set
        internal bool IsSetLatestSampleTime()
        {
            return this._latestSampleTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// Information required for model metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeMetric> ModelMetrics
        {
            get { return this._modelMetrics; }
            set { this._modelMetrics = value; }
        }

        // Check to see if ModelMetrics property is set
        internal bool IsSetModelMetrics()
        {
            return this._modelMetrics != null && (this._modelMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=255)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

    }
}