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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// The input options for generating an Q App definition.
    /// </summary>
    public partial class PredictQAppInputOptions
    {
        private List<ConversationMessage> _conversation = AWSConfigs.InitializeCollections ? new List<ConversationMessage>() : null;
        private string _problemStatement;

        /// <summary>
        /// Gets and sets the property Conversation. 
        /// <para>
        /// A conversation to use as input for generating the Q App definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<ConversationMessage> Conversation
        {
            get { return this._conversation; }
            set { this._conversation = value; }
        }

        // Check to see if Conversation property is set
        internal bool IsSetConversation()
        {
            return this._conversation != null && (this._conversation.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProblemStatement. 
        /// <para>
        /// A problem statement to use as input for generating the Q App definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public string ProblemStatement
        {
            get { return this._problemStatement; }
            set { this._problemStatement = value; }
        }

        // Check to see if ProblemStatement property is set
        internal bool IsSetProblemStatement()
        {
            return this._problemStatement != null;
        }

    }
}