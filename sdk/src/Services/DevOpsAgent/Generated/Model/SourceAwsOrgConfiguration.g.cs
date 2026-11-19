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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Configuration for Amazon Web Services Organization-wide source account integration.
    /// Use this configuration to monitor Amazon Web Services resources across multiple accounts
    /// within an organization or within targeted organizational units.
    /// </summary>
    public partial class SourceAwsOrgConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountType. 
        /// <para>
        /// The account type for this configuration. For Amazon Web Services Organization-level
        /// configurations, this value is <c>source</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceAccountType AccountType { get; set; }

        /// <summary>
        /// Checks to see if the AccountType property is set.
        /// </summary>
        internal bool IsSetAccountType() => this.AccountType != null;

        /// <summary>
        /// Gets and sets the property DeploymentState. 
        /// <para>
        /// The current deployment state of the Amazon Web Services Organization-wide source configuration.
        /// </para>
        /// </summary>
        public OrgSourceDeploymentState DeploymentState { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentState property is set.
        /// </summary>
        internal bool IsSetDeploymentState() => this.DeploymentState != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnit. 
        /// <para>
        /// The organizational units within the Amazon Web Services Organization that are targeted
        /// for source monitoring.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceAwsOrgUnit OrganizationalUnit { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnit property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnit() => this.OrganizationalUnit != null;
    }
}
