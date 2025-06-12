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
    /// This is the response object from the DescribeType operation.
    /// </summary>
    public partial class DescribeTypeResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private bool? _autoUpdate;
        private string _configurationSchema;
        private string _defaultVersionId;
        private DeprecatedStatus _deprecatedStatus;
        private string _description;
        private string _documentationUrl;
        private string _executionRoleArn;
        private bool? _isActivated;
        private bool? _isDefaultVersion;
        private DateTime? _lastUpdated;
        private string _latestPublicVersion;
        private LoggingConfig _loggingConfig;
        private string _originalTypeArn;
        private string _originalTypeName;
        private ProvisioningType _provisioningType;
        private string _publicVersionNumber;
        private string _publisherId;
        private List<RequiredActivatedType> _requiredActivatedTypes = AWSConfigs.InitializeCollections ? new List<RequiredActivatedType>() : null;
        private string _schema;
        private string _sourceUrl;
        private DateTime? _timeCreated;
        private RegistryType _type;
        private string _typeName;
        private TypeTestsStatus _typeTestsStatus;
        private string _typeTestsStatusDescription;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// Whether CloudFormation automatically updates the extension in this account and Region
        /// when a new <i>minor</i> version is published by the extension publisher. Major versions
        /// released by the publisher must be manually updated. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public.html#registry-public-enable-auto">Automatically
        /// use new versions of extensions</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public bool? AutoUpdate
        {
            get { return this._autoUpdate; }
            set { this._autoUpdate = value; }
        }

        // Check to see if AutoUpdate property is set
        internal bool IsSetAutoUpdate()
        {
            return this._autoUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSchema. 
        /// <para>
        /// A JSON string that represent the current configuration data for the extension in this
        /// account and Region.
        /// </para>
        ///  
        /// <para>
        /// To set the configuration data for an extension, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
        /// configuration data for extensions in your account</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60000)]
        public string ConfigurationSchema
        {
            get { return this._configurationSchema; }
            set { this._configurationSchema = value; }
        }

        // Check to see if ConfigurationSchema property is set
        internal bool IsSetConfigurationSchema()
        {
            return this._configurationSchema != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultVersionId. 
        /// <para>
        /// The ID of the default version of the extension. The default version is used when the
        /// extension version isn't specified.
        /// </para>
        ///  
        /// <para>
        /// This applies only to private extensions you have registered in your account. For public
        /// extensions, both those provided by Amazon Web Services and published by third parties,
        /// CloudFormation returns <c>null</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>.
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
        /// Gets and sets the property DeprecatedStatus. 
        /// <para>
        /// The deprecation status of the extension version.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LIVE</c>: The extension is activated or registered and can be used in CloudFormation
        /// operations, dependent on its provisioning behavior and visibility scope.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEPRECATED</c>: The extension has been deactivated or deregistered and can no
        /// longer be used in CloudFormation operations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For public third-party extensions, CloudFormation returns <c>null</c>.
        /// </para>
        /// </summary>
        public DeprecatedStatus DeprecatedStatus
        {
            get { return this._deprecatedStatus; }
            set { this._deprecatedStatus = value; }
        }

        // Check to see if DeprecatedStatus property is set
        internal bool IsSetDeprecatedStatus()
        {
            return this._deprecatedStatus != null;
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
        /// Gets and sets the property DocumentationUrl. 
        /// <para>
        /// The URL of a page providing detailed documentation for this extension.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string DocumentationUrl
        {
            get { return this._documentationUrl; }
            set { this._documentationUrl = value; }
        }

        // Check to see if DocumentationUrl property is set
        internal bool IsSetDocumentationUrl()
        {
            return this._documentationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM execution role used to register the extension.
        /// This applies only to private extensions you have registered in your account. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>.
        /// </para>
        ///  
        /// <para>
        /// If the registered extension calls any Amazon Web Services APIs, you must create an
        /// <i> <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM execution
        /// role</a> </i> that includes the necessary permissions to call those Amazon Web Services
        /// APIs, and provision that execution role in your account. CloudFormation then assumes
        /// that execution role to provide your extension with the appropriate credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property IsActivated. 
        /// <para>
        /// Whether the extension is activated in the account and Region.
        /// </para>
        ///  
        /// <para>
        /// This only applies to public third-party extensions. For all other extensions, CloudFormation
        /// returns <c>null</c>.
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
        /// Gets and sets the property IsDefaultVersion. 
        /// <para>
        /// Whether the specified extension version is set as the default version.
        /// </para>
        ///  
        /// <para>
        /// This applies only to private extensions you have registered in your account, and extensions
        /// published by Amazon Web Services. For public third-party extensions, whether they
        /// are activated in your account, CloudFormation returns <c>null</c>.
        /// </para>
        /// </summary>
        public bool? IsDefaultVersion
        {
            get { return this._isDefaultVersion; }
            set { this._isDefaultVersion = value; }
        }

        // Check to see if IsDefaultVersion property is set
        internal bool IsSetIsDefaultVersion()
        {
            return this._isDefaultVersion.HasValue; 
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
        /// The latest version of a public extension <i>that is available</i> for use.
        /// </para>
        ///  
        /// <para>
        /// This only applies if you specify a public extension, and you don't specify a version.
        /// For all other requests, CloudFormation returns <c>null</c>.
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
        /// Gets and sets the property LoggingConfig. 
        /// <para>
        /// Contains logging configuration information for private extensions. This applies only
        /// to private extensions you have registered in your account. For public extensions,
        /// both those provided by Amazon Web Services and published by third parties, CloudFormation
        /// returns <c>null</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>.
        /// </para>
        /// </summary>
        public LoggingConfig LoggingConfig
        {
            get { return this._loggingConfig; }
            set { this._loggingConfig = value; }
        }

        // Check to see if LoggingConfig property is set
        internal bool IsSetLoggingConfig()
        {
            return this._loggingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalTypeArn. 
        /// <para>
        /// For public extensions that have been activated for this account and Region, the Amazon
        /// Resource Name (ARN) of the public extension.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string OriginalTypeArn
        {
            get { return this._originalTypeArn; }
            set { this._originalTypeArn = value; }
        }

        // Check to see if OriginalTypeArn property is set
        internal bool IsSetOriginalTypeArn()
        {
            return this._originalTypeArn != null;
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
        /// Gets and sets the property ProvisioningType. 
        /// <para>
        /// For resource type extensions, the provisioning behavior of the resource type. CloudFormation
        /// determines the provisioning type during registration, based on the types of handlers
        /// in the schema handler package submitted.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FULLY_MUTABLE</c>: The resource type includes an update handler to process updates
        /// to the type during stack update operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMMUTABLE</c>: The resource type doesn't include an update handler, so the type
        /// can't be updated and must instead be replaced during stack update operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_PROVISIONABLE</c>: The resource type doesn't include all the following handlers,
        /// and therefore can't actually be provisioned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// create
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// read
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// delete
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public ProvisioningType ProvisioningType
        {
            get { return this._provisioningType; }
            set { this._provisioningType = value; }
        }

        // Check to see if ProvisioningType property is set
        internal bool IsSetProvisioningType()
        {
            return this._provisioningType != null;
        }

        /// <summary>
        /// Gets and sets the property PublicVersionNumber. 
        /// <para>
        /// The version number of a public third-party extension.
        /// </para>
        ///  
        /// <para>
        /// This applies only if you specify a public extension you have activated in your account,
        /// or specify a public extension without specifying a version. For all other extensions,
        /// CloudFormation returns <c>null</c>.
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
        /// The publisher ID of the extension publisher.
        /// </para>
        ///  
        /// <para>
        /// This applies only to public third-party extensions. For private registered extensions,
        /// and extensions provided by Amazon Web Services, CloudFormation returns <c>null</c>.
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
        /// Gets and sets the property RequiredActivatedTypes. 
        /// <para>
        /// For extensions that are modules, the public third-party extensions that must be activated
        /// in your account in order for the module itself to be activated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RequiredActivatedType> RequiredActivatedTypes
        {
            get { return this._requiredActivatedTypes; }
            set { this._requiredActivatedTypes = value; }
        }

        // Check to see if RequiredActivatedTypes property is set
        internal bool IsSetRequiredActivatedTypes()
        {
            return this._requiredActivatedTypes != null && (this._requiredActivatedTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema that defines the extension.
        /// </para>
        ///  
        /// <para>
        /// For more information about extension schemas, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html">Resource
        /// type schema</a> in the <i>CloudFormation Command Line Interface (CLI) User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16777216)]
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// The URL of the source code for the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string SourceUrl
        {
            get { return this._sourceUrl; }
            set { this._sourceUrl = value; }
        }

        // Check to see if SourceUrl property is set
        internal bool IsSetSourceUrl()
        {
            return this._sourceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TimeCreated. 
        /// <para>
        /// When the specified private extension version was registered or activated in your account.
        /// </para>
        /// </summary>
        public DateTime? TimeCreated
        {
            get { return this._timeCreated; }
            set { this._timeCreated = value; }
        }

        // Check to see if TimeCreated property is set
        internal bool IsSetTimeCreated()
        {
            return this._timeCreated.HasValue; 
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
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension.
        /// </para>
        ///  
        /// <para>
        /// If the extension is a public third-party type you have activated with a type name
        /// alias, CloudFormation returns the type name alias. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ActivateType.html">ActivateType</a>.
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

        /// <summary>
        /// Gets and sets the property TypeTestsStatus. 
        /// <para>
        /// The contract test status of the registered extension version. To return the extension
        /// test status of a specific extension version, you must specify <c>VersionId</c>.
        /// </para>
        ///  
        /// <para>
        /// This applies only to registered private extension versions. CloudFormation doesn't
        /// return this information for public extensions, whether they are activated in your
        /// account.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PASSED</c>: The extension has passed all its contract tests.
        /// </para>
        ///  
        /// <para>
        /// An extension must have a test status of <c>PASSED</c> before it can be published.
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-publish.html">Publishing
        /// extensions to make them available for public use</a> in the <i>CloudFormation Command
        /// Line Interface (CLI) User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The extension has failed one or more contract tests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c>: Contract tests are currently being performed on the extension.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_TESTED</c>: Contract tests haven't been performed on the extension.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TypeTestsStatus TypeTestsStatus
        {
            get { return this._typeTestsStatus; }
            set { this._typeTestsStatus = value; }
        }

        // Check to see if TypeTestsStatus property is set
        internal bool IsSetTypeTestsStatus()
        {
            return this._typeTestsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TypeTestsStatusDescription. 
        /// <para>
        /// The description of the test status. To return the extension test status of a specific
        /// extension version, you must specify <c>VersionId</c>.
        /// </para>
        ///  
        /// <para>
        /// This applies only to registered private extension versions. CloudFormation doesn't
        /// return this information for public extensions, whether they are activated in your
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TypeTestsStatusDescription
        {
            get { return this._typeTestsStatusDescription; }
            set { this._typeTestsStatusDescription = value; }
        }

        // Check to see if TypeTestsStatusDescription property is set
        internal bool IsSetTypeTestsStatusDescription()
        {
            return this._typeTestsStatusDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The scope at which the extension is visible and usable in CloudFormation operations.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PRIVATE</c>: The extension is only visible and usable within the account in which
        /// it is registered. CloudFormation marks any extensions you register as <c>PRIVATE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLIC</c>: The extension is publicly visible and usable within any Amazon Web
        /// Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}