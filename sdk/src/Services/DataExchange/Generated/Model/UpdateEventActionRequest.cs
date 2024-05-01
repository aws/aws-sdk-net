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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEventAction operation.
    /// This operation updates the event action.
    /// </summary>
    public partial class UpdateEventActionRequest : AmazonDataExchangeRequest
    {
        private Action _action;
        private string _eventActionId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// What occurs after a certain event.
        /// </para>
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property EventActionId. 
        /// <para>
        /// The unique identifier for the event action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventActionId
        {
            get { return this._eventActionId; }
            set { this._eventActionId = value; }
        }

        // Check to see if EventActionId property is set
        internal bool IsSetEventActionId()
        {
            return this._eventActionId != null;
        }

    }
}