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
    /// Specifies a list of message groups that Amazon Lex uses to respond the user input.
    /// </summary>
    public partial class ResponseSpecification
    {
        private bool? _allowInterrupt;
        private List<MessageGroup> _messageGroups = AWSConfigs.InitializeCollections ? new List<MessageGroup>() : null;

        /// <summary>
        /// Gets and sets the property AllowInterrupt. 
        /// <para>
        /// Indicates whether the user can interrupt a speech response from Amazon Lex.
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
        /// Gets and sets the property MessageGroups. 
        /// <para>
        /// A collection of responses that Amazon Lex can send to the user. Amazon Lex chooses
        /// the actual response to send at runtime.
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