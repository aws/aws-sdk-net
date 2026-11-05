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
    /// A filter that matches connectors by the ARN of the associated Amazon Web Services
    /// Config connector.
    /// </summary>
    public partial class AwsConfigConnectorArnFilter
    {
        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The comparison operator for the Amazon Web Services Config connector ARN filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AwsConfigConnectorArnComparison Comparison { get; set; }

        /// <summary>
        /// Checks to see if the Comparison property is set.
        /// </summary>
        internal bool IsSetComparison() => this.Comparison != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The Amazon Web Services Config connector ARN value to filter by.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
