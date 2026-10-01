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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateDomainAssociation operation. Creates a new
    /// domain association for an Amplify app. This action associates a custom domain with
    /// the Amplify app
    /// </summary>
    public partial class CreateDomainAssociationRequest : AmazonAmplifyRequest
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        ///  The unique ID for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property AutoSubDomainCreationPatterns. 
        /// <para>
        ///  Sets the branch patterns for automatic subdomain creation. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoSubDomainCreationPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutoSubDomainCreationPatterns property is set.
        /// </summary>
        internal bool IsSetAutoSubDomainCreationPatterns() => this.AutoSubDomainCreationPatterns != null && (this.AutoSubDomainCreationPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoSubDomainIAMRole. 
        /// <para>
        ///  The required AWS Identity and Access Management (IAM) service role for the Amazon
        /// Resource Name (ARN) for automatically creating subdomains. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string AutoSubDomainIAMRole { get; set; }

        /// <summary>
        /// Checks to see if the AutoSubDomainIAMRole property is set.
        /// </summary>
        internal bool IsSetAutoSubDomainIAMRole() => this.AutoSubDomainIAMRole != null;

        /// <summary>
        /// Gets and sets the property CertificateSettings. 
        /// <para>
        /// The type of SSL/TLS certificate to use for your custom domain. If you don't specify
        /// a certificate type, Amplify uses the default certificate that it provisions and manages
        /// for you.
        /// </para>
        /// </summary>
        public CertificateSettings CertificateSettings { get; set; }

        /// <summary>
        /// Checks to see if the CertificateSettings property is set.
        /// </summary>
        internal bool IsSetCertificateSettings() => this.CertificateSettings != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  The domain name for the domain association. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property EnableAutoSubDomain. 
        /// <para>
        ///  Enables the automated creation of subdomains for branches. 
        /// </para>
        /// </summary>
        public bool? EnableAutoSubDomain { get; set; }

        /// <summary>
        /// Checks to see if the EnableAutoSubDomain property is set.
        /// </summary>
        internal bool IsSetEnableAutoSubDomain() => this.EnableAutoSubDomain.HasValue;

        /// <summary>
        /// Gets and sets the property SubDomainSettings. 
        /// <para>
        ///  The setting for the subdomain. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public List<SubDomainSetting> SubDomainSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<SubDomainSetting>() : null;

        /// <summary>
        /// Checks to see if the SubDomainSettings property is set.
        /// </summary>
        internal bool IsSetSubDomainSettings() => this.SubDomainSettings != null && (this.SubDomainSettings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
