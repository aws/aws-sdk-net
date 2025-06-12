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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// This is the response object from the GetAdapterVersion operation.
    /// </summary>
    public partial class GetAdapterVersionResponse : AmazonWebServiceResponse
    {
        private string _adapterId;
        private string _adapterVersion;
        private DateTime? _creationTime;
        private AdapterVersionDatasetConfig _datasetConfig;
        private List<AdapterVersionEvaluationMetric> _evaluationMetrics = AWSConfigs.InitializeCollections ? new List<AdapterVersionEvaluationMetric>() : null;
        private List<string> _featureTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _kmsKeyId;
        private OutputConfig _outputConfig;
        private AdapterVersionStatus _status;
        private string _statusMessage;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A string containing a unique ID for the adapter version being retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=1011)]
        public string AdapterId
        {
            get { return this._adapterId; }
            set { this._adapterId = value; }
        }

        // Check to see if AdapterId property is set
        internal bool IsSetAdapterId()
        {
            return this._adapterId != null;
        }

        /// <summary>
        /// Gets and sets the property AdapterVersion. 
        /// <para>
        /// A string containing the adapter version that has been retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AdapterVersion
        {
            get { return this._adapterVersion; }
            set { this._adapterVersion = value; }
        }

        // Check to see if AdapterVersion property is set
        internal bool IsSetAdapterVersion()
        {
            return this._adapterVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the adapter version was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetConfig. 
        /// <para>
        /// Specifies a dataset used to train a new adapter version. Takes a ManifestS3Objec as
        /// the value.
        /// </para>
        /// </summary>
        public AdapterVersionDatasetConfig DatasetConfig
        {
            get { return this._datasetConfig; }
            set { this._datasetConfig = value; }
        }

        // Check to see if DatasetConfig property is set
        internal bool IsSetDatasetConfig()
        {
            return this._datasetConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationMetrics. 
        /// <para>
        /// The evaluation metrics (F1 score, Precision, and Recall) for the requested version,
        /// grouped by baseline metrics and adapter version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdapterVersionEvaluationMetric> EvaluationMetrics
        {
            get { return this._evaluationMetrics; }
            set { this._evaluationMetrics = value; }
        }

        // Check to see if EvaluationMetrics property is set
        internal bool IsSetEvaluationMetrics()
        {
            return this._evaluationMetrics != null && (this._evaluationMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// List of the targeted feature types for the requested adapter version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FeatureTypes
        {
            get { return this._featureTypes; }
            set { this._featureTypes = value; }
        }

        // Check to see if FeatureTypes property is set
        internal bool IsSetFeatureTypes()
        {
            return this._featureTypes != null && (this._featureTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The identifier for your AWS Key Management Service key (AWS KMS key). Used to encrypt
        /// your documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KMSKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KMSKeyId property is set
        internal bool IsSetKMSKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig.
        /// </summary>
        public OutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the adapter version that has been requested.
        /// </para>
        /// </summary>
        public AdapterVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that describes the status of the requested adapter version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags (key-value pairs) that are associated with the adapter version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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

    }
}