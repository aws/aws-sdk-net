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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRelationalDatabase operation.
    /// Creates a new database in Amazon Lightsail.
    /// </summary>
    public partial class CreateRelationalDatabaseRequest : AmazonLightsailRequest
    {
        private string _availabilityZone;
        private string _masterDatabaseName;
        private string _masterUsername;
        private string _masterUserPassword;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _relationalDatabaseBlueprintId;
        private string _relationalDatabaseBundleId;
        private string _relationalDatabaseName;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to create your new database. Use the <code>us-east-2a</code>
        /// case-sensitive format.
        /// </para>
        ///  
        /// <para>
        /// You can get a list of Availability Zones by using the <code>get regions</code> operation.
        /// Be sure to add the <code>include relational database Availability Zones</code> parameter
        /// to your request.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property MasterDatabaseName. 
        /// <para>
        /// The name of the master database created when the Lightsail database resource is created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 64 alphanumeric characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be a word reserved by the specified database engine
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string MasterDatabaseName
        {
            get { return this._masterDatabaseName; }
            set { this._masterDatabaseName = value; }
        }

        // Check to see if MasterDatabaseName property is set
        internal bool IsSetMasterDatabaseName()
        {
            return this._masterDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master user name for your new database.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Master user name is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 16 alphanumeric characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be a reserved word for the database engine you choose.
        /// </para>
        ///  
        /// <para>
        /// For more information about reserved words in MySQL 5.6 or 5.7, see the Keywords and
        /// Reserved Words articles for <a href="https://dev.mysql.com/doc/refman/5.6/en/keywords.html">MySQL
        /// 5.6</a> or <a href="https://dev.mysql.com/doc/refman/5.7/en/keywords.html">MySQL 5.7</a>
        /// respectively.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string MasterUsername
        {
            get { return this._masterUsername; }
            set { this._masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this._masterUsername != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The password for the master user of your new database. The password can include any
        /// printable ASCII character except "/", """, or "@".
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain 8 to 41 characters.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The daily time range during which automated backups are created for your new database
        /// if automated backups are enabled.
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each AWS Region. For more information about the preferred backup window time blocks
        /// for each region, see the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithAutomatedBackups.html#USER_WorkingWithAutomatedBackups.BackupWindow">Working
        /// With Backups</a> guide in the Amazon Relational Database Service (Amazon RDS) documentation.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the <code>hh24:mi-hh24:mi</code> format.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>16:00-16:30</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in Universal Coordinated Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not conflict with the preferred maintenance window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this._preferredBackupWindow; }
            set { this._preferredBackupWindow = value; }
        }

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this._preferredBackupWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range during which system maintenance can occur on your new database.
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each AWS Region, occurring on a random day of the week.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the <code>ddd:hh24:mi-ddd:hh24:mi</code> format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid days: Mon, Tue, Wed, Thu, Fri, Sat, Sun.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in Universal Coordinated Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <code>Tue:17:00-Tue:17:30</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies the accessibility options for your new database. A value of <code>true</code>
        /// specifies a database that is available to resources outside of your Lightsail account.
        /// A value of <code>false</code> specifies a database that is available only to your
        /// Lightsail resources in the same region as your database.
        /// </para>
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseBlueprintId. 
        /// <para>
        /// The blueprint ID for your new database. A blueprint describes the major engine version
        /// of a database.
        /// </para>
        ///  
        /// <para>
        /// You can get a list of database blueprints IDs by using the <code>get relational database
        /// blueprints</code> operation.
        /// </para>
        /// </summary>
        public string RelationalDatabaseBlueprintId
        {
            get { return this._relationalDatabaseBlueprintId; }
            set { this._relationalDatabaseBlueprintId = value; }
        }

        // Check to see if RelationalDatabaseBlueprintId property is set
        internal bool IsSetRelationalDatabaseBlueprintId()
        {
            return this._relationalDatabaseBlueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseBundleId. 
        /// <para>
        /// The bundle ID for your new database. A bundle describes the performance specifications
        /// for your database.
        /// </para>
        ///  
        /// <para>
        /// You can get a list of database bundle IDs by using the <code>get relational database
        /// bundles</code> operation.
        /// </para>
        /// </summary>
        public string RelationalDatabaseBundleId
        {
            get { return this._relationalDatabaseBundleId; }
            set { this._relationalDatabaseBundleId = value; }
        }

        // Check to see if RelationalDatabaseBundleId property is set
        internal bool IsSetRelationalDatabaseBundleId()
        {
            return this._relationalDatabaseBundleId != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name to use for your new database.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 2 to 255 alphanumeric characters, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first and last character must be a letter or number.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string RelationalDatabaseName
        {
            get { return this._relationalDatabaseName; }
            set { this._relationalDatabaseName = value; }
        }

        // Check to see if RelationalDatabaseName property is set
        internal bool IsSetRelationalDatabaseName()
        {
            return this._relationalDatabaseName != null;
        }

    }
}