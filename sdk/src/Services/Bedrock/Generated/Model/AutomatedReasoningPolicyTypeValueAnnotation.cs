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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
        private AutomatedReasoningPolicyAddTypeValue _addTypeValue;
        private AutomatedReasoningPolicyDeleteTypeValue _deleteTypeValue;
        private AutomatedReasoningPolicyUpdateTypeValue _updateTypeValue;

        /// <summary>
        /// Gets and sets the property AddTypeValue. 
        /// <para>
        /// An operation to add a new value to an existing custom type.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyAddTypeValue AddTypeValue
        {
            get { return this._addTypeValue; }
            set { this._addTypeValue = value; }
        }

        // Check to see if AddTypeValue property is set
        internal bool IsSetAddTypeValue()
        {
            return this._addTypeValue != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteTypeValue. 
        /// <para>
        /// An operation to remove a value from an existing custom type.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyDeleteTypeValue DeleteTypeValue
        {
            get { return this._deleteTypeValue; }
            set { this._deleteTypeValue = value; }
        }

        // Check to see if DeleteTypeValue property is set
        internal bool IsSetDeleteTypeValue()
        {
            return this._deleteTypeValue != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTypeValue. 
        /// <para>
        /// An operation to modify an existing value within a custom type.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyUpdateTypeValue UpdateTypeValue
        {
            get { return this._updateTypeValue; }
            set { this._updateTypeValue = value; }
        }

        // Check to see if UpdateTypeValue property is set
        internal bool IsSetUpdateTypeValue()
        {
            return this._updateTypeValue != null;
        }

    }
}