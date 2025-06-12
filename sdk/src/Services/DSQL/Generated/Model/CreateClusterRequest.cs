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
    /// Container for the parameters to the CreateCluster operation.
    /// The CreateCluster API allows you to create both single-region clusters and multi-Region
    /// clusters. With the addition of the <i>multiRegionProperties</i> parameter, you can
    /// create a cluster with witness Region support and establish peer relationships with
    /// clusters in other Regions during creation.
    /// 
    ///  <note> 
    /// <para>
    /// Creating multi-Region clusters requires additional IAM permissions beyond those needed
    /// for single-Region clusters, as detailed in the <b>Required permissions</b> section
    /// below.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Required permissions</b> 
    /// </para>
    ///  <dl> <dt>dsql:CreateCluster</dt> <dd> 
    /// <para>
    /// Required to create a cluster.
    /// </para>
    ///  
    /// <para>
    /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
    /// </para>
    ///  </dd> <dt>dsql:TagResource</dt> <dd> 
    /// <para>
    /// Permission to add tags to a resource.
    /// </para>
    ///  
    /// <para>
    /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
    /// </para>
    ///  </dd> <dt>dsql:PutMultiRegionProperties</dt> <dd> 
    /// <para>
    /// Permission to configure multi-region properties for a cluster.
    /// </para>
    ///  
    /// <para>
    /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
    /// </para>
    ///  </dd> <dt>dsql:AddPeerCluster</dt> <dd> 
    /// <para>
    /// When specifying <c>multiRegionProperties.clusters</c>, permission to add peer clusters.
    /// </para>
    ///  
    /// <para>
    /// Resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Local cluster: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each peer cluster: exact ARN of each specified peer cluster
    /// </para>
    ///  </li> </ul> </dd> <dt>dsql:PutWitnessRegion</dt> <dd> 
    /// <para>
    /// When specifying <c>multiRegionProperties.witnessRegion</c>, permission to set a witness
    /// Region. This permission is checked both in the cluster Region and in the witness Region.
    /// </para>
    ///  
    /// <para>
    /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
    /// </para>
    ///  
    /// <para>
    /// Condition Keys: <c>dsql:WitnessRegion</c> (matching the specified witness region)
    /// </para>
    ///  </dd> </dl> <important> <ul> <li> 
    /// <para>
    /// The witness Region specified in <c>multiRegionProperties.witnessRegion</c> cannot
    /// be the same as the cluster's Region.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class CreateClusterRequest : AmazonDSQLRequest
    {
        private string _clientToken;
        private bool? _deletionProtectionEnabled;
        private string _kmsEncryptionKey;
        private MultiRegionProperties _multiRegionProperties;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// If enabled, you can't delete your cluster. You must first disable this property before
        /// you can delete your cluster.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled; }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsEncryptionKey. 
        /// <para>
        /// The KMS key that encrypts and protects the data on your cluster. You can specify the
        /// ARN, ID, or alias of an existing key or have Amazon Web Services create a default
        /// key for you.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsEncryptionKey
        {
            get { return this._kmsEncryptionKey; }
            set { this._kmsEncryptionKey = value; }
        }

        // Check to see if KmsEncryptionKey property is set
        internal bool IsSetKmsEncryptionKey()
        {
            return this._kmsEncryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionProperties. 
        /// <para>
        /// The configuration settings when creating a multi-Region cluster, including the witness
        /// region and linked cluster properties.
        /// </para>
        /// </summary>
        public MultiRegionProperties MultiRegionProperties
        {
            get { return this._multiRegionProperties; }
            set { this._multiRegionProperties = value; }
        }

        // Check to see if MultiRegionProperties property is set
        internal bool IsSetMultiRegionProperties()
        {
            return this._multiRegionProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key and value pairs to use to tag your cluster.
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

    }
}