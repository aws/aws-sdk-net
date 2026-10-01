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
    /// An annotation for managing values within custom types, including adding, updating,
    /// or removing specific type values.
    /// </summary>
    public partial class AutomatedReasoningPolicyTypeValueAnnotation
    {
        /// <summary>
        /// Gets and sets the property AddTypeValue. 
        /// <para>
        /// An operation to add a new value to an existing custom type.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddTypeValue AddTypeValue { get; set; }

        /// <summary>
        /// Checks to see if the AddTypeValue property is set.
        /// </summary>
        internal bool IsSetAddTypeValue() => this.AddTypeValue != null;

        /// <summary>
        /// Gets and sets the property DeleteTypeValue. 
        /// <para>
        /// An operation to remove a value from an existing custom type.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteTypeValue DeleteTypeValue { get; set; }

        /// <summary>
        /// Checks to see if the DeleteTypeValue property is set.
        /// </summary>
        internal bool IsSetDeleteTypeValue() => this.DeleteTypeValue != null;

        /// <summary>
        /// Gets and sets the property UpdateTypeValue. 
        /// <para>
        /// An operation to modify an existing value within a custom type.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateTypeValue UpdateTypeValue { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTypeValue property is set.
        /// </summary>
        internal bool IsSetUpdateTypeValue() => this.UpdateTypeValue != null;
    }
}
