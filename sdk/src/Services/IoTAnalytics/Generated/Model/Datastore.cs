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
    /// Information about a data store.
    /// </summary>
    public partial class Datastore
    {
        private string _arn;
        private DateTime? _creationTime;
        private DatastorePartitions _datastorePartitions;
        private FileFormatConfiguration _fileFormatConfiguration;
        private DateTime? _lastMessageArrivalTime;
        private DateTime? _lastUpdateTime;
        private string _name;
        private RetentionPeriod _retentionPeriod;
        private DatastoreStatus _status;
        private DatastoreStorage _storage;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the data store.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FileFormatConfiguration. 
        /// <para>
        /// Contains the configuration information of file formats. IoT Analytics data stores
        /// support JSON and <a href="https://parquet.apache.org/">Parquet</a>.
        /// </para>
        ///  
        /// <para>
        /// The default file format is JSON. You can specify only one format.
        /// </para>
        ///  
        /// <para>
        /// You can't change the file format after you create the data store.
        /// </para>
        /// </summary>
        public FileFormatConfiguration FileFormatConfiguration
        {
            get { return this._fileFormatConfiguration; }
            set { this._fileFormatConfiguration = value; }
        }

        // Check to see if FileFormatConfiguration property is set
        internal bool IsSetFileFormatConfiguration()
        {
            return this._fileFormatConfiguration != null;
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// How long, in days, message data is kept for the data store. When <c>customerManagedS3</c>
        /// storage is selected, this parameter is ignored.
        /// </para>
        /// </summary>
        public RetentionPeriod RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a data store:
        /// </para>
        ///  <dl> <dt>CREATING</dt> <dd> 
        /// <para>
        /// The data store is being created.
        /// </para>
        ///  </dd> <dt>ACTIVE</dt> <dd> 
        /// <para>
        /// The data store has been created and can be used.
        /// </para>
        ///  </dd> <dt>DELETING</dt> <dd> 
        /// <para>
        /// The data store is being deleted.
        /// </para>
        ///  </dd> </dl>
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

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// Where data in a data store is stored.. You can choose <c>serviceManagedS3</c> storage,
        /// <c>customerManagedS3</c> storage, or <c>iotSiteWiseMultiLayerStorage</c> storage.
        /// The default is <c>serviceManagedS3</c>. You can't change the choice of Amazon S3 storage
        /// after your data store is created. 
        /// </para>
        /// </summary>
        public DatastoreStorage Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null;
        }

    }
}