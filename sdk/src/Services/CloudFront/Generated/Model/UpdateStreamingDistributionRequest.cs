/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStreamingDistribution operation.
    /// Update a streaming distribution.
    /// </summary>
    public partial class UpdateStreamingDistributionRequest : AmazonCloudFrontRequest
    {
        private string _id;
        private string _ifMatch;
        private StreamingDistributionConfig _streamingDistributionConfig;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateStreamingDistributionRequest() { }

        /// <summary>
        /// Instantiates UpdateStreamingDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="id">The streaming distribution's id.</param>
        /// <param name="ifMatch">The value of the <code>ETag</code> header that you received when retrieving the streaming distribution's configuration. For example: <code>E2QWRUHAPOMQZL</code>.</param>
        /// <param name="streamingDistributionConfig">The streaming distribution's configuration information.</param>
        public UpdateStreamingDistributionRequest(string id, string ifMatch, StreamingDistributionConfig streamingDistributionConfig)
        {
            _id = id;
            _ifMatch = ifMatch;
            _streamingDistributionConfig = streamingDistributionConfig;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The streaming distribution's id.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The value of the <code>ETag</code> header that you received when retrieving the streaming
        /// distribution's configuration. For example: <code>E2QWRUHAPOMQZL</code>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingDistributionConfig. 
        /// <para>
        /// The streaming distribution's configuration information.
        /// </para>
        /// </summary>
        public StreamingDistributionConfig StreamingDistributionConfig
        {
            get { return this._streamingDistributionConfig; }
            set { this._streamingDistributionConfig = value; }
        }

        // Check to see if StreamingDistributionConfig property is set
        internal bool IsSetStreamingDistributionConfig()
        {
            return this._streamingDistributionConfig != null;
        }

    }
}