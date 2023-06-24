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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateVocabularyFilter operation.
    /// Updates an existing custom vocabulary filter with a new list of words. The new list
    /// you provide overwrites all previous entries; you cannot append new terms onto an existing
    /// custom vocabulary filter.
    /// </summary>
    public partial class UpdateVocabularyFilterRequest : AmazonTranscribeServiceRequest
    {
        private string _dataAccessRoleArn;
        private string _vocabularyFilterFileUri;
        private string _vocabularyFilterName;
        private List<string> _words = new List<string>();

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has permissions to access the Amazon
        /// S3 bucket that contains your input files (in this case, your custom vocabulary filter).
        /// If the role that you specify doesn’t have the appropriate permissions to access the
        /// specified Amazon S3 location, your request fails.
        /// </para>
        ///  
        /// <para>
        /// IAM role ARNs have the format <code>arn:partition:iam::account:role/role-name-with-path</code>.
        /// For example: <code>arn:aws:iam::111122223333:role/Admin</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// ARNs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterFileUri. 
        /// <para>
        /// The Amazon S3 location of the text file that contains your custom vocabulary filter
        /// terms. The URI must be located in the same Amazon Web Services Region as the resource
        /// you're calling.
        /// </para>
        ///  
        /// <para>
        /// Here's an example URI path: <code>s3://DOC-EXAMPLE-BUCKET/my-vocab-filter-file.txt</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <code>VocabularyFilterFileUri</code> in your request, you
        /// cannot use <code>Words</code>; you must choose one or the other.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string VocabularyFilterFileUri
        {
            get { return this._vocabularyFilterFileUri; }
            set { this._vocabularyFilterFileUri = value; }
        }

        // Check to see if VocabularyFilterFileUri property is set
        internal bool IsSetVocabularyFilterFileUri()
        {
            return this._vocabularyFilterFileUri != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// The name of the custom vocabulary filter you want to update. Custom vocabulary filter
        /// names are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string VocabularyFilterName
        {
            get { return this._vocabularyFilterName; }
            set { this._vocabularyFilterName = value; }
        }

        // Check to see if VocabularyFilterName property is set
        internal bool IsSetVocabularyFilterName()
        {
            return this._vocabularyFilterName != null;
        }

        /// <summary>
        /// Gets and sets the property Words. 
        /// <para>
        /// Use this parameter if you want to update your custom vocabulary filter by including
        /// all desired terms, as comma-separated values, within your request. The other option
        /// for updating your vocabulary filter is to save your entries in a text file and upload
        /// them to an Amazon S3 bucket, then specify the location of your file using the <code>VocabularyFilterFileUri</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <code>Words</code> in your request, you cannot use <code>VocabularyFilterFileUri</code>;
        /// you must choose one or the other.
        /// </para>
        ///  
        /// <para>
        /// Each language has a character set that contains all allowed characters for that specific
        /// language. If you use unsupported characters, your custom vocabulary filter request
        /// fails. Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/charsets.html">Character
        /// Sets for Custom Vocabularies</a> to get the character set for your language.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Words
        {
            get { return this._words; }
            set { this._words = value; }
        }

        // Check to see if Words property is set
        internal bool IsSetWords()
        {
            return this._words != null && this._words.Count > 0; 
        }

    }
}