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
    /// This is the response object from the GetAppLaunchConfiguration operation.
    /// </summary>
    public partial class GetAppLaunchConfigurationResponse : AmazonWebServiceResponse
    {
        private string _appId;
        private bool? _autoLaunch;
        private string _roleName;
        private List<ServerGroupLaunchConfiguration> _serverGroupLaunchConfigurations = AWSConfigs.InitializeCollections ? new List<ServerGroupLaunchConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property AutoLaunch. 
        /// <para>
        /// Indicates whether the application is configured to launch automatically after replication
        /// is complete.
        /// </para>
        /// </summary>
        public bool? AutoLaunch
        {
            get { return this._autoLaunch; }
            set { this._autoLaunch = value; }
        }

        // Check to see if AutoLaunch property is set
        internal bool IsSetAutoLaunch()
        {
            return this._autoLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the service role in the customer's account that CloudFormation uses to
        /// launch the application.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerGroupLaunchConfigurations. 
        /// <para>
        /// The launch configurations for server groups in this application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerGroupLaunchConfiguration> ServerGroupLaunchConfigurations
        {
            get { return this._serverGroupLaunchConfigurations; }
            set { this._serverGroupLaunchConfigurations = value; }
        }

        // Check to see if ServerGroupLaunchConfigurations property is set
        internal bool IsSetServerGroupLaunchConfigurations()
        {
            return this._serverGroupLaunchConfigurations != null && (this._serverGroupLaunchConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}