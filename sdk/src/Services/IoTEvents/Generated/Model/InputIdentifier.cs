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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// The identifer of the input.
    /// </summary>
    public partial class InputIdentifier
    {
        private IotEventsInputIdentifier _iotEventsInputIdentifier;
        private IotSiteWiseInputIdentifier _iotSiteWiseInputIdentifier;

        /// <summary>
        /// Gets and sets the property IotEventsInputIdentifier. 
        /// <para>
        ///  The identifier of the input routed to AWS IoT Events. 
        /// </para>
        /// </summary>
        public IotEventsInputIdentifier IotEventsInputIdentifier
        {
            get { return this._iotEventsInputIdentifier; }
            set { this._iotEventsInputIdentifier = value; }
        }

        // Check to see if IotEventsInputIdentifier property is set
        internal bool IsSetIotEventsInputIdentifier()
        {
            return this._iotEventsInputIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property IotSiteWiseInputIdentifier. 
        /// <para>
        ///  The identifer of the input routed from AWS IoT SiteWise. 
        /// </para>
        /// </summary>
        public IotSiteWiseInputIdentifier IotSiteWiseInputIdentifier
        {
            get { return this._iotSiteWiseInputIdentifier; }
            set { this._iotSiteWiseInputIdentifier = value; }
        }

        // Check to see if IotSiteWiseInputIdentifier property is set
        internal bool IsSetIotSiteWiseInputIdentifier()
        {
            return this._iotSiteWiseInputIdentifier != null;
        }

    }
}