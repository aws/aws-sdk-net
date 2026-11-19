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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The DNS configuration for your domain names.
    /// </summary>
    public partial class DnsConfiguration
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name that you're verifying.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Explains the status of the DNS configuration.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of your domain name.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>valid-configuration</c>: The domain name is correctly configured and points to
        /// the correct routing endpoint of the connection group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>invalid-configuration</c>: There is either a missing DNS record or the DNS record
        /// exists but it's using an incorrect routing endpoint. Update the DNS record to point
        /// to the correct routing endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown-configuration</c>: CloudFront can't validate your DNS configuration. This
        /// status can appear if CloudFront can't verify the DNS record, or the DNS lookup request
        /// failed or timed out.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DnsConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
