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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReplicationConfigurationTemplates operation.
    /// Lists all ReplicationConfigurationTemplates, filtered by Source Server IDs.
    /// </summary>
    public partial class DescribeReplicationConfigurationTemplatesRequest : AmazonDrsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _replicationConfigurationTemplateIDs = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of Replication Configuration Templates to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token of the next Replication Configuration Template to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property ReplicationConfigurationTemplateIDs. 
        /// <para>
        /// The IDs of the Replication Configuration Templates to retrieve. An empty list means
        /// all Replication Configuration Templates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> ReplicationConfigurationTemplateIDs
        {
            get { return this._replicationConfigurationTemplateIDs; }
            set { this._replicationConfigurationTemplateIDs = value; }
        }

        /// <summary>
        /// This property is set to true if the property <seealso cref="ReplicationConfigurationTemplateIDs"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsReplicationConfigurationTemplateIDsSet
        {
            get
            {
                return Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._replicationConfigurationTemplateIDs);
            }
            set
            {
                Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._replicationConfigurationTemplateIDs);
            }
        }

        // Check to see if ReplicationConfigurationTemplateIDs property is set
        internal bool IsSetReplicationConfigurationTemplateIDs()
        {
            return this.IsReplicationConfigurationTemplateIDsSet; 
        }

    }
}