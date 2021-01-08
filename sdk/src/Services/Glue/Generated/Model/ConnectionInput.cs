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
    /// A structure that is used to specify a connection to create or update.
    /// </summary>
    public partial class ConnectionInput
    {
        private Dictionary<string, string> _connectionProperties = new Dictionary<string, string>();
        private ConnectionType _connectionType;
        private string _description;
        private List<string> _matchCriteria = new List<string>();
        private string _name;
        private PhysicalConnectionRequirements _physicalConnectionRequirements;

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// These key-value pairs define parameters for the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
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
        /// The type of the connection. Currently, these types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>JDBC</code> - Designates a connection to a database through Java Database Connectivity
        /// (JDBC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA</code> - Designates a connection to an Apache Kafka streaming platform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MONGODB</code> - Designates a connection to a MongoDB document database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NETWORK</code> - Designates a network connection to a data source within an
        /// Amazon Virtual Private Cloud environment (Amazon VPC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MARKETPLACE</code> - Uses configuration settings contained in a connector purchased
        /// from AWS Marketplace to read from and write to data stores that are not natively supported
        /// by AWS Glue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CUSTOM</code> - Uses configuration settings contained in a custom connector
        /// to read from and write to data stores that are not natively supported by AWS Glue.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// SFTP is not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the connection.
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
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// A list of criteria that can be used in selecting this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
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
        /// The name of the connection.
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
        /// Gets and sets the property PhysicalConnectionRequirements. 
        /// <para>
        /// A map of physical connection requirements, such as virtual private cloud (VPC) and
        /// <code>SecurityGroup</code>, that are needed to successfully make this connection.
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