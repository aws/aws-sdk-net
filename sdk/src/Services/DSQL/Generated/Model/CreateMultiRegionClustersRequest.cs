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
    /// Container for the parameters to the CreateMultiRegionClusters operation.
    /// Creates multi-Region clusters in Amazon Aurora DSQL. Multi-Region clusters require
    /// a linked Region list, which is an array of the Regions in which you want to create
    /// linked clusters. Multi-Region clusters require a witness Region, which participates
    /// in quorum in failure scenarios.
    /// </summary>
    public partial class CreateMultiRegionClustersRequest : AmazonDSQLRequest
    {
        private string _clientToken;
        private Dictionary<string, LinkedClusterProperties> _clusterProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, LinkedClusterProperties>() : null;
        private List<string> _linkedRegionList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _witnessRegion;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully. The subsequent
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
        /// Gets and sets the property ClusterProperties. 
        /// <para>
        /// A mapping of properties to use when creating linked clusters.
        /// </para>
        /// </summary>
        public Dictionary<string, LinkedClusterProperties> ClusterProperties
        {
            get { return this._clusterProperties; }
            set { this._clusterProperties = value; }
        }

        // Check to see if ClusterProperties property is set
        internal bool IsSetClusterProperties()
        {
            return this._clusterProperties != null && (this._clusterProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LinkedRegionList. 
        /// <para>
        /// An array of the Regions in which you want to create additional clusters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> LinkedRegionList
        {
            get { return this._linkedRegionList; }
            set { this._linkedRegionList = value; }
        }

        // Check to see if LinkedRegionList property is set
        internal bool IsSetLinkedRegionList()
        {
            return this._linkedRegionList != null && (this._linkedRegionList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WitnessRegion. 
        /// <para>
        /// The witness Region of multi-Region clusters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public string WitnessRegion
        {
            get { return this._witnessRegion; }
            set { this._witnessRegion = value; }
        }

        // Check to see if WitnessRegion property is set
        internal bool IsSetWitnessRegion()
        {
            return this._witnessRegion != null;
        }

    }
}