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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Represents an association between an Amazon Lex bot and an external messaging platform.
    /// </summary>
    public partial class BotChannelAssociation
    {
        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// An alias pointing to the specific version of the Amazon Lex bot to which this association
        /// is being made. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string BotAlias { get; set; }

        /// <summary>
        /// Checks to see if the BotAlias property is set.
        /// </summary>
        internal bool IsSetBotAlias() => this.BotAlias != null;

        /// <summary>
        /// Gets and sets the property BotConfiguration. 
        /// <para>
        /// Provides information necessary to communicate with the messaging platform. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 10)]
        public Dictionary<string, string> BotConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the BotConfiguration property is set.
        /// </summary>
        internal bool IsSetBotConfiguration() => this.BotConfiguration != null && (this.BotConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the Amazon Lex bot to which this association is being made. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, Amazon Lex supports associations with Facebook and Slack, and Twilio.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string BotName { get; set; }

        /// <summary>
        /// Checks to see if the BotName property is set.
        /// </summary>
        internal bool IsSetBotName() => this.BotName != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date that the association between the Amazon Lex bot and the channel was created.
        /// 
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A text description of the association you are creating. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <c>status</c> is <c>FAILED</c>, Amazon Lex provides the reason that it failed to
        /// create the association.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the association between the bot and the channel. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the bot channel. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATED</c> - The channel has been created and is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - Channel creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - There was an error creating the channel. For information about the
        /// reason for the failure, see the <c>failureReason</c> field.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChannelStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of association by indicating the type of channel being established
        /// between the Amazon Lex bot and the external messaging platform.
        /// </para>
        /// </summary>
        public ChannelType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
