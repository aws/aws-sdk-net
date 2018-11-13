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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBClusterEndpoint operation.
    /// Modifies the properties of an endpoint in an Amazon Aurora DB cluster.
    /// </summary>
    public partial class ModifyDBClusterEndpointRequest : AmazonRDSRequest
    {
        private string _dbClusterEndpointIdentifier;
        private string _endpointType;
        private List<string> _excludedMembers = new List<string>();
        private List<string> _staticMembers = new List<string>();

        /// <summary>
        /// Gets and sets the property DBClusterEndpointIdentifier. 
        /// <para>
        /// The identifier of the endpoint to modify. This parameter is stored as a lowercase
        /// string.
        /// </para>
        /// </summary>
        public string DBClusterEndpointIdentifier
        {
            get { return this._dbClusterEndpointIdentifier; }
            set { this._dbClusterEndpointIdentifier = value; }
        }

        // Check to see if DBClusterEndpointIdentifier property is set
        internal bool IsSetDBClusterEndpointIdentifier()
        {
            return this._dbClusterEndpointIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of the endpoint. One of: <code>READER</code>, <code>ANY</code>. 
        /// </para>
        /// </summary>
        public string EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedMembers. 
        /// <para>
        /// List of DB instance identifiers that aren't part of the custom endpoint group. All
        /// other eligible instances are reachable through the custom endpoint. Only relevant
        /// if the list of static members is empty.
        /// </para>
        /// </summary>
        public List<string> ExcludedMembers
        {
            get { return this._excludedMembers; }
            set { this._excludedMembers = value; }
        }

        // Check to see if ExcludedMembers property is set
        internal bool IsSetExcludedMembers()
        {
            return this._excludedMembers != null && this._excludedMembers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StaticMembers. 
        /// <para>
        /// List of DB instance identifiers that are part of the custom endpoint group.
        /// </para>
        /// </summary>
        public List<string> StaticMembers
        {
            get { return this._staticMembers; }
            set { this._staticMembers = value; }
        }

        // Check to see if StaticMembers property is set
        internal bool IsSetStaticMembers()
        {
            return this._staticMembers != null && this._staticMembers.Count > 0; 
        }

    }
}