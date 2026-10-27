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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the StopBotAnalyzer operation.
    /// </summary>
    public partial class StopBotAnalyzerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotAnalyzerRequestId. 
        /// <para>
        /// The unique identifier of the analysis request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string BotAnalyzerRequestId { get; set; }

        /// <summary>
        /// Checks to see if the BotAnalyzerRequestId property is set.
        /// </summary>
        internal bool IsSetBotAnalyzerRequestId() => this.BotAnalyzerRequestId != null;

        /// <summary>
        /// Gets and sets the property BotAnalyzerStatus. 
        /// <para>
        /// The updated status of the analysis. The status will be <c>Stopping</c> and will eventually
        /// transition to <c>Stopped</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>Processing | Available | Failed | Stopping | Stopped</c> 
        /// </para>
        /// </summary>
        public BotAnalyzerStatus BotAnalyzerStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotAnalyzerStatus property is set.
        /// </summary>
        internal bool IsSetBotAnalyzerStatus() => this.BotAnalyzerStatus != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale identifier of the bot locale.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;
    }
}
