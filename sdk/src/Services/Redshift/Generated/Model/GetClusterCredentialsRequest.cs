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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the GetClusterCredentials operation.
    /// Returns a database user name and temporary password with temporary authorization to
    /// log on to an Amazon Redshift database. The action returns the database user name prefixed
    /// with <code>IAM:</code> if <code>AutoCreate</code> is <code>False</code> or <code>IAMA:</code>
    /// if <code>AutoCreate</code> is <code>True</code>. You can optionally specify one or
    /// more database user groups that the user will join at log on. By default, the temporary
    /// credentials expire in 900 seconds. You can optionally specify a duration between 900
    /// seconds (15 minutes) and 3600 seconds (60 minutes). For more information, see <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/generating-user-credentials.html">Using
    /// IAM Authentication to Generate Database User Credentials</a> in the Amazon Redshift
    /// Cluster Management Guide.
    /// 
    ///  
    /// <para>
    /// The AWS Identity and Access Management (IAM)user or role that executes GetClusterCredentials
    /// must have an IAM policy attached that allows access to all necessary actions and resources.
    /// For more information about permissions, see <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html#redshift-policy-resources.getclustercredentials-resources">Resource
    /// Policies for GetClusterCredentials</a> in the Amazon Redshift Cluster Management Guide.
    /// </para>
    ///  
    /// <para>
    /// If the <code>DbGroups</code> parameter is specified, the IAM policy must allow the
    /// <code>redshift:JoinGroup</code> action with access to the listed <code>dbgroups</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// In addition, if the <code>AutoCreate</code> parameter is set to <code>True</code>,
    /// then the policy must include the <code>redshift:CreateClusterUser</code> privilege.
    /// </para>
    ///  
    /// <para>
    /// If the <code>DbName</code> parameter is specified, the IAM policy must allow access
    /// to the resource <code>dbname</code> for the specified database name. 
    /// </para>
    /// </summary>
    public partial class GetClusterCredentialsRequest : AmazonRedshiftRequest
    {
        private bool? _autoCreate;
        private string _clusterIdentifier;
        private List<string> _dbGroups = new List<string>();
        private string _dbName;
        private string _dbUser;
        private int? _durationSeconds;

        /// <summary>
        /// Gets and sets the property AutoCreate. 
        /// <para>
        /// Create a database user with the name specified for the user named in <code>DbUser</code>
        /// if one does not exist.
        /// </para>
        /// </summary>
        public bool AutoCreate
        {
            get { return this._autoCreate.GetValueOrDefault(); }
            set { this._autoCreate = value; }
        }

        // Check to see if AutoCreate property is set
        internal bool IsSetAutoCreate()
        {
            return this._autoCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster that contains the database for which your are
        /// requesting credentials. This parameter is case sensitive.
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbGroups. 
        /// <para>
        /// A list of the names of existing database groups that the user named in <code>DbUser</code>
        /// will join for the current session, in addition to any group memberships for an existing
        /// user. If not specified, a new user is added only to PUBLIC.
        /// </para>
        ///  
        /// <para>
        /// Database group name constraints
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 64 alphanumeric characters or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain only lowercase letters, numbers, underscore, plus sign, period (dot),
        /// at symbol (@), or hyphen.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not contain a colon ( : ) or slash ( / ). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be a reserved word. A list of reserved words can be found in <a href="http://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved
        /// Words</a> in the Amazon Redshift Database Developer Guide.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> DbGroups
        {
            get { return this._dbGroups; }
            set { this._dbGroups = value; }
        }

        // Check to see if DbGroups property is set
        internal bool IsSetDbGroups()
        {
            return this._dbGroups != null && this._dbGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DbName. 
        /// <para>
        /// The name of a database that <code>DbUser</code> is authorized to log on to. If <code>DbName</code>
        /// is not specified, <code>DbUser</code> can log on to any existing database.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 64 alphanumeric characters or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain only lowercase letters, numbers, underscore, plus sign, period (dot),
        /// at symbol (@), or hyphen.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not contain a colon ( : ) or slash ( / ). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be a reserved word. A list of reserved words can be found in <a href="http://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved
        /// Words</a> in the Amazon Redshift Database Developer Guide.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DbName
        {
            get { return this._dbName; }
            set { this._dbName = value; }
        }

        // Check to see if DbName property is set
        internal bool IsSetDbName()
        {
            return this._dbName != null;
        }

        /// <summary>
        /// Gets and sets the property DbUser. 
        /// <para>
        /// The name of a database user. If a user name matching <code>DbUser</code> exists in
        /// the database, the temporary user credentials have the same permissions as the existing
        /// user. If <code>DbUser</code> doesn't exist in the database and <code>Autocreate</code>
        /// is <code>True</code>, a new user is created using the value for <code>DbUser</code>
        /// with PUBLIC permissions. If a database user matching the value for <code>DbUser</code>
        /// doesn't exist and <code>Autocreate</code> is <code>False</code>, then the command
        /// succeeds but the connection attempt will fail because the user doesn't exist in the
        /// database.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/redshift/latest/dg/r_CREATE_USER.html">CREATE
        /// USER</a> in the Amazon Redshift Database Developer Guide. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 64 alphanumeric characters or hyphens. The user name can't be <code>PUBLIC</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain only lowercase letters, numbers, underscore, plus sign, period (dot),
        /// at symbol (@), or hyphen.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not contain a colon ( : ) or slash ( / ). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be a reserved word. A list of reserved words can be found in <a href="http://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved
        /// Words</a> in the Amazon Redshift Database Developer Guide.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DbUser
        {
            get { return this._dbUser; }
            set { this._dbUser = value; }
        }

        // Check to see if DbUser property is set
        internal bool IsSetDbUser()
        {
            return this._dbUser != null;
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The number of seconds until the returned temporary password expires.
        /// </para>
        ///  
        /// <para>
        /// Constraint: minimum 900, maximum 3600.
        /// </para>
        ///  
        /// <para>
        /// Default: 900
        /// </para>
        /// </summary>
        public int DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

    }
}