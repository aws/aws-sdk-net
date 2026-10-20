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
    /// Settings that specify the dialog code hook that is called by Amazon Lex at a step
    /// of the conversation.
    /// </summary>
    public partial class DialogCodeHookInvocationSetting
    {
        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Determines whether a dialog code hook is used when the intent is activated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property EnableCodeHookInvocation. 
        /// <para>
        /// Indicates whether a Lambda function should be invoked for the dialog.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? EnableCodeHookInvocation { get; set; }

        /// <summary>
        /// Checks to see if the EnableCodeHookInvocation property is set.
        /// </summary>
        internal bool IsSetEnableCodeHookInvocation() => this.EnableCodeHookInvocation.HasValue;

        /// <summary>
        /// Gets and sets the property InvocationLabel. 
        /// <para>
        /// A label that indicates the dialog step from which the dialog code hook is happening.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InvocationLabel { get; set; }

        /// <summary>
        /// Checks to see if the InvocationLabel property is set.
        /// </summary>
        internal bool IsSetInvocationLabel() => this.InvocationLabel != null;

        /// <summary>
        /// Gets and sets the property PostCodeHookSpecification. 
        /// <para>
        /// Contains the responses and actions that Amazon Lex takes after the Lambda function
        /// is complete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PostDialogCodeHookInvocationSpecification PostCodeHookSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PostCodeHookSpecification property is set.
        /// </summary>
        internal bool IsSetPostCodeHookSpecification() => this.PostCodeHookSpecification != null;
    }
}
