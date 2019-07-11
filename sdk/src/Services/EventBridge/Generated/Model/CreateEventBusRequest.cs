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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventBus operation.
    /// Creates a new event bus within your account. This can be a custom event bus which
    /// you can use to receive events from your own custom applications and services, or it
    /// can be a partner event bus which can be matched to a partner event source.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is used by AWS customers, not by SaaS partners.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateEventBusRequest : AmazonEventBridgeRequest
    {
        private string _eventSourceName;
        private string _name;

        /// <summary>
        /// Gets and sets the property EventSourceName. 
        /// <para>
        /// If you're creating a partner event bus, this specifies the partner event source that
        /// the new event bus will be matched with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EventSourceName
        {
            get { return this._eventSourceName; }
            set { this._eventSourceName = value; }
        }

        // Check to see if EventSourceName property is set
        internal bool IsSetEventSourceName()
        {
            return this._eventSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new event bus. 
        /// </para>
        ///  
        /// <para>
        /// The names of custom event buses can't contain the <code>/</code> character. You can't
        /// use the name <code>default</code> for a custom event bus because this name is already
        /// used for your account's default event bus.
        /// </para>
        ///  
        /// <para>
        /// If this is a partner event bus, the name must exactly match the name of the partner
        /// event source that this event bus is matched to. This name will include the <code>/</code>
        /// character.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}