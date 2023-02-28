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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The structure used to create or update a database.
    /// </summary>
    public partial class DatabaseInput
    {
        private List<PrincipalPermissions> _createTableDefaultPermissions = new List<PrincipalPermissions>();
        private string _description;
        private string _locationUri;
        private string _name;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private DatabaseIdentifier _targetDatabase;

        /// <summary>
        /// Gets and sets the property CreateTableDefaultPermissions. 
        /// <para>
        /// Creates a set of default permissions on the table for principals. Used by Lake Formation.
        /// Not used in the normal course of Glue operations.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The location of the database (for example, an HDFS path). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the database. For Hive compatibility, this is folded to lowercase when
        /// it is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// These key-value pairs define parameters and properties of the database.
        /// </para>
        ///  
        /// <para>
        /// These key-value pairs define parameters and properties of the database.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetDatabase. 
        /// <para>
        /// A <code>DatabaseIdentifier</code> structure that describes a target database for resource
        /// linking.
        /// </para>
        /// </summary>
        public DatabaseIdentifier TargetDatabase
        {
            get { return this._targetDatabase; }
            set { this._targetDatabase = value; }
        }

        // Check to see if TargetDatabase property is set
        internal bool IsSetTargetDatabase()
        {
            return this._targetDatabase != null;
        }

    }
}