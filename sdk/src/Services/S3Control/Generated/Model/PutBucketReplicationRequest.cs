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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketReplication operation.
    /// <note> 
    /// <para>
    /// This action creates an Amazon S3 on Outposts bucket's replication configuration. To
    /// create an S3 bucket's replication configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketReplication.html">PutBucketReplication</a>
    /// in the <i>Amazon S3 API Reference</i>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates a replication configuration or replaces an existing one. For information about
    /// S3 replication on Outposts configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsReplication.html">Replicating
    /// objects for S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// It can take a while to propagate <code>PUT</code> or <code>DELETE</code> requests
    /// for a replication configuration to all S3 on Outposts systems. Therefore, the replication
    /// configuration that's returned by a <code>GET</code> request soon after a <code>PUT</code>
    /// or <code>DELETE</code> request might return a more recent result than what's on the
    /// Outpost. If an Outpost is offline, the delay in updating the replication configuration
    /// on that Outpost can be significant.
    /// </para>
    ///  </note> 
    /// <para>
    /// Specify the replication configuration in the request body. In the replication configuration,
    /// you provide the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The name of the destination bucket or buckets where you want S3 on Outposts to replicate
    /// objects
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Identity and Access Management (IAM) role that S3 on Outposts can assume to replicate
    /// objects on your behalf
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Other relevant information, such as replication rules
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A replication configuration must include at least one rule and can contain a maximum
    /// of 100. Each rule identifies a subset of objects to replicate by filtering the objects
    /// in the source Outposts bucket. To choose additional subsets of objects to replicate,
    /// add a rule for each subset.
    /// </para>
    ///  
    /// <para>
    /// To specify a subset of the objects in the source Outposts bucket to apply a replication
    /// rule to, add the <code>Filter</code> element as a child of the <code>Rule</code> element.
    /// You can filter objects based on an object key prefix, one or more object tags, or
    /// both. When you add the <code>Filter</code> element in the configuration, you must
    /// also add the following elements: <code>DeleteMarkerReplication</code>, <code>Status</code>,
    /// and <code>Priority</code>.
    /// </para>
    ///  
    /// <para>
    /// Using <code>PutBucketReplication</code> on Outposts requires that both the source
    /// and destination buckets must have versioning enabled. For information about enabling
    /// versioning on a bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsManagingVersioning.html">Managing
    /// S3 Versioning for your S3 on Outposts bucket</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about S3 on Outposts replication failure reasons, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/outposts-replication-eventbridge.html#outposts-replication-failure-codes">Replication
    /// failure reasons</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Handling Replication of Encrypted Objects</b> 
    /// </para>
    ///  
    /// <para>
    /// Outposts buckets are encrypted at all times. All the objects in the source Outposts
    /// bucket are encrypted and can be replicated. Also, all the replicas in the destination
    /// Outposts bucket are encrypted with the same encryption key as the objects in the source
    /// Outposts bucket.
    /// </para>
    ///  
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To create a <code>PutBucketReplication</code> request, you must have <code>s3-outposts:PutReplicationConfiguration</code>
    /// permissions for the bucket. The Outposts bucket owner has this permission by default
    /// and can grant it to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsIAM.html">Setting
    /// up IAM with S3 on Outposts</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsBucketPolicy.html">Managing
    /// access to S3 on Outposts buckets</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// To perform this operation, the user or role must also have the <code>iam:CreateRole</code>
    /// and <code>iam:PassRole</code> permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
    /// a user permissions to pass a role to an Amazon Web Services service</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// All Amazon S3 on Outposts REST API requests for this action require an additional
    /// parameter of <code>x-amz-outpost-id</code> to be passed with the request. In addition,
    /// you must use an S3 on Outposts endpoint hostname prefix instead of <code>s3-control</code>.
    /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
    /// Outposts endpoint hostname prefix and the <code>x-amz-outpost-id</code> derived by
    /// using the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketReplication.html#API_control_PutBucketReplication_Examples">Examples</a>
    /// section.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>PutBucketReplication</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketReplication.html">GetBucketReplication</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketReplication.html">DeleteBucketReplication</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketReplicationRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _bucket;
        private ReplicationConfiguration _replicationConfiguration;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the Outposts bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// Specifies the S3 on Outposts bucket to set the configuration for.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with Amazon S3 on Outposts with the REST API, you must specify
        /// the name and the x-amz-outpost-id as well.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with S3 on Outposts with the Amazon Web Services SDK and
        /// CLI, you must specify the ARN of the bucket accessed in the format <code>arn:aws:s3-outposts:&lt;Region&gt;:&lt;account-id&gt;:outpost/&lt;outpost-id&gt;/bucket/&lt;my-bucket-name&gt;</code>.
        /// For example, to access the bucket <code>reports</code> through Outpost <code>my-outpost</code>
        /// owned by account <code>123456789012</code> in Region <code>us-west-2</code>, use the
        /// URL encoding of <code>arn:aws:s3-outposts:us-west-2:123456789012:outpost/my-outpost/bucket/reports</code>.
        /// The value must be URL encoded. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfiguration.
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