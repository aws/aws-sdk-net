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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Settings that specify the dialog code hook that is called by Amazon Lex at a step
    /// of the conversation.
    /// </summary>
    public partial class DialogCodeHookInvocationSetting
    {
        private bool? _active;
        private bool? _enableCodeHookInvocation;
        private string _invocationLabel;
        private PostDialogCodeHookInvocationSpecification _postCodeHookSpecification;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Determines whether a dialog code hook is used when the intent is activated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Active
        {
            get { return this._active.GetValueOrDefault(); }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableCodeHookInvocation. 
        /// <para>
        /// Indicates whether a Lambda function should be invoked for the dialog.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EnableCodeHookInvocation
        {
            get { return this._enableCodeHookInvocation.GetValueOrDefault(); }
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

        /// <summary>
        /// Gets and sets the property PostCodeHookSpecification. 
        /// <para>
        /// Contains the responses and actions that Amazon Lex takes after the Lambda function
        /// is complete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PostDialogCodeHookInvocationSpecification PostCodeHookSpecification
        {
            get { return this._postCodeHookSpecification; }
            set { this._postCodeHookSpecification = value; }
        }

        // Check to see if PostCodeHookSpecification property is set
        internal bool IsSetPostCodeHookSpecification()
        {
            return this._postCodeHookSpecification != null;
        }

    }
}