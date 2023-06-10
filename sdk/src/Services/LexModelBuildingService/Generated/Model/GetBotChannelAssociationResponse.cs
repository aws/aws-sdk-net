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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// This is the response object from the GetBotChannelAssociation operation.
    /// </summary>
    public partial class GetBotChannelAssociationResponse : AmazonWebServiceResponse
    {
        private string _botAlias;
        private Dictionary<string, string> _botConfiguration = new Dictionary<string, string>();
        private string _botName;
        private DateTime? _createdDate;
        private string _description;
        private string _failureReason;
        private string _name;
        private ChannelStatus _status;
        private ChannelType _type;

        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// An alias pointing to the specific version of the Amazon Lex bot to which this association
        /// is being made.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string BotAlias
        {
            get { return this._botAlias; }
            set { this._botAlias = value; }
        }

        // Check to see if BotAlias property is set
        internal bool IsSetBotAlias()
        {
            return this._botAlias != null;
        }

        /// <summary>
        /// Gets and sets the property BotConfiguration. 
        /// <para>
        /// Provides information that the messaging platform needs to communicate with the Amazon
        /// Lex bot.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=10)]
        public Dictionary<string, string> BotConfiguration
        {
            get { return this._botConfiguration; }
            set { this._botConfiguration = value; }
        }

        // Check to see if BotConfiguration property is set
        internal bool IsSetBotConfiguration()
        {
            return this._botConfiguration != null && this._botConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the Amazon Lex bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
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
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date that the association between the bot and the channel was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the association between the bot and the channel.
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

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <code>status</code> is <code>FAILED</code>, Amazon Lex provides the reason that
        /// it failed to create the association.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the association between the bot and the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the bot channel. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATED</code> - The channel has been created and is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code> - Channel creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> - There was an error creating the channel. For information about
        /// the reason for the failure, see the <code>failureReason</code> field.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChannelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the messaging platform.
        /// </para>
        /// </summary>
        public ChannelType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}