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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Associates a form property to a binding property. This enables exposed properties
    /// on the top level form to propagate data to the form's property values.
    /// </summary>
    public partial class FormInputValuePropertyBindingProperties
    {
        private string _field;
        private string _property;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The data field to bind the property to.
        /// </para>
        /// </summary>
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// The form property to bind to the data field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Property
        {
            get { return this._property; }
            set { this._property = value; }
        }

        // Check to see if Property property is set
        internal bool IsSetProperty()
        {
            return this._property != null;
        }

    }
}