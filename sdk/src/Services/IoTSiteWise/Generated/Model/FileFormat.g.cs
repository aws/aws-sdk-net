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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// The file format of the data in S3.
    /// </summary>
    public partial class FileFormat
    {
        /// <summary>
        /// Gets and sets the property Annotation. 
        /// <para>
        /// The annotation format configuration.
        /// </para>
        /// </summary>
        public Annotation Annotation { get; set; }

        /// <summary>
        /// Checks to see if the Annotation property is set.
        /// </summary>
        internal bool IsSetAnnotation() => this.Annotation != null;

        /// <summary>
        /// Gets and sets the property Csv. 
        /// <para>
        /// The file is in .CSV format.
        /// </para>
        /// </summary>
        public Csv Csv { get; set; }

        /// <summary>
        /// Checks to see if the Csv property is set.
        /// </summary>
        internal bool IsSetCsv() => this.Csv != null;

        /// <summary>
        /// Gets and sets the property Mp4. 
        /// <para>
        /// The MP4 format configuration.
        /// </para>
        /// </summary>
        public Mp4 Mp4 { get; set; }

        /// <summary>
        /// Checks to see if the Mp4 property is set.
        /// </summary>
        internal bool IsSetMp4() => this.Mp4 != null;

        /// <summary>
        /// Gets and sets the property Parquet. 
        /// <para>
        /// The file is in parquet format.
        /// </para>
        /// </summary>
        public Parquet Parquet { get; set; }

        /// <summary>
        /// Checks to see if the Parquet property is set.
        /// </summary>
        internal bool IsSetParquet() => this.Parquet != null;
    }
}
