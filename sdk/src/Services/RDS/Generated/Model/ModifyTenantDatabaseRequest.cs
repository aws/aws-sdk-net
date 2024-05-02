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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyTenantDatabase operation.
    /// Modifies an existing tenant database in a DB instance. You can change the tenant database
    /// name or the master user password. This operation is supported only for RDS for Oracle
    /// CDB instances using the multi-tenant configuration.
    /// </summary>
    public partial class ModifyTenantDatabaseRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private string _masterUserPassword;
        private string _newTenantDBName;
        private string _tenantDBName;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The identifier of the DB instance that contains the tenant database that you are modifying.
        /// This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DB instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The new password for the master user of the specified tenant database in your DB instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon RDS operations never return the password, so this action provides a way to
        /// regain access to a tenant database user if the password is lost. This includes restoring
        /// privileges that might have been accidentally revoked.
        /// </para>
        ///  </note> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can include any printable ASCII character except <c>/</c>, <c>"</c> (double quote),
        /// <c>@</c>, <c>&amp;</c> (ampersand), and <c>'</c> (single quote).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Length constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain between 8 and 30 characters. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string MasterUserPassword
        {
            get { return this._masterUserPassword; }
            set { this._masterUserPassword = value; }
        }

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this._masterUserPassword != null;
        }

        /// <summary>
        /// Gets and sets the property NewTenantDBName. 
        /// <para>
        /// The new name of the tenant database when renaming a tenant database. This parameter
        /// isn’t case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be the string null or any other reserved word.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be longer than 8 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string NewTenantDBName
        {
            get { return this._newTenantDBName; }
            set { this._newTenantDBName = value; }
        }

        // Check to see if NewTenantDBName property is set
        internal bool IsSetNewTenantDBName()
        {
            return this._newTenantDBName != null;
        }

        /// <summary>
        /// Gets and sets the property TenantDBName. 
        /// <para>
        /// The user-supplied name of the tenant database that you want to modify. This parameter
        /// isn’t case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing tenant database.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TenantDBName
        {
            get { return this._tenantDBName; }
            set { this._tenantDBName = value; }
        }

        // Check to see if TenantDBName property is set
        internal bool IsSetTenantDBName()
        {
            return this._tenantDBName != null;
        }

    }
}