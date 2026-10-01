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
    /// A collection of messages that convey information to the user. At runtime, Amazon Lex
    /// selects the message to convey.
    /// </summary>
    public partial class Statement
    {
        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// A collection of message objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 15)]
        public List<Message> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<Message>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponseCard. 
        /// <para>
        ///  At runtime, if the client is using the <a href="http://docs.aws.amazon.com/lex/latest/dg/API_runtime_PostText.html">PostText</a>
        /// API, Amazon Lex includes the response card in the response. It substitutes all of
        /// the session attributes and slot values for placeholders in the response card. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50000)]
        public string ResponseCard { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCard property is set.
        /// </summary>
        internal bool IsSetResponseCard() => this.ResponseCard != null;
    }
}
