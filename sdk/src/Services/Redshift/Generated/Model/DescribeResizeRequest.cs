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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeResize operation.
    /// Returns information about the last resize operation for the specified cluster. If
    /// no resize operation has ever been initiated for the specified cluster, a <code>HTTP
    /// 404</code> error is returned. If a resize operation was initiated and completed, the
    /// status of the resize remains as <code>SUCCEEDED</code> until the next resize. 
    /// 
    ///  
    /// <para>
    /// A resize operation can be requested using <a>ModifyCluster</a> and specifying a different
    /// number or type of nodes for the cluster. 
    /// </para>
    /// </summary>
    public partial class DescribeResizeRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of a cluster whose resize progress you are requesting. This
        /// parameter is case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// By default, resize operations for all clusters defined for an AWS account are returned.
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

    }
}