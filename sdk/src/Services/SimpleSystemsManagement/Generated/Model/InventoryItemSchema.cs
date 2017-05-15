/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The inventory item schema definition. Users can use this to compose inventory query
    /// filters.
    /// </summary>
    public partial class InventoryItemSchema
    {
        private List<InventoryItemAttribute> _attributes = new List<InventoryItemAttribute>();
        private string _typeName;
        private string _version;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The schema attributes for inventory. This contains data type and attribute name.
        /// </para>
        /// </summary>
        public List<InventoryItemAttribute> Attributes
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
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the inventory type. Default inventory item type names start with AWS.
        /// Custom inventory type names will start with Custom. Default inventory item types include
        /// the following: AWS:AWSComponent, AWS:Application, AWS:InstanceInformation, AWS:Network,
        /// and AWS:WindowsUpdate.
        /// </para>
        /// </summary>
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The schema version for the inventory item.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}