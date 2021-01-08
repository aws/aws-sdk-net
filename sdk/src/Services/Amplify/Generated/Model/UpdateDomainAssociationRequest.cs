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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomainAssociation operation.
    /// Creates a new domain association for an Amplify app.
    /// </summary>
    public partial class UpdateDomainAssociationRequest : AmazonAmplifyRequest
    {
        private string _appId;
        private List<string> _autoSubDomainCreationPatterns = new List<string>();
        private string _autoSubDomainIAMRole;
        private string _domainName;
        private bool? _enableAutoSubDomain;
        private List<SubDomainSetting> _subDomainSettings = new List<SubDomainSetting>();

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        ///  The unique ID for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property AutoSubDomainCreationPatterns. 
        /// <para>
        ///  Sets the branch patterns for automatic subdomain creation. 
        /// </para>
        /// </summary>
        public List<string> AutoSubDomainCreationPatterns
        {
            get { return this._autoSubDomainCreationPatterns; }
            set { this._autoSubDomainCreationPatterns = value; }
        }

        // Check to see if AutoSubDomainCreationPatterns property is set
        internal bool IsSetAutoSubDomainCreationPatterns()
        {
            return this._autoSubDomainCreationPatterns != null && this._autoSubDomainCreationPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoSubDomainIAMRole. 
        /// <para>
        ///  The required AWS Identity and Access Management (IAM) service role for the Amazon
        /// Resource Name (ARN) for automatically creating subdomains. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string AutoSubDomainIAMRole
        {
            get { return this._autoSubDomainIAMRole; }
            set { this._autoSubDomainIAMRole = value; }
        }

        // Check to see if AutoSubDomainIAMRole property is set
        internal bool IsSetAutoSubDomainIAMRole()
        {
            return this._autoSubDomainIAMRole != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  The name of the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property EnableAutoSubDomain. 
        /// <para>
        ///  Enables the automated creation of subdomains for branches. 
        /// </para>
        /// </summary>
        public bool EnableAutoSubDomain
        {
            get { return this._enableAutoSubDomain.GetValueOrDefault(); }
            set { this._enableAutoSubDomain = value; }
        }

        // Check to see if EnableAutoSubDomain property is set
        internal bool IsSetEnableAutoSubDomain()
        {
            return this._enableAutoSubDomain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubDomainSettings. 
        /// <para>
        ///  Describes the settings for the subdomain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public List<SubDomainSetting> SubDomainSettings
        {
            get { return this._subDomainSettings; }
            set { this._subDomainSettings = value; }
        }

        // Check to see if SubDomainSettings property is set
        internal bool IsSetSubDomainSettings()
        {
            return this._subDomainSettings != null && this._subDomainSettings.Count > 0; 
        }

    }
}