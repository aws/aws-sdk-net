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
    /// Configuration for forwarding a partner event source's events through a managed partner
    /// event bus.
    /// </summary>
    public partial class PartnerEventsSourceConfiguration
    {
        private OnFailureConfiguration _onFailureConfiguration;
        private string _partnerBusKmsKeyIdentifier;
        private string _partnerEventSourceArn;
        private string _pattern;

        /// <summary>
        /// Gets and sets the property OnFailureConfiguration. 
        /// <para>
        /// The destination for events that could not be forwarded, covering both the forwarding
        /// target and the managed partner event bus.
        /// </para>
        /// </summary>
        public OnFailureConfiguration OnFailureConfiguration
        {
            get { return this._onFailureConfiguration; }
            set { this._onFailureConfiguration = value; }
        }

        // Check to see if OnFailureConfiguration property is set
        internal bool IsSetOnFailureConfiguration()
        {
            return this._onFailureConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerBusKmsKeyIdentifier.
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PartnerBusKmsKeyIdentifier
        {
            get { return this._partnerBusKmsKeyIdentifier; }
            set { this._partnerBusKmsKeyIdentifier = value; }
        }

        // Check to see if PartnerBusKmsKeyIdentifier property is set
        internal bool IsSetPartnerBusKmsKeyIdentifier()
        {
            return this._partnerBusKmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerEventSourceArn.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string PartnerEventSourceArn
        {
            get { return this._partnerEventSourceArn; }
            set { this._partnerEventSourceArn = value; }
        }

        // Check to see if PartnerEventSourceArn property is set
        internal bool IsSetPartnerEventSourceArn()
        {
            return this._partnerEventSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// A filter pattern, as a JSON string, that defines which of the partner event source's
        /// events are forwarded to the event bus. If no pattern is specified, all events from
        /// the partner event source are forwarded.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=3753)]
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

    }
}