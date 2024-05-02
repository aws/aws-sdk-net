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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReturnShippingLabel operation.
    /// Creates a shipping label that will be used to return the Snow device to Amazon Web
    /// Services.
    /// </summary>
    public partial class CreateReturnShippingLabelRequest : AmazonSnowballRequest
    {
        private string _jobId;
        private ShippingOption _shippingOption;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID for a job that you want to create the return shipping label for; for example,
        /// <c>JID123e4567-e89b-12d3-a456-426655440000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=39, Max=39)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingOption. 
        /// <para>
        /// The shipping speed for a particular job. This speed doesn't dictate how soon the device
        /// is returned to Amazon Web Services. This speed represents how quickly it moves to
        /// its destination while in transit. Regional shipping speeds are as follows:
        /// </para>
        /// </summary>
        public ShippingOption ShippingOption
        {
            get { return this._shippingOption; }
            set { this._shippingOption = value; }
        }

        // Check to see if ShippingOption property is set
        internal bool IsSetShippingOption()
        {
            return this._shippingOption != null;
        }

    }
}