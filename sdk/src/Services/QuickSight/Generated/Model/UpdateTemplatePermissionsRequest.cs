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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTemplatePermissions operation.
    /// Updates the permissions on a template.
    /// 
    ///  
    /// <para>
    /// CLI syntax:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>aws quicksight describe-template-permissions —aws-account-id 111122223333 —template-id
    /// reports_test_template</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>aws quicksight update-template-permissions —cli-input-json file://update-permission.json
    /// </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The structure of <code>update-permissions.json</code> to add permissions:
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "AwsAccountId": "111122223333",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "DashboardId": "reports_test_template",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "GrantPermissions": [</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> { "Principal": "arn:aws:quicksight:us-east-1:196359894473:user/default/user3",</code>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Actions": [</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "quicksight:DescribeTemplate",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "quicksight:ListTemplateVersions"</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> ] } ] }</code> 
    /// </para>
    ///  
    /// <para>
    /// The structure of <code>update-permissions.json</code> to add permissions:
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "AwsAccountId": "111122223333",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "DashboardId": "reports_test_template",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "RevokePermissions": [</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> { "Principal": "arn:aws:quicksight:us-east-1:196359894473:user/default/user3",</code>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Actions": [</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "quicksight:DescribeTemplate",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "quicksight:ListTemplateVersions"</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> ] } ] }</code> 
    /// </para>
    ///  
    /// <para>
    /// To obtain the principal name of a QuickSight group or user, use user describe-group
    /// or describe-user. For example:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight describe-user </code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>--aws-account-id 111122223333</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>--namespace default</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>--user-name user2 </code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>--region us-east-1</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>{</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "User": {</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Arn": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2",</code>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Active": true,</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Email": "user2@example.com",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Role": "ADMIN",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "UserName": "user2",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "PrincipalId": "federated/iam/abcd2abcdabcdeabc5ab5"</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> },</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "RequestId": "8f74bb31-6291-448a-a71c-a765a44bae31",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Status": 200</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>}</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateTemplatePermissionsRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private List<ResourcePermission> _grantPermissions = new List<ResourcePermission>();
        private List<ResourcePermission> _revokePermissions = new List<ResourcePermission>();
        private string _templateId;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// AWS account ID that contains the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property GrantPermissions. 
        /// <para>
        /// A list of resource permissions to be granted on the template. The following example
        /// shows the shorthand syntax: 
        /// </para>
        ///  
        /// <para>
        ///  <code>Shorthand Syntax: Principal=string,Actions=string,string ... </code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ResourcePermission> GrantPermissions
        {
            get { return this._grantPermissions; }
            set { this._grantPermissions = value; }
        }

        // Check to see if GrantPermissions property is set
        internal bool IsSetGrantPermissions()
        {
            return this._grantPermissions != null && this._grantPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RevokePermissions. 
        /// <para>
        /// A list of resource permissions to be revoked from the template. Shorthand syntax:
        /// <code>Shorthand Syntax: Principal=string,Actions=string,string ... </code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ResourcePermission> RevokePermissions
        {
            get { return this._revokePermissions; }
            set { this._revokePermissions = value; }
        }

        // Check to see if RevokePermissions property is set
        internal bool IsSetRevokePermissions()
        {
            return this._revokePermissions != null && this._revokePermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

    }
}