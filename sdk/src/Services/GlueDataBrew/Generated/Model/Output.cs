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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents individual output from a particular job run.
    /// </summary>
    public partial class Output
    {
        private CompressionFormat _compressionFormat;
        private OutputFormat _format;
        private S3Location _location;
        private bool? _overwrite;
        private List<string> _partitionColumns = new List<string>();

        /// <summary>
        /// Gets and sets the property CompressionFormat. 
        /// <para>
        /// The compression algorithm used to compress the output text of the job.
        /// </para>
        /// </summary>
        public CompressionFormat CompressionFormat
        {
            get { return this._compressionFormat; }
            set { this._compressionFormat = value; }
        }

        // Check to see if CompressionFormat property is set
        internal bool IsSetCompressionFormat()
        {
            return this._compressionFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The data format of the output of the job.
        /// </para>
        /// </summary>
        public OutputFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location in Amazon S3 where the job writes its output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Overwrite. 
        /// <para>
        /// A value that, if true, means that any data in the location specified for output is
        /// overwritten with new output.
        /// </para>
        /// </summary>
        public bool Overwrite
        {
            get { return this._overwrite.GetValueOrDefault(); }
            set { this._overwrite = value; }
        }

        // Check to see if Overwrite property is set
        internal bool IsSetOverwrite()
        {
            return this._overwrite.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartitionColumns. 
        /// <para>
        /// The names of one or more partition columns for the output of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<string> PartitionColumns
        {
            get { return this._partitionColumns; }
            set { this._partitionColumns = value; }
        }

        // Check to see if PartitionColumns property is set
        internal bool IsSetPartitionColumns()
        {
            return this._partitionColumns != null && this._partitionColumns.Count > 0; 
        }

    }
}