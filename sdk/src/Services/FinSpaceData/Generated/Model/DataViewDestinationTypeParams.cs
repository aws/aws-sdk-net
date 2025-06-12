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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
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
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Structure for the Dataview destination type parameters.
    /// </summary>
    public partial class DataViewDestinationTypeParams
    {
        private string _destinationType;
        private ExportFileFormat _s3DestinationExportFileFormat;
        private Dictionary<string, string> _s3DestinationExportFileFormatOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// Destination type for a Dataview.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GLUE_TABLE</c> – Glue table destination type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> – S3 destination type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationType
        {
            get { return this._destinationType; }
            set { this._destinationType = value; }
        }

        // Check to see if DestinationType property is set
        internal bool IsSetDestinationType()
        {
            return this._destinationType != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationExportFileFormat. 
        /// <para>
        /// Dataview export file format.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PARQUET</c> – Parquet export file format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELIMITED_TEXT</c> – Delimited text export file format.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExportFileFormat S3DestinationExportFileFormat
        {
            get { return this._s3DestinationExportFileFormat; }
            set { this._s3DestinationExportFileFormat = value; }
        }

        // Check to see if S3DestinationExportFileFormat property is set
        internal bool IsSetS3DestinationExportFileFormat()
        {
            return this._s3DestinationExportFileFormat != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationExportFileFormatOptions. 
        /// <para>
        /// Format Options for S3 Destination type.
        /// </para>
        ///  
        /// <para>
        /// Here is an example of how you could specify the <c>s3DestinationExportFileFormatOptions</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c> { "header": "true", "delimiter": ",", "compression": "gzip" }</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> S3DestinationExportFileFormatOptions
        {
            get { return this._s3DestinationExportFileFormatOptions; }
            set { this._s3DestinationExportFileFormatOptions = value; }
        }

        // Check to see if S3DestinationExportFileFormatOptions property is set
        internal bool IsSetS3DestinationExportFileFormatOptions()
        {
            return this._s3DestinationExportFileFormatOptions != null && (this._s3DestinationExportFileFormatOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}