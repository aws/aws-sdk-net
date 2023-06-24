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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the GetAnnotationStore operation.
    /// </summary>
    public partial class GetAnnotationStoreResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _description;
        private string _id;
        private string _name;
        private ReferenceItem _reference;
        private SseConfig _sseConfig;
        private StoreStatus _status;
        private string _statusMessage;
        private string _storeArn;
        private StoreFormat _storeFormat;
        private StoreOptions _storeOptions;
        private long? _storeSizeBytes;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the store was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The store's description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
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
        /// The store's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The store's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Reference. 
        /// <para>
        /// The store's genome reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReferenceItem Reference
        {
            get { return this._reference; }
            set { this._reference = value; }
        }

        // Check to see if Reference property is set
        internal bool IsSetReference()
        {
            return this._reference != null;
        }

        /// <summary>
        /// Gets and sets the property SseConfig. 
        /// <para>
        /// The store's server-side encryption (SSE) settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SseConfig SseConfig
        {
            get { return this._sseConfig; }
            set { this._sseConfig = value; }
        }

        // Check to see if SseConfig property is set
        internal bool IsSetSseConfig()
        {
            return this._sseConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The store's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StoreStatus Status
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
        /// A status message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
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
        /// Gets and sets the property StoreArn. 
        /// <para>
        /// The store's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string StoreArn
        {
            get { return this._storeArn; }
            set { this._storeArn = value; }
        }

        // Check to see if StoreArn property is set
        internal bool IsSetStoreArn()
        {
            return this._storeArn != null;
        }

        /// <summary>
        /// Gets and sets the property StoreFormat. 
        /// <para>
        /// The store's annotation file format.
        /// </para>
        /// </summary>
        public StoreFormat StoreFormat
        {
            get { return this._storeFormat; }
            set { this._storeFormat = value; }
        }

        // Check to see if StoreFormat property is set
        internal bool IsSetStoreFormat()
        {
            return this._storeFormat != null;
        }

        /// <summary>
        /// Gets and sets the property StoreOptions. 
        /// <para>
        /// The store's parsing options.
        /// </para>
        /// </summary>
        public StoreOptions StoreOptions
        {
            get { return this._storeOptions; }
            set { this._storeOptions = value; }
        }

        // Check to see if StoreOptions property is set
        internal bool IsSetStoreOptions()
        {
            return this._storeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property StoreSizeBytes. 
        /// <para>
        /// The store's size in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long StoreSizeBytes
        {
            get { return this._storeSizeBytes.GetValueOrDefault(); }
            set { this._storeSizeBytes = value; }
        }

        // Check to see if StoreSizeBytes property is set
        internal bool IsSetStoreSizeBytes()
        {
            return this._storeSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The store's tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// When the store was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}