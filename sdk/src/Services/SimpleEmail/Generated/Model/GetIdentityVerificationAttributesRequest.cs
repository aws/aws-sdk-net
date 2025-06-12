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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the GetIdentityVerificationAttributes operation.
    /// Given a list of identities (email addresses and/or domains), returns the verification
    /// status and (for domain identities) the verification token for each identity.
    /// 
    ///  
    /// <para>
    /// The verification status of an email address is "Pending" until the email address owner
    /// clicks the link within the verification email that Amazon SES sent to that address.
    /// If the email address owner clicks the link within 24 hours, the verification status
    /// of the email address changes to "Success". If the link is not clicked within 24 hours,
    /// the verification status changes to "Failed." In that case, to verify the email address,
    /// you must restart the verification process from the beginning.
    /// </para>
    ///  
    /// <para>
    /// For domain identities, the domain's verification status is "Pending" as Amazon SES
    /// searches for the required TXT record in the DNS settings of the domain. When Amazon
    /// SES detects the record, the domain's verification status changes to "Success". If
    /// Amazon SES is unable to detect the record within 72 hours, the domain's verification
    /// status changes to "Failed." In that case, to verify the domain, you must restart the
    /// verification process from the beginning.
    /// </para>
    ///  
    /// <para>
    /// This operation is throttled at one request per second and can only get verification
    /// attributes for up to 100 identities at a time.
    /// </para>
    /// </summary>
    public partial class GetIdentityVerificationAttributesRequest : AmazonSimpleEmailServiceRequest
    {
        private List<string> _identities = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Identities. 
        /// <para>
        /// A list of identities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._identities != null && (this._identities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}