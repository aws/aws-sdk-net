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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyGlobalCluster operation.
    /// Modify a setting for an Amazon DocumentDB global cluster. You can change one or more
    /// configuration parameters (for example: deletion protection), or the global cluster
    /// identifier by specifying these parameters and the new values in the request.
    /// 
    ///  <note> 
    /// <para>
    /// This action only applies to Amazon DocumentDB clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifyGlobalClusterRequest : AmazonDocDBRequest
    {
        private bool? _deletionProtection;
        private string _globalClusterIdentifier;
        private string _newGlobalClusterIdentifier;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates if the global cluster has deletion protection enabled. The global cluster
        /// can't be deleted when deletion protection is enabled. 
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The identifier for the global cluster being modified. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing global cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GlobalClusterIdentifier
        {
            get { return this._globalClusterIdentifier; }
            set { this._globalClusterIdentifier = value; }
        }

        // Check to see if GlobalClusterIdentifier property is set
        internal bool IsSetGlobalClusterIdentifier()
        {
            return this._globalClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property NewGlobalClusterIdentifier. 
        /// <para>
        /// The new identifier for a global cluster when you modify a global cluster. This value
        /// is stored as a lowercase string.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens
        /// </para>
        ///  
        /// <para>
        /// The first character must be a letter
        /// </para>
        ///  
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-cluster2</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string NewGlobalClusterIdentifier
        {
            get { return this._newGlobalClusterIdentifier; }
            set { this._newGlobalClusterIdentifier = value; }
        }

        // Check to see if NewGlobalClusterIdentifier property is set
        internal bool IsSetNewGlobalClusterIdentifier()
        {
            return this._newGlobalClusterIdentifier != null;
        }

    }
}