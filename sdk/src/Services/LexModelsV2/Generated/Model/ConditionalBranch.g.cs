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
    /// A set of actions that Amazon Lex should run if the condition is matched.
    /// </summary>
    public partial class ConditionalBranch
    {
        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// Contains the expression to evaluate. If the condition is true, the branch's actions
        /// are taken.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Condition Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextStep. 
        /// <para>
        /// The next step in the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DialogState NextStep { get; set; }

        /// <summary>
        /// Checks to see if the NextStep property is set.
        /// </summary>
        internal bool IsSetNextStep() => this.NextStep != null;

        /// <summary>
        /// Gets and sets the property Response.
        /// </summary>
        public ResponseSpecification Response { get; set; }

        /// <summary>
        /// Checks to see if the Response property is set.
        /// </summary>
        internal bool IsSetResponse() => this.Response != null;
    }
}
