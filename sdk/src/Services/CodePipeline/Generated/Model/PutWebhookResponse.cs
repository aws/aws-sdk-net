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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// This is the response object from the PutWebhook operation.
    /// </summary>
    public partial class PutWebhookResponse : AmazonWebServiceResponse
    {
        private ListWebhookItem _webhook;

        /// <summary>
        /// Gets and sets the property Webhook. 
        /// <para>
        /// The detail returned from creating the webhook, such as the webhook name, webhook URL,
        /// and webhook ARN.
        /// </para>
        /// </summary>
        public ListWebhookItem Webhook
        {
            get { return this._webhook; }
            set { this._webhook = value; }
        }

        // Check to see if Webhook property is set
        internal bool IsSetWebhook()
        {
            return this._webhook != null;
        }

    }
}