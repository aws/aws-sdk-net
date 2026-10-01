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
    /// The metadata options for the instances.
    /// </summary>
    public partial class AwsAutoScalingLaunchConfigurationMetadataOptions
    {
        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Enables or disables the HTTP metadata endpoint on your instances. By default, the
        /// metadata endpoint is enabled.
        /// </para>
        /// </summary>
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the HttpEndpoint property is set.
        /// </summary>
        internal bool IsSetHttpEndpoint() => this.HttpEndpoint != null;

        /// <summary>
        /// Gets and sets the property HttpPutResponseHopLimit. 
        /// <para>
        /// The HTTP <c>PUT</c> response hop limit for instance metadata requests. The larger
        /// the number, the further instance metadata requests can travel.
        /// </para>
        /// </summary>
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// Checks to see if the HttpPutResponseHopLimit property is set.
        /// </summary>
        internal bool IsSetHttpPutResponseHopLimit() => this.HttpPutResponseHopLimit.HasValue;

        /// <summary>
        /// Gets and sets the property HttpTokens. 
        /// <para>
        /// Indicates whether token usage is <c>required</c> or <c>optional</c> for metadata requests.
        /// By default, token usage is <c>optional</c>.
        /// </para>
        /// </summary>
        public string HttpTokens { get; set; }

        /// <summary>
        /// Checks to see if the HttpTokens property is set.
        /// </summary>
        internal bool IsSetHttpTokens() => this.HttpTokens != null;
    }
}
