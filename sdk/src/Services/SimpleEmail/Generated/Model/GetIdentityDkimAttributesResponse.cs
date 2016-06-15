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
    /// Represents the status of Amazon SES Easy DKIM signing for an identity. For domain
    /// identities, this response also contains the DKIM tokens that are required for Easy
    /// DKIM signing, and whether Amazon SES successfully verified that these tokens were
    /// published.
    /// </summary>
    public partial class GetIdentityDkimAttributesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, IdentityDkimAttributes> _dkimAttributes = new Dictionary<string, IdentityDkimAttributes>();

        /// <summary>
        /// Gets and sets the property DkimAttributes. 
        /// <para>
        /// The DKIM attributes for an email address or a domain.
        /// </para>
        /// </summary>
        public Dictionary<string, IdentityDkimAttributes> DkimAttributes
        {
            get { return this._dkimAttributes; }
            set { this._dkimAttributes = value; }
        }

        // Check to see if DkimAttributes property is set
        internal bool IsSetDkimAttributes()
        {
            return this._dkimAttributes != null && this._dkimAttributes.Count > 0; 
        }

    }
}