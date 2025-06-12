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
    /// Provides settings for a message that is sent periodically to the user while a fulfillment
    /// Lambda function is running.
    /// </summary>
    public partial class FulfillmentUpdateResponseSpecification
    {
        private bool? _allowInterrupt;
        private int? _frequencyInSeconds;
        private List<MessageGroup> _messageGroups = AWSConfigs.InitializeCollections ? new List<MessageGroup>() : null;

        /// <summary>
        /// Gets and sets the property AllowInterrupt. 
        /// <para>
        /// Determines whether the user can interrupt an update message while it is playing.
        /// </para>
        /// </summary>
        public bool? AllowInterrupt
        {
            get { return this._allowInterrupt; }
            set { this._allowInterrupt = value; }
        }

        // Check to see if AllowInterrupt property is set
        internal bool IsSetAllowInterrupt()
        {
            return this._allowInterrupt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FrequencyInSeconds. 
        /// <para>
        /// The frequency that a message is sent to the user. When the period ends, Amazon Lex
        /// chooses a message from the message groups and plays it to the user. If the fulfillment
        /// Lambda returns before the first period ends, an update message is not played to the
        /// user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=900)]
        public int? FrequencyInSeconds
        {
            get { return this._frequencyInSeconds; }
            set { this._frequencyInSeconds = value; }
        }

        // Check to see if FrequencyInSeconds property is set
        internal bool IsSetFrequencyInSeconds()
        {
            return this._frequencyInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageGroups. 
        /// <para>
        /// 1 - 5 message groups that contain update messages. Amazon Lex chooses one of the messages
        /// to play to the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<MessageGroup> MessageGroups
        {
            get { return this._messageGroups; }
            set { this._messageGroups = value; }
        }

        // Check to see if MessageGroups property is set
        internal bool IsSetMessageGroups()
        {
            return this._messageGroups != null && (this._messageGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}