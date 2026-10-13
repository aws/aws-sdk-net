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
    /// Container for the parameters to the PutDataCatalogExportConfiguration operation. Creates
    /// or updates the export configuration for the Glue Data Catalog. Use this operation
    /// to enable or disable the export of catalog metadata to S3 Tables.
    /// </summary>
    public partial class PutDataCatalogExportConfigurationRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the exported data. If not specified, the default
        /// encryption settings are used.
        /// </para>
        /// </summary>
        public ExportEncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExportSetting. 
        /// <para>
        /// The export setting for the data catalog. Specify <c>ENABLED</c> to start exporting
        /// catalog metadata to S3 Tables, or <c>DISABLED</c> to stop exporting. This field is
        /// required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportSetting ExportSetting { get; set; }

        /// <summary>
        /// Checks to see if the ExportSetting property is set.
        /// </summary>
        internal bool IsSetExportSetting() => this.ExportSetting != null;
    }
}
