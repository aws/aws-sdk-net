/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines the amount of money paid to an Amazon Mechanical Turk worker for each task
    /// performed. 
    /// 
    ///  
    /// <para>
    /// Use one of the following prices for bounding box tasks. Prices are in US dollars.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// 0.036
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.048
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.060
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.072
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.120
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.240
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.360
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.480
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.600
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.720
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.840
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.960
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1.080
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1.200
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Use one of the following prices for image classification, text classification, and
    /// custom tasks. Prices are in US dollars.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// 0.012
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.024
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.036
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.048
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.060
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.072
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.120
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.240
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.360
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.480
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.600
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.720
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.840
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.960
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1.080
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1.200
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Use one of the following prices for semantic segmentation tasks. Prices are in US
    /// dollars.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// 0.840
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 0.960
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1.080
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1.200
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PublicWorkforceTaskPrice
    {
        private USD _amountInUsd;

        /// <summary>
        /// Gets and sets the property AmountInUsd. 
        /// <para>
        /// Defines the amount of money paid to a worker in United States dollars.
        /// </para>
        /// </summary>
        public USD AmountInUsd
        {
            get { return this._amountInUsd; }
            set { this._amountInUsd = value; }
        }

        // Check to see if AmountInUsd property is set
        internal bool IsSetAmountInUsd()
        {
            return this._amountInUsd != null;
        }

    }
}