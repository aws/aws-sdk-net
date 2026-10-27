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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains the results of an Amazon Web Services Lambda function layer
    /// finding aggregation.
    /// </summary>
    public partial class LambdaLayerAggregationResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID of the Amazon Web Services Lambda function layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The names of the Amazon Web Services Lambda functions associated with the layers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property LayerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Lambda function layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string LayerArn { get; set; }

        /// <summary>
        /// Checks to see if the LayerArn property is set.
        /// </summary>
        internal bool IsSetLayerArn() => this.LayerArn != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The Resource ID of the Amazon Web Services Lambda function layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// An object that contains the counts of aggregated finding per severity.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts { get; set; }

        /// <summary>
        /// Checks to see if the SeverityCounts property is set.
        /// </summary>
        internal bool IsSetSeverityCounts() => this.SeverityCounts != null;
    }
}
