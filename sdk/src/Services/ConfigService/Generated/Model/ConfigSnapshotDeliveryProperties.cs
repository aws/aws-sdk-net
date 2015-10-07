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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Options for how AWS Config delivers configuration snapshots to the Amazon S3 bucket
    /// in your delivery channel.
    /// </summary>
    public partial class ConfigSnapshotDeliveryProperties
    {
        private MaximumExecutionFrequency _deliveryFrequency;

        /// <summary>
        /// Gets and sets the property DeliveryFrequency. 
        /// <para>
        /// The frequency with which a AWS Config recurringly delivers configuration snapshots.
        /// </para>
        /// </summary>
        public MaximumExecutionFrequency DeliveryFrequency
        {
            get { return this._deliveryFrequency; }
            set { this._deliveryFrequency = value; }
        }

        // Check to see if DeliveryFrequency property is set
        internal bool IsSetDeliveryFrequency()
        {
            return this._deliveryFrequency != null;
        }

    }
}