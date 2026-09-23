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
    /// Defines a physical resource. A physical resource is a resource that exists in your
    /// account. It can be identified using an Amazon Resource Name (ARN) or an Resilience
    /// Hub-native identifier.
    /// </summary>
    public partial class PhysicalResource
    {
        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Additional configuration parameters for an Resilience Hub application. If you want
        /// to implement <c>additionalInfo</c> through the Resilience Hub console rather than
        /// using an API call, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/app-config-param.html">Configure
        /// the application configuration parameters</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, this parameter accepts a key-value mapping (in a string format) of only
        /// one failover region and one associated account.
        /// </para>
        ///  
        /// <para>
        /// Key: <c>"failover-regions"</c> 
        /// </para>
        ///  
        /// <para>
        /// Value: <c>"[{"region":"&lt;REGION&gt;", "accounts":[{"id":"&lt;ACCOUNT_ID&gt;"}]}]"</c>
        /// 
        /// </para>
        ///  </note>
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
        /// Gets and sets the property AppComponents. 
        /// <para>
        /// The application components that belong to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AppComponent> AppComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<AppComponent>() : null;

        /// <summary>
        /// Checks to see if the AppComponents property is set.
        /// </summary>
        internal bool IsSetAppComponents() => this.AppComponents != null && (this.AppComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Excluded. 
        /// <para>
        /// Indicates if a resource is included or excluded from the assessment.
        /// </para>
        /// </summary>
        public bool? Excluded { get; set; }

        /// <summary>
        /// Checks to see if the Excluded property is set.
        /// </summary>
        internal bool IsSetExcluded() => this.Excluded.HasValue;

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
        /// Gets and sets the property ParentResourceName. 
        /// <para>
        /// Name of the parent resource.
        /// </para>
        /// </summary>
        public string ParentResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ParentResourceName property is set.
        /// </summary>
        internal bool IsSetParentResourceName() => this.ParentResourceName != null;

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// Identifier of the physical resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PhysicalResourceId PhysicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalResourceId property is set.
        /// </summary>
        internal bool IsSetPhysicalResourceId() => this.PhysicalResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource.
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

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Type of input source.
        /// </para>
        /// </summary>
        public ResourceSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
