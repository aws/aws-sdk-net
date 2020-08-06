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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure representing a list of AWS Lake Formation principals designated as data
    /// lake administrators and lists of principal permission entries for default create database
    /// and default create table permissions.
    /// </summary>
    public partial class DataLakeSettings
    {
        private List<PrincipalPermissions> _createDatabaseDefaultPermissions = new List<PrincipalPermissions>();
        private List<PrincipalPermissions> _createTableDefaultPermissions = new List<PrincipalPermissions>();
        private List<DataLakePrincipal> _dataLakeAdmins = new List<DataLakePrincipal>();
        private List<string> _trustedResourceOwners = new List<string>();

        /// <summary>
        /// Gets and sets the property CreateDatabaseDefaultPermissions. 
        /// <para>
        /// A structure representing a list of up to three principal permissions entries for default
        /// create database permissions.
        /// </para>
        /// </summary>
        public List<PrincipalPermissions> CreateDatabaseDefaultPermissions
        {
            get { return this._createDatabaseDefaultPermissions; }
            set { this._createDatabaseDefaultPermissions = value; }
        }

        // Check to see if CreateDatabaseDefaultPermissions property is set
        internal bool IsSetCreateDatabaseDefaultPermissions()
        {
            return this._createDatabaseDefaultPermissions != null && this._createDatabaseDefaultPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreateTableDefaultPermissions. 
        /// <para>
        /// A structure representing a list of up to three principal permissions entries for default
        /// create table permissions.
        /// </para>
        /// </summary>
        public List<PrincipalPermissions> CreateTableDefaultPermissions
        {
            get { return this._createTableDefaultPermissions; }
            set { this._createTableDefaultPermissions = value; }
        }

        // Check to see if CreateTableDefaultPermissions property is set
        internal bool IsSetCreateTableDefaultPermissions()
        {
            return this._createTableDefaultPermissions != null && this._createTableDefaultPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataLakeAdmins. 
        /// <para>
        /// A list of AWS Lake Formation principals. Supported principals are IAM users or IAM
        /// roles.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<DataLakePrincipal> DataLakeAdmins
        {
            get { return this._dataLakeAdmins; }
            set { this._dataLakeAdmins = value; }
        }

        // Check to see if DataLakeAdmins property is set
        internal bool IsSetDataLakeAdmins()
        {
            return this._dataLakeAdmins != null && this._dataLakeAdmins.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrustedResourceOwners. 
        /// <para>
        /// A list of the resource-owning account IDs that the caller's account can use to share
        /// their user access details (user ARNs). The user ARNs can be logged in the resource
        /// owner's AWS CloudTrail log.
        /// </para>
        ///  
        /// <para>
        /// You may want to specify this property when you are in a high-trust boundary, such
        /// as the same team or company. 
        /// </para>
        /// </summary>
        public List<string> TrustedResourceOwners
        {
            get { return this._trustedResourceOwners; }
            set { this._trustedResourceOwners = value; }
        }

        // Check to see if TrustedResourceOwners property is set
        internal bool IsSetTrustedResourceOwners()
        {
            return this._trustedResourceOwners != null && this._trustedResourceOwners.Count > 0; 
        }

    }
}