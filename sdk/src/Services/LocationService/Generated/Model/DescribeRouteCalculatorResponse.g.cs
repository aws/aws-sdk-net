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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeRouteCalculator operation.
    /// </summary>
    public partial class DescribeRouteCalculatorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CalculatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Route calculator resource. Use the ARN when
        /// you specify a resource across Amazon Web Services.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Format example: <c>arn:aws:geo:region:account-id:route-calculator/ExampleCalculator</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Max = 1600)]
        public string CalculatorArn { get; set; }

        /// <summary>
        /// Checks to see if the CalculatorArn property is set.
        /// </summary>
        internal bool IsSetCalculatorArn() => this.CalculatorArn != null;

        /// <summary>
        /// Gets and sets the property CalculatorName. 
        /// <para>
        /// The name of the route calculator resource being described.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string CalculatorName { get; set; }

        /// <summary>
        /// Checks to see if the CalculatorName property is set.
        /// </summary>
        internal bool IsSetCalculatorName() => this.CalculatorName != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp when the route calculator resource was created in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, <c>2020–07-2T12:15:20.000Z+01:00</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data provider of traffic and road network data. Indicates one of the available
        /// providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Esri</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Grab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Here</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about data providers, see <a href="https://docs.aws.amazon.com/location/previous/developerguide/what-is-data-provider.html">Amazon
        /// Location Service data providers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description of the route calculator resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// Always returns <c>RequestBasedUsage</c>.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. Always returns RequestBasedUsage.")]
        public PricingPlan PricingPlan { get; set; }

        /// <summary>
        /// Checks to see if the PricingPlan property is set.
        /// </summary>
        internal bool IsSetPricingPlan() => this.PricingPlan != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with route calculator resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The timestamp when the route calculator resource was last updated in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, <c>2020–07-2T12:15:20.000Z+01:00</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
