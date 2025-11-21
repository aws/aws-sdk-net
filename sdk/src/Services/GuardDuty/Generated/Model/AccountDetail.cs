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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the account.
    /// </summary>
    public partial class AccountDetail
    {
        private string _accountId;
        private string _email;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The member account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the member account. The following list includes the rules for
        /// a valid email address:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The email address must be a minimum of 6 and a maximum of 64 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All characters must be 7-bit ASCII characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There must be one and only one @ symbol, which separates the local name from the domain
        /// name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The local name can't contain any of the following characters:
        /// </para>
        ///  
        /// <para>
        /// whitespace, " ' ( ) &lt; &gt; [ ] : ' , \ | % &amp;
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The local name can't begin with a dot (.).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain name can consist of only the characters [a-z], [A-Z], [0-9], hyphen (-),
        /// or dot (.).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain name can't begin or end with a dot (.) or hyphen (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain name must contain at least one dot. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=6, Max=64)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

    }
}