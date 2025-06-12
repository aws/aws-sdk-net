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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
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
namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Container for the parameters to the StartImportJob operation.
    /// Start an asynchronous job to import Wisdom resources from an uploaded source file.
    /// Before calling this API, use <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>
    /// to upload an asset that contains the resource data.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For importing Wisdom quick responses, you need to upload a csv file including the
    /// quick responses. For information about how to format the csv file for importing quick
    /// responses, see <a href="https://docs.aws.amazon.com/console/connect/quick-responses/add-data">Import
    /// quick responses</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartImportJobRequest : AmazonConnectWisdomServiceRequest
    {
        private string _clientToken;
        private ExternalSourceConfiguration _externalSourceConfiguration;
        private ImportJobType _importJobType;
        private string _knowledgeBaseId;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalSourceConfiguration. 
        /// <para>
        /// The configuration information of the external source that the resource data are imported
        /// from.
        /// </para>
        /// </summary>
        public ExternalSourceConfiguration ExternalSourceConfiguration
        {
            get { return this._externalSourceConfiguration; }
            set { this._externalSourceConfiguration = value; }
        }

        // Check to see if ExternalSourceConfiguration property is set
        internal bool IsSetExternalSourceConfiguration()
        {
            return this._externalSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImportJobType. 
        /// <para>
        /// The type of the import job.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For importing quick response resource, set the value to <c>QUICK_RESPONSES</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportJobType ImportJobType
        {
            get { return this._importJobType; }
            set { this._importJobType = value; }
        }

        // Check to see if ImportJobType property is set
        internal bool IsSetImportJobType()
        {
            return this._importJobType != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. This should not be a QUICK_RESPONSES type knowledge
        /// base if you're storing Wisdom Content resource to it. Can be either the ID or the
        /// ARN. URLs cannot contain the ARN.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For importing Wisdom quick responses, this should be a <c>QUICK_RESPONSES</c> type
        /// knowledge base.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata fields of the imported Wisdom resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// A pointer to the uploaded asset. This value is returned by <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1200)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

    }
}