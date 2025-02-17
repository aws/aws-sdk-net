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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateKeyspace operation.
    /// Adds a new Amazon Web Services Region to the keyspace. You can add a new Region to
    /// a keyspace that is either a single or a multi-Region keyspace. Amazon Keyspaces is
    /// going to replicate all tables in the keyspace to the new Region. To successfully replicate
    /// all tables to the new Region, they must use client-side timestamps for conflict resolution.
    /// To enable client-side timestamps, specify <c>clientSideTimestamps.status = enabled</c>
    /// when invoking the API. For more information about client-side timestamps, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/client-side-timestamps.html">Client-side
    /// timestamps in Amazon Keyspaces</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// To add a Region to a keyspace using the <c>UpdateKeyspace</c> API, the IAM principal
    /// needs permissions for the following IAM actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>cassandra:Alter</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cassandra:AlterMultiRegionResource</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cassandra:Create</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cassandra:CreateMultiRegionResource</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cassandra:Select</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cassandra:SelectMultiRegionResource</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cassandra:Modify</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cassandra:ModifyMultiRegionResource</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the keyspace contains a table that is configured in provisioned mode with auto
    /// scaling enabled, the following additional IAM actions need to be allowed.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>application-autoscaling:RegisterScalableTarget</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>application-autoscaling:DeregisterScalableTarget</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>application-autoscaling:DescribeScalableTargets</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>application-autoscaling:PutScalingPolicy</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>application-autoscaling:DescribeScalingPolicies</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To use the <c>UpdateKeyspace</c> API, the IAM principal also needs permissions to
    /// create a service-linked role with the following elements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>iam:CreateServiceLinkedRole</c> - The <b>action</b> the principal can perform.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>arn:aws:iam::*:role/aws-service-role/replication.cassandra.amazonaws.com/AWSServiceRoleForKeyspacesReplication</c>
    /// - The <b>resource</b> that the action can be performed on. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>iam:AWSServiceName: replication.cassandra.amazonaws.com</c> - The only Amazon
    /// Web Services service that this role can be attached to is Amazon Keyspaces.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/howitworks_replication_permissions_addReplica.html">Configure
    /// the IAM permissions required to add an Amazon Web Services Region to a keyspace</a>
    /// in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateKeyspaceRequest : AmazonKeyspacesRequest
    {
        private ClientSideTimestamps _clientSideTimestamps;
        private string _keyspaceName;
        private ReplicationSpecification _replicationSpecification;

        /// <summary>
        /// Gets and sets the property ClientSideTimestamps.
        /// </summary>
        public ClientSideTimestamps ClientSideTimestamps
        {
            get { return this._clientSideTimestamps; }
            set { this._clientSideTimestamps = value; }
        }

        // Check to see if ClientSideTimestamps property is set
        internal bool IsSetClientSideTimestamps()
        {
            return this._clientSideTimestamps != null;
        }

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        ///  The name of the keyspace. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationSpecification.
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicationSpecification ReplicationSpecification
        {
            get { return this._replicationSpecification; }
            set { this._replicationSpecification = value; }
        }

        // Check to see if ReplicationSpecification property is set
        internal bool IsSetReplicationSpecification()
        {
            return this._replicationSpecification != null;
        }

    }
}