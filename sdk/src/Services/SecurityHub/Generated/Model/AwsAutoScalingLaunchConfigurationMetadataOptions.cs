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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The metadata options for the instances.
    /// </summary>
    public partial class AwsAutoScalingLaunchConfigurationMetadataOptions
    {
        private string _httpEndpoint;
        private int? _httpPutResponseHopLimit;
        private string _httpTokens;

        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Enables or disables the HTTP metadata endpoint on your instances. By default, the
        /// metadata endpoint is enabled.
        /// </para>
        /// </summary>
        public string HttpEndpoint
        {
            get { return this._httpEndpoint; }
            set { this._httpEndpoint = value; }
        }

        // Check to see if HttpEndpoint property is set
        internal bool IsSetHttpEndpoint()
        {
            return this._httpEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property HttpPutResponseHopLimit. 
        /// <para>
        /// The HTTP <code>PUT</code> response hop limit for instance metadata requests. The larger
        /// the number, the further instance metadata requests can travel.
        /// </para>
        /// </summary>
        public int HttpPutResponseHopLimit
        {
            get { return this._httpPutResponseHopLimit.GetValueOrDefault(); }
            set { this._httpPutResponseHopLimit = value; }
        }

        // Check to see if HttpPutResponseHopLimit property is set
        internal bool IsSetHttpPutResponseHopLimit()
        {
            return this._httpPutResponseHopLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpTokens. 
        /// <para>
        /// Indicates whether token usage is <code>required</code> or <code>optional</code> for
        /// metadata requests. By default, token usage is <code>optional</code>.
        /// </para>
        /// </summary>
        public string HttpTokens
        {
            get { return this._httpTokens; }
            set { this._httpTokens = value; }
        }

        // Check to see if HttpTokens property is set
        internal bool IsSetHttpTokens()
        {
            return this._httpTokens != null;
        }

    }
}