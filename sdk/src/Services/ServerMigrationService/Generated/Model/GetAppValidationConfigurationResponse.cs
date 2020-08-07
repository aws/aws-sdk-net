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

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// This is the response object from the GetAppValidationConfiguration operation.
    /// </summary>
    public partial class GetAppValidationConfigurationResponse : AmazonWebServiceResponse
    {
        private List<AppValidationConfiguration> _appValidationConfigurations = new List<AppValidationConfiguration>();
        private List<ServerGroupValidationConfiguration> _serverGroupValidationConfigurations = new List<ServerGroupValidationConfiguration>();

        /// <summary>
        /// Gets and sets the property AppValidationConfigurations. 
        /// <para>
        /// The configuration for application validation.
        /// </para>
        /// </summary>
        public List<AppValidationConfiguration> AppValidationConfigurations
        {
            get { return this._appValidationConfigurations; }
            set { this._appValidationConfigurations = value; }
        }

        // Check to see if AppValidationConfigurations property is set
        internal bool IsSetAppValidationConfigurations()
        {
            return this._appValidationConfigurations != null && this._appValidationConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServerGroupValidationConfigurations. 
        /// <para>
        /// The configuration for instance validation.
        /// </para>
        /// </summary>
        public List<ServerGroupValidationConfiguration> ServerGroupValidationConfigurations
        {
            get { return this._serverGroupValidationConfigurations; }
            set { this._serverGroupValidationConfigurations = value; }
        }

        // Check to see if ServerGroupValidationConfigurations property is set
        internal bool IsSetServerGroupValidationConfigurations()
        {
            return this._serverGroupValidationConfigurations != null && this._serverGroupValidationConfigurations.Count > 0; 
        }

    }
}