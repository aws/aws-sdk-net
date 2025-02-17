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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the PutEvents operation.
    /// Sends custom events to Amazon EventBridge so that they can be matched to rules.
    /// 
    ///  
    /// <para>
    /// The maximum size for a PutEvents event entry is 256 KB. Entry size is calculated including
    /// the event and any necessary characters and keys of the JSON representation of the
    /// event. To learn more, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-putevent-size.html">Calculating
    /// PutEvents event entry size</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>
    /// 
    /// </para>
    ///  
    /// <para>
    /// PutEvents accepts the data in JSON format. For the JSON number (integer) data type,
    /// the constraints are: a minimum value of -9,223,372,036,854,775,808 and a maximum value
    /// of 9,223,372,036,854,775,807.
    /// </para>
    ///  <note> 
    /// <para>
    /// PutEvents will only process nested JSON up to 1000 levels deep.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutEventsRequest : AmazonEventBridgeRequest
    {
        private string _endpointId;
        private List<PutEventsRequestEntry> _entries = AWSConfigs.InitializeCollections ? new List<PutEventsRequestEntry>() : null;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The URL subdomain of the endpoint. For example, if the URL for Endpoint is https://abcde.veo.endpoints.event.amazonaws.com,
        /// then the EndpointId is <c>abcde.veo</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// When using Java, you must include <c>auth-crt</c> on the class path.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The entry that defines an event in your system. You can specify several parameters
        /// for the entry such as the source and type of the event, resources associated with
        /// the event, and so on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<PutEventsRequestEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}