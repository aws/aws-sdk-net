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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the CreateClusterV2 operation.
    /// Creates a new MSK cluster.
    /// </summary>
    public partial class CreateClusterV2Request : AmazonKafkaRequest
    {
        private string _clusterName;
        private ProvisionedRequest _provisioned;
        private ServerlessRequest _serverless;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterName.             
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Provisioned.             
        /// <para>
        /// Information about the provisioned cluster.
        /// </para>
        /// </summary>
        public ProvisionedRequest Provisioned
        {
            get { return this._provisioned; }
            set { this._provisioned = value; }
        }

        // Check to see if Provisioned property is set
        internal bool IsSetProvisioned()
        {
            return this._provisioned != null;
        }

        /// <summary>
        /// Gets and sets the property Serverless.             
        /// <para>
        /// Information about the serverless cluster.
        /// </para>
        /// </summary>
        public ServerlessRequest Serverless
        {
            get { return this._serverless; }
            set { this._serverless = value; }
        }

        // Check to see if Serverless property is set
        internal bool IsSetServerless()
        {
            return this._serverless != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.             
        /// <para>
        /// A map of tags that you want the cluster to have.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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