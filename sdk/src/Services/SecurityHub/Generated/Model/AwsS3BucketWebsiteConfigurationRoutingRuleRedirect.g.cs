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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The rules to redirect the request if the condition in <c>Condition</c> is met.
    /// </summary>
    public partial class AwsS3BucketWebsiteConfigurationRoutingRuleRedirect
    {
        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name to use in the redirect request.
        /// </para>
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property HttpRedirectCode. 
        /// <para>
        /// The HTTP redirect code to use in the response.
        /// </para>
        /// </summary>
        public string HttpRedirectCode { get; set; }

        /// <summary>
        /// Checks to see if the HttpRedirectCode property is set.
        /// </summary>
        internal bool IsSetHttpRedirectCode() => this.HttpRedirectCode != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use to redirect the request. By default, uses the protocol from the
        /// original request.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ReplaceKeyPrefixWith. 
        /// <para>
        /// The object key prefix to use in the redirect request.
        /// </para>
        ///  
        /// <para>
        /// Cannot be provided if <c>ReplaceKeyWith</c> is present.
        /// </para>
        /// </summary>
        public string ReplaceKeyPrefixWith { get; set; }

        /// <summary>
        /// Checks to see if the ReplaceKeyPrefixWith property is set.
        /// </summary>
        internal bool IsSetReplaceKeyPrefixWith() => this.ReplaceKeyPrefixWith != null;

        /// <summary>
        /// Gets and sets the property ReplaceKeyWith. 
        /// <para>
        /// The specific object key to use in the redirect request.
        /// </para>
        ///  
        /// <para>
        /// Cannot be provided if <c>ReplaceKeyPrefixWith</c> is present.
        /// </para>
        /// </summary>
        public string ReplaceKeyWith { get; set; }

        /// <summary>
        /// Checks to see if the ReplaceKeyWith property is set.
        /// </summary>
        internal bool IsSetReplaceKeyWith() => this.ReplaceKeyWith != null;
    }
}
