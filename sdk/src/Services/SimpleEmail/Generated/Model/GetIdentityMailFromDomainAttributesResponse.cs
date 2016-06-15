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
    /// Represents the custom MAIL FROM attributes for a list of identities.
    /// </summary>
    public partial class GetIdentityMailFromDomainAttributesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, IdentityMailFromDomainAttributes> _mailFromDomainAttributes = new Dictionary<string, IdentityMailFromDomainAttributes>();

        /// <summary>
        /// Gets and sets the property MailFromDomainAttributes. 
        /// <para>
        /// A map of identities to custom MAIL FROM attributes.
        /// </para>
        /// </summary>
        public Dictionary<string, IdentityMailFromDomainAttributes> MailFromDomainAttributes
        {
            get { return this._mailFromDomainAttributes; }
            set { this._mailFromDomainAttributes = value; }
        }

        // Check to see if MailFromDomainAttributes property is set
        internal bool IsSetMailFromDomainAttributes()
        {
            return this._mailFromDomainAttributes != null && this._mailFromDomainAttributes.Count > 0; 
        }

    }
}