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
    /// Represents a resource metrics configuration for an Amazon Web Services resource. A
    /// resource metrics configuration enables detailed metric collection for the resource
    /// that is identified by its Amazon Resource Name (ARN). Each Amazon Web Services resource
    /// can have only one resource metrics configuration.
    /// 
    ///  
    /// <para>
    /// This structure is returned by the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_CreateResourceMetricsConfiguration.html">CreateResourceMetricsConfiguration</a>,
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_UpdateResourceMetricsConfiguration.html">UpdateResourceMetricsConfiguration</a>,
    /// and <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetResourceMetricsConfiguration.html">GetResourceMetricsConfiguration</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class ResourceMetricsConfiguration
    {
        private DateTime? _createdAt;
        private List<ResourceMetricSelection> _metricSelections = AWSConfigs.InitializeCollections ? new List<ResourceMetricSelection>() : null;
        private string _resourceArn;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the resource metrics configuration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricSelections. 
        /// <para>
        /// The metrics that Amazon CloudWatch collects for the resource. If this field is not
        /// present, Amazon CloudWatch collects all available detailed metrics for the resource.
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
        /// The Amazon Resource Name (ARN) of the Amazon Web Services resource that this configuration
        /// applies to.
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the resource metrics configuration was last updated. When the
        /// configuration is first created, this value is the same as <c>CreatedAt</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}