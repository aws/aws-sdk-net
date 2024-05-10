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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
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
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// A Microsoft Teams team that has been authorized with AWS Chatbot.
    /// </summary>
    public partial class ConfiguredTeam
    {
        private string _teamId;
        private string _teamName;
        private string _tenantId;

        /// <summary>
        /// Gets and sets the property TeamId. The ID of the Microsoft Team authorized with AWS
        /// Chatbot. To get the team ID, you must perform the initial authorization flow with
        /// Microsoft Teams in the AWS Chatbot console. Then you can copy and paste the team ID
        /// from the console. For more details, see steps 1-4 in Get started with Microsoft Teams
        /// in the AWS Chatbot Administrator Guide.
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property TeamName. The name of the Microsoft Teams Team.
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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

        /// <summary>
        /// Gets and sets the property TenantId. The ID of the Microsoft Teams tenant.
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }

        // Check to see if TenantId property is set
        internal bool IsSetTenantId()
        {
            return this._tenantId != null;
        }

    }
}