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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about an action.
    /// </summary>
    public partial class Action
    {
        private AuthenticateCognitoActionConfig _authenticateCognitoConfig;
        private AuthenticateOidcActionConfig _authenticateOidcConfig;
        private int? _order;
        private string _targetGroupArn;
        private ActionTypeEnum _type;

        /// <summary>
        /// Gets and sets the property AuthenticateCognitoConfig. 
        /// <para>
        /// [HTTPS listener] Information for using Amazon Cognito to authenticate users. Specify
        /// only when <code>Type</code> is <code>authenticate-cognito</code>.
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
        /// [HTTPS listener] Information about an identity provider that is compliant with OpenID
        /// Connect (OIDC). Specify only when <code>Type</code> is <code>authenticate-oidc</code>.
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
        /// Gets and sets the property Order. 
        /// <para>
        /// The order for the action. This value is required for rules with multiple actions.
        /// The action with the lowest value for order is performed first. The forward action
        /// must be performed last.
        /// </para>
        /// </summary>
        public int Order
        {
            get { return this._order.GetValueOrDefault(); }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target group. Specify only when <code>Type</code>
        /// is <code>forward</code>.
        /// </para>
        ///  
        /// <para>
        /// For a default rule, the protocol of the target group must be HTTP or HTTPS for an
        /// Application Load Balancer or TCP for a Network Load Balancer.
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
        /// The type of action. Each rule must include one forward action.
        /// </para>
        /// </summary>
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