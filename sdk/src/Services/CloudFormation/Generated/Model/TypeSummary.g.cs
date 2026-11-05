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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Contains summary information about the specified CloudFormation extension.
    /// </summary>
    public partial class TypeSummary
    {
        /// <summary>
        /// Gets and sets the property DefaultVersionId. 
        /// <para>
        /// The ID of the default version of the extension. The default version is used when the
        /// extension version isn't specified.
        /// </para>
        ///  
        /// <para>
        /// This applies only to private extensions you have registered in your account. For public
        /// extensions, both those provided by Amazon and published by third parties, CloudFormation
        /// returns <c>null</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>.
        /// </para>
        ///  
        /// <para>
        /// To set the default version of an extension, use <a>SetTypeDefaultVersion</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DefaultVersionId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultVersionId property is set.
        /// </summary>
        internal bool IsSetDefaultVersionId() => this.DefaultVersionId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsActivated. 
        /// <para>
        /// Whether the extension is activated for this account and Region.
        /// </para>
        ///  
        /// <para>
        /// This applies only to third-party public extensions. Extensions published by Amazon
        /// are activated by default.
        /// </para>
        /// </summary>
        public bool? IsActivated { get; set; }

        /// <summary>
        /// Checks to see if the IsActivated property is set.
        /// </summary>
        internal bool IsSetIsActivated() => this.IsActivated.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// When the specified extension version was registered. This applies only to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Private extensions you have registered in your account. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Public extensions you have activated in your account with auto-update specified. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ActivateType.html">ActivateType</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For all other extension types, CloudFormation returns <c>null</c>.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property LatestPublicVersion. 
        /// <para>
        /// For public extensions that have been activated for this account and Region, the latest
        /// version of the public extension <i>that is available</i>. For any extensions other
        /// than activated third-party extensions, CloudFormation returns <c>null</c>.
        /// </para>
        ///  
        /// <para>
        /// How you specified <c>AutoUpdate</c> when enabling the extension affects whether CloudFormation
        /// automatically updates the extension in this account and Region when a new version
        /// is released. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public.html#registry-public-enable-auto">Automatically
        /// use new versions of extensions</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5)]
        public string LatestPublicVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestPublicVersion property is set.
        /// </summary>
        internal bool IsSetLatestPublicVersion() => this.LatestPublicVersion != null;

        /// <summary>
        /// Gets and sets the property OriginalTypeName. 
        /// <para>
        /// For public extensions that have been activated for this account and Region, the type
        /// name of the public extension.
        /// </para>
        ///  
        /// <para>
        /// If you specified a <c>TypeNameAlias</c> when enabling the extension in this account
        /// and Region, CloudFormation treats that alias as the extension's type name within the
        /// account and Region, not the type name of the public extension. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public.html#registry-public-enable-alias">Use
        /// aliases to refer to extensions</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 204)]
        public string OriginalTypeName { get; set; }

        /// <summary>
        /// Checks to see if the OriginalTypeName property is set.
        /// </summary>
        internal bool IsSetOriginalTypeName() => this.OriginalTypeName != null;

        /// <summary>
        /// Gets and sets the property PublicVersionNumber. 
        /// <para>
        /// For public extensions that have been activated for this account and Region, the version
        /// of the public extension to be used for CloudFormation operations in this account and
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// How you specified <c>AutoUpdate</c> when enabling the extension affects whether CloudFormation
        /// automatically updates the extension in this account and Region when a new version
        /// is released. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public.html#registry-public-enable-auto">Automatically
        /// use new versions of extensions</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5)]
        public string PublicVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the PublicVersionNumber property is set.
        /// </summary>
        internal bool IsSetPublicVersionNumber() => this.PublicVersionNumber != null;

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The ID of the extension publisher, if the extension is published by a third party.
        /// Extensions published by Amazon don't return a publisher ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string PublisherId { get; set; }

        /// <summary>
        /// Checks to see if the PublisherId property is set.
        /// </summary>
        internal bool IsSetPublisherId() => this.PublisherId != null;

        /// <summary>
        /// Gets and sets the property PublisherIdentity. 
        /// <para>
        /// The service used to verify the publisher identity.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html">Publishing
        /// extensions to make them available for public use</a> in the <i>CloudFormation Command
        /// Line Interface (CLI) User Guide</i>.
        /// </para>
        /// </summary>
        public IdentityProvider PublisherIdentity { get; set; }

        /// <summary>
        /// Checks to see if the PublisherIdentity property is set.
        /// </summary>
        internal bool IsSetPublisherIdentity() => this.PublisherIdentity != null;

        /// <summary>
        /// Gets and sets the property PublisherName. 
        /// <para>
        /// The publisher name, as defined in the public profile for that publisher in the service
        /// used to verify the publisher identity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PublisherName { get; set; }

        /// <summary>
        /// Checks to see if the PublisherName property is set.
        /// </summary>
        internal bool IsSetPublisherName() => this.PublisherName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of extension.
        /// </para>
        /// </summary>
        public RegistryType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property TypeArn. 
        /// <para>
        /// The ARN of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TypeArn { get; set; }

        /// <summary>
        /// Checks to see if the TypeArn property is set.
        /// </summary>
        internal bool IsSetTypeArn() => this.TypeArn != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension.
        /// </para>
        ///  
        /// <para>
        /// If you specified a <c>TypeNameAlias</c> when you call the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ActivateType.html">ActivateType</a>
        /// API operation in your account and Region, CloudFormation considers that alias as the
        /// type name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 204)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}
