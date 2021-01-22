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
    /// This is the response object from the CreateBotVersion operation.
    /// </summary>
    public partial class CreateBotVersionResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private BotStatus _botStatus;
        private string _botVersion;
        private Dictionary<string, BotVersionLocaleDetails> _botVersionLocaleSpecification = new Dictionary<string, BotVersionLocaleDetails>();
        private DateTime? _creationDateTime;
        private string _description;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The bot identifier specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property BotStatus. 
        /// <para>
        /// When you send a request to create or update a bot, Amazon Lex sets the status response
        /// element to <code>Creating</code>. After Amazon Lex builds the bot, it sets status
        /// to <code>Available</code>. If Amazon Lex can't build the bot, it sets status to <code>Failed</code>.
        /// </para>
        /// </summary>
        public BotStatus BotStatus
        {
            get { return this._botStatus; }
            set { this._botStatus = value; }
        }

        // Check to see if BotStatus property is set
        internal bool IsSetBotStatus()
        {
            return this._botStatus != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version number assigned to the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersionLocaleSpecification. 
        /// <para>
        /// The source versions used for each locale in the new version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public Dictionary<string, BotVersionLocaleDetails> BotVersionLocaleSpecification
        {
            get { return this._botVersionLocaleSpecification; }
            set { this._botVersionLocaleSpecification = value; }
        }

        // Check to see if BotVersionLocaleSpecification property is set
        internal bool IsSetBotVersionLocaleSpecification()
        {
            return this._botVersionLocaleSpecification != null && this._botVersionLocaleSpecification.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the version was created.
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the version specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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

    }
}