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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// This is the response object from the GetReplicationSet operation.
    /// </summary>
    public partial class GetReplicationSetResponse : AmazonWebServiceResponse
    {
        private ReplicationSet _replicationSet;

        /// <summary>
        /// Gets and sets the property ReplicationSet. 
        /// <para>
        /// Details of the replication set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicationSet ReplicationSet
        {
            get { return this._replicationSet; }
            set { this._replicationSet = value; }
        }

        // Check to see if ReplicationSet property is set
        internal bool IsSetReplicationSet()
        {
            return this._replicationSet != null;
        }

    }
}