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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Configuration object that specifies an email address to be associated with a queue.
    /// This configuration contains the identifier of the email address that should be linked
    /// to the queue for routing email contacts.
    /// </summary>
    public partial class EmailAddressConfig
    {
        private string _emailAddressId;

        /// <summary>
        /// Gets and sets the property EmailAddressId. 
        /// <para>
        /// The identifier of the email address that should be associated with the queue. This
        /// email address must already exist in the Amazon Connect instance and will be used to
        /// route incoming email contacts to the specified queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string EmailAddressId
        {
            get { return this._emailAddressId; }
            set { this._emailAddressId = value; }
        }

        // Check to see if EmailAddressId property is set
        internal bool IsSetEmailAddressId()
        {
            return this._emailAddressId != null;
        }

    }
}