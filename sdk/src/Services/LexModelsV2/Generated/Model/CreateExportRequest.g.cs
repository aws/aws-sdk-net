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
    /// Container for the parameters to the CreateExport operation. Creates a zip archive
    /// containing the contents of a bot or a bot locale. The archive contains a directory
    /// structure that contains JSON files that define the bot. <para> You can create an archive
    /// that contains the complete definition of a bot, or you can specify that the archive
    /// contain only the definition of a single bot locale. </para> <para> For more information
    /// about exporting bots, and about the structure of the export archive, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/importing-exporting.html">
    /// Importing and exporting bots </a> </para>
    /// </summary>
    public partial class CreateExportRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The file format of the bot or bot locale definition files.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImportExportFileFormat FileFormat { get; set; }

        /// <summary>
        /// Checks to see if the FileFormat property is set.
        /// </summary>
        internal bool IsSetFileFormat() => this.FileFormat != null;

        /// <summary>
        /// Gets and sets the property FilePassword. 
        /// <para>
        /// An password to use to encrypt the exported archive. Using a password is optional,
        /// but you should encrypt the archive to protect the data in transit between Amazon Lex
        /// and your local computer.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string FilePassword { get; set; }

        /// <summary>
        /// Checks to see if the FilePassword property is set.
        /// </summary>
        internal bool IsSetFilePassword() => this.FilePassword != null;

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        /// Specifies the type of resource to export, either a bot or a bot locale. You can only
        /// specify one type of resource to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportResourceSpecification ResourceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSpecification property is set.
        /// </summary>
        internal bool IsSetResourceSpecification() => this.ResourceSpecification != null;
    }
}
