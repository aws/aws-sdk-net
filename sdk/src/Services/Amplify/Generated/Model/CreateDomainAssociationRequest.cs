/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomainAssociation operation.
    /// Create a new DomainAssociation on an App
    /// </summary>
    public partial class CreateDomainAssociationRequest : AmazonAmplifyRequest
    {
        private string _appId;
        private string _domainName;
        private bool? _enableAutoSubDomain;
        private List<SubDomainSetting> _subDomainSettings = new List<SubDomainSetting>();

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        ///  Unique Id for an Amplify App. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  Domain name for the Domain Association. 
        /// </para>
        /// </summary>
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
        ///  Enables automated creation of Subdomains for branches. 
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
        ///  Setting structure for the Subdomain. 
        /// </para>
        /// </summary>
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