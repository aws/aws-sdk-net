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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSubdomain operation. Deletes a Lightsail
    /// subdomain. <para> The subdomain must be in the <c>UNATTACHED</c> or <c>CREATE_FAILED</c>
    /// state. To delete a subdomain that's associated with a resource, first disassociate
    /// it by using the <c>UpdateSubdomainAssociation</c> action. </para> <para> When you
    /// delete a top-level subdomain that has nested subdomains, the nested subdomains continue
    /// to work, and the top-level subdomain changes to the <c>IMPLICIT</c> state. </para>
    /// <note> <para> After you delete a subdomain that was associated with a resource, the
    /// subdomain isn't available to other accounts for at least 30 days. </para> </note>
    /// </summary>
    public partial class DeleteSubdomainRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property SubdomainName. 
        /// <para>
        /// The subdomain to delete (for example, <c>mysite</c> or <c>blog.mysite</c>), not its
        /// web address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubdomainName { get; set; }

        /// <summary>
        /// Checks to see if the SubdomainName property is set.
        /// </summary>
        internal bool IsSetSubdomainName() => this.SubdomainName != null;
    }
}
