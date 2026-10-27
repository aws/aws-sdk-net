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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateVocabulary operation. Updates an existing
    /// custom vocabulary with new values. This operation overwrites all existing information
    /// with your new values; you cannot append new terms onto an existing custom vocabulary.
    /// <para> Your custom vocabulary must be in a terminal state (<c>READY</c> or <c>FAILED</c>)
    /// before you can update it. You must include either <c>Phrases</c> or <c>VocabularyFileUri</c>
    /// in your request. </para>
    /// </summary>
    public partial class UpdateVocabularyRequest : AmazonTranscribeServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has permissions to access the Amazon
        /// S3 bucket that contains your input files (in this case, your custom vocabulary). If
        /// you include <c>EncryptionConfiguration</c> in your request, this role must also have
        /// permissions to access the specified KMS key. If the role that you specify doesn’t
        /// have the appropriate permissions, your request fails.
        /// </para>
        ///  
        /// <para>
        /// IAM role ARNs have the format <c>arn:partition:iam::account:role/role-name-with-path</c>.
        /// For example: <c>arn:aws:iam::111122223333:role/Admin</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// ARNs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Specifies the new encryption configuration for your custom vocabulary. The vocabulary
        /// artifacts are re-encrypted in place using the specified KMS key or with an AWS-owned
        /// key if a key is not supplied.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code that represents the language of the entries in the custom vocabulary
        /// you want to update. Each custom vocabulary must contain terms in only one language.
        /// </para>
        ///  
        /// <para>
        /// A custom vocabulary can only be used to transcribe files in the same language as the
        /// custom vocabulary. For example, if you create a custom vocabulary using US English
        /// (<c>en-US</c>), you can only apply this custom vocabulary to files that contain English
        /// audio.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported languages and their associated language codes, refer to the
        /// <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property Phrases. 
        /// <para>
        /// Use this parameter if you want to update your custom vocabulary by including all desired
        /// terms, as comma-separated values, within your request. The other option for updating
        /// your custom vocabulary is to save your entries in a text file and upload them to an
        /// Amazon S3 bucket, then specify the location of your file using the <c>VocabularyFileUri</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <c>Phrases</c> in your request, you cannot use <c>VocabularyFileUri</c>;
        /// you must choose one or the other.
        /// </para>
        ///  
        /// <para>
        /// Each language has a character set that contains all allowed characters for that specific
        /// language. If you use unsupported characters, your custom vocabulary filter request
        /// fails. Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/charsets.html">Character
        /// Sets for Custom Vocabularies</a> to get the character set for your language.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Phrases { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Phrases property is set.
        /// </summary>
        internal bool IsSetPhrases() => this.Phrases != null && (this.Phrases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VocabularyFileUri. 
        /// <para>
        /// The Amazon S3 location of the text file that contains your custom vocabulary. The
        /// URI must be located in the same Amazon Web Services Region as the resource you're
        /// calling.
        /// </para>
        ///  
        /// <para>
        /// Here's an example URI path: <c>s3://DOC-EXAMPLE-BUCKET/my-vocab-file.txt</c> 
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <c>VocabularyFileUri</c> in your request, you cannot use
        /// the <c>Phrases</c> flag; you must choose one or the other.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string VocabularyFileUri { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFileUri property is set.
        /// </summary>
        internal bool IsSetVocabularyFileUri() => this.VocabularyFileUri != null;

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the custom vocabulary you want to update. Custom vocabulary names are
        /// case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string VocabularyName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyName property is set.
        /// </summary>
        internal bool IsSetVocabularyName() => this.VocabularyName != null;
    }
}
