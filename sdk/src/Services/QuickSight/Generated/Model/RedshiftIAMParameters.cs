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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that grants QuickSight access to your cluster and make a call to the <c>redshift:GetClusterCredentials</c>
    /// API. For more information on the <c>redshift:GetClusterCredentials</c> API, see <a
    /// href="https://docs.aws.amazon.com/redshift/latest/APIReference/API_GetClusterCredentials.html">
    /// <c>GetClusterCredentials</c> </a>.
    /// </summary>
    public partial class RedshiftIAMParameters
    {
        private bool? _autoCreateDatabaseUser;
        private List<string> _databaseGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _databaseUser;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AutoCreateDatabaseUser. 
        /// <para>
        /// Automatically creates a database user. If your database doesn't have a <c>DatabaseUser</c>,
        /// set this parameter to <c>True</c>. If there is no <c>DatabaseUser</c>, Amazon QuickSight
        /// can't connect to your cluster. The <c>RoleArn</c> that you use for this operation
        /// must grant access to <c>redshift:CreateClusterUser</c> to successfully create the
        /// user.
        /// </para>
        /// </summary>
        public bool? AutoCreateDatabaseUser
        {
            get { return this._autoCreateDatabaseUser; }
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
        /// A list of groups whose permissions will be granted to QuickSight to access the cluster.
        /// These permissions are combined with the permissions granted to QuickSight by the <c>DatabaseUser</c>.
        /// If you choose to include this parameter, the <c>RoleArn</c> must grant access to <c>redshift:JoinGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._databaseGroups != null && (this._databaseGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatabaseUser. 
        /// <para>
        /// The user whose permissions and group memberships will be used by QuickSight to access
        /// the cluster. If this user already exists in your database, QuickSight is granted the
        /// same permissions that the user has. If the user doesn't exist, set the value of <c>AutoCreateDatabaseUser</c>
        /// to <c>True</c> to create a new user with PUBLIC permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Use the <c>RoleArn</c> structure to allow QuickSight to call <c>redshift:GetClusterCredentials</c>
        /// on your cluster. The calling principal must have <c>iam:PassRole</c> access to pass
        /// the role to QuickSight. The role's trust policy must allow the QuickSight service
        /// principal to assume the role.
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