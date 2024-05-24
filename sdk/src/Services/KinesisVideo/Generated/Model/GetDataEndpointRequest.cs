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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the GetDataEndpoint operation.
    /// Gets an endpoint for a specified stream for either reading or writing. Use this endpoint
    /// in your application to read from the specified stream (using the <c>GetMedia</c> or
    /// <c>GetMediaForFragmentList</c> operations) or write to it (using the <c>PutMedia</c>
    /// operation). 
    /// 
    ///  <note> 
    /// <para>
    /// The returned endpoint does not have the API name appended. The client needs to add
    /// the API name to the returned endpoint.
    /// </para>
    ///  </note> 
    /// <para>
    /// In the request, specify the stream either by <c>StreamName</c> or <c>StreamARN</c>.
    /// </para>
    /// </summary>
    public partial class GetDataEndpointRequest : AmazonKinesisVideoRequest
    {
        private APIName _apiName;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property APIName. 
        /// <para>
        /// The name of the API action for which to get an endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public APIName APIName
        {
            get { return this._apiName; }
            set { this._apiName = value; }
        }

        // Check to see if APIName property is set
        internal bool IsSetAPIName()
        {
            return this._apiName != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream that you want to get the endpoint for.
        /// You must specify either this parameter or a <c>StreamName</c> in the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream that you want to get the endpoint for. You must specify either
        /// this parameter or a <c>StreamARN</c> in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}