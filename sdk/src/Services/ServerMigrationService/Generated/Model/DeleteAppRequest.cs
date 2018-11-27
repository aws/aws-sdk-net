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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApp operation.
    /// Deletes an existing application. Optionally deletes the launched stack associated
    /// with the application and all AWS SMS replication jobs for servers in the application.
    /// </summary>
    public partial class DeleteAppRequest : AmazonServerMigrationServiceRequest
    {
        private string _appId;
        private bool? _forceStopAppReplication;
        private bool? _forceTerminateApp;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// ID of the application to delete.
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
        /// Gets and sets the property ForceStopAppReplication. 
        /// <para>
        /// While deleting the application, stop all replication jobs corresponding to the servers
        /// in the application.
        /// </para>
        /// </summary>
        public bool ForceStopAppReplication
        {
            get { return this._forceStopAppReplication.GetValueOrDefault(); }
            set { this._forceStopAppReplication = value; }
        }

        // Check to see if ForceStopAppReplication property is set
        internal bool IsSetForceStopAppReplication()
        {
            return this._forceStopAppReplication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceTerminateApp. 
        /// <para>
        /// While deleting the application, terminate the stack corresponding to the application.
        /// </para>
        /// </summary>
        public bool ForceTerminateApp
        {
            get { return this._forceTerminateApp.GetValueOrDefault(); }
            set { this._forceTerminateApp = value; }
        }

        // Check to see if ForceTerminateApp property is set
        internal bool IsSetForceTerminateApp()
        {
            return this._forceTerminateApp.HasValue; 
        }

    }
}