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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the GetSequenceStore operation.
    /// </summary>
    public partial class GetSequenceStoreResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _description;
        private ETagAlgorithmFamily _eTagAlgorithmFamily;
        private string _fallbackLocation;
        private string _id;
        private string _name;
        private List<string> _propagatedSetLevelTags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SequenceStoreS3Access _s3Access;
        private SseConfig _sseConfig;
        private SequenceStoreStatus _status;
        private string _statusMessage;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The store's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the store was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The store's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ETagAlgorithmFamily. 
        /// <para>
        /// The algorithm family of the ETag.
        /// </para>
        /// </summary>
        public ETagAlgorithmFamily ETagAlgorithmFamily
        {
            get { return this._eTagAlgorithmFamily; }
            set { this._eTagAlgorithmFamily = value; }
        }

        // Check to see if ETagAlgorithmFamily property is set
        internal bool IsSetETagAlgorithmFamily()
        {
            return this._eTagAlgorithmFamily != null;
        }

        /// <summary>
        /// Gets and sets the property FallbackLocation. 
        /// <para>
        /// An S3 location that is used to store files that have failed a direct upload.
        /// </para>
        /// </summary>
        public string FallbackLocation
        {
            get { return this._fallbackLocation; }
            set { this._fallbackLocation = value; }
        }

        // Check to see if FallbackLocation property is set
        internal bool IsSetFallbackLocation()
        {
            return this._fallbackLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The store's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
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
        [AWSProperty(Min=1, Max=127)]
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
        /// Gets and sets the property PropagatedSetLevelTags. 
        /// <para>
        /// The tags keys to propagate to the S3 objects associated with read sets in the sequence
        /// store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> PropagatedSetLevelTags
        {
            get { return this._propagatedSetLevelTags; }
            set { this._propagatedSetLevelTags = value; }
        }

        // Check to see if PropagatedSetLevelTags property is set
        internal bool IsSetPropagatedSetLevelTags()
        {
            return this._propagatedSetLevelTags != null && (this._propagatedSetLevelTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3Access. 
        /// <para>
        /// The S3 metadata of a sequence store, including the ARN and S3 URI of the S3 bucket.
        /// </para>
        /// </summary>
        public SequenceStoreS3Access S3Access
        {
            get { return this._s3Access; }
            set { this._s3Access = value; }
        }

        // Check to see if S3Access property is set
        internal bool IsSetS3Access()
        {
            return this._s3Access != null;
        }

        /// <summary>
        /// Gets and sets the property SseConfig. 
        /// <para>
        /// The store's server-side encryption (SSE) settings.
        /// </para>
        /// </summary>
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
        /// The status of the sequence store.
        /// </para>
        /// </summary>
        public SequenceStoreStatus Status
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
        /// The status message of the sequence store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The last-updated time of the sequence store.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}