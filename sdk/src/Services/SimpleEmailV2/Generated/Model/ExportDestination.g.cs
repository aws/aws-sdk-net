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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains details about the destination of the export job.
    /// </summary>
    public partial class ExportDestination
    {
        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The data format of the final export job file, can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CSV</c> - A comma-separated values file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JSON</c> - A Json file.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataFormat DataFormat { get; set; }

        /// <summary>
        /// Checks to see if the DataFormat property is set.
        /// </summary>
        internal bool IsSetDataFormat() => this.DataFormat != null;

        /// <summary>
        /// Gets and sets the property S3Url. 
        /// <para>
        /// An Amazon S3 pre-signed URL that points to the generated export file.
        /// </para>
        /// </summary>
        public string S3Url { get; set; }

        /// <summary>
        /// Checks to see if the S3Url property is set.
        /// </summary>
        internal bool IsSetS3Url() => this.S3Url != null;
    }
}
