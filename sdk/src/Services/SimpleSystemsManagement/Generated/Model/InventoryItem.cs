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
    /// Information collected from managed instances based on your inventory policy document
    /// </summary>
    public partial class InventoryItem
    {
        private string _captureTime;
        private List<Dictionary<string, string>> _content = new List<Dictionary<string, string>>();
        private string _contentHash;
        private string _schemaVersion;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property CaptureTime. 
        /// <para>
        /// The time the inventory information was collected.
        /// </para>
        /// </summary>
        public string CaptureTime
        {
            get { return this._captureTime; }
            set { this._captureTime = value; }
        }

        // Check to see if CaptureTime property is set
        internal bool IsSetCaptureTime()
        {
            return this._captureTime != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The inventory data of the inventory type.
        /// </para>
        /// </summary>
        public List<Dictionary<string, string>> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && this._content.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContentHash. 
        /// <para>
        /// MD5 hash of the inventory item type contents. The content hash is used to determine
        /// whether to update inventory information. The <code>PutInventory</code> API does not
        /// update the inventory item type contents if the MD5 hash has not changed since last
        /// update. 
        /// </para>
        /// </summary>
        public string ContentHash
        {
            get { return this._contentHash; }
            set { this._contentHash = value; }
        }

        // Check to see if ContentHash property is set
        internal bool IsSetContentHash()
        {
            return this._contentHash != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version for the inventory item.
        /// </para>
        /// </summary>
        public string SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the inventory type. Default inventory item type names start with <code>AWS</code>.
        /// Custom inventory type names will start with <code>Custom</code>. Default inventory
        /// item types include the following: <code>AWS:AWSComponent</code>, <code>AWS:Application</code>,
        /// <code>AWS:InstanceInformation</code>, <code>AWS:Network</code>, and <code>AWS:WindowsUpdate</code>.
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

    }
}