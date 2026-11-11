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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Configuration information of an Amazon Lex or Amazon Lex V2 bot.
    /// </summary>
    public partial class LexBotConfig
    {
        /// <summary>
        /// Gets and sets the property LexBot.
        /// </summary>
        public LexBot LexBot { get; set; }

        /// <summary>
        /// Checks to see if the LexBot property is set.
        /// </summary>
        internal bool IsSetLexBot() => this.LexBot != null;

        /// <summary>
        /// Gets and sets the property LexV2Bot. 
        /// <para>
        /// Configuration information of an Amazon Lex V2 bot.
        /// </para>
        /// </summary>
        public LexV2Bot LexV2Bot { get; set; }

        /// <summary>
        /// Checks to see if the LexV2Bot property is set.
        /// </summary>
        internal bool IsSetLexV2Bot() => this.LexV2Bot != null;
    }
}
