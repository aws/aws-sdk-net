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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to connect to Slack as your data source.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Kendra now supports an upgraded Slack connector.
    /// </para>
    ///  
    /// <para>
    /// You must now use the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_TemplateConfiguration.html">TemplateConfiguration</a>
    /// object instead of the <c>SlackConfiguration</c> object to configure your connector.
    /// </para>
    ///  
    /// <para>
    /// Connectors configured using the older console and API architecture will continue to
    /// function as configured. However, you won’t be able to edit or update them. If you
    /// want to edit or update your connector configuration, you must create a new connector.
    /// </para>
    ///  
    /// <para>
    /// We recommended migrating your connector workflow to the upgraded version. Support
    /// for connectors configured using the older architecture is scheduled to end by June
    /// 2024.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SlackConfiguration
    {
        private bool? _crawlBotMessage;
        private bool? _excludeArchived;
        private List<string> _exclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DataSourceToIndexFieldMapping> _fieldMappings = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;
        private List<string> _inclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _lookBackPeriod;
        private List<string> _privateChannelFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _publicChannelFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _secretArn;
        private string _sinceCrawlDate;
        private List<string> _slackEntityList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _teamId;
        private bool? _useChangeLog;
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property CrawlBotMessage. 
        /// <para>
        ///  <c>TRUE</c> to index bot messages from your Slack workspace team.
        /// </para>
        /// </summary>
        public bool? CrawlBotMessage
        {
            get { return this._crawlBotMessage; }
            set { this._crawlBotMessage = value; }
        }

        // Check to see if CrawlBotMessage property is set
        internal bool IsSetCrawlBotMessage()
        {
            return this._crawlBotMessage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeArchived. 
        /// <para>
        ///  <c>TRUE</c> to exclude archived messages to index from your Slack workspace team.
        /// </para>
        /// </summary>
        public bool? ExcludeArchived
        {
            get { return this._excludeArchived; }
            set { this._excludeArchived = value; }
        }

        // Check to see if ExcludeArchived property is set
        internal bool IsSetExcludeArchived()
        {
            return this._excludeArchived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain attached files in your Slack
        /// workspace team. Files that match the patterns are excluded from the index. Files that
        /// don’t match the patterns are included in the index. If a file matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the file isn't included
        /// in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> ExclusionPatterns
        {
            get { return this._exclusionPatterns; }
            set { this._exclusionPatterns = value; }
        }

        // Check to see if ExclusionPatterns property is set
        internal bool IsSetExclusionPatterns()
        {
            return this._exclusionPatterns != null && (this._exclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map Slack data source
        /// attributes or field names to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Slack fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Slack data source field names must exist in your Slack
        /// custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._fieldMappings != null && (this._fieldMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain attached files in your Slack
        /// workspace team. Files that match the patterns are included in the index. Files that
        /// don't match the patterns are excluded from the index. If a file matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the file isn't included
        /// in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> InclusionPatterns
        {
            get { return this._inclusionPatterns; }
            set { this._inclusionPatterns = value; }
        }

        // Check to see if InclusionPatterns property is set
        internal bool IsSetInclusionPatterns()
        {
            return this._inclusionPatterns != null && (this._inclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LookBackPeriod. 
        /// <para>
        /// The number of hours for change log to look back from when you last synchronized your
        /// data. You can look back up to 7 days or 168 hours.
        /// </para>
        ///  
        /// <para>
        /// Change log updates your index only if new content was added since you last synced
        /// your data. Updated or deleted content from before you last synced does not get updated
        /// in your index. To capture updated or deleted content before you last synced, set the
        /// <c>LookBackPeriod</c> to the number of hours you want change log to look back.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=168)]
        public int? LookBackPeriod
        {
            get { return this._lookBackPeriod; }
            set { this._lookBackPeriod = value; }
        }

        // Check to see if LookBackPeriod property is set
        internal bool IsSetLookBackPeriod()
        {
            return this._lookBackPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateChannelFilter. 
        /// <para>
        /// The list of private channel names from your Slack workspace team. You use this if
        /// you want to index specific private channels, not all private channels. You can also
        /// use regular expression patterns to filter private channels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrivateChannelFilter
        {
            get { return this._privateChannelFilter; }
            set { this._privateChannelFilter = value; }
        }

        // Check to see if PrivateChannelFilter property is set
        internal bool IsSetPrivateChannelFilter()
        {
            return this._privateChannelFilter != null && (this._privateChannelFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PublicChannelFilter. 
        /// <para>
        /// The list of public channel names to index from your Slack workspace team. You use
        /// this if you want to index specific public channels, not all public channels. You can
        /// also use regular expression patterns to filter public channels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PublicChannelFilter
        {
            get { return this._publicChannelFilter; }
            set { this._publicChannelFilter = value; }
        }

        // Check to see if PublicChannelFilter property is set
        internal bool IsSetPublicChannelFilter()
        {
            return this._publicChannelFilter != null && (this._publicChannelFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Manager secret that contains the key-value
        /// pairs required to connect to your Slack workspace team. The secret must contain a
        /// JSON structure with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// slackToken—The user or bot token created in Slack. For more information on creating
        /// a token in Slack, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-slack.html#slack-authentication">Authentication
        /// for a Slack data source</a>.
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
        /// Gets and sets the property SinceCrawlDate. 
        /// <para>
        /// The date to start crawling your data from your Slack workspace team. The date must
        /// follow this format: <c>yyyy-mm-dd</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string SinceCrawlDate
        {
            get { return this._sinceCrawlDate; }
            set { this._sinceCrawlDate = value; }
        }

        // Check to see if SinceCrawlDate property is set
        internal bool IsSetSinceCrawlDate()
        {
            return this._sinceCrawlDate != null;
        }

        /// <summary>
        /// Gets and sets the property SlackEntityList. 
        /// <para>
        /// Specify whether to index public channels, private channels, group messages, and direct
        /// messages. You can specify one or more of these options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> SlackEntityList
        {
            get { return this._slackEntityList; }
            set { this._slackEntityList = value; }
        }

        // Check to see if SlackEntityList property is set
        internal bool IsSetSlackEntityList()
        {
            return this._slackEntityList != null && (this._slackEntityList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// The identifier of the team in the Slack workspace. For example, <i>T0123456789</i>.
        /// </para>
        ///  
        /// <para>
        /// You can find your team ID in the URL of the main page of your Slack workspace. When
        /// you log in to Slack via a browser, you are directed to the URL of the main page. For
        /// example, <i>https://app.slack.com/client/<b>T0123456789</b>/...</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TeamId
        {
            get { return this._teamId; }
            set { this._teamId = value; }
        }

        // Check to see if TeamId property is set
        internal bool IsSetTeamId()
        {
            return this._teamId != null;
        }

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <c>TRUE</c> to use the Slack change log to determine which documents require updating
        /// in the index. Depending on the Slack change log's size, it may take longer for Amazon
        /// Kendra to use the change log than to scan all of your documents in Slack.
        /// </para>
        /// </summary>
        public bool? UseChangeLog
        {
            get { return this._useChangeLog; }
            set { this._useChangeLog = value; }
        }

        // Check to see if UseChangeLog property is set
        internal bool IsSetUseChangeLog()
        {
            return this._useChangeLog.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon Virtual Private Cloud to connect to your Slack.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
        /// a VPC</a>.
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