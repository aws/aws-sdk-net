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

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes a webhook that connects repository events to an Amplify app.
    /// </summary>
    public partial class Webhook
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID of an Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name for a branch that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string BranchName { get; set; }

        /// <summary>
        /// Checks to see if the BranchName property is set.
        /// </summary>
        internal bool IsSetBranchName() => this.BranchName != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// A timestamp of when Amplify created the webhook in your Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for a webhook. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// A timestamp of when Amplify updated the webhook in your Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property WebhookArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the webhook. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string WebhookArn { get; set; }

        /// <summary>
        /// Checks to see if the WebhookArn property is set.
        /// </summary>
        internal bool IsSetWebhookArn() => this.WebhookArn != null;

        /// <summary>
        /// Gets and sets the property WebhookId. 
        /// <para>
        /// The ID of the webhook. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string WebhookId { get; set; }

        /// <summary>
        /// Checks to see if the WebhookId property is set.
        /// </summary>
        internal bool IsSetWebhookId() => this.WebhookId != null;

        /// <summary>
        /// Gets and sets the property WebhookUrl. 
        /// <para>
        /// The URL of the webhook. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebhookUrl property is set.
        /// </summary>
        internal bool IsSetWebhookUrl() => this.WebhookUrl != null;
    }
}
