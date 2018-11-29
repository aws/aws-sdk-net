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
    /// performed. For more information, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/sms-public-payment.html">
    /// Public Workforce Task Price</a>.
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