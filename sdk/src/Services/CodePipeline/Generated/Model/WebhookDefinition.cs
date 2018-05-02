/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about a webhook and its definition.
    /// </summary>
    public partial class WebhookDefinition
    {
        private WebhookAuthenticationType _authentication;
        private WebhookAuthConfiguration _authenticationConfiguration;
        private List<WebhookFilterRule> _filters = new List<WebhookFilterRule>();
        private string _name;
        private string _targetAction;
        private string _targetPipeline;

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// Supported options are GITHUB_HMAC, IP and UNAUTHENTICATED.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  GITHUB_HMAC implements the authentication scheme described here: https://developer.github.com/webhooks/securing/
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  IP will reject webhooks trigger requests unless they originate from an IP within
        /// the IP range whitelisted in the authentication configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  UNAUTHENTICATED will accept all webhook trigger requests regardless of origin.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// SecretToken property must be set. For IP, only the AllowedIPRange property must be
        /// set to a valid CIDR range. For UNAUTHENTICATED, no properties can be set.
        /// </para>
        /// </summary>
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
        /// </summary>
        public List<WebhookFilterRule> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the webhook.
        /// </para>
        /// </summary>
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