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
    /// This is the response object from the CreateRouteCalculator operation.
    /// </summary>
    public partial class CreateRouteCalculatorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CalculatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the route calculator resource. Use the ARN when
        /// you specify a resource across all Amazon Web Services.
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
        /// The name of the route calculator resource. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, <c>ExampleRouteCalculator</c>.
        /// </para>
        ///  </li> </ul>
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
    }
}
