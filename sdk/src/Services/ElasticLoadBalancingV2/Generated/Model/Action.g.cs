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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about an action.
    /// 
    ///  
    /// <para>
    /// Each rule must include exactly one of the following routing actions: <c>forward</c>,
    /// <c>fixed-response</c>, or <c>redirect</c>, and it must be the last action to be performed.
    /// </para>
    ///  
    /// <para>
    /// Optionally, a rule for an HTTPS listener can also include one of the following user
    /// authentication actions: <c>authenticate-oidc</c>, <c>authenticate-cognito</c>, or
    /// <c>jwt-validation</c>.
    /// </para>
    /// </summary>
    public partial class Action
    {
        /// <summary>
        /// Gets and sets the property AuthenticateCognitoConfig. 
        /// <para>
        /// [HTTPS listeners] Information for using Amazon Cognito to authenticate users. Specify
        /// only when <c>Type</c> is <c>authenticate-cognito</c>.
        /// </para>
        /// </summary>
        public AuthenticateCognitoActionConfig AuthenticateCognitoConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticateCognitoConfig property is set.
        /// </summary>
        internal bool IsSetAuthenticateCognitoConfig() => this.AuthenticateCognitoConfig != null;

        /// <summary>
        /// Gets and sets the property AuthenticateOidcConfig. 
        /// <para>
        /// [HTTPS listeners] Information about an identity provider that is compliant with OpenID
        /// Connect (OIDC). Specify only when <c>Type</c> is <c>authenticate-oidc</c>.
        /// </para>
        /// </summary>
        public AuthenticateOidcActionConfig AuthenticateOidcConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticateOidcConfig property is set.
        /// </summary>
        internal bool IsSetAuthenticateOidcConfig() => this.AuthenticateOidcConfig != null;

        /// <summary>
        /// Gets and sets the property FixedResponseConfig. 
        /// <para>
        /// [Application Load Balancer] Information for creating an action that returns a custom
        /// HTTP response. Specify only when <c>Type</c> is <c>fixed-response</c>.
        /// </para>
        /// </summary>
        public FixedResponseActionConfig FixedResponseConfig { get; set; }

        /// <summary>
        /// Checks to see if the FixedResponseConfig property is set.
        /// </summary>
        internal bool IsSetFixedResponseConfig() => this.FixedResponseConfig != null;

        /// <summary>
        /// Gets and sets the property ForwardConfig. 
        /// <para>
        /// Information for creating an action that distributes requests among multiple target
        /// groups. Specify only when <c>Type</c> is <c>forward</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both <c>ForwardConfig</c> and <c>TargetGroupArn</c>, you can specify
        /// only one target group using <c>ForwardConfig</c> and it must be the same target group
        /// specified in <c>TargetGroupArn</c>.
        /// </para>
        /// </summary>
        public ForwardActionConfig ForwardConfig { get; set; }

        /// <summary>
        /// Checks to see if the ForwardConfig property is set.
        /// </summary>
        internal bool IsSetForwardConfig() => this.ForwardConfig != null;

        /// <summary>
        /// Gets and sets the property JwtValidationConfig. 
        /// <para>
        /// [HTTPS listeners] Information for validating JWT access tokens in client requests.
        /// Specify only when <c>Type</c> is <c>jwt-validation</c>.
        /// </para>
        /// </summary>
        public JwtValidationActionConfig JwtValidationConfig { get; set; }

        /// <summary>
        /// Checks to see if the JwtValidationConfig property is set.
        /// </summary>
        internal bool IsSetJwtValidationConfig() => this.JwtValidationConfig != null;

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The order for the action. This value is required for rules with multiple actions.
        /// The action with the lowest value for order is performed first.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50000)]
        public int? Order { get; set; }

        /// <summary>
        /// Checks to see if the Order property is set.
        /// </summary>
        internal bool IsSetOrder() => this.Order.HasValue;

        /// <summary>
        /// Gets and sets the property RedirectConfig. 
        /// <para>
        /// [Application Load Balancer] Information for creating a redirect action. Specify only
        /// when <c>Type</c> is <c>redirect</c>.
        /// </para>
        /// </summary>
        public RedirectActionConfig RedirectConfig { get; set; }

        /// <summary>
        /// Checks to see if the RedirectConfig property is set.
        /// </summary>
        internal bool IsSetRedirectConfig() => this.RedirectConfig != null;

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target group. Specify only when <c>Type</c>
        /// is <c>forward</c> and you want to route to a single target group. To route to multiple
        /// target groups, you must use <c>ForwardConfig</c> instead.
        /// </para>
        /// </summary>
        public string TargetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupArn property is set.
        /// </summary>
        internal bool IsSetTargetGroupArn() => this.TargetGroupArn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionTypeEnum Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
