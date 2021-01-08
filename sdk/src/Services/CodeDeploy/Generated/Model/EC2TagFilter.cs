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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about an EC2 tag filter.
    /// </summary>
    public partial class EC2TagFilter
    {
        private string _key;
        private EC2TagFilterType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The tag filter key.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The tag filter type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KEY_ONLY</code>: Key only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VALUE_ONLY</code>: Value only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KEY_AND_VALUE</code>: Key and value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EC2TagFilterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The tag filter value.
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