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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Defines a data set.
    /// </summary>
    public partial class DataSet
    {
        private string _datasetName;
        private DatasetOrgAttributes _datasetOrg;
        private RecordLength _recordLength;
        private string _relativePath;
        private string _storageType;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The logical identifier for a specific data set (in mainframe format).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetOrg. 
        /// <para>
        /// The type of dataset. The only supported value is VSAM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetOrgAttributes DatasetOrg
        {
            get { return this._datasetOrg; }
            set { this._datasetOrg = value; }
        }

        // Check to see if DatasetOrg property is set
        internal bool IsSetDatasetOrg()
        {
            return this._datasetOrg != null;
        }

        /// <summary>
        /// Gets and sets the property RecordLength. 
        /// <para>
        /// The length of a record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordLength RecordLength
        {
            get { return this._recordLength; }
            set { this._recordLength = value; }
        }

        // Check to see if RecordLength property is set
        internal bool IsSetRecordLength()
        {
            return this._recordLength != null;
        }

        /// <summary>
        /// Gets and sets the property RelativePath. 
        /// <para>
        /// The relative location of the data set in the database or file system. 
        /// </para>
        /// </summary>
        public string RelativePath
        {
            get { return this._relativePath; }
            set { this._relativePath = value; }
        }

        // Check to see if RelativePath property is set
        internal bool IsSetRelativePath()
        {
            return this._relativePath != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type of the data set: database or file system. For Micro Focus, database
        /// corresponds to datastore and file system corresponds to EFS/FSX. For Blu Age, there
        /// is no support of file system and database corresponds to Blusam. 
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}