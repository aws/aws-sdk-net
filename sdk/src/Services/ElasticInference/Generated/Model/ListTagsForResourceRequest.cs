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
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
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
namespace Amazon.ElasticInference.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Returns all tags of an Elastic Inference Accelerator. 
    /// 
    ///  
    /// <para>
    ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
    /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
    /// to options that offer better price and performance. After April 15, 2023, new customers
    /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
    /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
    /// during the past 30-day period are considered current customers and will be able to
    /// continue using the service. 
    /// </para>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonElasticInferenceRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  The ARN of the Elastic Inference Accelerator to list the tags for. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
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