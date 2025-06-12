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
    /// Container for the parameters to the GetIdentityDkimAttributes operation.
    /// Returns the current status of Easy DKIM signing for an entity. For domain name identities,
    /// this operation also returns the DKIM tokens that are required for Easy DKIM signing,
    /// and whether Amazon SES has successfully verified that these tokens have been published.
    /// 
    ///  
    /// <para>
    /// This operation takes a list of identities as input and returns the following information
    /// for each:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Whether Easy DKIM signing is enabled or disabled.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A set of DKIM tokens that represent the identity. If the identity is an email address,
    /// the tokens represent the domain of that address.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Whether Amazon SES has successfully verified the DKIM tokens published in the domain's
    /// DNS. This information is only returned for domain name identities, not for email addresses.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation is throttled at one request per second and can only get DKIM attributes
    /// for up to 100 identities at a time.
    /// </para>
    ///  
    /// <para>
    /// For more information about creating DNS records using DKIM tokens, go to the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-easy-managing.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class GetIdentityDkimAttributesRequest : AmazonSimpleEmailServiceRequest
    {
        private List<string> _identities = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Identities. 
        /// <para>
        /// A list of one or more verified identities - email addresses, domains, or both.
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