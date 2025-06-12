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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the results of a successful call to the <a>DescribeDBClusterSnapshotAttributes</a>
    /// API action.
    /// 
    ///  
    /// <para>
    /// Manual DB cluster snapshot attributes are used to authorize other Amazon accounts
    /// to copy or restore a manual DB cluster snapshot. For more information, see the <a>ModifyDBClusterSnapshotAttribute</a>
    /// API action.
    /// </para>
    /// </summary>
    public partial class DBClusterSnapshotAttributesResult
    {
        private List<DBClusterSnapshotAttribute> _dbClusterSnapshotAttributes = AWSConfigs.InitializeCollections ? new List<DBClusterSnapshotAttribute>() : null;
        private string _dbClusterSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotAttributes. 
        /// <para>
        /// The list of attributes and values for the manual DB cluster snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBClusterSnapshotAttribute> DBClusterSnapshotAttributes
        {
            get { return this._dbClusterSnapshotAttributes; }
            set { this._dbClusterSnapshotAttributes = value; }
        }

        // Check to see if DBClusterSnapshotAttributes property is set
        internal bool IsSetDBClusterSnapshotAttributes()
        {
            return this._dbClusterSnapshotAttributes != null && (this._dbClusterSnapshotAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotIdentifier. 
        /// <para>
        /// The identifier of the manual DB cluster snapshot that the attributes apply to.
        /// </para>
        /// </summary>
        public string DBClusterSnapshotIdentifier
        {
            get { return this._dbClusterSnapshotIdentifier; }
            set { this._dbClusterSnapshotIdentifier = value; }
        }

        // Check to see if DBClusterSnapshotIdentifier property is set
        internal bool IsSetDBClusterSnapshotIdentifier()
        {
            return this._dbClusterSnapshotIdentifier != null;
        }

    }
}