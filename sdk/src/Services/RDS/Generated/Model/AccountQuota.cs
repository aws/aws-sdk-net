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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Describes a quota for an Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// The following are account quotas:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>AllocatedStorage</c> - The total allocated storage per account, in GiB. The used
    /// value is the total allocated storage in the account, in GiB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>AuthorizationsPerDBSecurityGroup</c> - The number of ingress rules per DB security
    /// group. The used value is the highest number of ingress rules in a DB security group
    /// in the account. Other DB security groups in the account might have a lower number
    /// of ingress rules.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CustomEndpointsPerDBCluster</c> - The number of custom endpoints per DB cluster.
    /// The used value is the highest number of custom endpoints in a DB clusters in the account.
    /// Other DB clusters in the account might have a lower number of custom endpoints.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DBClusterParameterGroups</c> - The number of DB cluster parameter groups per account,
    /// excluding default parameter groups. The used value is the count of nondefault DB cluster
    /// parameter groups in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DBClusterRoles</c> - The number of associated Amazon Web Services Identity and
    /// Access Management (IAM) roles per DB cluster. The used value is the highest number
    /// of associated IAM roles for a DB cluster in the account. Other DB clusters in the
    /// account might have a lower number of associated IAM roles.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DBClusters</c> - The number of DB clusters per account. The used value is the
    /// count of DB clusters in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DBInstanceRoles</c> - The number of associated IAM roles per DB instance. The
    /// used value is the highest number of associated IAM roles for a DB instance in the
    /// account. Other DB instances in the account might have a lower number of associated
    /// IAM roles.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DBInstances</c> - The number of DB instances per account. The used value is the
    /// count of the DB instances in the account.
    /// </para>
    ///  
    /// <para>
    /// Amazon RDS DB instances, Amazon Aurora DB instances, Amazon Neptune instances, and
    /// Amazon DocumentDB instances apply to this quota.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DBParameterGroups</c> - The number of DB parameter groups per account, excluding
    /// default parameter groups. The used value is the count of nondefault DB parameter groups
    /// in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DBSecurityGroups</c> - The number of DB security groups (not VPC security groups)
    /// per account, excluding the default security group. The used value is the count of
    /// nondefault DB security groups in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DBSubnetGroups</c> - The number of DB subnet groups per account. The used value
    /// is the count of the DB subnet groups in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>EventSubscriptions</c> - The number of event subscriptions per account. The used
    /// value is the count of the event subscriptions in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ManualClusterSnapshots</c> - The number of manual DB cluster snapshots per account.
    /// The used value is the count of the manual DB cluster snapshots in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ManualSnapshots</c> - The number of manual DB instance snapshots per account.
    /// The used value is the count of the manual DB instance snapshots in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>OptionGroups</c> - The number of DB option groups per account, excluding default
    /// option groups. The used value is the count of nondefault DB option groups in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ReadReplicasPerMaster</c> - The number of read replicas per DB instance. The used
    /// value is the highest number of read replicas for a DB instance in the account. Other
    /// DB instances in the account might have a lower number of read replicas.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ReservedDBInstances</c> - The number of reserved DB instances per account. The
    /// used value is the count of the active reserved DB instances in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SubnetsPerDBSubnetGroup</c> - The number of subnets per DB subnet group. The used
    /// value is highest number of subnets for a DB subnet group in the account. Other DB
    /// subnet groups in the account might have a lower number of subnets.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Limits.html">Quotas
    /// for Amazon RDS</a> in the <i>Amazon RDS User Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_Limits.html">Quotas
    /// for Amazon Aurora</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AccountQuota
    {
        private string _accountQuotaName;
        private long? _max;
        private long? _used;

        /// <summary>
        /// Gets and sets the property AccountQuotaName. 
        /// <para>
        /// The name of the Amazon RDS quota for this Amazon Web Services account.
        /// </para>
        /// </summary>
        public string AccountQuotaName
        {
            get { return this._accountQuotaName; }
            set { this._accountQuotaName = value; }
        }

        // Check to see if AccountQuotaName property is set
        internal bool IsSetAccountQuotaName()
        {
            return this._accountQuotaName != null;
        }

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum allowed value for the quota.
        /// </para>
        /// </summary>
        public long? Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Used. 
        /// <para>
        /// The amount currently used toward the quota maximum.
        /// </para>
        /// </summary>
        public long? Used
        {
            get { return this._used; }
            set { this._used = value; }
        }

        // Check to see if Used property is set
        internal bool IsSetUsed()
        {
            return this._used.HasValue; 
        }

    }
}