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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Log status for the Security Lake account.
    /// </summary>
    public partial class LogsStatus
    {
        private SourceStatus _healthStatus;
        private string _pathToLogs;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// Health status of services including error codes and patterns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PathToLogs. 
        /// <para>
        /// Defines path the stored logs are available which has information on your systems,
        /// applications, and services. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PathToLogs
        {
            get { return this._pathToLogs; }
            set { this._pathToLogs = value; }
        }

        // Check to see if PathToLogs property is set
        internal bool IsSetPathToLogs()
        {
            return this._pathToLogs != null;
        }

    }
}