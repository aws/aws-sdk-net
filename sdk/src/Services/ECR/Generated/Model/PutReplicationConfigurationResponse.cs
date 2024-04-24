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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the PutReplicationConfiguration operation.
    /// </summary>
    public partial class PutReplicationConfigurationResponse : AmazonWebServiceResponse
    {
        private ReplicationConfiguration _replicationConfiguration;

        /// <summary>
        /// Gets and sets the property ReplicationConfiguration. 
        /// <para>
        /// The contents of the replication configuration for the registry.
        /// </para>
        /// </summary>
        public ReplicationConfiguration ReplicationConfiguration
        {
            get { return this._replicationConfiguration; }
            set { this._replicationConfiguration = value; }
        }

        // Check to see if ReplicationConfiguration property is set
        internal bool IsSetReplicationConfiguration()
        {
            return this._replicationConfiguration != null;
        }

    }
}