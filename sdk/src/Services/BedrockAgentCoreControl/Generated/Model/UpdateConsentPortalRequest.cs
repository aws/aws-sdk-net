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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConsentPortal operation.
    /// Updates an existing consent portal.
    /// </summary>
    public partial class UpdateConsentPortalRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _consentPortalIdentifier;
        private string _description;
        private string _executionRoleArn;
        private ConsentPortalIdpConfig _idpConfig;

        /// <summary>
        /// Gets and sets the property ConsentPortalIdentifier. 
        /// <para>
        /// The identifier of the consent portal. You can specify either the consent portal ID
        /// or its Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsentPortalIdentifier
        {
            get { return this._consentPortalIdentifier; }
            set { this._consentPortalIdentifier = value; }
        }

        // Check to see if ConsentPortalIdentifier property is set
        internal bool IsSetConsentPortalIdentifier()
        {
            return this._consentPortalIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the consent portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the consent portal assumes to
        /// access the resources defined in its sources.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdpConfig. 
        /// <para>
        /// The identity provider configuration that the consent portal uses to authenticate end
        /// users.
        /// </para>
        /// </summary>
        public ConsentPortalIdpConfig IdpConfig
        {
            get { return this._idpConfig; }
            set { this._idpConfig = value; }
        }

        // Check to see if IdpConfig property is set
        internal bool IsSetIdpConfig()
        {
            return this._idpConfig != null;
        }

    }
}