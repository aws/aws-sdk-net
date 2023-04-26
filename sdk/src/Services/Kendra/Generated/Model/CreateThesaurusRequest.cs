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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the CreateThesaurus operation.
    /// Creates a thesaurus for an index. The thesaurus contains a list of synonyms in Solr
    /// format.
    /// 
    ///  
    /// <para>
    /// For an example of adding a thesaurus file to an index, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/index-synonyms-adding-thesaurus-file.html">Adding
    /// custom synonyms to an index</a>.
    /// </para>
    /// </summary>
    public partial class CreateThesaurusRequest : AmazonKendraRequest
    {
        private string _clientToken;
        private string _description;
        private string _indexId;
        private string _name;
        private string _roleArn;
        private S3Path _sourceS3Path;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to create a thesaurus. Multiple calls
        /// to the <code>CreateThesaurus</code> API with the same client token will create only
        /// one thesaurus. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the thesaurus.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index for the thesaurus.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the thesaurus.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role with permission to access your S3 bucket
        /// that contains the thesaurus file. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/iam-roles.html">IAM
        /// access roles for Amazon Kendra</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceS3Path. 
        /// <para>
        /// The path to the thesaurus file in S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Path SourceS3Path
        {
            get { return this._sourceS3Path; }
            set { this._sourceS3Path = value; }
        }

        // Check to see if SourceS3Path property is set
        internal bool IsSetSourceS3Path()
        {
            return this._sourceS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that identify or categorize the thesaurus. You can also
        /// use tags to help control access to the thesaurus. Tag keys and values can consist
        /// of Unicode letters, digits, white space, and any of the following symbols: _ . : /
        /// = + - @.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}