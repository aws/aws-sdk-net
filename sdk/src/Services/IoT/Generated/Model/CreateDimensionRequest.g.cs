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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDimension operation. <note> <para> The IoT
    /// Device Defender detect feature will no longer be available to new customers starting
    /// August 31, 2026. If you would like to use the detect feature, sign up prior to August
    /// 31, 2026. To learn about alternatives to IoT Device Defender detect, see IoT Device
    /// Defender detect feature availability change in the IoT Device Defender Developer Guide.
    /// There is no change to IoT Device Defender audit availability. </para> </note> <para>
    /// Create a dimension that you can use to limit the scope of a metric used in a security
    /// profile for IoT Device Defender. For example, using a <c>TOPIC_FILTER</c> dimension,
    /// you can narrow down the scope of the metric only to MQTT topics whose name match the
    /// pattern specified in the dimension. </para> <para> Requires permission to access the
    /// <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateDimension</a>
    /// action. </para>
    /// </summary>
    public partial class CreateDimensionRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Each dimension must have a unique client request token. If you try to create a new
        /// dimension with the same token as a dimension that already exists, an exception occurs.
        /// If you omit this value, Amazon Web Services SDKs will automatically generate a unique
        /// client request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique identifier for the dimension. Choose something that describes the type and
        /// value to make it easy to remember what it does.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StringValues. 
        /// <para>
        /// Specifies the value or list of values for the dimension. For <c>TOPIC_FILTER</c> dimensions,
        /// this is a pattern used to match the MQTT topic (for example, "admin/#").
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<string> StringValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StringValues property is set.
        /// </summary>
        internal bool IsSetStringValues() => this.StringValues != null && (this.StringValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the dimension.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of dimension. Supported types: <c>TOPIC_FILTER.</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DimensionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
