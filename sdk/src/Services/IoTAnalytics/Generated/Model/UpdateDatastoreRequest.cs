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
    /// Container for the parameters to the UpdateDatastore operation.
    /// Used to update the settings of a data store.
    /// </summary>
    public partial class UpdateDatastoreRequest : AmazonIoTAnalyticsRequest
    {
        private string _datastoreName;
        private DatastoreStorage _datastoreStorage;
        private FileFormatConfiguration _fileFormatConfiguration;
        private RetentionPeriod _retentionPeriod;

        /// <summary>
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The name of the data store to be updated.
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
        /// How long, in days, message data is kept for the data store. The retention period can't
        /// be updated if the data store's Amazon S3 storage is customer-managed.
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

    }
}