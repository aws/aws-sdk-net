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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
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
namespace Amazon.Account.Model
{
    /// <summary>
    /// This is the response object from the GetAlternateContact operation.
    /// </summary>
    public partial class GetAlternateContactResponse : AmazonWebServiceResponse
    {
        private AlternateContact _alternateContact;

        /// <summary>
        /// Gets and sets the property AlternateContact. 
        /// <para>
        /// A structure that contains the details for the specified alternate contact.
        /// </para>
        /// </summary>
        public AlternateContact AlternateContact
        {
            get { return this._alternateContact; }
            set { this._alternateContact = value; }
        }

        // Check to see if AlternateContact property is set
        internal bool IsSetAlternateContact()
        {
            return this._alternateContact != null;
        }

    }
}