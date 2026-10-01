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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Configures whether Batch manages an Amazon EKS access entry on the cluster for the
    /// compute environment. For information on how the fields interact with the cluster's
    /// <c>authenticationMode</c> and with other compute environments that share the cluster,
    /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/eks-access-entries.html">Amazon
    /// EKS access entry authentication</a> in the <i>Batch User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// Setting <c>desiredState=ENABLED</c> on a single compute environment does not guarantee
    /// that Batch creates an access entry, and setting <c>desiredState=DISABLED</c> on a
    /// single compute environment does not guarantee that Batch deletes one. Batch compares
    /// the <c>desiredState</c> across all compute environments that target the same cluster.
    /// The Batch-managed access entry is created only when all compute environments have
    /// <c>desiredState=ENABLED</c>, and deleted only when all have <c>desiredState=DISABLED</c>.
    /// If you have multiple compute environments on the same cluster, set <c>desiredState</c>
    /// consistently across all of them to avoid uncertainty. For more information, see <a
    /// href="https://docs.aws.amazon.com/batch/latest/userguide/eks-access-entries.html#eks-access-entries-reconciliation">Reconciling
    /// desiredState across compute environments</a> in the <i>Batch User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class EksAccessEntry
    {
        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The desired access entry state for the compute environment. Valid values:
        /// </para>
        ///  <dl> <dt>ENABLED</dt> <dd> 
        /// <para>
        /// Batch manages an access entry on the cluster for the compute environment.
        /// </para>
        ///  </dd> <dt>DISABLED</dt> <dd> 
        /// <para>
        /// Batch deletes the Batch-managed access entry for the cluster. This value is rejected
        /// if the cluster's <c>authenticationMode</c> is <c>API</c>, because such a cluster doesn't
        /// support the <c>aws-auth</c> ConfigMap.
        /// </para>
        ///  </dd> <dt>INHERIT_FROM_CLUSTER</dt> <dd> 
        /// <para>
        /// Batch defers to the cluster's current access entry <c>status</c>. On a cluster whose
        /// authentication mode is <c>API</c>, Batch creates and manages an access entry. On a
        /// cluster whose authentication mode is <c>API_AND_CONFIG_MAP</c> or <c>CONFIG_MAP</c>,
        /// Batch neither adds nor removes an access entry.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public EksAccessEntryDesiredState DesiredState { get; set; }

        /// <summary>
        /// Checks to see if the DesiredState property is set.
        /// </summary>
        internal bool IsSetDesiredState() => this.DesiredState != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The observed state of the access entry on the cluster. <c>ACTIVE</c> means that an
        /// access entry for the compute environment exists on the cluster and takes precedence
        /// over the <c>aws-auth</c> ConfigMap. <c>INACTIVE</c> means that no Batch-managed access
        /// entry is present. This is a read-only field returned by <c>DescribeComputeEnvironments</c>.
        /// </para>
        /// </summary>
        public EksAccessEntryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
