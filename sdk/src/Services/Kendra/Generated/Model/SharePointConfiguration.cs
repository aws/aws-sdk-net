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
    /// Provides configuration information for connecting to a Microsoft SharePoint data source.
    /// </summary>
    public partial class SharePointConfiguration
    {
        private bool? _crawlAttachments;
        private bool? _disableLocalGroups;
        private string _documentTitleFieldName;
        private List<string> _exclusionPatterns = new List<string>();
        private List<DataSourceToIndexFieldMapping> _fieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<string> _inclusionPatterns = new List<string>();
        private string _secretArn;
        private SharePointVersion _sharePointVersion;
        private List<string> _urls = new List<string>();
        private bool? _useChangeLog;
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property CrawlAttachments. 
        /// <para>
        ///  <code>TRUE</code> to include attachments to documents stored in your Microsoft SharePoint
        /// site in the index; otherwise, <code>FALSE</code>.
        /// </para>
        /// </summary>
        public bool CrawlAttachments
        {
            get { return this._crawlAttachments.GetValueOrDefault(); }
            set { this._crawlAttachments = value; }
        }

        // Check to see if CrawlAttachments property is set
        internal bool IsSetCrawlAttachments()
        {
            return this._crawlAttachments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisableLocalGroups. 
        /// <para>
        /// A Boolean value that specifies whether local groups are disabled (<code>True</code>)
        /// or enabled (<code>False</code>). 
        /// </para>
        /// </summary>
        public bool DisableLocalGroups
        {
            get { return this._disableLocalGroups.GetValueOrDefault(); }
            set { this._disableLocalGroups = value; }
        }

        // Check to see if DisableLocalGroups property is set
        internal bool IsSetDisableLocalGroups()
        {
            return this._disableLocalGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentTitleFieldName. 
        /// <para>
        /// The Microsoft SharePoint attribute field that contains the title of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DocumentTitleFieldName
        {
            get { return this._documentTitleFieldName; }
            set { this._documentTitleFieldName = value; }
        }

        // Check to see if DocumentTitleFieldName property is set
        internal bool IsSetDocumentTitleFieldName()
        {
            return this._documentTitleFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns. Documents that match the patterns are excluded
        /// from the index. Documents that don't match the patterns are included in the index.
        /// If a document matches both an exclusion pattern and an inclusion pattern, the document
        /// is not included in the index.
        /// </para>
        ///  
        /// <para>
        /// The regex is applied to the display URL of the SharePoint document.
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
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map Microsoft SharePoint
        /// attributes to custom fields in the Amazon Kendra index. You must first create the
        /// index fields using the operation before you map SharePoint attributes. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// Data Source Fields</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings
        {
            get { return this._fieldMappings; }
            set { this._fieldMappings = value; }
        }

        // Check to see if FieldMappings property is set
        internal bool IsSetFieldMappings()
        {
            return this._fieldMappings != null && this._fieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns. Documents that match the patterns are included
        /// in the index. Documents that don't match the patterns are excluded from the index.
        /// If a document matches both an inclusion pattern and an exclusion pattern, the document
        /// is not included in the index.
        /// </para>
        ///  
        /// <para>
        /// The regex is applied to the display URL of the SharePoint document.
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
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of credentials stored in AWS Secrets Manager. The credentials
        /// should be a user/password pair. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-sharepoint.html">Using
        /// a Microsoft SharePoint Data Source</a>. For more information about AWS Secrets Manager,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/intro.html">
        /// What Is AWS Secrets Manager </a> in the <i>AWS Secrets Manager</i> user guide.
        /// </para>
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
        /// Gets and sets the property SharePointVersion. 
        /// <para>
        /// The version of Microsoft SharePoint that you are using as a data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SharePointVersion SharePointVersion
        {
            get { return this._sharePointVersion; }
            set { this._sharePointVersion = value; }
        }

        // Check to see if SharePointVersion property is set
        internal bool IsSetSharePointVersion()
        {
            return this._sharePointVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Urls. 
        /// <para>
        /// The URLs of the Microsoft SharePoint site that contains the documents that should
        /// be indexed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> Urls
        {
            get { return this._urls; }
            set { this._urls = value; }
        }

        // Check to see if Urls property is set
        internal bool IsSetUrls()
        {
            return this._urls != null && this._urls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        /// Set to <code>TRUE</code> to use the Microsoft SharePoint change log to determine the
        /// documents that need to be updated in the index. Depending on the size of the SharePoint
        /// change log, it may take longer for Amazon Kendra to use the change log than it takes
        /// it to determine the changed documents using the Amazon Kendra document crawler.
        /// </para>
        /// </summary>
        public bool UseChangeLog
        {
            get { return this._useChangeLog.GetValueOrDefault(); }
            set { this._useChangeLog = value; }
        }

        // Check to see if UseChangeLog property is set
        internal bool IsSetUseChangeLog()
        {
            return this._useChangeLog.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration.
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