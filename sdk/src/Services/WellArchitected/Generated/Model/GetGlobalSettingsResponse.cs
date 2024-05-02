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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// This is the response object from the GetGlobalSettings operation.
    /// </summary>
    public partial class GetGlobalSettingsResponse : AmazonWebServiceResponse
    {
        private DiscoveryIntegrationStatus _discoveryIntegrationStatus;
        private AccountJiraConfigurationOutput _jiraConfiguration;
        private OrganizationSharingStatus _organizationSharingStatus;

        /// <summary>
        /// Gets and sets the property DiscoveryIntegrationStatus. 
        /// <para>
        /// Discovery integration status.
        /// </para>
        /// </summary>
        public DiscoveryIntegrationStatus DiscoveryIntegrationStatus
        {
            get { return this._discoveryIntegrationStatus; }
            set { this._discoveryIntegrationStatus = value; }
        }

        // Check to see if DiscoveryIntegrationStatus property is set
        internal bool IsSetDiscoveryIntegrationStatus()
        {
            return this._discoveryIntegrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Jira configuration status.
        /// </para>
        /// </summary>
        public AccountJiraConfigurationOutput JiraConfiguration
        {
            get { return this._jiraConfiguration; }
            set { this._jiraConfiguration = value; }
        }

        // Check to see if JiraConfiguration property is set
        internal bool IsSetJiraConfiguration()
        {
            return this._jiraConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationSharingStatus. 
        /// <para>
        /// Amazon Web Services Organizations sharing status.
        /// </para>
        /// </summary>
        public OrganizationSharingStatus OrganizationSharingStatus
        {
            get { return this._organizationSharingStatus; }
            set { this._organizationSharingStatus = value; }
        }

        // Check to see if OrganizationSharingStatus property is set
        internal bool IsSetOrganizationSharingStatus()
        {
            return this._organizationSharingStatus != null;
        }

    }
}