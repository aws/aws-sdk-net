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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Specifies the actions performed when the <code>condition</code> evaluates to TRUE.
    /// </summary>
    public partial class OnInputLifecycle
    {
        private List<Event> _events = new List<Event>();
        private List<TransitionEvent> _transitionEvents = new List<TransitionEvent>();

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// Specifies the actions performed when the <code>condition</code> evaluates to TRUE.
        /// </para>
        /// </summary>
        public List<Event> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TransitionEvents. 
        /// <para>
        /// Specifies the actions performed, and the next state entered, when a <code>condition</code>
        /// evaluates to TRUE.
        /// </para>
        /// </summary>
        public List<TransitionEvent> TransitionEvents
        {
            get { return this._transitionEvents; }
            set { this._transitionEvents = value; }
        }

        // Check to see if TransitionEvents property is set
        internal bool IsSetTransitionEvents()
        {
            return this._transitionEvents != null && this._transitionEvents.Count > 0; 
        }

    }
}