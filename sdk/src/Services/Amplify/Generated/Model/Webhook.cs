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
    /// Describes a webhook that connects repository events to an Amplify app.
    /// </summary>
    public partial class Webhook
    {
        private string _appId;
        private string _branchName;
        private DateTime? _createTime;
        private string _description;
        private DateTime? _updateTime;
        private string _webhookArn;
        private string _webhookId;
        private string _webhookUrl;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID of an Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name for a branch that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// A timestamp of when Amplify created the webhook in your Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for a webhook. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// A timestamp of when Amplify updated the webhook in your Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WebhookArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the webhook. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string WebhookArn
        {
            get { return this._webhookArn; }
            set { this._webhookArn = value; }
        }

        // Check to see if WebhookArn property is set
        internal bool IsSetWebhookArn()
        {
            return this._webhookArn != null;
        }

        /// <summary>
        /// Gets and sets the property WebhookId. 
        /// <para>
        /// The ID of the webhook. 
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

        /// <summary>
        /// Gets and sets the property WebhookUrl. 
        /// <para>
        /// The URL of the webhook. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string WebhookUrl
        {
            get { return this._webhookUrl; }
            set { this._webhookUrl = value; }
        }

        // Check to see if WebhookUrl property is set
        internal bool IsSetWebhookUrl()
        {
            return this._webhookUrl != null;
        }

    }
}