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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Holds persistent application user interface information. Applications installed on
    /// the Amazon EMR cluster publish user interfaces as web sites to monitor cluster activity.
    /// </summary>
    public partial class PersistentAppUI
    {
        private string _authorId;
        private DateTime? _creationTime;
        private DateTime? _lastModifiedTime;
        private string _lastStateChangeReason;
        private string _persistentAppUIId;
        private string _persistentAppUIStatus;
        private List<string> _persistentAppUITypeList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AuthorId. 
        /// <para>
        /// The author ID for the persistent application user interface object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string AuthorId
        {
            get { return this._authorId; }
            set { this._authorId = value; }
        }

        // Check to see if AuthorId property is set
        internal bool IsSetAuthorId()
        {
            return this._authorId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation date and time for the persistent application user interface object.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the persistent application user interface object was last changed.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastStateChangeReason. 
        /// <para>
        /// The reason the persistent application user interface object was last changed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string LastStateChangeReason
        {
            get { return this._lastStateChangeReason; }
            set { this._lastStateChangeReason = value; }
        }

        // Check to see if LastStateChangeReason property is set
        internal bool IsSetLastStateChangeReason()
        {
            return this._lastStateChangeReason != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentAppUIId. 
        /// <para>
        /// The identifier for the persistent application user interface object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string PersistentAppUIId
        {
            get { return this._persistentAppUIId; }
            set { this._persistentAppUIId = value; }
        }

        // Check to see if PersistentAppUIId property is set
        internal bool IsSetPersistentAppUIId()
        {
            return this._persistentAppUIId != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentAppUIStatus. 
        /// <para>
        /// The status for the persistent application user interface object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string PersistentAppUIStatus
        {
            get { return this._persistentAppUIStatus; }
            set { this._persistentAppUIStatus = value; }
        }

        // Check to see if PersistentAppUIStatus property is set
        internal bool IsSetPersistentAppUIStatus()
        {
            return this._persistentAppUIStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentAppUITypeList. 
        /// <para>
        /// The type list for the persistent application user interface object. Valid values include
        /// SHS, YTS, or TEZ.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PersistentAppUITypeList
        {
            get { return this._persistentAppUITypeList; }
            set { this._persistentAppUITypeList = value; }
        }

        // Check to see if PersistentAppUITypeList property is set
        internal bool IsSetPersistentAppUITypeList()
        {
            return this._persistentAppUITypeList != null && (this._persistentAppUITypeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of tags for the persistent application user interface object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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