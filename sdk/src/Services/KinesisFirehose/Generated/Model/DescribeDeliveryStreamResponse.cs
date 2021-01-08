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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// This is the response object from the DescribeDeliveryStream operation.
    /// </summary>
    public partial class DescribeDeliveryStreamResponse : AmazonWebServiceResponse
    {
        private DeliveryStreamDescription _deliveryStreamDescription;

        /// <summary>
        /// Gets and sets the property DeliveryStreamDescription. 
        /// <para>
        /// Information about the delivery stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeliveryStreamDescription DeliveryStreamDescription
        {
            get { return this._deliveryStreamDescription; }
            set { this._deliveryStreamDescription = value; }
        }

        // Check to see if DeliveryStreamDescription property is set
        internal bool IsSetDeliveryStreamDescription()
        {
            return this._deliveryStreamDescription != null;
        }

    }
}