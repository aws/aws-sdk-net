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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAppVersionResource operation. Adds a resource
    /// to the Resilience Hub application and assigns it to the specified Application Components.
    /// If you specify a new Application Component, Resilience Hub will automatically create
    /// the Application Component. <note> <ul> <li> <para> This action has no effect outside
    /// Resilience Hub. </para> </li> <li> <para> This API updates the Resilience Hub application
    /// draft version. To use this resource for running resiliency assessments, you must publish
    /// the Resilience Hub application using the <c>PublishAppVersion</c> API. </para> </li>
    /// <li> <para> To update application version with new <c>physicalResourceID</c>, you
    /// must call <c>ResolveAppVersionResources</c> API. </para> </li> </ul> </note>
    /// </summary>
    public partial class CreateAppVersionResourceRequest : AmazonResilienceHubRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Currently, there is no supported additional information for resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> AdditionalInfo { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the AdditionalInfo property is set.
        /// </summary>
        internal bool IsSetAdditionalInfo() => this.AdditionalInfo != null && (this.AdditionalInfo.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AppArn { get; set; }

        /// <summary>
        /// Checks to see if the AppArn property is set.
        /// </summary>
        internal bool IsSetAppArn() => this.AppArn != null;

        /// <summary>
        /// Gets and sets the property AppComponents. 
        /// <para>
        /// List of Application Components that this resource belongs to. If an Application Component
        /// is not part of the Resilience Hub application, it will be added.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AppComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AppComponents property is set.
        /// </summary>
        internal bool IsSetAppComponents() => this.AppComponents != null && (this.AppComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// Amazon Web Services account that owns the physical resource.
        /// </para>
        /// </summary>
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// Amazon Web Services region that owns the physical resource.
        /// </para>
        /// </summary>
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used for an idempotency token. A client token is a unique, case-sensitive string of
        /// up to 64 ASCII characters. You should not reuse the same client token for other API
        /// requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// Logical identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LogicalResourceId LogicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the LogicalResourceId property is set.
        /// </summary>
        internal bool IsSetLogicalResourceId() => this.LogicalResourceId != null;

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// Physical identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PhysicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalResourceId property is set.
        /// </summary>
        internal bool IsSetPhysicalResourceId() => this.PhysicalResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// Name of the resource.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Type of resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
