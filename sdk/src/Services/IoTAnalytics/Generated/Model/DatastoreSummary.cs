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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// A summary of information about a data store.
    /// </summary>
    public partial class DatastoreSummary
    {
        private DateTime? _creationTime;
        private string _datastoreName;
        private DatastorePartitions _datastorePartitions;
        private DatastoreStorageSummary _datastoreStorage;
        private FileFormatType _fileFormatType;
        private DateTime? _lastMessageArrivalTime;
        private DateTime? _lastUpdateTime;
        private DatastoreStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the data store was created.
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
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The name of the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DatastoreName
        {
            get { return this._datastoreName; }
            set { this._datastoreName = value; }
        }

        // Check to see if DatastoreName property is set
        internal bool IsSetDatastoreName()
        {
            return this._datastoreName != null;
        }

        /// <summary>
        /// Gets and sets the property DatastorePartitions. 
        /// <para>
        ///  Contains information about the partition dimensions in a data store. 
        /// </para>
        /// </summary>
        public DatastorePartitions DatastorePartitions
        {
            get { return this._datastorePartitions; }
            set { this._datastorePartitions = value; }
        }

        // Check to see if DatastorePartitions property is set
        internal bool IsSetDatastorePartitions()
        {
            return this._datastorePartitions != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreStorage. 
        /// <para>
        /// Where data in a data store is stored.
        /// </para>
        /// </summary>
        public DatastoreStorageSummary DatastoreStorage
        {
            get { return this._datastoreStorage; }
            set { this._datastoreStorage = value; }
        }

        // Check to see if DatastoreStorage property is set
        internal bool IsSetDatastoreStorage()
        {
            return this._datastoreStorage != null;
        }

        /// <summary>
        /// Gets and sets the property FileFormatType. 
        /// <para>
        /// The file format of the data in the data store.
        /// </para>
        /// </summary>
        public FileFormatType FileFormatType
        {
            get { return this._fileFormatType; }
            set { this._fileFormatType = value; }
        }

        // Check to see if FileFormatType property is set
        internal bool IsSetFileFormatType()
        {
            return this._fileFormatType != null;
        }

        /// <summary>
        /// Gets and sets the property LastMessageArrivalTime. 
        /// <para>
        /// The last time when a new message arrived in the data store.
        /// </para>
        ///  
        /// <para>
        /// IoT Analytics updates this value at most once per minute for Amazon Simple Storage
        /// Service one data store. Hence, the <c>lastMessageArrivalTime</c> value is an approximation.
        /// </para>
        ///  
        /// <para>
        /// This feature only applies to messages that arrived in the data store after October
        /// 23, 2020. 
        /// </para>
        /// </summary>
        public DateTime? LastMessageArrivalTime
        {
            get { return this._lastMessageArrivalTime; }
            set { this._lastMessageArrivalTime = value; }
        }

        // Check to see if LastMessageArrivalTime property is set
        internal bool IsSetLastMessageArrivalTime()
        {
            return this._lastMessageArrivalTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last time the data store was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the data store.
        /// </para>
        /// </summary>
        public DatastoreStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}