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
    /// Specifies a Lambda function that verifies requests to a bot or fulfills the user's
    /// request to a bot.
    /// </summary>
    public partial class LambdaCodeHook
    {
        /// <summary>
        /// Gets and sets the property CodeHookInterfaceVersion. 
        /// <para>
        /// The version of the request-response that you want Amazon Lex to use to invoke your
        /// Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public string CodeHookInterfaceVersion { get; set; }

        /// <summary>
        /// Checks to see if the CodeHookInterfaceVersion property is set.
        /// </summary>
        internal bool IsSetCodeHookInterfaceVersion() => this.CodeHookInterfaceVersion != null;

        /// <summary>
        /// Gets and sets the property LambdaARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string LambdaARN { get; set; }

        /// <summary>
        /// Checks to see if the LambdaARN property is set.
        /// </summary>
        internal bool IsSetLambdaARN() => this.LambdaARN != null;
    }
}
