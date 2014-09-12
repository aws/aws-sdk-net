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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents a list of all the email addresses verified for the current user.
    /// </summary>
    public partial class ListVerifiedEmailAddressesResult : AmazonWebServiceResponse
    {
        private List<string> _verifiedEmailAddresses = new List<string>();

        /// <summary>
        /// Gets and sets the property VerifiedEmailAddresses. 
        /// <para>
        /// A list of email addresses that have been verified.
        /// </para>
        /// </summary>
        public List<string> VerifiedEmailAddresses
        {
            get { return this._verifiedEmailAddresses; }
            set { this._verifiedEmailAddresses = value; }
        }

        // Check to see if VerifiedEmailAddresses property is set
        internal bool IsSetVerifiedEmailAddresses()
        {
            return this._verifiedEmailAddresses != null && this._verifiedEmailAddresses.Count > 0; 
        }

    }
}