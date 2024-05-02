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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Multiplex MediaConnect output destination settings.
    /// </summary>
    public partial class MultiplexMediaConnectOutputDestinationSettings
    {
        private string _entitlementArn;

        /// <summary>
        /// Gets and sets the property EntitlementArn. The MediaConnect entitlement ARN available
        /// as a Flow source.
        /// </summary>
        [AWSProperty(Min=1)]
        public string EntitlementArn
        {
            get { return this._entitlementArn; }
            set { this._entitlementArn = value; }
        }

        // Check to see if EntitlementArn property is set
        internal bool IsSetEntitlementArn()
        {
            return this._entitlementArn != null;
        }

    }
}