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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReplicationConfigurationTemplates operation.
    /// Lists all ReplicationConfigurationTemplates, filtered by Source Server IDs.
    /// </summary>
    public partial class DescribeReplicationConfigurationTemplatesRequest : AmazonDrsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of Replication Configuration Templates to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token of the next Replication Configuration Template to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        private List<string> _ReplicationConfigurationTemplateIDs = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ReplicationConfigurationTemplateIDs. 
        /// <para>
        /// The IDs of the Replication Configuration Templates to retrieve. An empty list means
        /// all Replication Configuration Templates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<string> ReplicationConfigurationTemplateIDs { get => this._ReplicationConfigurationTemplateIDs; set => this._ReplicationConfigurationTemplateIDs = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="ReplicationConfigurationTemplateIDs"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="ReplicationConfigurationTemplateIDs"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsReplicationConfigurationTemplateIDsSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._ReplicationConfigurationTemplateIDs);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._ReplicationConfigurationTemplateIDs);
        }

        /// <summary>
        /// Checks to see if the ReplicationConfigurationTemplateIDs property is set.
        /// </summary>
        internal bool IsSetReplicationConfigurationTemplateIDs() => this.IsReplicationConfigurationTemplateIDsSet;
    }
}
