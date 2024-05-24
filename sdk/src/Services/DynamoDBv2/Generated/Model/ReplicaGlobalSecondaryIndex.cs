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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the properties of a replica global secondary index.
    /// </summary>
    public partial class ReplicaGlobalSecondaryIndex
    {
        private string _indexName;
        private OnDemandThroughputOverride _onDemandThroughputOverride;
        private ProvisionedThroughputOverride _provisionedThroughputOverride;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the global secondary index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandThroughputOverride. 
        /// <para>
        /// Overrides the maximum on-demand throughput settings for the specified global secondary
        /// index in the specified replica table.
        /// </para>
        /// </summary>
        public OnDemandThroughputOverride OnDemandThroughputOverride
        {
            get { return this._onDemandThroughputOverride; }
            set { this._onDemandThroughputOverride = value; }
        }

        // Check to see if OnDemandThroughputOverride property is set
        internal bool IsSetOnDemandThroughputOverride()
        {
            return this._onDemandThroughputOverride != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedThroughputOverride. 
        /// <para>
        /// Replica table GSI-specific provisioned throughput. If not specified, uses the source
        /// table GSI's read capacity settings.
        /// </para>
        /// </summary>
        public ProvisionedThroughputOverride ProvisionedThroughputOverride
        {
            get { return this._provisionedThroughputOverride; }
            set { this._provisionedThroughputOverride = value; }
        }

        // Check to see if ProvisionedThroughputOverride property is set
        internal bool IsSetProvisionedThroughputOverride()
        {
            return this._provisionedThroughputOverride != null;
        }

    }
}