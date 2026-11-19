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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A configuration used when creating an Object Lambda Access Point.
    /// </summary>
    public partial class ObjectLambdaConfiguration
    {
        /// <summary>
        /// Gets and sets the property AllowedFeatures. 
        /// <para>
        /// A container for allowed features. Valid inputs are <c>GetObject-Range</c>, <c>GetObject-PartNumber</c>,
        /// <c>HeadObject-Range</c>, and <c>HeadObject-PartNumber</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedFeatures property is set.
        /// </summary>
        internal bool IsSetAllowedFeatures() => this.AllowedFeatures != null && (this.AllowedFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudWatchMetricsEnabled. 
        /// <para>
        /// A container for whether the CloudWatch metrics configuration is enabled.
        /// </para>
        /// </summary>
        public bool? CloudWatchMetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchMetricsEnabled property is set.
        /// </summary>
        internal bool IsSetCloudWatchMetricsEnabled() => this.CloudWatchMetricsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SupportingAccessPoint. 
        /// <para>
        /// Standard access point associated with the Object Lambda Access Point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SupportingAccessPoint { get; set; }

        /// <summary>
        /// Checks to see if the SupportingAccessPoint property is set.
        /// </summary>
        internal bool IsSetSupportingAccessPoint() => this.SupportingAccessPoint != null;

        /// <summary>
        /// Gets and sets the property TransformationConfigurations. 
        /// <para>
        /// A container for transformation configurations for an Object Lambda Access Point.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ObjectLambdaTransformationConfiguration> TransformationConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ObjectLambdaTransformationConfiguration>() : null;

        /// <summary>
        /// Checks to see if the TransformationConfigurations property is set.
        /// </summary>
        internal bool IsSetTransformationConfigurations() => this.TransformationConfigurations != null && (this.TransformationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
