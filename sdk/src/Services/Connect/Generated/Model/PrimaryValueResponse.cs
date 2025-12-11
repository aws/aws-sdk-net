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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// A primary value response.
    /// </summary>
    public partial class PrimaryValueResponse
    {
        private string _attributeId;
        private string _attributeName;
        private string _value;

        /// <summary>
        /// Gets and sets the property AttributeId. 
        /// <para>
        /// The value's attribute ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AttributeId
        {
            get { return this._attributeId; }
            set { this._attributeId = value; }
        }

        // Check to see if AttributeId property is set
        internal bool IsSetAttributeId()
        {
            return this._attributeId != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The value's attribute name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value's value.
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