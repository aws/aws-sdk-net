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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
    /// Container for the parameters to the CreateComponent operation.
    /// Creates a new component that can be used to build, validate, test, and assess your
    /// image. The component is based on a YAML document that you specify using exactly one
    /// of the following methods:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Inline, using the <c>data</c> property in the request body.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A URL that points to a YAML document file stored in Amazon S3, using the <c>uri</c>
    /// property in the request body.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Image Builder determines the component type from the document. If the document contains
    /// a single phase named <c>test</c>, the component type is <c>TEST</c>. Otherwise, the
    /// component type is <c>BUILD</c>.
    /// </para>
    /// </summary>
    public partial class CreateComponentRequest : AmazonImagebuilderRequest
    {
        private string _changeDescription;
        private string _clientToken;
        private string _data;
        private string _description;
        private bool? _dryRun;
        private string _kmsKeyId;
        private string _name;
        private Platform _platform;
        private string _semanticVersion;
        private List<string> _supportedOsVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _uri;

        /// <summary>
        /// Gets and sets the property ChangeDescription. 
        /// <para>
        /// The change description of the component. Describes what change has been made in this
        /// version, or what makes this version different from other versions of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ChangeDescription
        {
            get { return this._changeDescription; }
            set { this._changeDescription = value; }
        }

        // Check to see if ChangeDescription property is set
        internal bool IsSetChangeDescription()
        {
            return this._changeDescription != null;
        }

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
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// Component <c>data</c> contains inline YAML document content for the component. Alternatively,
        /// you can specify the <c>uri</c> of a YAML document file stored in Amazon S3. However,
        /// you cannot specify both properties.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16000)]
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes the contents of the component.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Validates the required permissions and request parameters without performing the operation.
        /// If validation succeeds, the operation returns a <c>DryRunOperationException</c> error
        /// response.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

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
        [AWSProperty(Min=1, Max=1024)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

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
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Platform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

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
        [AWSProperty(Required=true)]
        public string SemanticVersion
        {
            get { return this._semanticVersion; }
            set { this._semanticVersion = value; }
        }

        // Check to see if SemanticVersion property is set
        internal bool IsSetSemanticVersion()
        {
            return this._semanticVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedOsVersions. 
        /// <para>
        /// The operating system (OS) version supported by the component. If the OS information
        /// is available, a prefix match is performed against the base image OS version during
        /// image recipe creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> SupportedOsVersions
        {
            get { return this._supportedOsVersions; }
            set { this._supportedOsVersions = value; }
        }

        // Check to see if SupportedOsVersions property is set
        internal bool IsSetSupportedOsVersions()
        {
            return this._supportedOsVersions != null && (this._supportedOsVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that apply to the component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}