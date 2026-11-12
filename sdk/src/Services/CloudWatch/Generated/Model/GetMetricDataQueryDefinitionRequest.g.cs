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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the GetMetricDataQueryDefinition operation. Returns
    /// a metric data query definition, including its expression. <para> <b>Permissions</b>
    /// </para> <para> To get a definition, you need the <c>cloudwatch:GetMetricDataQueryDefinition</c>
    /// permission on the metric data query definition resource. You can use the <c>aws:ResourceTag/${TagKey}</c>
    /// condition key to control access based on the tags of the definition. </para>
    /// </summary>
    public partial class GetMetricDataQueryDefinitionRequest : AmazonCloudWatchRequest
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the metric data query definition to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
