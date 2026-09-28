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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Discriminated EventSource configuration. Exactly one variant must be set.
    /// </summary>
    public partial class EventSourceConfiguration
    {
        private AwsServiceEventsSourceConfiguration _awsServiceEventsConfiguration;
        private PartnerEventsSourceConfiguration _partnerEventsConfiguration;

        /// <summary>
        /// Gets and sets the property AwsServiceEventsConfiguration.
        /// </summary>
        public AwsServiceEventsSourceConfiguration AwsServiceEventsConfiguration
        {
            get { return this._awsServiceEventsConfiguration; }
            set { this._awsServiceEventsConfiguration = value; }
        }

        // Check to see if AwsServiceEventsConfiguration property is set
        internal bool IsSetAwsServiceEventsConfiguration()
        {
            return this._awsServiceEventsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerEventsConfiguration.
        /// </summary>
        public PartnerEventsSourceConfiguration PartnerEventsConfiguration
        {
            get { return this._partnerEventsConfiguration; }
            set { this._partnerEventsConfiguration = value; }
        }

        // Check to see if PartnerEventsConfiguration property is set
        internal bool IsSetPartnerEventsConfiguration()
        {
            return this._partnerEventsConfiguration != null;
        }

    }
}