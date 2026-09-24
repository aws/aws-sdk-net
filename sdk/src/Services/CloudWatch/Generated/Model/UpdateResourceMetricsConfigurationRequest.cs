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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResourceMetricsConfiguration operation.
    /// Updates the resource metrics configuration for an Amazon Web Services resource. The
    /// <c>MetricSelections</c> value that you provide replaces any existing metric selections
    /// for the resource; it is not merged with them.
    /// 
    ///  
    /// <para>
    /// If you omit <c>MetricSelections</c>, Amazon CloudWatch removes any existing metric
    /// selection filter and collects all available detailed metrics for the resource.
    /// </para>
    ///  
    /// <para>
    /// This operation returns a <c>ResourceNotFoundException</c> if no resource metrics configuration
    /// exists for the specified resource ARN. To create a configuration, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_CreateResourceMetricsConfiguration.html">CreateResourceMetricsConfiguration</a>.
    /// </para>
    ///  
    /// <para>
    /// To update a resource metrics configuration, you must have the <c>cloudwatch:UpdateResourceMetricsConfiguration</c>
    /// permission. For information about scoping this permission to specific resources, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/iam-cw-condition-keys-resource-arn.html">Condition
    /// keys for resource metrics configuration access</a> in the <i>Amazon CloudWatch User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateResourceMetricsConfigurationRequest : AmazonCloudWatchRequest
    {
        private List<ResourceMetricSelection> _metricSelections = AWSConfigs.InitializeCollections ? new List<ResourceMetricSelection>() : null;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property MetricSelections. 
        /// <para>
        /// Specifies which metrics Amazon CloudWatch collects for the resource. The selections
        /// that you provide completely replace any existing metric selections.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, Amazon CloudWatch removes any existing metric selection
        /// filter and collects all available detailed metrics for the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ResourceMetricSelection> MetricSelections
        {
            get { return this._metricSelections; }
            set { this._metricSelections = value; }
        }

        // Check to see if MetricSelections property is set
        internal bool IsSetMetricSelections()
        {
            return this._metricSelections != null && (this._metricSelections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services resource to update the resource
        /// metrics configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}