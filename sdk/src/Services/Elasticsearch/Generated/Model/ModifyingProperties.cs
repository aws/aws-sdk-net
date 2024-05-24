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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Information about the domain properties that are currently being modified.
    /// </summary>
    public partial class ModifyingProperties
    {
        private string _activeValue;
        private string _name;
        private string _pendingValue;
        private PropertyValueType _valueType;

        /// <summary>
        /// Gets and sets the property ActiveValue. 
        /// <para>
        /// The current value of the domain property that is being modified.
        /// </para>
        /// </summary>
        public string ActiveValue
        {
            get { return this._activeValue; }
            set { this._activeValue = value; }
        }

        // Check to see if ActiveValue property is set
        internal bool IsSetActiveValue()
        {
            return this._activeValue != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the property that is currently being modified.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PendingValue. 
        /// <para>
        /// The value that the property that is currently being modified will eventually have.
        /// </para>
        /// </summary>
        public string PendingValue
        {
            get { return this._pendingValue; }
            set { this._pendingValue = value; }
        }

        // Check to see if PendingValue property is set
        internal bool IsSetPendingValue()
        {
            return this._pendingValue != null;
        }

        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        /// The type of value that is currently being modified. Properties can have two types:
        /// </para>
        ///  <ul> <li><b>PLAIN_TEXT</b>: Contain direct values such as "1", "True", or "c5.large.search".</li>
        /// <li><b>STRINGIFIED_JSON</b>: Contain content in JSON format, such as {"Enabled":"True"}".</li>
        /// </ul>
        /// </summary>
        public PropertyValueType ValueType
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