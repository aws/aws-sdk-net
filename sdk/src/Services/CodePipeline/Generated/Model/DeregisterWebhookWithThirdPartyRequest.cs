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
    /// Container for the parameters to the DeregisterWebhookWithThirdParty operation.
    /// Removes the connection between the webhook that was created by CodePipeline and the
    /// external tool with events to be detected. Currently supported only for webhooks that
    /// target an action type of GitHub.
    /// </summary>
    public partial class DeregisterWebhookWithThirdPartyRequest : AmazonCodePipelineRequest
    {
        private string _webhookName;

        /// <summary>
        /// Gets and sets the property WebhookName. 
        /// <para>
        /// The name of the webhook you want to deregister.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string WebhookName
        {
            get { return this._webhookName; }
            set { this._webhookName = value; }
        }

        // Check to see if WebhookName property is set
        internal bool IsSetWebhookName()
        {
            return this._webhookName != null;
        }

    }
}