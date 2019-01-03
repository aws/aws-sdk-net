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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// The destination to which data set contents are delivered.
    /// </summary>
    public partial class DatasetContentDeliveryDestination
    {
        private IotEventsDestinationConfiguration _iotEventsDestinationConfiguration;

        /// <summary>
        /// Gets and sets the property IotEventsDestinationConfiguration. 
        /// <para>
        /// Configuration information for delivery of data set contents to AWS IoT Events.
        /// </para>
        /// </summary>
        public IotEventsDestinationConfiguration IotEventsDestinationConfiguration
        {
            get { return this._iotEventsDestinationConfiguration; }
            set { this._iotEventsDestinationConfiguration = value; }
        }

        // Check to see if IotEventsDestinationConfiguration property is set
        internal bool IsSetIotEventsDestinationConfiguration()
        {
            return this._iotEventsDestinationConfiguration != null;
        }

    }
}