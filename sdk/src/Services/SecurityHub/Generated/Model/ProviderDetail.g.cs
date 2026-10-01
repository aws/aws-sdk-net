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
    /// The third-party provider detail for a service configuration.
    /// </summary>
    public partial class ProviderDetail
    {
        /// <summary>
        /// Gets and sets the property Azure. 
        /// <para>
        /// Details about a Microsoft Azure CSPM integration.
        /// </para>
        /// </summary>
        public AzureDetail Azure { get; set; }

        /// <summary>
        /// Checks to see if the Azure property is set.
        /// </summary>
        internal bool IsSetAzure() => this.Azure != null;

        /// <summary>
        /// Gets and sets the property JiraCloud. 
        /// <para>
        /// Details about a Jira Cloud integration.
        /// </para>
        /// </summary>
        public JiraCloudDetail JiraCloud { get; set; }

        /// <summary>
        /// Checks to see if the JiraCloud property is set.
        /// </summary>
        internal bool IsSetJiraCloud() => this.JiraCloud != null;

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        /// Details about a ServiceNow ITSM integration.
        /// </para>
        /// </summary>
        public ServiceNowDetail ServiceNow { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNow property is set.
        /// </summary>
        internal bool IsSetServiceNow() => this.ServiceNow != null;
    }
}
