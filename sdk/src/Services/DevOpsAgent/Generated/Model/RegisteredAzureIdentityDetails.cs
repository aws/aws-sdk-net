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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
    /// Details specific to a registered Azure identity using AWS Outbound Identity Federation.
    /// </summary>
    public partial class RegisteredAzureIdentityDetails
    {
        private string _clientId;
        private string _tenantId;
        private string _webIdentityRoleArn;
        private List<string> _webIdentityTokenAudiences = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID of the service principal or managed identity used for authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=36)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The Azure Active Directory tenant ID for the identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=36)]
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

        /// <summary>
        /// Gets and sets the property WebIdentityRoleArn. 
        /// <para>
        /// The role ARN to be assumed by DevOps Agent for requesting Web Identity Token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string WebIdentityRoleArn
        {
            get { return this._webIdentityRoleArn; }
            set { this._webIdentityRoleArn = value; }
        }

        // Check to see if WebIdentityRoleArn property is set
        internal bool IsSetWebIdentityRoleArn()
        {
            return this._webIdentityRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property WebIdentityTokenAudiences. 
        /// <para>
        /// The audiences for the Web Identity Token.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> WebIdentityTokenAudiences
        {
            get { return this._webIdentityTokenAudiences; }
            set { this._webIdentityTokenAudiences = value; }
        }

        // Check to see if WebIdentityTokenAudiences property is set
        internal bool IsSetWebIdentityTokenAudiences()
        {
            return this._webIdentityTokenAudiences != null && (this._webIdentityTokenAudiences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}