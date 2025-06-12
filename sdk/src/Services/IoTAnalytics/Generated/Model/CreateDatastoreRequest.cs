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
    /// Container for the parameters to the CreateDatastore operation.
    /// Creates a data store, which is a repository for messages.
    /// </summary>
    public partial class CreateDatastoreRequest : AmazonIoTAnalyticsRequest
    {
        private string _datastoreName;
        private DatastorePartitions _datastorePartitions;
        private DatastoreStorage _datastoreStorage;
        private FileFormatConfiguration _fileFormatConfiguration;
        private RetentionPeriod _retentionPeriod;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The name of the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Where data in a data store is stored.. You can choose <c>serviceManagedS3</c> storage,
        /// <c>customerManagedS3</c> storage, or <c>iotSiteWiseMultiLayerStorage</c> storage.
        /// The default is <c>serviceManagedS3</c>. You can't change the choice of Amazon S3 storage
        /// after your data store is created. 
        /// </para>
        /// </summary>
        public DatastoreStorage DatastoreStorage
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the data store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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