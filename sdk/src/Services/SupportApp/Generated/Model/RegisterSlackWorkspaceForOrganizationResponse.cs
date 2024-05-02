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
    /// This is the response object from the RegisterSlackWorkspaceForOrganization operation.
    /// </summary>
    public partial class RegisterSlackWorkspaceForOrganizationResponse : AmazonWebServiceResponse
    {
        private AccountType _accountType;
        private string _teamId;
        private string _teamName;

        /// <summary>
        /// Gets and sets the property AccountType. 
        /// <para>
        /// Whether the Amazon Web Services account is a management or member account that's part
        /// of an organization in Organizations.
        /// </para>
        /// </summary>
        public AccountType AccountType
        {
            get { return this._accountType; }
            set { this._accountType = value; }
        }

        // Check to see if AccountType property is set
        internal bool IsSetAccountType()
        {
            return this._accountType != null;
        }

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// The team ID in Slack. This ID uniquely identifies a Slack workspace, such as <c>T012ABCDEFG</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property TeamName. 
        /// <para>
        /// The name of the Slack workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TeamName
        {
            get { return this._teamName; }
            set { this._teamName = value; }
        }

        // Check to see if TeamName property is set
        internal bool IsSetTeamName()
        {
            return this._teamName != null;
        }

    }
}