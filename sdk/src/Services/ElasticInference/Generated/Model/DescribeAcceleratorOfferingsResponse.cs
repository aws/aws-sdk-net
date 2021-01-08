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
    /// This is the response object from the DescribeAcceleratorOfferings operation.
    /// </summary>
    public partial class DescribeAcceleratorOfferingsResponse : AmazonWebServiceResponse
    {
        private List<AcceleratorTypeOffering> _acceleratorTypeOfferings = new List<AcceleratorTypeOffering>();

        /// <summary>
        /// Gets and sets the property AcceleratorTypeOfferings. 
        /// <para>
        ///  The list of accelerator type offerings for a specific location. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<AcceleratorTypeOffering> AcceleratorTypeOfferings
        {
            get { return this._acceleratorTypeOfferings; }
            set { this._acceleratorTypeOfferings = value; }
        }

        // Check to see if AcceleratorTypeOfferings property is set
        internal bool IsSetAcceleratorTypeOfferings()
        {
            return this._acceleratorTypeOfferings != null && this._acceleratorTypeOfferings.Count > 0; 
        }

    }
}