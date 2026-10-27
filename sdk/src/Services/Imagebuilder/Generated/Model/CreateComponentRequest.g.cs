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
    /// Container for the parameters to the CreateComponent operation. Creates a new component
    /// that can be used to build, validate, test, and assess your image. The component is
    /// based on a YAML document that you specify using exactly one of the following methods:
    /// <ul> <li> <para> Inline, using the <c>data</c> property in the request body. </para>
    /// </li> <li> <para> A URL that points to a YAML document file stored in Amazon S3, using
    /// the <c>uri</c> property in the request body. </para> </li> </ul> <para> Image Builder
    /// determines the component type from the document. If the document contains a single
    /// phase named <c>test</c>, the component type is <c>TEST</c>. Otherwise, the component
    /// type is <c>BUILD</c>. </para>
    /// </summary>
    public partial class CreateComponentRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property ChangeDescription. 
        /// <para>
        /// The change description of the component. Describes what change has been made in this
        /// version, or what makes this version different from other versions of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ChangeDescription { get; set; }

        /// <summary>
        /// Checks to see if the ChangeDescription property is set.
        /// </summary>
        internal bool IsSetChangeDescription() => this.ChangeDescription != null;

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
        /// Gets and sets the property Data. 
        /// <para>
        /// Component <c>data</c> contains inline YAML document content for the component. Alternatively,
        /// you can specify the <c>uri</c> of a YAML document file stored in Amazon S3. However,
        /// you cannot specify both properties.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16000)]
        public string Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes the contents of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Validates the required permissions and request parameters without performing the operation.
        /// If validation succeeds, the operation returns a <c>DryRunOperationException</c> error
        /// response.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the KMS key used to encrypt
        /// this component. This can be either the Key ARN or the Alias ARN. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">Key
        /// identifiers (KeyId)</a> in the <i>Key Management Service Developer Guide</i>. If you
        /// don't specify a key, Image Builder encrypts the component data with a KMS key that
        /// Image Builder owns.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the component. Image Builder generates the component ARN from a normalized
        /// form of the name, so names that differ only in case, spaces, or underscores count
        /// as the same name. If a component with the same name and semantic version already exists
        /// in your account in the same Amazon Web Services Region, the request creates a new
        /// build version for it. If the content is also identical to the latest build version,
        /// the request fails because the component already exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The semantic version of the component. This version follows the semantic version syntax.
        /// </para>
        ///  <note> 
        /// <para>
        /// The semantic version has four nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;/&lt;build&gt;.
        /// You can assign values for the first three, and can filter on all of them.
        /// </para>
        ///  
        /// <para>
        ///  <b>Assignment:</b> For the first three nodes, you can assign any positive integer
        /// value, including zero. The upper limit is 2^30-1, or 1073741823, for each node. Image
        /// Builder automatically assigns the build number to the fourth node.
        /// </para>
        ///  
        /// <para>
        ///  <b>Patterns:</b> You can use any numeric pattern that adheres to the assignment requirements
        /// for the nodes that you can assign. For example, you might choose a software version
        /// pattern, such as 1.0.0, or a date, such as 2021.01.01.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SemanticVersion { get; set; }

        /// <summary>
        /// Checks to see if the SemanticVersion property is set.
        /// </summary>
        internal bool IsSetSemanticVersion() => this.SemanticVersion != null;

        /// <summary>
        /// Gets and sets the property SupportedOsVersions. 
        /// <para>
        /// The operating system (OS) version supported by the component. If the OS information
        /// is available, a prefix match is performed against the base image OS version during
        /// image recipe creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public List<string> SupportedOsVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedOsVersions property is set.
        /// </summary>
        internal bool IsSetSupportedOsVersions() => this.SupportedOsVersions != null && (this.SupportedOsVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that apply to the component.
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
        /// The <c>uri</c> of a YAML component document file. This must be an S3 URL (<c>s3://bucket/key</c>),
        /// and you must have permission to access the S3 bucket it points to. If you use Amazon
        /// S3, you can specify component content up to your service quota for component size,
        /// which is 64 KB by default.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can specify the YAML document inline, using the component <c>data</c>
        /// property. You cannot specify both properties.
        /// </para>
        /// </summary>
        public string Uri { get; set; }

        /// <summary>
        /// Checks to see if the Uri property is set.
        /// </summary>
        internal bool IsSetUri() => this.Uri != null;
    }
}
