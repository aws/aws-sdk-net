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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateExport operation. Updates the password used
    /// to protect an export zip archive. <para> The password is not required. If you don't
    /// supply a password, Amazon Lex generates a zip file that is not protected by a password.
    /// This is the archive that is available at the pre-signed S3 URL provided by the <a
    /// href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DescribeExport.html">DescribeExport</a>
    /// operation. </para>
    /// </summary>
    public partial class UpdateExportRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique identifier Amazon Lex assigned to the export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string ExportId { get; set; }

        /// <summary>
        /// Checks to see if the ExportId property is set.
        /// </summary>
        internal bool IsSetExportId() => this.ExportId != null;

        /// <summary>
        /// Gets and sets the property FilePassword. 
        /// <para>
        /// The new password to use to encrypt the export zip archive.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string FilePassword { get; set; }

        /// <summary>
        /// Checks to see if the FilePassword property is set.
        /// </summary>
        internal bool IsSetFilePassword() => this.FilePassword != null;
    }
}
