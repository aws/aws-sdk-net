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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the StartImport operation.
    /// Starts importing a bot, bot locale, or custom vocabulary from a zip archive that you
    /// uploaded to an S3 bucket.
    /// </summary>
    public partial class StartImportRequest : AmazonLexModelsV2Request
    {
        private string _filePassword;
        private string _importId;
        private MergeStrategy _mergeStrategy;
        private ImportResourceSpecification _resourceSpecification;

        /// <summary>
        /// Gets and sets the property FilePassword. 
        /// <para>
        /// The password used to encrypt the zip archive that contains the resource definition.
        /// You should always encrypt the zip archive to protect it during transit between your
        /// site and Amazon Lex.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string FilePassword
        {
            get { return this._filePassword; }
            set { this._filePassword = value; }
        }

        // Check to see if FilePassword property is set
        internal bool IsSetFilePassword()
        {
            return this._filePassword != null;
        }

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The unique identifier for the import. It is included in the response from the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_CreateUploadUrl.html">CreateUploadUrl</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string ImportId
        {
            get { return this._importId; }
            set { this._importId = value; }
        }

        // Check to see if ImportId property is set
        internal bool IsSetImportId()
        {
            return this._importId != null;
        }

        /// <summary>
        /// Gets and sets the property MergeStrategy. 
        /// <para>
        /// The strategy to use when there is a name conflict between the imported resource and
        /// an existing resource. When the merge strategy is <code>FailOnConflict</code> existing
        /// resources are not overwritten and the import fails.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MergeStrategy MergeStrategy
        {
            get { return this._mergeStrategy; }
            set { this._mergeStrategy = value; }
        }

        // Check to see if MergeStrategy property is set
        internal bool IsSetMergeStrategy()
        {
            return this._mergeStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        /// Parameters for creating the bot, bot locale or custom vocabulary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportResourceSpecification ResourceSpecification
        {
            get { return this._resourceSpecification; }
            set { this._resourceSpecification = value; }
        }

        // Check to see if ResourceSpecification property is set
        internal bool IsSetResourceSpecification()
        {
            return this._resourceSpecification != null;
        }

    }
}