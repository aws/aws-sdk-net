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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes how to bind a component property to form data.
    /// </summary>
    public partial class FormBindingElement
    {
        private string _element;
        private string _property;

        /// <summary>
        /// Gets and sets the property Element. 
        /// <para>
        /// The name of the component to retrieve a value from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Element
        {
            get { return this._element; }
            set { this._element = value; }
        }

        // Check to see if Element property is set
        internal bool IsSetElement()
        {
            return this._element != null;
        }

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// The property to retrieve a value from.
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