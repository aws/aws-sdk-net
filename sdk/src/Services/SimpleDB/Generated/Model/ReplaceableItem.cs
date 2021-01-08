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

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReplaceableItem
    {
        private List<ReplaceableAttribute> _attributes = new List<ReplaceableAttribute>();
        private string _name;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ReplaceableItem() { }

        /// <summary>
        /// Instantiates ReplaceableItem with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the replaceable item.</param>
        public ReplaceableItem(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Instantiates ReplaceableItem with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the replaceable item.</param>
        /// <param name="attributes">The list of attributes for a replaceable item.</param>
        public ReplaceableItem(string name, List<ReplaceableAttribute> attributes)
        {
            _name = name;
            _attributes = attributes;
        }

        /// <summary>
        /// Gets and sets the property Attributes. The list of attributes for a replaceable item.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ReplaceableAttribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the replaceable item.
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}