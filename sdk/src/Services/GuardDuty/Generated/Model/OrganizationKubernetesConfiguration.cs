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
    /// Organization-wide Kubernetes data sources configurations.
    /// </summary>
    public partial class OrganizationKubernetesConfiguration
    {
        private OrganizationKubernetesAuditLogsConfiguration _auditLogs;

        /// <summary>
        /// Gets and sets the property AuditLogs. 
        /// <para>
        /// Whether Kubernetes audit logs data source should be auto-enabled for new members joining
        /// the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationKubernetesAuditLogsConfiguration AuditLogs
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