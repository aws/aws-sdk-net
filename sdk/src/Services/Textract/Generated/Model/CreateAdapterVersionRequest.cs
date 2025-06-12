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
    /// Container for the parameters to the CreateAdapterVersion operation.
    /// Creates a new version of an adapter. Operates on a provided AdapterId and a specified
    /// dataset provided via the DatasetConfig argument. Requires that you specify an Amazon
    /// S3 bucket with the OutputConfig argument. You can provide an optional KMSKeyId, an
    /// optional ClientRequestToken, and optional tags.
    /// </summary>
    public partial class CreateAdapterVersionRequest : AmazonTextractRequest
    {
        private string _adapterId;
        private string _clientRequestToken;
        private AdapterVersionDatasetConfig _datasetConfig;
        private string _kmsKeyId;
        private OutputConfig _outputConfig;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A string containing a unique ID for the adapter that will receive a new version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=1011)]
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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotent token is used to recognize the request. If the same token is used with
        /// multiple CreateAdapterVersion requests, the same session is returned. This token is
        /// employed to avoid unintentionally creating the same session multiple times.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property DatasetConfig. 
        /// <para>
        /// Specifies a dataset used to train a new adapter version. Takes a ManifestS3Object
        /// as the value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags (key-value pairs) that you want to attach to the adapter version. 
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