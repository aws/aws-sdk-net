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

namespace Amazon.ElasticInference.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAcceleratorOfferings operation.
    /// Describes the locations in which a given accelerator type or set of types is present
    /// in a given region. 
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
    public partial class DescribeAcceleratorOfferingsRequest : AmazonElasticInferenceRequest
    {
        private List<string> _acceleratorTypes = new List<string>();
        private LocationType _locationType;

        /// <summary>
        /// Gets and sets the property AcceleratorTypes. 
        /// <para>
        ///  The list of accelerator types to describe. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> AcceleratorTypes
        {
            get { return this._acceleratorTypes; }
            set { this._acceleratorTypes = value; }
        }

        // Check to see if AcceleratorTypes property is set
        internal bool IsSetAcceleratorTypes()
        {
            return this._acceleratorTypes != null && this._acceleratorTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LocationType. 
        /// <para>
        ///  The location type that you want to describe accelerator type offerings for. It can
        /// assume the following values: region: will return the accelerator type offering at
        /// the regional level. availability-zone: will return the accelerator type offering at
        /// the availability zone level. availability-zone-id: will return the accelerator type
        /// offering at the availability zone level returning the availability zone id. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public LocationType LocationType
        {
            get { return this._locationType; }
            set { this._locationType = value; }
        }

        // Check to see if LocationType property is set
        internal bool IsSetLocationType()
        {
            return this._locationType != null;
        }

    }
}