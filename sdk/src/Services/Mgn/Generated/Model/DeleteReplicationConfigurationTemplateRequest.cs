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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteReplicationConfigurationTemplate operation.
    /// Deletes a single Replication Configuration Template by ID
    /// </summary>
    public partial class DeleteReplicationConfigurationTemplateRequest : AmazonMgnRequest
    {
        private string _replicationConfigurationTemplateID;

        /// <summary>
        /// Gets and sets the property ReplicationConfigurationTemplateID. 
        /// <para>
        /// Request to delete Replication Configuration Template from service by Replication Configuration
        /// Template ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string ReplicationConfigurationTemplateID
        {
            get { return this._replicationConfigurationTemplateID; }
            set { this._replicationConfigurationTemplateID = value; }
        }

        // Check to see if ReplicationConfigurationTemplateID property is set
        internal bool IsSetReplicationConfigurationTemplateID()
        {
            return this._replicationConfigurationTemplateID != null;
        }

    }
}