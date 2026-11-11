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
    /// The value to be compared with the <c>metric</c>.
    /// </summary>
    public partial class MetricValue
    {
        /// <summary>
        /// Gets and sets the property Cidrs. 
        /// <para>
        /// If the <c>comparisonOperator</c> calls for a set of CIDRs, use this to specify that
        /// set to be compared with the <c>metric</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Cidrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Cidrs property is set.
        /// </summary>
        internal bool IsSetCidrs() => this.Cidrs != null && (this.Cidrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// If the <c>comparisonOperator</c> calls for a numeric value, use this to specify that
        /// numeric value to be compared with the <c>metric</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property Number. 
        /// <para>
        ///  The numeral value of a metric. 
        /// </para>
        /// </summary>
        public double? Number { get; set; }

        /// <summary>
        /// Checks to see if the Number property is set.
        /// </summary>
        internal bool IsSetNumber() => this.Number.HasValue;

        /// <summary>
        /// Gets and sets the property Numbers. 
        /// <para>
        ///  The numeral values of a metric. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> Numbers { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Numbers property is set.
        /// </summary>
        internal bool IsSetNumbers() => this.Numbers != null && (this.Numbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ports. 
        /// <para>
        /// If the <c>comparisonOperator</c> calls for a set of ports, use this to specify that
        /// set to be compared with the <c>metric</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Ports { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Ports property is set.
        /// </summary>
        internal bool IsSetPorts() => this.Ports != null && (this.Ports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Strings. 
        /// <para>
        ///  The string values of a metric. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Strings { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Strings property is set.
        /// </summary>
        internal bool IsSetStrings() => this.Strings != null && (this.Strings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
