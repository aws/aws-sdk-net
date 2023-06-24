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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConstraint operation.
    /// Updates the specified constraint.
    /// </summary>
    public partial class UpdateConstraintRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _description;
        private string _id;
        private string _parameters;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>jp</code> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh</code> - Chinese
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
        /// The updated description of the constraint.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The constraint parameters, in JSON format. The syntax depends on the constraint type
        /// as follows:
        /// </para>
        ///  <dl> <dt>LAUNCH</dt> <dd> 
        /// <para>
        /// You are required to specify either the <code>RoleArn</code> or the <code>LocalRoleName</code>
        /// but can't use both.
        /// </para>
        ///  
        /// <para>
        /// Specify the <code>RoleArn</code> property as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"RoleArn" : "arn:aws:iam::123456789012:role/LaunchRole"}</code> 
        /// </para>
        ///  
        /// <para>
        /// Specify the <code>LocalRoleName</code> property as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"LocalRoleName": "SCBasicLaunchRole"}</code> 
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>LocalRoleName</code> property, when an account uses the launch
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
        /// You cannot have both a <code>LAUNCH</code> and a <code>STACKSET</code> constraint.
        /// </para>
        ///  
        /// <para>
        /// You also cannot have more than one <code>LAUNCH</code> constraint on a product and
        /// portfolio.
        /// </para>
        ///  </dd> <dt>NOTIFICATION</dt> <dd> 
        /// <para>
        /// Specify the <code>NotificationArns</code> property as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"NotificationArns" : ["arn:aws:sns:us-east-1:123456789012:Topic"]}</code>
        /// 
        /// </para>
        ///  </dd> <dt>RESOURCE_UPDATE</dt> <dd> 
        /// <para>
        /// Specify the <code>TagUpdatesOnProvisionedProduct</code> property as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"Version":"2.0","Properties":{"TagUpdateOnProvisionedProduct":"String"}}</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The <code>TagUpdatesOnProvisionedProduct</code> property accepts a string value of
        /// <code>ALLOWED</code> or <code>NOT_ALLOWED</code>.
        /// </para>
        ///  </dd> <dt>STACKSET</dt> <dd> 
        /// <para>
        /// Specify the <code>Parameters</code> property as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"Version": "String", "Properties": {"AccountList": [ "String" ], "RegionList":
        /// [ "String" ], "AdminRole": "String", "ExecutionRole": "String"}}</code> 
        /// </para>
        ///  
        /// <para>
        /// You cannot have both a <code>LAUNCH</code> and a <code>STACKSET</code> constraint.
        /// </para>
        ///  
        /// <para>
        /// You also cannot have more than one <code>STACKSET</code> constraint on a product and
        /// portfolio.
        /// </para>
        ///  
        /// <para>
        /// Products with a <code>STACKSET</code> constraint will launch an CloudFormation stack
        /// set.
        /// </para>
        ///  </dd> <dt>TEMPLATE</dt> <dd> 
        /// <para>
        /// Specify the <code>Rules</code> property. For more information, see <a href="http://docs.aws.amazon.com/servicecatalog/latest/adminguide/reference-template_constraint_rules.html">Template
        /// Constraint Rules</a>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
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

    }
}