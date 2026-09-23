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

namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// A criteria for when a button should be shown based on values in the notification
    /// </summary>
    public partial class CustomActionAttachmentCriteria
    {
        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operation to perform on the named variable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomActionAttachmentCriteriaOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A value that is compared with the actual value of the variable based on the behavior
        /// of the operator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;

        /// <summary>
        /// Gets and sets the property VariableName. 
        /// <para>
        /// The name of the variable to operate on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string VariableName { get; set; }

        /// <summary>
        /// Checks to see if the VariableName property is set.
        /// </summary>
        internal bool IsSetVariableName() => this.VariableName != null;
    }
}
