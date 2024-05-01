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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the GetClusterCredentialsWithIAM operation.
    /// Returns a database user name and temporary password with temporary authorization to
    /// log in to an Amazon Redshift database. The database user is mapped 1:1 to the source
    /// Identity and Access Management (IAM) identity. For more information about IAM identities,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id.html">IAM Identities
    /// (users, user groups, and roles)</a> in the Amazon Web Services Identity and Access
    /// Management User Guide.
    /// 
    ///  
    /// <para>
    /// The Identity and Access Management (IAM) identity that runs this operation must have
    /// an IAM policy attached that allows access to all necessary actions and resources.
    /// For more information about permissions, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html">Using
    /// identity-based policies (IAM policies)</a> in the Amazon Redshift Cluster Management
    /// Guide. 
    /// </para>
    /// </summary>
    public partial class GetClusterCredentialsWithIAMRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _customDomainName;
        private string _dbName;
        private int? _durationSeconds;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster that contains the database for which you are
        /// requesting credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name for the IAM message cluster credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string CustomDomainName
        {
            get { return this._customDomainName; }
            set { this._customDomainName = value; }
        }

        // Check to see if CustomDomainName property is set
        internal bool IsSetCustomDomainName()
        {
            return this._customDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property DbName. 
        /// <para>
        /// The name of the database for which you are requesting credentials. If the database
        /// name is specified, the IAM policy must allow access to the resource <c>dbname</c>
        /// for the specified database name. If the database name is not specified, access to
        /// all databases is allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The number of seconds until the returned temporary password expires.
        /// </para>
        ///  
        /// <para>
        /// Range: 900-3600. Default: 900.
        /// </para>
        /// </summary>
        public int? DurationSeconds
        {
            get { return this._durationSeconds; }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

    }
}