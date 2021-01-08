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
    /// Container for the parameters to the DeleteBotAlias operation.
    /// Deletes an alias for the specified bot. 
    /// 
    ///  
    /// <para>
    /// You can't delete an alias that is used in the association between a bot and a messaging
    /// channel. If an alias is used in a channel association, the <code>DeleteBot</code>
    /// operation returns a <code>ResourceInUseException</code> exception that includes a
    /// reference to the channel association that refers to the bot. You can remove the reference
    /// to the alias by deleting the channel association. If you get the same exception again,
    /// delete the referring association until the <code>DeleteBotAlias</code> operation is
    /// successful.
    /// </para>
    /// </summary>
    public partial class DeleteBotAliasRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _botName;
        private string _name;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot that the alias points to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the alias to delete. The name is case sensitive. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

    }
}