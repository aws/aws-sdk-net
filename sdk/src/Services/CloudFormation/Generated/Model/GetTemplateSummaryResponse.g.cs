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
    /// This is the response object from the GetTemplateSummary operation.
    /// </summary>
    public partial class GetTemplateSummaryResponse : AmazonWebServiceResponse
    {
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null && (this.Capabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapabilitiesReason. 
        /// <para>
        /// The list of resources that generated the values in the <c>Capabilities</c> response
        /// element.
        /// </para>
        /// </summary>
        public string CapabilitiesReason { get; set; }

        /// <summary>
        /// Checks to see if the CapabilitiesReason property is set.
        /// </summary>
        internal bool IsSetCapabilitiesReason() => this.CapabilitiesReason != null;

        /// <summary>
        /// Gets and sets the property DeclaredTransforms. 
        /// <para>
        /// A list of the transforms that are declared in the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeclaredTransforms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DeclaredTransforms property is set.
        /// </summary>
        internal bool IsSetDeclaredTransforms() => this.DeclaredTransforms != null && (this.DeclaredTransforms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The value that's defined in the <c>Description</c> property of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The value that's defined for the <c>Metadata</c> property of the template.
        /// </para>
        /// </summary>
        public string Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of parameter declarations that describe various properties for each parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterDeclaration> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ParameterDeclaration>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceIdentifierSummaries. 
        /// <para>
        /// A list of resource identifier summaries that describe the target resources of an import
        /// operation and the properties you can provide during the import to identify the target
        /// resources. For example, <c>BucketName</c> is a possible identifier property for an
        /// <c>AWS::S3::Bucket</c> resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceIdentifierSummary> ResourceIdentifierSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceIdentifierSummary>() : null;

        /// <summary>
        /// Checks to see if the ResourceIdentifierSummaries property is set.
        /// </summary>
        internal bool IsSetResourceIdentifierSummaries() => this.ResourceIdentifierSummaries != null && (this.ResourceIdentifierSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// A list of all the template resource types that are defined in the template, such as
        /// <c>AWS::EC2::Instance</c>, <c>AWS::Dynamo::Table</c>, and <c>Custom::MyCustomInstance</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The Amazon Web Services template format version, which identifies the capabilities
        /// of the template.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// An object that contains any warnings returned.
        /// </para>
        /// </summary>
        public Warnings Warnings { get; set; }

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null;
    }
}
