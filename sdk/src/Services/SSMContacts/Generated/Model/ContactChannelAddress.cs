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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
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
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// The details that Incident Manager uses when trying to engage the contact channel.
    /// </summary>
    public partial class ContactChannelAddress
    {
        private string _simpleAddress;

        /// <summary>
        /// Gets and sets the property SimpleAddress. 
        /// <para>
        /// The format is dependent on the type of the contact channel. The following are the
        /// expected formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SMS - '+' followed by the country code and phone number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VOICE - '+' followed by the country code and phone number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL - any standard email format
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=320)]
        public string SimpleAddress
        {
            get { return this._simpleAddress; }
            set { this._simpleAddress = value; }
        }

        // Check to see if SimpleAddress property is set
        internal bool IsSetSimpleAddress()
        {
            return this._simpleAddress != null;
        }

    }
}