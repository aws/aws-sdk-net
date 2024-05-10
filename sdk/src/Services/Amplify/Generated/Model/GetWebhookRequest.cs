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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the GetWebhook operation.
    /// Returns the webhook information that corresponds to a specified webhook ID.
    /// </summary>
    public partial class GetWebhookRequest : AmazonAmplifyRequest
    {
        private string _webhookId;

        /// <summary>
        /// Gets and sets the property WebhookId. 
        /// <para>
        /// The unique ID for a webhook. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string WebhookId
        {
            get { return this._webhookId; }
            set { this._webhookId = value; }
        }

        // Check to see if WebhookId property is set
        internal bool IsSetWebhookId()
        {
            return this._webhookId != null;
        }

    }
}