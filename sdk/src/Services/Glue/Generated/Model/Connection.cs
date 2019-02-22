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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a connection to a data source.
    /// </summary>
    public partial class Connection
    {
        private Dictionary<string, string> _connectionProperties = new Dictionary<string, string>();
        private ConnectionType _connectionType;
        private DateTime? _creationTime;
        private string _description;
        private string _lastUpdatedBy;
        private DateTime? _lastUpdatedTime;
        private List<string> _matchCriteria = new List<string>();
        private string _name;
        private PhysicalConnectionRequirements _physicalConnectionRequirements;

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// These key-value pairs define parameters for the connection:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>HOST</code> - The host URI: either the fully qualified domain name (FQDN) or
        /// the IPv4 address of the database host.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PORT</code> - The port number, between 1024 and 65535, of the port on which
        /// the database host is listening for database connections.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>USER_NAME</code> - The name under which to log in to the database. The value
        /// string for <code>USER_NAME</code> is "<code>USERNAME</code>".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PASSWORD</code> - A password, if one is used, for the user name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENCRYPTED_PASSWORD</code> - When you enable connection password protection
        /// by setting <code>ConnectionPasswordEncryption</code> in the Data Catalog encryption
        /// settings, this field stores the encrypted password.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_DRIVER_JAR_URI</code> - The Amazon S3 path of the JAR file that contains
        /// the JDBC driver to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_DRIVER_CLASS_NAME</code> - The class name of the JDBC driver to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_ENGINE</code> - The name of the JDBC engine to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_ENGINE_VERSION</code> - The version of the JDBC engine to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CONFIG_FILES</code> - (Reserved for future use).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INSTANCE_ID</code> - The instance ID to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_CONNECTION_URL</code> - The URL for the JDBC connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_ENFORCE_SSL</code> - A Boolean string (true, false) specifying whether
        /// Secure Sockets Layer (SSL) with hostname matching will be enforced for the JDBC connection
        /// on the client. The default is false.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> ConnectionProperties
        {
            get { return this._connectionProperties; }
            set { this._connectionProperties = value; }
        }

        // Check to see if ConnectionProperties property is set
        internal bool IsSetConnectionProperties()
        {
            return this._connectionProperties != null && this._connectionProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of the connection. Currently, only JDBC is supported; SFTP is not supported.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that this connection definition was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the connection.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The user, group, or role that last updated this connection definition.
        /// </para>
        /// </summary>
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that this connection definition was updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// A list of criteria that can be used in selecting this connection.
        /// </para>
        /// </summary>
        public List<string> MatchCriteria
        {
            get { return this._matchCriteria; }
            set { this._matchCriteria = value; }
        }

        // Check to see if MatchCriteria property is set
        internal bool IsSetMatchCriteria()
        {
            return this._matchCriteria != null && this._matchCriteria.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection definition.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PhysicalConnectionRequirements. 
        /// <para>
        /// A map of physical connection requirements, such as virtual private cloud (VPC) and
        /// <code>SecurityGroup</code>, that are needed to make this connection successfully.
        /// </para>
        /// </summary>
        public PhysicalConnectionRequirements PhysicalConnectionRequirements
        {
            get { return this._physicalConnectionRequirements; }
            set { this._physicalConnectionRequirements = value; }
        }

        // Check to see if PhysicalConnectionRequirements property is set
        internal bool IsSetPhysicalConnectionRequirements()
        {
            return this._physicalConnectionRequirements != null;
        }

    }
}