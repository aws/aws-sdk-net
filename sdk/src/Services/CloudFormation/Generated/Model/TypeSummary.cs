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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
        private string _defaultVersionId;
        private string _description;
        private bool? _isActivated;
        private DateTime? _lastUpdated;
        private string _latestPublicVersion;
        private string _originalTypeName;
        private string _publicVersionNumber;
        private string _publisherId;
        private IdentityProvider _publisherIdentity;
        private string _publisherName;
        private RegistryType _type;
        private string _typeArn;
        private string _typeName;

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
        [AWSProperty(Min=1, Max=128)]
        public string DefaultVersionId
        {
            get { return this._defaultVersionId; }
            set { this._defaultVersionId = value; }
        }

        // Check to see if DefaultVersionId property is set
        internal bool IsSetDefaultVersionId()
        {
            return this._defaultVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        public bool? IsActivated
        {
            get { return this._isActivated; }
            set { this._isActivated = value; }
        }

        // Check to see if IsActivated property is set
        internal bool IsSetIsActivated()
        {
            return this._isActivated.HasValue; 
        }

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
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

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
        [AWSProperty(Min=5)]
        public string LatestPublicVersion
        {
            get { return this._latestPublicVersion; }
            set { this._latestPublicVersion = value; }
        }

        // Check to see if LatestPublicVersion property is set
        internal bool IsSetLatestPublicVersion()
        {
            return this._latestPublicVersion != null;
        }

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
        [AWSProperty(Min=10, Max=204)]
        public string OriginalTypeName
        {
            get { return this._originalTypeName; }
            set { this._originalTypeName = value; }
        }

        // Check to see if OriginalTypeName property is set
        internal bool IsSetOriginalTypeName()
        {
            return this._originalTypeName != null;
        }

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
        [AWSProperty(Min=5)]
        public string PublicVersionNumber
        {
            get { return this._publicVersionNumber; }
            set { this._publicVersionNumber = value; }
        }

        // Check to see if PublicVersionNumber property is set
        internal bool IsSetPublicVersionNumber()
        {
            return this._publicVersionNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The ID of the extension publisher, if the extension is published by a third party.
        /// Extensions published by Amazon don't return a publisher ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string PublisherId
        {
            get { return this._publisherId; }
            set { this._publisherId = value; }
        }

        // Check to see if PublisherId property is set
        internal bool IsSetPublisherId()
        {
            return this._publisherId != null;
        }

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
        public IdentityProvider PublisherIdentity
        {
            get { return this._publisherIdentity; }
            set { this._publisherIdentity = value; }
        }

        // Check to see if PublisherIdentity property is set
        internal bool IsSetPublisherIdentity()
        {
            return this._publisherIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property PublisherName. 
        /// <para>
        /// The publisher name, as defined in the public profile for that publisher in the service
        /// used to verify the publisher identity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PublisherName
        {
            get { return this._publisherName; }
            set { this._publisherName = value; }
        }

        // Check to see if PublisherName property is set
        internal bool IsSetPublisherName()
        {
            return this._publisherName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of extension.
        /// </para>
        /// </summary>
        public RegistryType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property TypeArn. 
        /// <para>
        /// The ARN of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TypeArn
        {
            get { return this._typeArn; }
            set { this._typeArn = value; }
        }

        // Check to see if TypeArn property is set
        internal bool IsSetTypeArn()
        {
            return this._typeArn != null;
        }

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
        [AWSProperty(Min=10, Max=204)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}