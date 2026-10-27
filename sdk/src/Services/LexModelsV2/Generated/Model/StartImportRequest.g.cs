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
    /// Container for the parameters to the StartImport operation. Starts importing a bot,
    /// bot locale, or custom vocabulary from a zip archive that you uploaded to an S3 bucket.
    /// </summary>
    public partial class StartImportRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property FilePassword. 
        /// <para>
        /// The password used to encrypt the zip archive that contains the resource definition.
        /// You should always encrypt the zip archive to protect it during transit between your
        /// site and Amazon Lex.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string FilePassword { get; set; }

        /// <summary>
        /// Checks to see if the FilePassword property is set.
        /// </summary>
        internal bool IsSetFilePassword() => this.FilePassword != null;

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The unique identifier for the import. It is included in the response from the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_CreateUploadUrl.html">CreateUploadUrl</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string ImportId { get; set; }

        /// <summary>
        /// Checks to see if the ImportId property is set.
        /// </summary>
        internal bool IsSetImportId() => this.ImportId != null;

        /// <summary>
        /// Gets and sets the property MergeStrategy. 
        /// <para>
        /// The strategy to use when there is a name conflict between the imported resource and
        /// an existing resource. When the merge strategy is <c>FailOnConflict</c> existing resources
        /// are not overwritten and the import fails.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MergeStrategy MergeStrategy { get; set; }

        /// <summary>
        /// Checks to see if the MergeStrategy property is set.
        /// </summary>
        internal bool IsSetMergeStrategy() => this.MergeStrategy != null;

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        /// Parameters for creating the bot, bot locale or custom vocabulary.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImportResourceSpecification ResourceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSpecification property is set.
        /// </summary>
        internal bool IsSetResourceSpecification() => this.ResourceSpecification != null;
    }
}
