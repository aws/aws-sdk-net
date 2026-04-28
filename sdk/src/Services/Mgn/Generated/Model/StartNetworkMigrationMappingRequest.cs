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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the StartNetworkMigrationMapping operation.
    /// Starts the network migration mapping process for a given network migration execution.
    /// </summary>
    public partial class StartNetworkMigrationMappingRequest : AmazonMgnRequest
    {
        private string _networkMigrationDefinitionID;
        private string _networkMigrationExecutionID;
        private SecurityGroupMappingStrategy _securityGroupMappingStrategy;

        /// <summary>
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string NetworkMigrationDefinitionID
        {
            get { return this._networkMigrationDefinitionID; }
            set { this._networkMigrationDefinitionID = value; }
        }

        // Check to see if NetworkMigrationDefinitionID property is set
        internal bool IsSetNetworkMigrationDefinitionID()
        {
            return this._networkMigrationDefinitionID != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkMigrationExecutionID. 
        /// <para>
        /// The unique identifier of the network migration execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string NetworkMigrationExecutionID
        {
            get { return this._networkMigrationExecutionID; }
            set { this._networkMigrationExecutionID = value; }
        }

        // Check to see if NetworkMigrationExecutionID property is set
        internal bool IsSetNetworkMigrationExecutionID()
        {
            return this._networkMigrationExecutionID != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupMappingStrategy. 
        /// <para>
        /// The security group mapping strategy to use.
        /// </para>
        /// </summary>
        public SecurityGroupMappingStrategy SecurityGroupMappingStrategy
        {
            get { return this._securityGroupMappingStrategy; }
            set { this._securityGroupMappingStrategy = value; }
        }

        // Check to see if SecurityGroupMappingStrategy property is set
        internal bool IsSetSecurityGroupMappingStrategy()
        {
            return this._securityGroupMappingStrategy != null;
        }

    }
}