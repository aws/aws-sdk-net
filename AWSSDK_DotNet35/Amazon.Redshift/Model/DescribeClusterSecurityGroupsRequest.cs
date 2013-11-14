/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeClusterSecurityGroups operation.
    /// <para> Returns information about Amazon Redshift security groups. If the name of a security group is specified, the response will contain
    /// only information about only that security group. </para> <para> For information about managing security groups, go to <a
    /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html" >Amazon Redshift Cluster Security Groups</a> in the
    /// <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    public partial class DescribeClusterSecurityGroupsRequest : AmazonRedshiftRequest
    {
        private string clusterSecurityGroupName;
        private int? maxRecords;
        private string marker;


        /// <summary>
        /// The name of a cluster security group for which you are requesting details. You can specify either the <b>Marker</b> parameter or a
        /// <b>ClusterSecurityGroupName</b> parameter, but not both. Example: <c>securitygroup1</c>
        ///  
        /// </summary>
        public string ClusterSecurityGroupName
        {
            get { return this.clusterSecurityGroupName; }
            set { this.clusterSecurityGroupName = value; }
        }

        // Check to see if ClusterSecurityGroupName property is set
        internal bool IsSetClusterSecurityGroupName()
        {
            return this.clusterSecurityGroupName != null;
        }

        /// <summary>
        /// The maximum number of records to be included in the response. If more records exist than the specified <c>MaxRecords</c> value, a marker is
        /// included in the response, which you can use in a subsequent <a>DescribeClusterSecurityGroups</a> request. Default: <c>100</c> Constraints:
        /// Value must be at least 20 and no more than 100.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// An optional marker returned by a previous <a>DescribeClusterSecurityGroups</a> request to indicate the first security group that the current
        /// request will return. You can specify either the <b>Marker</b> parameter or a <b>ClusterSecurityGroupName</b> parameter, but not both.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

    }
}
    
