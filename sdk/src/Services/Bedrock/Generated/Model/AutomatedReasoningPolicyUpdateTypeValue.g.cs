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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Represents a modification to a value within an existing custom type.
    /// </summary>
    public partial class AutomatedReasoningPolicyUpdateTypeValue
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description for the type value, replacing the previous description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property NewValue. 
        /// <para>
        /// The new identifier or name for the type value, if you want to rename it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string NewValue { get; set; }

        /// <summary>
        /// Checks to see if the NewValue property is set.
        /// </summary>
        internal bool IsSetNewValue() => this.NewValue != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The current identifier or name of the type value to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
