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
    /// Provides one or more messages that Amazon Lex should send to the user.
    /// </summary>
    public partial class MessageGroup
    {
        private Message _message;
        private List<Message> _variations = AWSConfigs.InitializeCollections ? new List<Message>() : null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The primary message that Amazon Lex should send to the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Message Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Variations. 
        /// <para>
        /// Message variations to send to the user. When variations are defined, Amazon Lex chooses
        /// the primary message or one of the variations to send to the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<Message> Variations
        {
            get { return this._variations; }
            set { this._variations = value; }
        }

        // Check to see if Variations property is set
        internal bool IsSetVariations()
        {
            return this._variations != null && (this._variations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}