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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
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
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateLicense operation.
    /// Assigns a Grafana Enterprise license to a workspace. To upgrade, you must use <c>ENTERPRISE</c>
    /// for the <c>licenseType</c>, and pass in a valid Grafana Labs token for the <c>grafanaToken</c>.
    /// Upgrading to Grafana Enterprise incurs additional fees. For more information, see
    /// <a href="https://docs.aws.amazon.com/grafana/latest/userguide/upgrade-to-Grafana-Enterprise.html">Upgrade
    /// a workspace to Grafana Enterprise</a>.
    /// </summary>
    public partial class AssociateLicenseRequest : AmazonManagedGrafanaRequest
    {
        private string _grafanaToken;
        private LicenseType _licenseType;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property GrafanaToken. 
        /// <para>
        /// A token from Grafana Labs that ties your Amazon Web Services account with a Grafana
        /// Labs account. For more information, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/upgrade-to-Grafana-Enterprise.html#AMG-workspace-register-enterprise">Link
        /// your account with Grafana Labs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string GrafanaToken
        {
            get { return this._grafanaToken; }
            set { this._grafanaToken = value; }
        }

        // Check to see if GrafanaToken property is set
        internal bool IsSetGrafanaToken()
        {
            return this._grafanaToken != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The type of license to associate with the workspace.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Managed Grafana workspaces no longer support Grafana Enterprise free trials.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public LicenseType LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to associate the license with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}