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
    /// Represents information about a webhook and its definition.
    /// </summary>
    public partial class WebhookDefinition
    {
        private WebhookAuthenticationType _authentication;
        private WebhookAuthConfiguration _authenticationConfiguration;
        private List<WebhookFilterRule> _filters = AWSConfigs.InitializeCollections ? new List<WebhookFilterRule>() : null;
        private string _name;
        private string _targetAction;
        private string _targetPipeline;

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// Supported options are GITHUB_HMAC, IP, and UNAUTHENTICATED.
        /// </para>
        ///  <important> 
        /// <para>
        /// When creating CodePipeline webhooks, do not use your own credentials or reuse the
        /// same secret token across multiple webhooks. For optimal security, generate a unique
        /// secret token for each webhook you create. The secret token is an arbitrary string
        /// that you provide, which GitHub uses to compute and sign the webhook payloads sent
        /// to CodePipeline, for protecting the integrity and authenticity of the webhook payloads.
        /// Using your own credentials or reusing the same token across multiple webhooks can
        /// lead to security vulnerabilities.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// If a secret token was provided, it will be redacted in the response.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// For information about the authentication scheme implemented by GITHUB_HMAC, see <a
        /// href="https://developer.github.com/webhooks/securing/">Securing your webhooks</a>
        /// on the GitHub Developer website.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  IP rejects webhooks trigger requests unless they originate from an IP address in
        /// the IP range whitelisted in the authentication configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  UNAUTHENTICATED accepts all webhook trigger requests regardless of origin.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public WebhookAuthenticationType Authentication
        {
            get { return this._authentication; }
            set { this._authentication = value; }
        }

        // Check to see if Authentication property is set
        internal bool IsSetAuthentication()
        {
            return this._authentication != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// Properties that configure the authentication applied to incoming webhook trigger requests.
        /// The required properties depend on the authentication type. For GITHUB_HMAC, only the
        /// <c>SecretToken </c>property must be set. For IP, only the <c>AllowedIPRange </c>property
        /// must be set to a valid CIDR range. For UNAUTHENTICATED, no properties can be set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WebhookAuthConfiguration AuthenticationConfiguration
        {
            get { return this._authenticationConfiguration; }
            set { this._authenticationConfiguration = value; }
        }

        // Check to see if AuthenticationConfiguration property is set
        internal bool IsSetAuthenticationConfiguration()
        {
            return this._authenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of rules applied to the body/payload sent in the POST request to a webhook
        /// URL. All defined rules must pass for the request to be accepted and the pipeline started.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=5)]
        public List<WebhookFilterRule> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the webhook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAction. 
        /// <para>
        /// The name of the action in a pipeline you want to connect to the webhook. The action
        /// must be from the source (first) stage of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TargetAction
        {
            get { return this._targetAction; }
            set { this._targetAction = value; }
        }

        // Check to see if TargetAction property is set
        internal bool IsSetTargetAction()
        {
            return this._targetAction != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPipeline. 
        /// <para>
        /// The name of the pipeline you want to connect to the webhook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TargetPipeline
        {
            get { return this._targetPipeline; }
            set { this._targetPipeline = value; }
        }

        // Check to see if TargetPipeline property is set
        internal bool IsSetTargetPipeline()
        {
            return this._targetPipeline != null;
        }

    }
}