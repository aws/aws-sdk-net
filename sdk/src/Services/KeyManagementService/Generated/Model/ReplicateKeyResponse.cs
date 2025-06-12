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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
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
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the ReplicateKey operation.
    /// </summary>
    public partial class ReplicateKeyResponse : AmazonWebServiceResponse
    {
        private KeyMetadata _replicaKeyMetadata;
        private string _replicaPolicy;
        private List<Tag> _replicaTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ReplicaKeyMetadata. 
        /// <para>
        /// Displays details about the new replica key, including its Amazon Resource Name (<a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">key
        /// ARN</a>) and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a>. It also includes the ARN and Amazon Web Services Region of
        /// its primary key and other replica keys.
        /// </para>
        /// </summary>
        public KeyMetadata ReplicaKeyMetadata
        {
            get { return this._replicaKeyMetadata; }
            set { this._replicaKeyMetadata = value; }
        }

        // Check to see if ReplicaKeyMetadata property is set
        internal bool IsSetReplicaKeyMetadata()
        {
            return this._replicaKeyMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaPolicy. 
        /// <para>
        /// The key policy of the new replica key. The value is a key policy document in JSON
        /// format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string ReplicaPolicy
        {
            get { return this._replicaPolicy; }
            set { this._replicaPolicy = value; }
        }

        // Check to see if ReplicaPolicy property is set
        internal bool IsSetReplicaPolicy()
        {
            return this._replicaPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaTags. 
        /// <para>
        /// The tags on the new replica key. The value is a list of tag key and tag value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> ReplicaTags
        {
            get { return this._replicaTags; }
            set { this._replicaTags = value; }
        }

        // Check to see if ReplicaTags property is set
        internal bool IsSetReplicaTags()
        {
            return this._replicaTags != null && (this._replicaTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}