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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteStreamingDistribution operation.
    /// Delete a streaming distribution. To delete an RTMP distribution using the CloudFront
    /// API, perform the following steps.
    /// 
    ///  
    /// <para>
    ///  <b>To delete an RTMP distribution using the CloudFront API</b>:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Disable the RTMP distribution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <c>GET Streaming Distribution Config</c> request to get the current configuration
    /// and the <c>Etag</c> header for the distribution. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Update the XML document that was returned in the response to your <c>GET Streaming
    /// Distribution Config</c> request to change the value of <c>Enabled</c> to <c>false</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <c>PUT Streaming Distribution Config</c> request to update the configuration
    /// for your distribution. In the request body, include the XML document that you updated
    /// in Step 3. Then set the value of the HTTP <c>If-Match</c> header to the value of the
    /// <c>ETag</c> header that CloudFront returned when you submitted the <c>GET Streaming
    /// Distribution Config</c> request in Step 2.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Review the response to the <c>PUT Streaming Distribution Config</c> request to confirm
    /// that the distribution was successfully disabled.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <c>GET Streaming Distribution Config</c> request to confirm that your changes
    /// have propagated. When propagation is complete, the value of <c>Status</c> is <c>Deployed</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <c>DELETE Streaming Distribution</c> request. Set the value of the HTTP <c>If-Match</c>
    /// header to the value of the <c>ETag</c> header that CloudFront returned when you submitted
    /// the <c>GET Streaming Distribution Config</c> request in Step 2.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Review the response to your <c>DELETE Streaming Distribution</c> request to confirm
    /// that the distribution was successfully deleted.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For information about deleting a distribution using the CloudFront console, see <a
    /// href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/HowToDeleteDistribution.html">Deleting
    /// a Distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteStreamingDistributionRequest : AmazonCloudFrontRequest
    {
        private string _id;
        private string _ifMatch;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteStreamingDistributionRequest() { }

        /// <summary>
        /// Instantiates DeleteStreamingDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="id">The distribution ID.</param>
        /// <param name="ifMatch">The value of the <c>ETag</c> header that you received when you disabled the streaming distribution. For example: <c>E2QWRUHAPOMQZL</c>.</param>
        public DeleteStreamingDistributionRequest(string id, string ifMatch)
        {
            _id = id;
            _ifMatch = ifMatch;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The distribution ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The value of the <c>ETag</c> header that you received when you disabled the streaming
        /// distribution. For example: <c>E2QWRUHAPOMQZL</c>.
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

    }
}