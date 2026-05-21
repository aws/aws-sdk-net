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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
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
namespace Amazon.DSQL.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStream operation.
    /// Creates a new change data capture (CDC) stream for a cluster. The stream captures
    /// database changes and delivers them to the specified target destination.
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions</b> 
    /// </para>
    ///  <dl> <dt>dsql:CreateStream</dt> <dd> 
    /// <para>
    /// Permission to create a new stream.
    /// </para>
    ///  
    /// <para>
    /// Resources: <c>arn:aws:dsql:region:account-id:cluster/cluster-id</c> 
    /// </para>
    ///  </dd> <dt>iam:PassRole</dt> <dd> 
    /// <para>
    /// Permission to pass the IAM role specified in the target definition to the service.
    /// </para>
    ///  
    /// <para>
    /// Resources: ARN of the IAM role specified in <c>targetDefinition.kinesis.roleArn</c>
    /// 
    /// </para>
    ///  </dd> <dt>kms:Decrypt</dt> <dd> 
    /// <para>
    /// Required when the cluster uses a customer managed KMS key (CMK). Permission to decrypt
    /// data using the cluster's CMK.
    /// </para>
    ///  
    /// <para>
    /// Resources: ARN of the KMS key used by the cluster
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class CreateStreamRequest : AmazonDSQLRequest
    {
        private string _clientToken;
        private string _clusterIdentifier;
        private StreamFormat _format;
        private StreamOrdering _ordering;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TargetDefinition _targetDefinition;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully, the subsequent
        /// retries with the same client token return the result from the original successful
        /// request and they have no additional effect.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a client token, the Amazon Web Services SDK automatically generates
        /// one.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The ID of the cluster for which to create the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the stream records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Ordering. 
        /// <para>
        /// The ordering mode for the stream. Determines how change events are ordered when delivered
        /// to the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamOrdering Ordering
        {
            get { return this._ordering; }
            set { this._ordering = value; }
        }

        // Check to see if Ordering property is set
        internal bool IsSetOrdering()
        {
            return this._ordering != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key and value pairs to use to tag your stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetDefinition. 
        /// <para>
        /// The target destination configuration for the stream. Contains Kinesis stream configuration
        /// including stream ARN and IAM role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetDefinition TargetDefinition
        {
            get { return this._targetDefinition; }
            set { this._targetDefinition = value; }
        }

        // Check to see if TargetDefinition property is set
        internal bool IsSetTargetDefinition()
        {
            return this._targetDefinition != null;
        }

    }
}