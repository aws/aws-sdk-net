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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// This is the response object from the DescribeReplicationConfigurations operation.
    /// </summary>
    public partial class DescribeReplicationConfigurationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ReplicationConfigurationDescription> _replications = new List<ReplicationConfigurationDescription>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// You can use the <code>NextToken</code> from the previous response in a subsequent
        /// request to fetch the additional descriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Replications. 
        /// <para>
        /// The collection of replication configurations that is returned.
        /// </para>
        /// </summary>
        public List<ReplicationConfigurationDescription> Replications
        {
            get { return this._replications; }
            set { this._replications = value; }
        }

        // Check to see if Replications property is set
        internal bool IsSetReplications()
        {
            return this._replications != null && this._replications.Count > 0; 
        }

    }
}