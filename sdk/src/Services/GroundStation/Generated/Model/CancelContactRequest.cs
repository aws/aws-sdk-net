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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the CancelContact operation.
    /// Cancels or stops a contact with a specified contact ID based on its position in the
    /// <a href="https://docs.aws.amazon.com/ground-station/latest/ug/contacts.lifecycle.html">contact
    /// lifecycle</a>.
    /// 
    ///  
    /// <para>
    /// For contacts that:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Have yet to start, the contact will be cancelled.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Have started but have yet to finish, the contact will be stopped.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CancelContactRequest : AmazonGroundStationRequest
    {
        private string _contactId;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// UUID of a contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

    }
}