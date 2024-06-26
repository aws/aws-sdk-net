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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
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
namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The Amazon Data Firehose logging configuration settings for the pipe.
    /// </summary>
    public partial class FirehoseLogDestination
    {
        private string _deliveryStreamArn;

        /// <summary>
        /// Gets and sets the property DeliveryStreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Firehose delivery stream to which EventBridge
        /// delivers the pipe log records.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string DeliveryStreamArn
        {
            get { return this._deliveryStreamArn; }
            set { this._deliveryStreamArn = value; }
        }

        // Check to see if DeliveryStreamArn property is set
        internal bool IsSetDeliveryStreamArn()
        {
            return this._deliveryStreamArn != null;
        }

    }
}