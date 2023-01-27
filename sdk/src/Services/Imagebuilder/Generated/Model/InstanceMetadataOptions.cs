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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// The instance metadata options that apply to the HTTP requests that pipeline builds
    /// use to launch EC2 build and test instances. For more information about instance metadata
    /// options, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-options.html">Configure
    /// the instance metadata options</a> in the <i> <i>Amazon EC2 User Guide</i> </i> for
    /// Linux instances, or <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/configuring-instance-metadata-options.html">Configure
    /// the instance metadata options</a> in the <i> <i>Amazon EC2 Windows Guide</i> </i>
    /// for Windows instances.
    /// </summary>
    public partial class InstanceMetadataOptions
    {
        private int? _httpPutResponseHopLimit;
        private string _httpTokens;

        /// <summary>
        /// Gets and sets the property HttpPutResponseHopLimit. 
        /// <para>
        /// Limit the number of hops that an instance metadata request can traverse to reach its
        /// destination. The default is one hop. However, if HTTP tokens are required, container
        /// image builds need a minimum of two hops.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Indicates whether a signed token header is required for instance metadata retrieval
        /// requests. The values affect the response as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>required</b> – When you retrieve the IAM role credentials, version 2.0 credentials
        /// are returned in all cases.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>optional</b> – You can include a signed token header in your request to retrieve
        /// instance metadata, or you can leave it out. If you include it, version 2.0 credentials
        /// are returned for the IAM role. Otherwise, version 1.0 credentials are returned.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default setting is <b>optional</b>.
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