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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Describes whether any Kubernetes logs will be enabled as a data source.
    /// </summary>
    public partial class KubernetesConfigurationResult
    {
        private KubernetesAuditLogsConfigurationResult _auditLogs;

        /// <summary>
        /// Gets and sets the property AuditLogs. 
        /// <para>
        /// Describes whether Kubernetes audit logs are enabled as a data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KubernetesAuditLogsConfigurationResult AuditLogs
        {
            get { return this._auditLogs; }
            set { this._auditLogs = value; }
        }

        // Check to see if AuditLogs property is set
        internal bool IsSetAuditLogs()
        {
            return this._auditLogs != null;
        }

    }
}