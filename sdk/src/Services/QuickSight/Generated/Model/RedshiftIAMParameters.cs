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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that grants Amazon QuickSight access to your cluster and make a call to
    /// the <code>redshift:GetClusterCredentials</code> API. For more information on the <code>redshift:GetClusterCredentials</code>
    /// API, see <a href="https://docs.aws.amazon.com/redshift/latest/APIReference/API_GetClusterCredentials.html">
    /// <code>GetClusterCredentials</code> </a>.
    /// </summary>
    public partial class RedshiftIAMParameters
    {
        private bool? _autoCreateDatabaseUser;
        private List<string> _databaseGroups = new List<string>();
        private string _databaseUser;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AutoCreateDatabaseUser. 
        /// <para>
        /// Automatically creates a database user. If your database doesn't have a <code>DatabaseUser</code>,
        /// set this parameter to <code>True</code>. If there is no <code>DatabaseUser</code>,
        /// Amazon QuickSight can't connect to your cluster. The <code>RoleArn</code> that you
        /// use for this operation must grant access to <code>redshift:CreateClusterUser</code>
        /// to successfully create the user.
        /// </para>
        /// </summary>
        public bool AutoCreateDatabaseUser
        {
            get { return this._autoCreateDatabaseUser.GetValueOrDefault(); }
            set { this._autoCreateDatabaseUser = value; }
        }

        // Check to see if AutoCreateDatabaseUser property is set
        internal bool IsSetAutoCreateDatabaseUser()
        {
            return this._autoCreateDatabaseUser.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseGroups. 
        /// <para>
        /// A list of groups whose permissions will be granted to Amazon QuickSight to access
        /// the cluster. These permissions are combined with the permissions granted to Amazon
        /// QuickSight by the <code>DatabaseUser</code>. If you choose to include this parameter,
        /// the <code>RoleArn</code> must grant access to <code>redshift:JoinGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> DatabaseGroups
        {
            get { return this._databaseGroups; }
            set { this._databaseGroups = value; }
        }

        // Check to see if DatabaseGroups property is set
        internal bool IsSetDatabaseGroups()
        {
            return this._databaseGroups != null && this._databaseGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseUser. 
        /// <para>
        /// The user whose permissions and group memberships will be used by Amazon QuickSight
        /// to access the cluster. If this user already exists in your database, Amazon QuickSight
        /// is granted the same permissions that the user has. If the user doesn't exist, set
        /// the value of <code>AutoCreateDatabaseUser</code> to <code>True</code> to create a
        /// new user with PUBLIC permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DatabaseUser
        {
            get { return this._databaseUser; }
            set { this._databaseUser = value; }
        }

        // Check to see if DatabaseUser property is set
        internal bool IsSetDatabaseUser()
        {
            return this._databaseUser != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// Use the <code>RoleArn</code> structure to allow Amazon QuickSight to call <code>redshift:GetClusterCredentials</code>
        /// on your cluster. The calling principal must have <code>iam:PassRole</code> access
        /// to pass the role to Amazon QuickSight. The role's trust policy must allow the Amazon
        /// QuickSight service principal to assume the role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}