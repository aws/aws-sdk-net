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
    /// This is the response object from the GetAnnotationStoreVersion operation.
    /// </summary>
    public partial class GetAnnotationStoreVersionResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _description;
        private string _id;
        private string _name;
        private VersionStatus _status;
        private string _statusMessage;
        private string _storeId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updateTime;
        private string _versionArn;
        private string _versionName;
        private VersionOptions _versionOptions;
        private long? _versionSizeBytes;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time stamp for when an annotation store version was created. 
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
        ///  The description for an annotation store version. 
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
        ///  The annotation store version ID. 
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
        ///  The name of the annotation store. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of an annotation store version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VersionStatus Status
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
        ///  The status of an annotation store version. 
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
        /// Gets and sets the property StoreId. 
        /// <para>
        ///  The store ID for annotation store version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StoreId
        {
            get { return this._storeId; }
            set { this._storeId = value; }
        }

        // Check to see if StoreId property is set
        internal bool IsSetStoreId()
        {
            return this._storeId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  Any tags associated with an annotation store version. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  The time stamp for when an annotation store version was updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property VersionArn. 
        /// <para>
        ///  The Arn for the annotation store. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string VersionArn
        {
            get { return this._versionArn; }
            set { this._versionArn = value; }
        }

        // Check to see if VersionArn property is set
        internal bool IsSetVersionArn()
        {
            return this._versionArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        ///  The name given to an annotation store version to distinguish it from others. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionOptions. 
        /// <para>
        ///  The options for an annotation store version. 
        /// </para>
        /// </summary>
        public VersionOptions VersionOptions
        {
            get { return this._versionOptions; }
            set { this._versionOptions = value; }
        }

        // Check to see if VersionOptions property is set
        internal bool IsSetVersionOptions()
        {
            return this._versionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VersionSizeBytes. 
        /// <para>
        ///  The size of the annotation store version in Bytes. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? VersionSizeBytes
        {
            get { return this._versionSizeBytes; }
            set { this._versionSizeBytes = value; }
        }

        // Check to see if VersionSizeBytes property is set
        internal bool IsSetVersionSizeBytes()
        {
            return this._versionSizeBytes.HasValue; 
        }

    }
}