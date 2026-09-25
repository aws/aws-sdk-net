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
    /// This is the response object from the GetDataSetDetails operation.
    /// </summary>
    public partial class GetDataSetDetailsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Blocksize. 
        /// <para>
        /// The size of the block on disk. 
        /// </para>
        /// </summary>
        public int? Blocksize { get; set; }

        /// <summary>
        /// Checks to see if the Blocksize property is set.
        /// </summary>
        internal bool IsSetBlocksize() => this.Blocksize.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the data set was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataSetName. 
        /// <para>
        /// The name of the data set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSetName { get; set; }

        /// <summary>
        /// Checks to see if the DataSetName property is set.
        /// </summary>
        internal bool IsSetDataSetName() => this.DataSetName != null;

        /// <summary>
        /// Gets and sets the property DataSetOrg. 
        /// <para>
        /// The type of data set. The only supported value is VSAM.
        /// </para>
        /// </summary>
        public DatasetDetailOrgAttributes DataSetOrg { get; set; }

        /// <summary>
        /// Checks to see if the DataSetOrg property is set.
        /// </summary>
        internal bool IsSetDataSetOrg() => this.DataSetOrg != null;

        /// <summary>
        /// Gets and sets the property FileSize. 
        /// <para>
        /// File size of the dataset.
        /// </para>
        /// </summary>
        public long? FileSize { get; set; }

        /// <summary>
        /// Checks to see if the FileSize property is set.
        /// </summary>
        internal bool IsSetFileSize() => this.FileSize.HasValue;

        /// <summary>
        /// Gets and sets the property LastReferencedTime. 
        /// <para>
        /// The last time the data set was referenced.
        /// </para>
        /// </summary>
        public DateTime? LastReferencedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastReferencedTime property is set.
        /// </summary>
        internal bool IsSetLastReferencedTime() => this.LastReferencedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time the data set was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location where the data set is stored.
        /// </para>
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property RecordLength. 
        /// <para>
        /// The length of records in the data set.
        /// </para>
        /// </summary>
        public int? RecordLength { get; set; }

        /// <summary>
        /// Checks to see if the RecordLength property is set.
        /// </summary>
        internal bool IsSetRecordLength() => this.RecordLength.HasValue;
    }
}
