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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
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
namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Specifies the conditions under which data should be updated. If an update condition
    /// is specified for a request, the data will only be updated if the condition is satisfied.
    /// For example, if an attribute with a specific name and value exists, or if a specific
    /// attribute doesn't exist.
    /// </summary>
    public partial class UpdateCondition
    {
        private bool? _exists;
        private string _name;
        private string _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateCondition() { }

        /// <summary>
        /// Instantiates UpdateCondition with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the attribute involved in the condition.</param>
        /// <param name="value">The value of an attribute. This value can only be specified when the <c>Exists</c> parameter is equal to <c>true</c>.</param>
        /// <param name="exists">A value specifying whether or not the specified attribute must exist with the specified value in order for the update condition to be satisfied. Specify <c>true</c> if the attribute must exist for the update condition to be satisfied. Specify <c>false</c> if the attribute should not exist in order for the update condition to be satisfied.</param>
        public UpdateCondition(string name, string value, bool? exists)
        {
            _name = name;
            _value = value;
            _exists = exists;
        }

        /// <summary>
        /// Gets and sets the property Exists. 
        /// <para>
        /// A value specifying whether or not the specified attribute must exist with the specified
        /// value in order for the update condition to be satisfied. Specify <c>true</c> if the
        /// attribute must exist for the update condition to be satisfied. Specify <c>false</c>
        /// if the attribute should not exist in order for the update condition to be satisfied.
        /// </para>
        /// </summary>
        public bool? Exists
        {
            get { return this._exists; }
            set { this._exists = value; }
        }

        // Check to see if Exists property is set
        internal bool IsSetExists()
        {
            return this._exists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute involved in the condition.
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of an attribute. This value can only be specified when the <c>Exists</c>
        /// parameter is equal to <c>true</c>.
        /// </para>
        /// </summary>
        public string Value
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