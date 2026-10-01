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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The parameters required to update the configuration of an integration provider.
    /// </summary>
    public partial class ProviderUpdateConfiguration
    {
        /// <summary>
        /// Gets and sets the property Azure. 
        /// <para>
        /// The parameters required to update the configuration for a Microsoft Azure CSPM integration.
        /// </para>
        /// </summary>
        public AzureUpdateConfiguration Azure { get; set; }

        /// <summary>
        /// Checks to see if the Azure property is set.
        /// </summary>
        internal bool IsSetAzure() => this.Azure != null;

        /// <summary>
        /// Gets and sets the property JiraCloud. 
        /// <para>
        /// The parameters required to update the configuration for a Jira Cloud integration.
        /// </para>
        /// </summary>
        public JiraCloudUpdateConfiguration JiraCloud { get; set; }

        /// <summary>
        /// Checks to see if the JiraCloud property is set.
        /// </summary>
        internal bool IsSetJiraCloud() => this.JiraCloud != null;

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        /// The parameters required to update the configuration for a ServiceNow integration.
        /// </para>
        /// </summary>
        public ServiceNowUpdateConfiguration ServiceNow { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNow property is set.
        /// </summary>
        internal bool IsSetServiceNow() => this.ServiceNow != null;
    }
}
