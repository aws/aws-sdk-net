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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An object that provides the current value of a security control parameter and identifies
    /// whether it has been customized.
    /// </summary>
    public partial class ParameterConfiguration
    {
        private ParameterValue _value;
        private ParameterValueType _valueType;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  The current value of a control parameter. 
        /// </para>
        /// </summary>
        public ParameterValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        ///  Identifies whether a control parameter uses a custom user-defined value or subscribes
        /// to the default Security Hub behavior.
        /// </para>
        ///  
        /// <para>
        /// When <c>ValueType</c> is set equal to <c>DEFAULT</c>, the default behavior can be
        /// a specific Security Hub default value, or the default behavior can be to ignore a
        /// specific parameter. When <c>ValueType</c> is set equal to <c>DEFAULT</c>, Security
        /// Hub ignores user-provided input for the <c>Value</c> field.
        /// </para>
        ///  
        /// <para>
        /// When <c>ValueType</c> is set equal to <c>CUSTOM</c>, the <c>Value</c> field can't
        /// be empty.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParameterValueType ValueType
        {
            get { return this._valueType; }
            set { this._valueType = value; }
        }

        // Check to see if ValueType property is set
        internal bool IsSetValueType()
        {
            return this._valueType != null;
        }

    }
}