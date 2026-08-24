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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// The export configuration returned by the <c>PutDataCatalogExportConfiguration</c>
    /// operation.
    /// </summary>
    public partial class PutDataCatalogExportConfigurationResponse : AmazonWebServiceResponse
    {
        private ExportEncryptionConfiguration _encryptionConfiguration;
        private ExportSetting _exportSetting;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the exported data.
        /// </para>
        /// </summary>
        public ExportEncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExportSetting. 
        /// <para>
        /// The export setting for the data catalog.
        /// </para>
        /// </summary>
        public ExportSetting ExportSetting
        {
            get { return this._exportSetting; }
            set { this._exportSetting = value; }
        }

        // Check to see if ExportSetting property is set
        internal bool IsSetExportSetting()
        {
            return this._exportSetting != null;
        }

    }
}