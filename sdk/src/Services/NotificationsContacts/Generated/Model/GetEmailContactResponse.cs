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
 * Do not modify this file. This file is generated from the notificationscontacts-2018-05-10.normal.json service model.
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
namespace Amazon.NotificationsContacts.Model
{
    /// <summary>
    /// This is the response object from the GetEmailContact operation.
    /// </summary>
    public partial class GetEmailContactResponse : AmazonWebServiceResponse
    {
        private EmailContact _emailContact;

        /// <summary>
        /// Gets and sets the property EmailContact. 
        /// <para>
        /// The email contact for the provided email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EmailContact EmailContact
        {
            get { return this._emailContact; }
            set { this._emailContact = value; }
        }

        // Check to see if EmailContact property is set
        internal bool IsSetEmailContact()
        {
            return this._emailContact != null;
        }

    }
}