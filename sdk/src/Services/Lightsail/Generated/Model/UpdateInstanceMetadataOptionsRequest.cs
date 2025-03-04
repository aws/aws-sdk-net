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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInstanceMetadataOptions operation.
    /// Modifies the Amazon Lightsail instance metadata parameters on a running or stopped
    /// instance. When you modify the parameters on a running instance, the <c>GetInstance</c>
    /// or <c>GetInstances</c> API operation initially responds with a state of <c>pending</c>.
    /// After the parameter modifications are successfully applied, the state changes to <c>applied</c>
    /// in subsequent <c>GetInstance</c> or <c>GetInstances</c> API calls. For more information,
    /// see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-configuring-instance-metadata-service">Use
    /// IMDSv2 with an Amazon Lightsail instance</a> in the <i>Amazon Lightsail Developer
    /// Guide</i>.
    /// </summary>
    public partial class UpdateInstanceMetadataOptionsRequest : AmazonLightsailRequest
    {
        private HttpEndpoint _httpEndpoint;
        private HttpProtocolIpv6 _httpProtocolIpv6;
        private int? _httpPutResponseHopLimit;
        private HttpTokens _httpTokens;
        private string _instanceName;

        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Enables or disables the HTTP metadata endpoint on your instances. If this parameter
        /// is not specified, the existing state is maintained.
        /// </para>
        ///  
        /// <para>
        /// If you specify a value of <c>disabled</c>, you cannot access your instance metadata.
        /// </para>
        /// </summary>
        public HttpEndpoint HttpEndpoint
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
        /// Gets and sets the property HttpProtocolIpv6. 
        /// <para>
        /// Enables or disables the IPv6 endpoint for the instance metadata service. This setting
        /// applies only when the HTTP metadata endpoint is enabled.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is available only for instances in the Europe (Stockholm) Amazon Web
        /// Services Region (<c>eu-north-1</c>).
        /// </para>
        ///  </note>
        /// </summary>
        public HttpProtocolIpv6 HttpProtocolIpv6
        {
            get { return this._httpProtocolIpv6; }
            set { this._httpProtocolIpv6 = value; }
        }

        // Check to see if HttpProtocolIpv6 property is set
        internal bool IsSetHttpProtocolIpv6()
        {
            return this._httpProtocolIpv6 != null;
        }

        /// <summary>
        /// Gets and sets the property HttpPutResponseHopLimit. 
        /// <para>
        /// The desired HTTP PUT response hop limit for instance metadata requests. A larger number
        /// means that the instance metadata requests can travel farther. If no parameter is specified,
        /// the existing state is maintained.
        /// </para>
        /// </summary>
        public int? HttpPutResponseHopLimit
        {
            get { return this._httpPutResponseHopLimit; }
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
        /// The state of token usage for your instance metadata requests. If the parameter is
        /// not specified in the request, the default state is <c>optional</c>.
        /// </para>
        ///  
        /// <para>
        /// If the state is <c>optional</c>, you can choose whether to retrieve instance metadata
        /// with a signed token header on your request. If you retrieve the IAM role credentials
        /// without a token, the version 1.0 role credentials are returned. If you retrieve the
        /// IAM role credentials by using a valid signed token, the version 2.0 role credentials
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If the state is <c>required</c>, you must send a signed token header with all instance
        /// metadata retrieval requests. In this state, retrieving the IAM role credential always
        /// returns the version 2.0 credentials. The version 1.0 credentials are not available.
        /// </para>
        /// </summary>
        public HttpTokens HttpTokens
        {
            get { return this._httpTokens; }
            set { this._httpTokens = value; }
        }

        // Check to see if HttpTokens property is set
        internal bool IsSetHttpTokens()
        {
            return this._httpTokens != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the instance for which to update metadata parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

    }
}