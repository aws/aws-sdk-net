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
    /// Container for the parameters to the SwitchoverGlobalCluster operation.
    /// Switches over the specified secondary Amazon DocumentDB cluster to be the new primary
    /// Amazon DocumentDB cluster in the global database cluster.
    /// </summary>
    public partial class SwitchoverGlobalClusterRequest : AmazonDocDBRequest
    {
        private string _globalClusterIdentifier;
        private string _targetDbClusterIdentifier;

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The identifier of the Amazon DocumentDB global database cluster to switch over. The
        /// identifier is the unique key assigned by the user when the cluster is created. In
        /// other words, it's the name of the global cluster. This parameter isn’t case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing global cluster (Amazon DocumentDB global
        /// database).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Minimum length of 1. Maximum length of 255.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Pattern: <c>[A-Za-z][0-9A-Za-z-:._]*</c> 
        /// </para>
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
        /// Gets and sets the property TargetDbClusterIdentifier. 
        /// <para>
        /// The identifier of the secondary Amazon DocumentDB cluster to promote to the new primary
        /// for the global database cluster. Use the Amazon Resource Name (ARN) for the identifier
        /// so that Amazon DocumentDB can locate the cluster in its Amazon Web Services region.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing secondary cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Minimum length of 1. Maximum length of 255.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Pattern: <c>[A-Za-z][0-9A-Za-z-:._]*</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TargetDbClusterIdentifier
        {
            get { return this._targetDbClusterIdentifier; }
            set { this._targetDbClusterIdentifier = value; }
        }

        // Check to see if TargetDbClusterIdentifier property is set
        internal bool IsSetTargetDbClusterIdentifier()
        {
            return this._targetDbClusterIdentifier != null;
        }

    }
}