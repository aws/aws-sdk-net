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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// A filter for the user data.
    /// </summary>
    public partial class UserDataFilters
    {
        private ContactFilter _contactFilter;
        private List<string> _queues = new List<string>();

        /// <summary>
        /// Gets and sets the property ContactFilter. 
        /// <para>
        /// A filter for the user data based on the contact information that is associated to
        /// the user. It contains a list of contact states. 
        /// </para>
        /// </summary>
        public ContactFilter ContactFilter
        {
            get { return this._contactFilter; }
            set { this._contactFilter = value; }
        }

        // Check to see if ContactFilter property is set
        internal bool IsSetContactFilter()
        {
            return this._contactFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Queues. 
        /// <para>
        /// Contains information about a queue resource for which metrics are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Queues
        {
            get { return this._queues; }
            set { this._queues = value; }
        }

        // Check to see if Queues property is set
        internal bool IsSetQueues()
        {
            return this._queues != null && this._queues.Count > 0; 
        }

    }
}