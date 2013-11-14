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
    /// Container for the parameters to the DeleteClusterSecurityGroup operation.
    /// <para> Deletes an Amazon Redshift security group. </para> <para><b>NOTE:</b>You cannot delete a security group that is associated with any
    /// clusters. You cannot delete the default security group.</para> <para> For information about managing security groups, go to <a
    /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html" >Amazon Redshift Cluster Security Groups</a> in the
    /// <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    public partial class DeleteClusterSecurityGroupRequest : AmazonRedshiftRequest
    {
        private string clusterSecurityGroupName;


        /// <summary>
        /// The name of the cluster security group to be deleted.
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

    }
}
    
