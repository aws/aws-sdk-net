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
    /// Container for the parameters to the UpdateDashboardPermissions operation.
    /// Updates read and write permissions on a dashboard.
    /// 
    ///  
    /// <para>
    /// CLI syntax:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight update-dashboard-permissions —cli-input-json file://update-permission.json</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// A sample update-permissions.json for granting read only permissions:
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "GrantPermissions":
    /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
    /// [ "quicksight:DescribeDashboard", "quicksight:ListDashboardVersions", "quicksight:DescribeDashboardVersion",
    /// "quicksight:QueryDashboard" ] } ] }</code> 
    /// </para>
    ///  
    /// <para>
    /// A sample update-permissions.json for granting read and write permissions:
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "GrantPermissions":
    /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
    /// [ "quicksight:DescribeDashboard", "quicksight:ListDashboardVersions", "quicksight:DescribeDashboardVersion",
    /// "quicksight:QueryDashboard", "quicksight:DescribeDashboardPermissions", "quicksight:UpdateDashboardPermissions",
    /// "quicksight:DeleteDashboardVersion", "quicksight:DeleteDashboard", "quicksight:UpdateDashboard",
    /// "quicksight:UpdateDashboardPublishedVersion", ] } ] }</code> 
    /// </para>
    ///  
    /// <para>
    /// A sample update-permissions.json for revoking write permissions:
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "RevokePermissions":
    /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
    /// [ "quicksight:DescribeDashboardPermissions", "quicksight:UpdateDashboardPermissions",
    /// "quicksight:DeleteDashboardVersion", "quicksight:DeleteDashboard", "quicksight:UpdateDashboard",
    /// "quicksight:UpdateDashboardPublishedVersion", ] } ] }</code> 
    /// </para>
    ///  
    /// <para>
    /// A sample update-permissions.json for revoking read and write permissions:
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "RevokePermissions":
    /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
    /// [ "quicksight:DescribeDashboard", "quicksight:ListDashboardVersions", "quicksight:DescribeDashboardVersion",
    /// "quicksight:QueryDashboard", "quicksight:DescribeDashboardPermissions", "quicksight:UpdateDashboardPermissions",
    /// "quicksight:DeleteDashboardVersion", "quicksight:DeleteDashboard", "quicksight:UpdateDashboard",
    /// "quicksight:UpdateDashboardPublishedVersion", ] } ] }</code> 
    /// </para>
    ///  
    /// <para>
    /// To obtain the principal name of a QuickSight user or group, you can use describe-group
    /// or describe-user. For example:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight describe-user --aws-account-id 111122223333 --namespace default
    /// --user-name user2 --region us-east-1 { "User": { "Arn": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2",
    /// "Active": true, "Email": "user2@example.com", "Role": "ADMIN", "UserName": "user2",
    /// "PrincipalId": "federated/iam/abcd2abcdabcdeabc5ab5" }, "RequestId": "8f74bb31-6291-448a-a71c-a765a44bae31",
    /// "Status": 200 }</code> 
    /// </para>
    /// </summary>
    public partial class UpdateDashboardPermissionsRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _dashboardId;
        private List<ResourcePermission> _grantPermissions = new List<ResourcePermission>();
        private List<ResourcePermission> _revokePermissions = new List<ResourcePermission>();

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// AWS account ID that contains the dashboard you are updating.
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
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID for the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DashboardId
        {
            get { return this._dashboardId; }
            set { this._dashboardId = value; }
        }

        // Check to see if DashboardId property is set
        internal bool IsSetDashboardId()
        {
            return this._dashboardId != null;
        }

        /// <summary>
        /// Gets and sets the property GrantPermissions. 
        /// <para>
        /// The permissions that you want to grant on this resource.
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
        /// The permissions that you want to revoke from this resource.
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

    }
}