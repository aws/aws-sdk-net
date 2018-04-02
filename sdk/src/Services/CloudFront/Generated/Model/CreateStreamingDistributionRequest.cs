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
    /// Container for the parameters to the CreateStreamingDistribution operation.
    /// Creates a new RMTP distribution. An RTMP distribution is similar to a web distribution,
    /// but an RTMP distribution streams media files using the Adobe Real-Time Messaging Protocol
    /// (RTMP) instead of serving files using HTTP. 
    /// 
    ///  
    /// <para>
    /// To create a new web distribution, submit a <code>POST</code> request to the <i>CloudFront
    /// API version</i>/distribution resource. The request body must include a document with
    /// a <i>StreamingDistributionConfig</i> element. The response echoes the <code>StreamingDistributionConfig</code>
    /// element and returns other information about the RTMP distribution.
    /// </para>
    ///  
    /// <para>
    /// To get the status of your request, use the <i>GET StreamingDistribution</i> API action.
    /// When the value of <code>Enabled</code> is <code>true</code> and the value of <code>Status</code>
    /// is <code>Deployed</code>, your distribution is ready. A distribution usually deploys
    /// in less than 15 minutes.
    /// </para>
    ///  
    /// <para>
    /// For more information about web distributions, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-rtmp.html">Working
    /// with RTMP Distributions</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// Beginning with the 2012-05-05 version of the CloudFront API, we made substantial changes
    /// to the format of the XML document that you include in the request body when you create
    /// or update a web distribution or an RTMP distribution, and when you invalidate objects.
    /// With previous versions of the API, we discovered that it was too easy to accidentally
    /// delete one or more values for an element that accepts multiple values, for example,
    /// CNAMEs and trusted signers. Our changes for the 2012-05-05 release are intended to
    /// prevent these accidental deletions and to notify you when there's a mismatch between
    /// the number of values you say you're specifying in the <code>Quantity</code> element
    /// and the number of values specified.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateStreamingDistributionRequest : AmazonCloudFrontRequest
    {
        private StreamingDistributionConfig _streamingDistributionConfig;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateStreamingDistributionRequest() { }

        /// <summary>
        /// Instantiates CreateStreamingDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="streamingDistributionConfig">The streaming distribution's configuration information.</param>
        public CreateStreamingDistributionRequest(StreamingDistributionConfig streamingDistributionConfig)
        {
            _streamingDistributionConfig = streamingDistributionConfig;
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