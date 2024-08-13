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
    /// Settings that specify the dialog code hook that is called by Amazon Lex between eliciting
    /// slot values.
    /// </summary>
    public partial class ElicitationCodeHookInvocationSetting
    {
        private bool? _enableCodeHookInvocation;
        private string _invocationLabel;

        /// <summary>
        /// Gets and sets the property EnableCodeHookInvocation. 
        /// <para>
        /// Indicates whether a Lambda function should be invoked for the dialog.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? EnableCodeHookInvocation
        {
            get { return this._enableCodeHookInvocation; }
            set { this._enableCodeHookInvocation = value; }
        }

        // Check to see if EnableCodeHookInvocation property is set
        internal bool IsSetEnableCodeHookInvocation()
        {
            return this._enableCodeHookInvocation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InvocationLabel. 
        /// <para>
        /// A label that indicates the dialog step from which the dialog code hook is happening.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string InvocationLabel
        {
            get { return this._invocationLabel; }
            set { this._invocationLabel = value; }
        }

        // Check to see if InvocationLabel property is set
        internal bool IsSetInvocationLabel()
        {
            return this._invocationLabel != null;
        }

    }
}