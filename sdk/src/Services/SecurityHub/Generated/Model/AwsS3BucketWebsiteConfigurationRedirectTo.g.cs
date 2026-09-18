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
    /// The redirect behavior for requests to the website.
    /// </summary>
    public partial class AwsS3BucketWebsiteConfigurationRedirectTo
    {
        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The name of the host to redirect requests to.
        /// </para>
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use when redirecting requests. By default, this field uses the same
        /// protocol as the original request. Valid values are <c>http</c> or <c>https</c>.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;
    }
}
