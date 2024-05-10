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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateImpersonationRole operation.
    /// Creates an impersonation role for the given WorkMail organization.
    /// 
    ///  
    /// <para>
    ///  <i>Idempotency</i> ensures that an API request completes no more than one time. With
    /// an idempotent request, if the original request completes successfully, any subsequent
    /// retries also complete successfully without performing any further actions.
    /// </para>
    /// </summary>
    public partial class CreateImpersonationRoleRequest : AmazonWorkMailRequest
    {
        private string _clientToken;
        private string _description;
        private string _name;
        private string _organizationId;
        private List<ImpersonationRule> _rules = AWSConfigs.InitializeCollections ? new List<ImpersonationRule>() : null;
        private ImpersonationRoleType _type;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the client request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the new impersonation role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new impersonation role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The WorkMail organization to create the new impersonation role within.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The list of rules for the impersonation role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<ImpersonationRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The impersonation role's type. The available impersonation role types are <c>READ_ONLY</c>
        /// or <c>FULL_ACCESS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImpersonationRoleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}