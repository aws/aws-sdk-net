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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
        private List<string> _allowedFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _cloudWatchMetricsEnabled;
        private string _supportingAccessPoint;
        private List<ObjectLambdaTransformationConfiguration> _transformationConfigurations = AWSConfigs.InitializeCollections ? new List<ObjectLambdaTransformationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property AllowedFeatures. 
        /// <para>
        /// A container for allowed features. Valid inputs are <c>GetObject-Range</c>, <c>GetObject-PartNumber</c>,
        /// <c>HeadObject-Range</c>, and <c>HeadObject-PartNumber</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedFeatures
        {
            get { return this._allowedFeatures; }
            set { this._allowedFeatures = value; }
        }

        // Check to see if AllowedFeatures property is set
        internal bool IsSetAllowedFeatures()
        {
            return this._allowedFeatures != null && (this._allowedFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CloudWatchMetricsEnabled. 
        /// <para>
        /// A container for whether the CloudWatch metrics configuration is enabled.
        /// </para>
        /// </summary>
        public bool? CloudWatchMetricsEnabled
        {
            get { return this._cloudWatchMetricsEnabled; }
            set { this._cloudWatchMetricsEnabled = value; }
        }

        // Check to see if CloudWatchMetricsEnabled property is set
        internal bool IsSetCloudWatchMetricsEnabled()
        {
            return this._cloudWatchMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportingAccessPoint. 
        /// <para>
        /// Standard access point associated with the Object Lambda Access Point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string SupportingAccessPoint
        {
            get { return this._supportingAccessPoint; }
            set { this._supportingAccessPoint = value; }
        }

        // Check to see if SupportingAccessPoint property is set
        internal bool IsSetSupportingAccessPoint()
        {
            return this._supportingAccessPoint != null;
        }

        /// <summary>
        /// Gets and sets the property TransformationConfigurations. 
        /// <para>
        /// A container for transformation configurations for an Object Lambda Access Point.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ObjectLambdaTransformationConfiguration> TransformationConfigurations
        {
            get { return this._transformationConfigurations; }
            set { this._transformationConfigurations = value; }
        }

        // Check to see if TransformationConfigurations property is set
        internal bool IsSetTransformationConfigurations()
        {
            return this._transformationConfigurations != null && (this._transformationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}