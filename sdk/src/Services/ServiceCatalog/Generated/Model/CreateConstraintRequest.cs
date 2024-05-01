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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConstraint operation.
    /// Creates a constraint.
    /// 
    ///  
    /// <para>
    /// A delegated admin is authorized to invoke this command.
    /// </para>
    /// </summary>
    public partial class CreateConstraintRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _description;
        private string _idempotencyToken;
        private string _parameters;
        private string _portfolioId;
        private string _productId;
        private string _type;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=100)]
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
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
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique identifier that you provide to ensure idempotency. If multiple requests differ
        /// only by the idempotency token, the same response is returned for each repeated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The constraint parameters, in JSON format. The syntax depends on the constraint type
        /// as follows:
        /// </para>
        ///  <dl> <dt>LAUNCH</dt> <dd> 
        /// <para>
        /// You are required to specify either the <c>RoleArn</c> or the <c>LocalRoleName</c>
        /// but can't use both.
        /// </para>
        ///  
        /// <para>
        /// Specify the <c>RoleArn</c> property as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"RoleArn" : "arn:aws:iam::123456789012:role/LaunchRole"}</c> 
        /// </para>
        ///  
        /// <para>
        /// Specify the <c>LocalRoleName</c> property as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"LocalRoleName": "SCBasicLaunchRole"}</c> 
        /// </para>
        ///  
        /// <para>
        /// If you specify the <c>LocalRoleName</c> property, when an account uses the launch
        /// constraint, the IAM role with that name in the account will be used. This allows launch-role
        /// constraints to be account-agnostic so the administrator can create fewer resources
        /// per shared account.
        /// </para>
        ///  <note> 
        /// <para>
        /// The given role name must exist in the account used to create the launch constraint
        /// and the account of the user who launches a product with this launch constraint.
        /// </para>
        ///  </note> 
        /// <para>
        /// You cannot have both a <c>LAUNCH</c> and a <c>STACKSET</c> constraint.
        /// </para>
        ///  
        /// <para>
        /// You also cannot have more than one <c>LAUNCH</c> constraint on a product and portfolio.
        /// </para>
        ///  </dd> <dt>NOTIFICATION</dt> <dd> 
        /// <para>
        /// Specify the <c>NotificationArns</c> property as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"NotificationArns" : ["arn:aws:sns:us-east-1:123456789012:Topic"]}</c> 
        /// </para>
        ///  </dd> <dt>RESOURCE_UPDATE</dt> <dd> 
        /// <para>
        /// Specify the <c>TagUpdatesOnProvisionedProduct</c> property as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"Version":"2.0","Properties":{"TagUpdateOnProvisionedProduct":"String"}}</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The <c>TagUpdatesOnProvisionedProduct</c> property accepts a string value of <c>ALLOWED</c>
        /// or <c>NOT_ALLOWED</c>.
        /// </para>
        ///  </dd> <dt>STACKSET</dt> <dd> 
        /// <para>
        /// Specify the <c>Parameters</c> property as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"Version": "String", "Properties": {"AccountList": [ "String" ], "RegionList":
        /// [ "String" ], "AdminRole": "String", "ExecutionRole": "String"}}</c> 
        /// </para>
        ///  
        /// <para>
        /// You cannot have both a <c>LAUNCH</c> and a <c>STACKSET</c> constraint.
        /// </para>
        ///  
        /// <para>
        /// You also cannot have more than one <c>STACKSET</c> constraint on a product and portfolio.
        /// </para>
        ///  
        /// <para>
        /// Products with a <c>STACKSET</c> constraint will launch an CloudFormation stack set.
        /// </para>
        ///  </dd> <dt>TEMPLATE</dt> <dd> 
        /// <para>
        /// Specify the <c>Rules</c> property. For more information, see <a href="http://docs.aws.amazon.com/servicecatalog/latest/adminguide/reference-template_constraint_rules.html">Template
        /// Constraint Rules</a>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

        /// <summary>
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The portfolio identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string PortfolioId
        {
            get { return this._portfolioId; }
            set { this._portfolioId = value; }
        }

        // Check to see if PortfolioId property is set
        internal bool IsSetPortfolioId()
        {
            return this._portfolioId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of constraint.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LAUNCH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOTIFICATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE_UPDATE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STACKSET</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEMPLATE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Type
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