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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
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
namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Configuration for validating an instance.
    /// </summary>
    public partial class ServerGroupValidationConfiguration
    {
        private string _serverGroupId;
        private List<ServerValidationConfiguration> _serverValidationConfigurations = AWSConfigs.InitializeCollections ? new List<ServerValidationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ServerGroupId. 
        /// <para>
        /// The ID of the server group.
        /// </para>
        /// </summary>
        public string ServerGroupId
        {
            get { return this._serverGroupId; }
            set { this._serverGroupId = value; }
        }

        // Check to see if ServerGroupId property is set
        internal bool IsSetServerGroupId()
        {
            return this._serverGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerValidationConfigurations. 
        /// <para>
        /// The validation configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerValidationConfiguration> ServerValidationConfigurations
        {
            get { return this._serverValidationConfigurations; }
            set { this._serverValidationConfigurations = value; }
        }

        // Check to see if ServerValidationConfigurations property is set
        internal bool IsSetServerValidationConfigurations()
        {
            return this._serverValidationConfigurations != null && (this._serverValidationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}