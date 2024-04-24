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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the RejectInboundCrossClusterSearchConnection operation.
    /// Allows the destination domain owner to reject an inbound cross-cluster search connection
    /// request.
    /// </summary>
    public partial class RejectInboundCrossClusterSearchConnectionRequest : AmazonElasticsearchRequest
    {
        private string _crossClusterSearchConnectionId;

        /// <summary>
        /// Gets and sets the property CrossClusterSearchConnectionId. 
        /// <para>
        /// The id of the inbound connection that you want to reject.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CrossClusterSearchConnectionId
        {
            get { return this._crossClusterSearchConnectionId; }
            set { this._crossClusterSearchConnectionId = value; }
        }

        // Check to see if CrossClusterSearchConnectionId property is set
        internal bool IsSetCrossClusterSearchConnectionId()
        {
            return this._crossClusterSearchConnectionId != null;
        }

    }
}