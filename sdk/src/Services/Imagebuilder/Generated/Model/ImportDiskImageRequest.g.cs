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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the ImportDiskImage operation. Imports a Windows operating
    /// system image from a verified Microsoft ISO disk file. The following disk images are
    /// supported: <ul> <li> <para> Windows 11 Enterprise </para> </li> </ul> <para> The response
    /// returns as soon as Image Builder creates the new image resource in the <c>PENDING</c>
    /// state. The conversion from ISO file to AMI then runs asynchronously on an EC2 instance
    /// that Image Builder launches with the specified infrastructure configuration. </para>
    /// </summary>
    public partial class ImportDiskImageRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure that the operation runs
        /// no more than one time. If you retry a request with the same client token, Image Builder
        /// returns the original response without running the operation again. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for your disk image import.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) for the IAM role you create that grants Image
        /// Builder access to perform workflow actions to import an image from a Microsoft ISO
        /// file. If you don't provide a role, Image Builder uses the Image Builder service-linked
        /// role in your account, and creates it if it doesn't exist.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property InfrastructureConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure configuration resource that's
        /// used for launching the EC2 instance on which the ISO image is built.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InfrastructureConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureConfigurationArn property is set.
        /// </summary>
        internal bool IsSetInfrastructureConfigurationArn() => this.InfrastructureConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The CloudWatch Logs log group where Image Builder sends the import logs. If you specify
        /// a log group name outside of the <c>/aws/imagebuilder/</c> namespace, you must also
        /// provide an <c>executionRole</c> that has permission to write to that log group.
        /// </para>
        /// </summary>
        public ImageLoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image resource that's created from the import. Image Builder generates
        /// the image ARN from a normalized form of the name, so names that differ only in case,
        /// spaces, or underscores count as the same name. If an image with the same name and
        /// semantic version already exists in your account in the same Amazon Web Services Region,
        /// the import creates a new build version for it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The operating system version for the imported image. The only supported value is <c>Microsoft
        /// Windows 11</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Checks to see if the OsVersion property is set.
        /// </summary>
        internal bool IsSetOsVersion() => this.OsVersion != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform for the imported image. Allowed values include the following:
        /// <c>Windows</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property RegisterImageOptions. 
        /// <para>
        /// Configures Secure Boot and UEFI settings for the imported image.
        /// </para>
        /// </summary>
        public RegisterImageOptions RegisterImageOptions { get; set; }

        /// <summary>
        /// Checks to see if the RegisterImageOptions property is set.
        /// </summary>
        internal bool IsSetRegisterImageOptions() => this.RegisterImageOptions != null;

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The semantic version to attach to the image that's created during the import process.
        /// This version follows the semantic version syntax.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SemanticVersion { get; set; }

        /// <summary>
        /// Checks to see if the SemanticVersion property is set.
        /// </summary>
        internal bool IsSetSemanticVersion() => this.SemanticVersion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags that are attached to image resources created from the import.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The <c>uri</c> of the ISO disk file that's stored in Amazon S3, in <c>s3://bucket/key</c>
        /// format. The key must end with the <c>.iso</c>, <c>.ISO</c>, or <c>.Iso</c> extension,
        /// and the bucket must be owned by the account that makes the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Checks to see if the Uri property is set.
        /// </summary>
        internal bool IsSetUri() => this.Uri != null;

        /// <summary>
        /// Gets and sets the property WindowsConfiguration. 
        /// <para>
        /// Specifies Windows settings for ISO imports.
        /// </para>
        /// </summary>
        public WindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WindowsConfiguration property is set.
        /// </summary>
        internal bool IsSetWindowsConfiguration() => this.WindowsConfiguration != null;
    }
}
