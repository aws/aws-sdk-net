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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// This is an object that contains the information of a property.
    /// </summary>
    public partial class PropertySummary
    {
        private bool? _areAllPropertyValuesReturned;
        private PropertyDefinitionResponse _definition;
        private string _propertyName;
        private DataValue _value;

        /// <summary>
        /// Gets and sets the property AreAllPropertyValuesReturned. 
        /// <para>
        /// This flag notes whether all values of a list or map type property are returned in
        /// the API response. The maximum number of values per property returned is 50.
        /// </para>
        /// </summary>
        public bool? AreAllPropertyValuesReturned
        {
            get { return this._areAllPropertyValuesReturned; }
            set { this._areAllPropertyValuesReturned = value; }
        }

        // Check to see if AreAllPropertyValuesReturned property is set
        internal bool IsSetAreAllPropertyValuesReturned()
        {
            return this._areAllPropertyValuesReturned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// This is the schema for the property.
        /// </para>
        /// </summary>
        public PropertyDefinitionResponse Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyName. 
        /// <para>
        /// This is the name of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PropertyName
        {
            get { return this._propertyName; }
            set { this._propertyName = value; }
        }

        // Check to see if PropertyName property is set
        internal bool IsSetPropertyName()
        {
            return this._propertyName != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// This is the value for the property.
        /// </para>
        /// </summary>
        public DataValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}