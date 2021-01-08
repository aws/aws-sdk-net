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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the GetIdentityMailFromDomainAttributes operation.
    /// Returns the custom MAIL FROM attributes for a list of identities (email addresses
    /// : domains).
    /// 
    ///  
    /// <para>
    /// This operation is throttled at one request per second and can only get custom MAIL
    /// FROM attributes for up to 100 identities at a time.
    /// </para>
    /// </summary>
    public partial class GetIdentityMailFromDomainAttributesRequest : AmazonSimpleEmailServiceRequest
    {
        private List<string> _identities = new List<string>();

        /// <summary>
        /// Gets and sets the property Identities. 
        /// <para>
        /// A list of one or more identities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Identities
        {
            get { return this._identities; }
            set { this._identities = value; }
        }

        // Check to see if Identities property is set
        internal bool IsSetIdentities()
        {
            return this._identities != null && this._identities.Count > 0; 
        }

    }
}