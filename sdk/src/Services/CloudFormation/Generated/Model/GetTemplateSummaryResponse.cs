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
    /// The output for the <a>GetTemplateSummary</a> action.
    /// </summary>
    public partial class GetTemplateSummaryResponse : AmazonWebServiceResponse
    {
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _capabilitiesReason;
        private List<string> _declaredTransforms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _metadata;
        private List<ParameterDeclaration> _parameters = AWSConfigs.InitializeCollections ? new List<ParameterDeclaration>() : null;
        private List<ResourceIdentifierSummary> _resourceIdentifierSummaries = AWSConfigs.InitializeCollections ? new List<ResourceIdentifierSummary>() : null;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _version;
        private Warnings _warnings;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities found within the template. If your template contains IAM resources,
        /// you must specify the <c>CAPABILITY_IAM</c> or <c>CAPABILITY_NAMED_IAM</c> value for
        /// this parameter when you use the <a>CreateStack</a> or <a>UpdateStack</a> actions with
        /// your template; otherwise, those actions return an <c>InsufficientCapabilities</c>
        /// error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/control-access-with-iam.html#using-iam-capabilities">Acknowledging
        /// IAM resources in CloudFormation templates</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && (this._capabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapabilitiesReason. 
        /// <para>
        /// The list of resources that generated the values in the <c>Capabilities</c> response
        /// element.
        /// </para>
        /// </summary>
        public string CapabilitiesReason
        {
            get { return this._capabilitiesReason; }
            set { this._capabilitiesReason = value; }
        }

        // Check to see if CapabilitiesReason property is set
        internal bool IsSetCapabilitiesReason()
        {
            return this._capabilitiesReason != null;
        }

        /// <summary>
        /// Gets and sets the property DeclaredTransforms. 
        /// <para>
        /// A list of the transforms that are declared in the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeclaredTransforms
        {
            get { return this._declaredTransforms; }
            set { this._declaredTransforms = value; }
        }

        // Check to see if DeclaredTransforms property is set
        internal bool IsSetDeclaredTransforms()
        {
            return this._declaredTransforms != null && (this._declaredTransforms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The value that's defined in the <c>Description</c> property of the template.
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
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The value that's defined for the <c>Metadata</c> property of the template.
        /// </para>
        /// </summary>
        public string Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of parameter declarations that describe various properties for each parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterDeclaration> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifierSummaries. 
        /// <para>
        /// A list of resource identifier summaries that describe the target resources of an import
        /// operation and the properties you can provide during the import to identify the target
        /// resources. For example, <c>BucketName</c> is a possible identifier property for an
        /// <c>AWS::S3::Bucket</c> resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceIdentifierSummary> ResourceIdentifierSummaries
        {
            get { return this._resourceIdentifierSummaries; }
            set { this._resourceIdentifierSummaries = value; }
        }

        // Check to see if ResourceIdentifierSummaries property is set
        internal bool IsSetResourceIdentifierSummaries()
        {
            return this._resourceIdentifierSummaries != null && (this._resourceIdentifierSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// A list of all the template resource types that are defined in the template, such as
        /// <c>AWS::EC2::Instance</c>, <c>AWS::Dynamo::Table</c>, and <c>Custom::MyCustomInstance</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The Amazon Web Services template format version, which identifies the capabilities
        /// of the template.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// An object that contains any warnings returned.
        /// </para>
        /// </summary>
        public Warnings Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null;
        }

    }
}