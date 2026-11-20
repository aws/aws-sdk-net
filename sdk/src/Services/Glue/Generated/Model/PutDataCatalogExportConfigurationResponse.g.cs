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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the PutDataCatalogExportConfiguration operation.
    /// </summary>
    public partial class PutDataCatalogExportConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// The export setting for asset metadata.
        /// </para>
        /// </summary>
        public AssetsExport Assets { get; set; }

        /// <summary>
        /// Checks to see if the Assets property is set.
        /// </summary>
        internal bool IsSetAssets() => this.Assets != null;

        /// <summary>
        /// Gets and sets the property S3TablesConfiguration. 
        /// <para>
        /// The S3 Tables configuration for the export.
        /// </para>
        /// </summary>
        public S3TablesConfiguration S3TablesConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3TablesConfiguration property is set.
        /// </summary>
        internal bool IsSetS3TablesConfiguration() => this.S3TablesConfiguration != null;
    }
}
