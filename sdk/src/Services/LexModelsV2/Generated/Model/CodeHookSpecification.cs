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
    /// Contains information about code hooks that Amazon Lex calls during a conversation.
    /// </summary>
    public partial class CodeHookSpecification
    {
        private LambdaCodeHook _lambdaCodeHook;

        /// <summary>
        /// Gets and sets the property LambdaCodeHook.
        /// </summary>
        [AWSProperty(Required=true)]
        public LambdaCodeHook LambdaCodeHook
        {
            get { return this._lambdaCodeHook; }
            set { this._lambdaCodeHook = value; }
        }

        // Check to see if LambdaCodeHook property is set
        internal bool IsSetLambdaCodeHook()
        {
            return this._lambdaCodeHook != null;
        }

    }
}