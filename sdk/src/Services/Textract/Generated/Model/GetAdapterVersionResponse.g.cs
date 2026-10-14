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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// This is the response object from the GetAdapterVersion operation.
    /// </summary>
    public partial class GetAdapterVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A string containing a unique ID for the adapter version being retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 1011)]
        public string AdapterId { get; set; }

        /// <summary>
        /// Checks to see if the AdapterId property is set.
        /// </summary>
        internal bool IsSetAdapterId() => this.AdapterId != null;

        /// <summary>
        /// Gets and sets the property AdapterVersion. 
        /// <para>
        /// A string containing the adapter version that has been retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AdapterVersion { get; set; }

        /// <summary>
        /// Checks to see if the AdapterVersion property is set.
        /// </summary>
        internal bool IsSetAdapterVersion() => this.AdapterVersion != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the adapter version was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetConfig. 
        /// <para>
        /// Specifies a dataset used to train a new adapter version. Takes a ManifestS3Objec as
        /// the value.
        /// </para>
        /// </summary>
        public AdapterVersionDatasetConfig DatasetConfig { get; set; }

        /// <summary>
        /// Checks to see if the DatasetConfig property is set.
        /// </summary>
        internal bool IsSetDatasetConfig() => this.DatasetConfig != null;

        /// <summary>
        /// Gets and sets the property EvaluationMetrics. 
        /// <para>
        /// The evaluation metrics (F1 score, Precision, and Recall) for the requested version,
        /// grouped by baseline metrics and adapter version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdapterVersionEvaluationMetric> EvaluationMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<AdapterVersionEvaluationMetric>() : null;

        /// <summary>
        /// Checks to see if the EvaluationMetrics property is set.
        /// </summary>
        internal bool IsSetEvaluationMetrics() => this.EvaluationMetrics != null && (this.EvaluationMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// List of the targeted feature types for the requested adapter version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FeatureTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FeatureTypes property is set.
        /// </summary>
        internal bool IsSetFeatureTypes() => this.FeatureTypes != null && (this.FeatureTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The identifier for your AWS Key Management Service key (AWS KMS key). Used to encrypt
        /// your documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyId property is set.
        /// </summary>
        internal bool IsSetKMSKeyId() => this.KMSKeyId != null;

        /// <summary>
        /// Gets and sets the property OutputConfig.
        /// </summary>
        public OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the adapter version that has been requested.
        /// </para>
        /// </summary>
        public AdapterVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that describes the status of the requested adapter version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags (key-value pairs) that are associated with the adapter version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
