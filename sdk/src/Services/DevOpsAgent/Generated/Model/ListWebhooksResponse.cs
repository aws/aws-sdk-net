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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Output containing a list of service association webhooks.
    /// </summary>
    public partial class ListWebhooksResponse : AmazonWebServiceResponse
    {
        private List<Webhook> _webhooks = AWSConfigs.InitializeCollections ? new List<Webhook>() : null;

        /// <summary>
        /// Gets and sets the property Webhooks. 
        /// <para>
        /// The list of association webhooks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Webhook> Webhooks
        {
            get { return this._webhooks; }
            set { this._webhooks = value; }
        }

        // Check to see if Webhooks property is set
        internal bool IsSetWebhooks()
        {
            return this._webhooks != null && (this._webhooks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}