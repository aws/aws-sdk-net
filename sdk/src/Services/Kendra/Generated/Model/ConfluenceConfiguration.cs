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
    /// Provides configuration information for data sources that connect to Confluence.
    /// </summary>
    public partial class ConfluenceConfiguration
    {
        private ConfluenceAttachmentConfiguration _attachmentConfiguration;
        private ConfluenceBlogConfiguration _blogConfiguration;
        private List<string> _exclusionPatterns = new List<string>();
        private List<string> _inclusionPatterns = new List<string>();
        private ConfluencePageConfiguration _pageConfiguration;
        private string _secretArn;
        private string _serverUrl;
        private ConfluenceSpaceConfiguration _spaceConfiguration;
        private ConfluenceVersion _version;
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property AttachmentConfiguration. 
        /// <para>
        /// Specifies configuration information for indexing attachments to Confluence blogs and
        /// pages.
        /// </para>
        /// </summary>
        public ConfluenceAttachmentConfiguration AttachmentConfiguration
        {
            get { return this._attachmentConfiguration; }
            set { this._attachmentConfiguration = value; }
        }

        // Check to see if AttachmentConfiguration property is set
        internal bool IsSetAttachmentConfiguration()
        {
            return this._attachmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BlogConfiguration. 
        /// <para>
        ///  Specifies configuration information for indexing Confluence blogs.
        /// </para>
        /// </summary>
        public ConfluenceBlogConfiguration BlogConfiguration
        {
            get { return this._blogConfiguration; }
            set { this._blogConfiguration = value; }
        }

        // Check to see if BlogConfiguration property is set
        internal bool IsSetBlogConfiguration()
        {
            return this._blogConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns that apply to a URL on the Confluence server.
        /// An exclusion pattern can apply to a blog post, a page, a space, or an attachment.
        /// Items that match the pattern are excluded from the index. Items that don't match the
        /// pattern are included in the index. If a item matches both an exclusion pattern and
        /// an inclusion pattern, the item isn't included in the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExclusionPatterns
        {
            get { return this._exclusionPatterns; }
            set { this._exclusionPatterns = value; }
        }

        // Check to see if ExclusionPatterns property is set
        internal bool IsSetExclusionPatterns()
        {
            return this._exclusionPatterns != null && this._exclusionPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns that apply to a URL on the Confluence server.
        /// An inclusion pattern can apply to a blog post, a page, a space, or an attachment.
        /// Items that match the patterns are included in the index. Items that don't match the
        /// pattern are excluded from the index. If an item matches both an inclusion pattern
        /// and an exclusion pattern, the item isn't included in the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> InclusionPatterns
        {
            get { return this._inclusionPatterns; }
            set { this._inclusionPatterns = value; }
        }

        // Check to see if InclusionPatterns property is set
        internal bool IsSetInclusionPatterns()
        {
            return this._inclusionPatterns != null && this._inclusionPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PageConfiguration. 
        /// <para>
        /// Specifies configuration information for indexing Confluence pages.
        /// </para>
        /// </summary>
        public ConfluencePageConfiguration PageConfiguration
        {
            get { return this._pageConfiguration; }
            set { this._pageConfiguration = value; }
        }

        // Check to see if PageConfiguration property is set
        internal bool IsSetPageConfiguration()
        {
            return this._pageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AWS Secrets Manager secret that contains the
        /// key/value pairs required to connect to your Confluence server. The secret must contain
        /// a JSON structure with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// username - The user name or email address of a user with administrative privileges
        /// for the Confluence server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// password - The password associated with the user logging in to the Confluence server.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1284)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServerUrl. 
        /// <para>
        /// The URL of your Confluence instance. Use the full URL of the server. For example,
        /// <code>https://server.example.com:port/</code>. You can also use an IP address, for
        /// example, <code>https://192.168.1.113/</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ServerUrl
        {
            get { return this._serverUrl; }
            set { this._serverUrl = value; }
        }

        // Check to see if ServerUrl property is set
        internal bool IsSetServerUrl()
        {
            return this._serverUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceConfiguration. 
        /// <para>
        /// Specifies configuration information for indexing Confluence spaces.
        /// </para>
        /// </summary>
        public ConfluenceSpaceConfiguration SpaceConfiguration
        {
            get { return this._spaceConfiguration; }
            set { this._spaceConfiguration = value; }
        }

        // Check to see if SpaceConfiguration property is set
        internal bool IsSetSpaceConfiguration()
        {
            return this._spaceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Specifies the version of the Confluence installation that you are connecting to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfluenceVersion Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Specifies the information for connecting to an Amazon VPC.
        /// </para>
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}