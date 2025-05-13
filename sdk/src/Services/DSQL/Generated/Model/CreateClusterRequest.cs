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
    /// This operation creates a cluster in Amazon Aurora DSQL. You need the following permissions
    /// to use this operation.
    /// 
    ///  
    /// <para>
    /// Permission to create a cluster.
    /// </para>
    ///  <dl> <dt>dsql:CreateCluster</dt> <dd> 
    /// <para>
    /// Resources: arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/*
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    ///  Permission to add tags to a resource.
    /// </para>
    ///  <dl> <dt>dsql:TagResource</dt> <dd> 
    /// <para>
    /// Resources: arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/*
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// Permission to configure multi-region properties for a cluster.
    /// </para>
    ///  <dl> <dt>dsql:PutMultiRegionProperties</dt> <dd> 
    /// <para>
    /// Resources: arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/*
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// When specifying multiRegionProperties.clusters.
    /// </para>
    ///  <dl> <dt>dsql:AddPeerCluster</dt> <dd> 
    /// <para>
    /// Permission to add peer clusters.
    /// </para>
    ///  
    /// <para>
    /// Resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Local cluster: arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/*
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each peer cluster: exact ARN of each specified peer cluster
    /// </para>
    ///  </li> </ul> </dd> </dl> 
    /// <para>
    /// When specifying multiRegionProperties.witnessRegion.
    /// </para>
    ///  <dl> <dt>dsql:PutWitnessRegion</dt> <dd> 
    /// <para>
    /// Permission to set a witness region.
    /// </para>
    ///  
    /// <para>
    /// Resources: arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/*
    /// </para>
    ///  
    /// <para>
    /// Condition Keys: <c>dsql:WitnessRegion</c> (matching the specified witness region)
    /// </para>
    ///  <note> 
    /// <para>
    /// This permission is checked both in the cluster Region and in the witness Region.
    /// </para>
    ///  </note> </dd> </dl> <important> 
    /// <para>
    ///  <b>Important Notes for Multi-Region Operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The witness region specified in <c>multiRegionProperties.witnessRegion</c> cannot
    /// be the same as the cluster's Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When updating clusters with peer relationships, permissions are checked for both adding
    /// and removing peers.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class CreateClusterRequest : AmazonDSQLRequest
    {
        private string _clientToken;
        private bool? _deletionProtectionEnabled;
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
        public bool DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled.GetValueOrDefault(); }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
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