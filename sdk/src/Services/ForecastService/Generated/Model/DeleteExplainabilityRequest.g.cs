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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteExplainability operation. Deletes an Explainability
    /// resource. <para> You can delete only predictor that have a status of <c>ACTIVE</c>
    /// or <c>CREATE_FAILED</c>. To get the status, use the <a>DescribeExplainability</a>
    /// operation. </para>
    /// </summary>
    public partial class DeleteExplainabilityRequest : AmazonForecastServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ExplainabilityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Explainability resource to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ExplainabilityArn { get; set; }

        /// <summary>
        /// Checks to see if the ExplainabilityArn property is set.
        /// </summary>
        internal bool IsSetExplainabilityArn() => this.ExplainabilityArn != null;
    }
}
