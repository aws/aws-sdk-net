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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Describes the configuration of this multi-Region CMK. This field appears only when
    /// the CMK is a primary or replica of a multi-Region CMK.
    /// 
    ///  
    /// <para>
    /// For more information about any listed CMK, use the <a>DescribeKey</a> operation.
    /// </para>
    /// </summary>
    public partial class MultiRegionConfiguration
    {
        private MultiRegionKeyType _multiRegionKeyType;
        private MultiRegionKey _primaryKey;
        private List<MultiRegionKey> _replicaKeys = new List<MultiRegionKey>();

        /// <summary>
        /// Gets and sets the property MultiRegionKeyType. 
        /// <para>
        /// Indicates whether the CMK is a <code>PRIMARY</code> or <code>REPLICA</code> key.
        /// </para>
        /// </summary>
        public MultiRegionKeyType MultiRegionKeyType
        {
            get { return this._multiRegionKeyType; }
            set { this._multiRegionKeyType = value; }
        }

        // Check to see if MultiRegionKeyType property is set
        internal bool IsSetMultiRegionKeyType()
        {
            return this._multiRegionKeyType != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryKey. 
        /// <para>
        /// Displays the key ARN and Region of the primary key. This field includes the current
        /// CMK if it is the primary key.
        /// </para>
        /// </summary>
        public MultiRegionKey PrimaryKey
        {
            get { return this._primaryKey; }
            set { this._primaryKey = value; }
        }

        // Check to see if PrimaryKey property is set
        internal bool IsSetPrimaryKey()
        {
            return this._primaryKey != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaKeys. 
        /// <para>
        /// displays the key ARNs and Regions of all replica keys. This field includes the current
        /// CMK if it is a replica key.
        /// </para>
        /// </summary>
        public List<MultiRegionKey> ReplicaKeys
        {
            get { return this._replicaKeys; }
            set { this._replicaKeys = value; }
        }

        // Check to see if ReplicaKeys property is set
        internal bool IsSetReplicaKeys()
        {
            return this._replicaKeys != null && this._replicaKeys.Count > 0; 
        }

    }
}