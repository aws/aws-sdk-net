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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that defines an Amazon CloudWatch destination for email events. You can
    /// use Amazon CloudWatch to monitor and gain insights on your email sending metrics.
    /// </summary>
    public partial class CloudWatchDestination
    {
        private List<CloudWatchDimensionConfiguration> _dimensionConfigurations = new List<CloudWatchDimensionConfiguration>();

        /// <summary>
        /// Gets and sets the property DimensionConfigurations. 
        /// <para>
        /// An array of objects that define the dimensions to use when you send email events to
        /// Amazon CloudWatch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CloudWatchDimensionConfiguration> DimensionConfigurations
        {
            get { return this._dimensionConfigurations; }
            set { this._dimensionConfigurations = value; }
        }

        // Check to see if DimensionConfigurations property is set
        internal bool IsSetDimensionConfigurations()
        {
            return this._dimensionConfigurations != null && this._dimensionConfigurations.Count > 0; 
        }

    }
}