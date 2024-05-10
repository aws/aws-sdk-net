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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Indicates the slot configuration and global identifier for a slice group.
    /// </summary>
    public partial class GlobalNodeGroup
    {
        private string _globalNodeGroupId;
        private string _slots;

        /// <summary>
        /// Gets and sets the property GlobalNodeGroupId. 
        /// <para>
        /// The name of the global node group
        /// </para>
        /// </summary>
        public string GlobalNodeGroupId
        {
            get { return this._globalNodeGroupId; }
            set { this._globalNodeGroupId = value; }
        }

        // Check to see if GlobalNodeGroupId property is set
        internal bool IsSetGlobalNodeGroupId()
        {
            return this._globalNodeGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// The keyspace for this node group
        /// </para>
        /// </summary>
        public string Slots
        {
            get { return this._slots; }
            set { this._slots = value; }
        }

        // Check to see if Slots property is set
        internal bool IsSetSlots()
        {
            return this._slots != null;
        }

    }
}