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
    /// This is the response object from the DescribeType operation.
    /// </summary>
    public partial class DescribeTypeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// Whether CloudFormation automatically updates the extension in this account and Region
        /// when a new <i>minor</i> version is published by the extension publisher. Major versions
        /// released by the publisher must be manually updated. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public.html#registry-public-enable-auto">Automatically
        /// use new versions of extensions</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public bool? AutoUpdate { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpdate property is set.
        /// </summary>
        internal bool IsSetAutoUpdate() => this.AutoUpdate.HasValue;

        /// <summary>
        /// Gets and sets the property ConfigurationSchema. 
        /// <para>
        /// A JSON string that represent the current configuration data for the extension in this
        /// account and Region.
        /// </para>
        ///  
        /// <para>
        /// To set the configuration data for an extension, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60000)]
        public string ConfigurationSchema { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSchema property is set.
        /// </summary>
        internal bool IsSetConfigurationSchema() => this.ConfigurationSchema != null;

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
        [AWSProperty(Min = 1, Max = 128)]
        public string DefaultVersionId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultVersionId property is set.
        /// </summary>
        internal bool IsSetDefaultVersionId() => this.DefaultVersionId != null;

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
        public DeprecatedStatus DeprecatedStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeprecatedStatus property is set.
        /// </summary>
        internal bool IsSetDeprecatedStatus() => this.DeprecatedStatus != null;

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
        /// Gets and sets the property DocumentationUrl. 
        /// <para>
        /// The URL of a page providing detailed documentation for this extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string DocumentationUrl { get; set; }

        /// <summary>
        /// Checks to see if the DocumentationUrl property is set.
        /// </summary>
        internal bool IsSetDocumentationUrl() => this.DocumentationUrl != null;

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
        [AWSProperty(Min = 1, Max = 256)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

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
        public bool? IsActivated { get; set; }

        /// <summary>
        /// Checks to see if the IsActivated property is set.
        /// </summary>
        internal bool IsSetIsActivated() => this.IsActivated.HasValue;

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
        public bool? IsDefaultVersion { get; set; }

        /// <summary>
        /// Checks to see if the IsDefaultVersion property is set.
        /// </summary>
        internal bool IsSetIsDefaultVersion() => this.IsDefaultVersion.HasValue;

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
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

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
        [AWSProperty(Min = 5)]
        public string LatestPublicVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestPublicVersion property is set.
        /// </summary>
        internal bool IsSetLatestPublicVersion() => this.LatestPublicVersion != null;

        /// <summary>
        /// Gets and sets the property LoggingConfig. 
        /// <para>
        /// Contains logging configuration information for private extensions. This applies only
        /// to private extensions you have registered in your account. For public extensions,
        /// both those provided by Amazon Web Services and published by third parties, CloudFormation
        /// returns <c>null</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>.
        /// </para>
        /// </summary>
        public LoggingConfig LoggingConfig { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfig property is set.
        /// </summary>
        internal bool IsSetLoggingConfig() => this.LoggingConfig != null;

        /// <summary>
        /// Gets and sets the property OriginalTypeArn. 
        /// <para>
        /// For public extensions that have been activated for this account and Region, the Amazon
        /// Resource Name (ARN) of the public extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OriginalTypeArn { get; set; }

        /// <summary>
        /// Checks to see if the OriginalTypeArn property is set.
        /// </summary>
        internal bool IsSetOriginalTypeArn() => this.OriginalTypeArn != null;

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
        public ProvisioningType ProvisioningType { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningType property is set.
        /// </summary>
        internal bool IsSetProvisioningType() => this.ProvisioningType != null;

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
        [AWSProperty(Min = 5)]
        public string PublicVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the PublicVersionNumber property is set.
        /// </summary>
        internal bool IsSetPublicVersionNumber() => this.PublicVersionNumber != null;

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
        [AWSProperty(Min = 1, Max = 40)]
        public string PublisherId { get; set; }

        /// <summary>
        /// Checks to see if the PublisherId property is set.
        /// </summary>
        internal bool IsSetPublisherId() => this.PublisherId != null;

        /// <summary>
        /// Gets and sets the property RequiredActivatedTypes. 
        /// <para>
        /// For extensions that are modules, the public third-party extensions that must be activated
        /// in your account in order for the module itself to be activated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RequiredActivatedType> RequiredActivatedTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<RequiredActivatedType>() : null;

        /// <summary>
        /// Checks to see if the RequiredActivatedTypes property is set.
        /// </summary>
        internal bool IsSetRequiredActivatedTypes() => this.RequiredActivatedTypes != null && (this.RequiredActivatedTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema that defines the extension.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html">Resource
        /// type schema</a> in the <i>CloudFormation Command Line Interface (CLI) User Guide</i>
        /// and the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/hooks-userguide/what-is-cloudformation-hooks.html">CloudFormation
        /// Hooks User Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16777216)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// The URL of the source code for the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceUrl property is set.
        /// </summary>
        internal bool IsSetSourceUrl() => this.SourceUrl != null;

        /// <summary>
        /// Gets and sets the property TimeCreated. 
        /// <para>
        /// When the specified private extension version was registered or activated in your account.
        /// </para>
        /// </summary>
        public DateTime? TimeCreated { get; set; }

        /// <summary>
        /// Checks to see if the TimeCreated property is set.
        /// </summary>
        internal bool IsSetTimeCreated() => this.TimeCreated.HasValue;

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
        [AWSProperty(Min = 10, Max = 204)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;

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
        public TypeTestsStatus TypeTestsStatus { get; set; }

        /// <summary>
        /// Checks to see if the TypeTestsStatus property is set.
        /// </summary>
        internal bool IsSetTypeTestsStatus() => this.TypeTestsStatus != null;

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
        [AWSProperty(Min = 1, Max = 1024)]
        public string TypeTestsStatusDescription { get; set; }

        /// <summary>
        /// Checks to see if the TypeTestsStatusDescription property is set.
        /// </summary>
        internal bool IsSetTypeTestsStatusDescription() => this.TypeTestsStatusDescription != null;

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
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
