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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about an action.
    /// 
    ///  
    /// <para>
    /// Each rule must include exactly one of the following types of actions: <c>forward</c>,
    /// <c>fixed-response</c>, or <c>redirect</c>, and it must be the last action to be performed.
    /// </para>
    /// </summary>
    public partial class Action
    {
        private AuthenticateCognitoActionConfig _authenticateCognitoConfig;
        private AuthenticateOidcActionConfig _authenticateOidcConfig;
        private FixedResponseActionConfig _fixedResponseConfig;
        private ForwardActionConfig _forwardConfig;
        private int? _order;
        private RedirectActionConfig _redirectConfig;
        private string _targetGroupArn;
        private ActionTypeEnum _type;

        /// <summary>
        /// Gets and sets the property AuthenticateCognitoConfig. 
        /// <para>
        /// [HTTPS listeners] Information for using Amazon Cognito to authenticate users. Specify
        /// only when <c>Type</c> is <c>authenticate-cognito</c>.
        /// </para>
        /// </summary>
        public AuthenticateCognitoActionConfig AuthenticateCognitoConfig
        {
            get { return this._authenticateCognitoConfig; }
            set { this._authenticateCognitoConfig = value; }
        }

        // Check to see if AuthenticateCognitoConfig property is set
        internal bool IsSetAuthenticateCognitoConfig()
        {
            return this._authenticateCognitoConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticateOidcConfig. 
        /// <para>
        /// [HTTPS listeners] Information about an identity provider that is compliant with OpenID
        /// Connect (OIDC). Specify only when <c>Type</c> is <c>authenticate-oidc</c>.
        /// </para>
        /// </summary>
        public AuthenticateOidcActionConfig AuthenticateOidcConfig
        {
            get { return this._authenticateOidcConfig; }
            set { this._authenticateOidcConfig = value; }
        }

        // Check to see if AuthenticateOidcConfig property is set
        internal bool IsSetAuthenticateOidcConfig()
        {
            return this._authenticateOidcConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FixedResponseConfig. 
        /// <para>
        /// [Application Load Balancer] Information for creating an action that returns a custom
        /// HTTP response. Specify only when <c>Type</c> is <c>fixed-response</c>.
        /// </para>
        /// </summary>
        public FixedResponseActionConfig FixedResponseConfig
        {
            get { return this._fixedResponseConfig; }
            set { this._fixedResponseConfig = value; }
        }

        // Check to see if FixedResponseConfig property is set
        internal bool IsSetFixedResponseConfig()
        {
            return this._fixedResponseConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ForwardConfig. 
        /// <para>
        /// Information for creating an action that distributes requests among one or more target
        /// groups. For Network Load Balancers, you can specify a single target group. Specify
        /// only when <c>Type</c> is <c>forward</c>. If you specify both <c>ForwardConfig</c>
        /// and <c>TargetGroupArn</c>, you can specify only one target group using <c>ForwardConfig</c>
        /// and it must be the same target group specified in <c>TargetGroupArn</c>.
        /// </para>
        /// </summary>
        public ForwardActionConfig ForwardConfig
        {
            get { return this._forwardConfig; }
            set { this._forwardConfig = value; }
        }

        // Check to see if ForwardConfig property is set
        internal bool IsSetForwardConfig()
        {
            return this._forwardConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The order for the action. This value is required for rules with multiple actions.
        /// The action with the lowest value for order is performed first.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50000)]
        public int? Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedirectConfig. 
        /// <para>
        /// [Application Load Balancer] Information for creating a redirect action. Specify only
        /// when <c>Type</c> is <c>redirect</c>.
        /// </para>
        /// </summary>
        public RedirectActionConfig RedirectConfig
        {
            get { return this._redirectConfig; }
            set { this._redirectConfig = value; }
        }

        // Check to see if RedirectConfig property is set
        internal bool IsSetRedirectConfig()
        {
            return this._redirectConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target group. Specify only when <c>Type</c>
        /// is <c>forward</c> and you want to route to a single target group. To route to one
        /// or more target groups, use <c>ForwardConfig</c> instead.
        /// </para>
        /// </summary>
        public string TargetGroupArn
        {
            get { return this._targetGroupArn; }
            set { this._targetGroupArn = value; }
        }

        // Check to see if TargetGroupArn property is set
        internal bool IsSetTargetGroupArn()
        {
            return this._targetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionTypeEnum Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}