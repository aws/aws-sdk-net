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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the configuration of the HTTP endpoint to which Kinesis Firehose delivers
    /// data.
    /// </summary>
    public partial class HttpEndpointConfiguration
    {
        private string _accessKey;
        private string _name;
        private string _url;

        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// The access key required for Kinesis Firehose to authenticate with the HTTP endpoint
        /// selected as the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4096)]
        public string AccessKey
        {
            get { return this._accessKey; }
            set { this._accessKey = value; }
        }

        // Check to see if AccessKey property is set
        internal bool IsSetAccessKey()
        {
            return this._accessKey != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the HTTP endpoint selected as the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the HTTP endpoint selected as the destination.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you choose an HTTP endpoint as your destination, review and follow the instructions
        /// in the <a href="https://docs.aws.amazon.com/firehose/latest/dev/httpdeliveryrequestresponse.html">Appendix
        /// - HTTP Endpoint Delivery Request and Response Specifications</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1000)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}