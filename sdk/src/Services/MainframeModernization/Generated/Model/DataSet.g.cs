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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Defines a data set.
    /// </summary>
    public partial class DataSet
    {
        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The logical identifier for a specific data set (in mainframe format).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property DatasetOrg. 
        /// <para>
        /// The type of dataset. The only supported value is VSAM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetOrgAttributes DatasetOrg { get; set; }

        /// <summary>
        /// Checks to see if the DatasetOrg property is set.
        /// </summary>
        internal bool IsSetDatasetOrg() => this.DatasetOrg != null;

        /// <summary>
        /// Gets and sets the property RecordLength. 
        /// <para>
        /// The length of a record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecordLength RecordLength { get; set; }

        /// <summary>
        /// Checks to see if the RecordLength property is set.
        /// </summary>
        internal bool IsSetRecordLength() => this.RecordLength != null;

        /// <summary>
        /// Gets and sets the property RelativePath. 
        /// <para>
        /// The relative location of the data set in the database or file system. 
        /// </para>
        /// </summary>
        public string RelativePath { get; set; }

        /// <summary>
        /// Checks to see if the RelativePath property is set.
        /// </summary>
        internal bool IsSetRelativePath() => this.RelativePath != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type of the data set: database or file system. For Micro Focus, database
        /// corresponds to datastore and file system corresponds to EFS/FSX. For Blu Age, there
        /// is no support of file system and database corresponds to Blusam. 
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;
    }
}
