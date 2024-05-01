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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyClusterDbRevision operation.
    /// Modifies the database revision of a cluster. The database revision is a unique revision
    /// of the database running in a cluster.
    /// </summary>
    public partial class ModifyClusterDbRevisionRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _revisionTarget;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of a cluster whose database revision you want to modify. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>examplecluster</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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

        /// <summary>
        /// Gets and sets the property RevisionTarget. 
        /// <para>
        /// The identifier of the database revision. You can retrieve this value from the response
        /// to the <a>DescribeClusterDbRevisions</a> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string RevisionTarget
        {
            get { return this._revisionTarget; }
            set { this._revisionTarget = value; }
        }

        // Check to see if RevisionTarget property is set
        internal bool IsSetRevisionTarget()
        {
            return this._revisionTarget != null;
        }

    }
}