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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the PutReplicationConfiguration operation.
    /// Creates or updates the replication configuration for a registry. The existing replication
    /// configuration for a repository can be retrieved with the <a>DescribeRegistry</a> API
    /// action. The first time the PutReplicationConfiguration API is called, a service-linked
    /// IAM role is created in your account for the replication process. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/using-service-linked-roles.html">Using
    /// service-linked roles for Amazon ECR</a> in the <i>Amazon Elastic Container Registry
    /// User Guide</i>. For more information on the custom role for replication, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/replication-creation-templates.html#roles-creatingrole-user-console">Creating
    /// an IAM role for replication</a>.
    /// 
    ///  <note> 
    /// <para>
    /// When configuring cross-account replication, the destination account must grant the
    /// source account permission to replicate. This permission is controlled using a registry
    /// permissions policy. For more information, see <a>PutRegistryPolicy</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutReplicationConfigurationRequest : AmazonECRRequest
    {
        private ReplicationConfiguration _replicationConfiguration;

        /// <summary>
        /// Gets and sets the property ReplicationConfiguration. 
        /// <para>
        /// An object representing the replication configuration for a registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicationConfiguration ReplicationConfiguration
        {
            get { return this._replicationConfiguration; }
            set { this._replicationConfiguration = value; }
        }

        // Check to see if ReplicationConfiguration property is set
        internal bool IsSetReplicationConfiguration()
        {
            return this._replicationConfiguration != null;
        }

    }
}