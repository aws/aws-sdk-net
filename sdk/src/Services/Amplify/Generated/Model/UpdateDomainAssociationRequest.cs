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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomainAssociation operation.
    /// Creates a new domain association for an Amplify app.
    /// </summary>
    public partial class UpdateDomainAssociationRequest : AmazonAmplifyRequest
    {
        private string _appId;
        private List<string> _autoSubDomainCreationPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _autoSubDomainIAMRole;
        private CertificateSettings _certificateSettings;
        private string _domainName;
        private bool? _enableAutoSubDomain;
        private List<SubDomainSetting> _subDomainSettings = AWSConfigs.InitializeCollections ? new List<SubDomainSetting>() : null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoSubDomainCreationPatterns
        {
            get { return this._autoSubDomainCreationPatterns; }
            set { this._autoSubDomainCreationPatterns = value; }
        }

        // Check to see if AutoSubDomainCreationPatterns property is set
        internal bool IsSetAutoSubDomainCreationPatterns()
        {
            return this._autoSubDomainCreationPatterns != null && (this._autoSubDomainCreationPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property CertificateSettings. 
        /// <para>
        /// The type of SSL/TLS certificate to use for your custom domain.
        /// </para>
        /// </summary>
        public CertificateSettings CertificateSettings
        {
            get { return this._certificateSettings; }
            set { this._certificateSettings = value; }
        }

        // Check to see if CertificateSettings property is set
        internal bool IsSetCertificateSettings()
        {
            return this._certificateSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  The name of the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
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
        public bool? EnableAutoSubDomain
        {
            get { return this._enableAutoSubDomain; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=500)]
        public List<SubDomainSetting> SubDomainSettings
        {
            get { return this._subDomainSettings; }
            set { this._subDomainSettings = value; }
        }

        // Check to see if SubDomainSettings property is set
        internal bool IsSetSubDomainSettings()
        {
            return this._subDomainSettings != null && (this._subDomainSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}