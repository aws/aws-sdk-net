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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Contains the CNAME record that you must add to your DNS configuration to validate
    /// domain ownership using DNS validation.
    /// </summary>
    public partial class DnsValidationChallenge
    {
        /// <summary>
        /// Gets and sets the property ResourceRecord. 
        /// <para>
        /// The CNAME record that ACM creates for DNS validation. Add this record to your DNS
        /// configuration to prove that you own or control the domain.
        /// </para>
        /// </summary>
        public ResourceRecord ResourceRecord { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRecord property is set.
        /// </summary>
        internal bool IsSetResourceRecord() => this.ResourceRecord != null;
    }
}
