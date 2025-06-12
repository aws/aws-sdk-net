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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Provides the bot parameters required for importing a bot.
    /// </summary>
    public partial class BotImportSpecification
    {
        private string _botName;
        private Dictionary<string, string> _botTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DataPrivacy _dataPrivacy;
        private ErrorLogSettings _errorLogSettings;
        private int? _idleSessionTTLInSeconds;
        private string _roleArn;
        private Dictionary<string, string> _testBotAliasTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name that Amazon Lex should use for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property BotTags. 
        /// <para>
        /// A list of tags to add to the bot. You can only add tags when you import a bot. You
        /// can't use the <c>UpdateBot</c> operation to update tags. To update tags, use the <c>TagResource</c>
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> BotTags
        {
            get { return this._botTags; }
            set { this._botTags = value; }
        }

        // Check to see if BotTags property is set
        internal bool IsSetBotTags()
        {
            return this._botTags != null && (this._botTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataPrivacy.
        /// </summary>
        [AWSProperty(Required=true)]
        public DataPrivacy DataPrivacy
        {
            get { return this._dataPrivacy; }
            set { this._dataPrivacy = value; }
        }

        // Check to see if DataPrivacy property is set
        internal bool IsSetDataPrivacy()
        {
            return this._dataPrivacy != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorLogSettings. 
        /// <para>
        /// Allows you to configure destinations where error logs will be published during the
        /// bot import process.
        /// </para>
        /// </summary>
        public ErrorLogSettings ErrorLogSettings
        {
            get { return this._errorLogSettings; }
            set { this._errorLogSettings = value; }
        }

        // Check to see if ErrorLogSettings property is set
        internal bool IsSetErrorLogSettings()
        {
            return this._errorLogSettings != null;
        }

        /// <summary>
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        /// The time, in seconds, that Amazon Lex should keep information about a user's conversation
        /// with the bot. 
        /// </para>
        ///  
        /// <para>
        /// A user interaction remains active for the amount of time specified. If no conversation
        /// occurs during this time, the session expires and Amazon Lex deletes any data provided
        /// before the timeout.
        /// </para>
        ///  
        /// <para>
        /// You can specify between 60 (1 minute) and 86,400 (24 hours) seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=86400)]
        public int? IdleSessionTTLInSeconds
        {
            get { return this._idleSessionTTLInSeconds; }
            set { this._idleSessionTTLInSeconds = value; }
        }

        // Check to see if IdleSessionTTLInSeconds property is set
        internal bool IsSetIdleSessionTTLInSeconds()
        {
            return this._idleSessionTTLInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used to build and run the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=2048)]
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
        /// Gets and sets the property TestBotAliasTags. 
        /// <para>
        /// A list of tags to add to the test alias for a bot. You can only add tags when you
        /// import a bot. You can't use the <c>UpdateAlias</c> operation to update tags. To update
        /// tags on the test alias, use the <c>TagResource</c> operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> TestBotAliasTags
        {
            get { return this._testBotAliasTags; }
            set { this._testBotAliasTags = value; }
        }

        // Check to see if TestBotAliasTags property is set
        internal bool IsSetTestBotAliasTags()
        {
            return this._testBotAliasTags != null && (this._testBotAliasTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}