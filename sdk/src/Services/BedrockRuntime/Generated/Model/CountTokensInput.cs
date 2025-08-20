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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The input value for token counting. The value should be either an <c>InvokeModel</c>
    /// or <c>Converse</c> request body.
    /// </summary>
    public partial class CountTokensInput
    {
        private ConverseTokensRequest _converse;
        private InvokeModelTokensRequest _invokeModel;

        /// <summary>
        /// Gets and sets the property Converse. 
        /// <para>
        /// A <c>Converse</c> request for which to count tokens. Use this field when you want
        /// to count tokens for a conversation-based input that would be sent to the <c>Converse</c>
        /// operation.
        /// </para>
        /// </summary>
        public ConverseTokensRequest Converse
        {
            get { return this._converse; }
            set { this._converse = value; }
        }

        // Check to see if Converse property is set
        internal bool IsSetConverse()
        {
            return this._converse != null;
        }

        /// <summary>
        /// Gets and sets the property InvokeModel. 
        /// <para>
        /// An <c>InvokeModel</c> request for which to count tokens. Use this field when you want
        /// to count tokens for a raw text input that would be sent to the <c>InvokeModel</c>
        /// operation.
        /// </para>
        /// </summary>
        public InvokeModelTokensRequest InvokeModel
        {
            get { return this._invokeModel; }
            set { this._invokeModel = value; }
        }

        // Check to see if InvokeModel property is set
        internal bool IsSetInvokeModel()
        {
            return this._invokeModel != null;
        }

    }
}