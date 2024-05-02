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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBotChannelAssociation operation.
    /// Deletes the association between an Amazon Lex bot and a messaging platform.
    /// 
    ///  
    /// <para>
    /// This operation requires permission for the <c>lex:DeleteBotChannelAssociation</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeleteBotChannelAssociationRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _botAlias;
        private string _botName;
        private string _name;

        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// An alias that points to the specific version of the Amazon Lex bot to which this association
        /// is being made.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the Amazon Lex bot.
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
        /// The name of the association. The name is case sensitive. 
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