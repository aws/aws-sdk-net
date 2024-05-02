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
 * Do not modify this file. This file is generated from the support-app-2021-08-20.normal.json service model.
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
namespace Amazon.SupportApp.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterSlackWorkspaceForOrganization operation.
    /// Registers a Slack workspace for your Amazon Web Services account. To call this API,
    /// your account must be part of an organization in Organizations.
    /// 
    ///  
    /// <para>
    /// If you're the <i>management account</i> and you want to register Slack workspaces
    /// for your organization, you must complete the following tasks:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Sign in to the <a href="https://console.aws.amazon.com/support/app">Amazon Web Services
    /// Support Center</a> and authorize the Slack workspaces where you want your organization
    /// to have access to. See <a href="https://docs.aws.amazon.com/awssupport/latest/user/authorize-slack-workspace.html">Authorize
    /// a Slack workspace</a> in the <i>Amazon Web Services Support User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API to authorize each Slack
    /// workspace for the organization.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// After the management account authorizes the Slack workspace, member accounts can call
    /// this API to authorize the same Slack workspace for their individual accounts. Member
    /// accounts don't need to authorize the Slack workspace manually through the <a href="https://console.aws.amazon.com/support/app">Amazon
    /// Web Services Support Center</a>.
    /// </para>
    ///  
    /// <para>
    /// To use the Amazon Web Services Support App, each account must then complete the following
    /// tasks:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Create an Identity and Access Management (IAM) role with the required permission.
    /// For more information, see <a href="https://docs.aws.amazon.com/awssupport/latest/user/support-app-permissions.html">Managing
    /// access to the Amazon Web Services Support App</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Configure a Slack channel to use the Amazon Web Services Support App for support cases
    /// for that account. For more information, see <a href="https://docs.aws.amazon.com/awssupport/latest/user/add-your-slack-channel.html">Configuring
    /// a Slack channel</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RegisterSlackWorkspaceForOrganizationRequest : AmazonSupportAppRequest
    {
        private string _teamId;

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// The team ID in Slack. This ID uniquely identifies a Slack workspace, such as <c>T012ABCDEFG</c>.
        /// Specify the Slack workspace that you want to use for your organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TeamId
        {
            get { return this._teamId; }
            set { this._teamId = value; }
        }

        // Check to see if TeamId property is set
        internal bool IsSetTeamId()
        {
            return this._teamId != null;
        }

    }
}