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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The metadata options for the instances. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-launch-config.html#launch-configurations-imds">Configure
    /// the instance metadata options</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </summary>
    public partial class InstanceMetadataOptions
    {
        private InstanceMetadataEndpointState _httpEndpoint;
        private int? _httpPutResponseHopLimit;
        private InstanceMetadataHttpTokensState _httpTokens;

        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// This parameter enables or disables the HTTP metadata endpoint on your instances. If
        /// the parameter is not specified, the default state is <c>enabled</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify a value of <c>disabled</c>, you will not be able to access your instance
        /// metadata. 
        /// </para>
        ///  </note>
        /// </summary>
        public InstanceMetadataEndpointState HttpEndpoint
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
        /// The desired HTTP PUT response hop limit for instance metadata requests. The larger
        /// the number, the further instance metadata requests can travel.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// If the state is <c>optional</c>, you can choose to retrieve instance metadata with
        /// or without a signed token header on your request. If you retrieve the IAM role credentials
        /// without a token, the version 1.0 role credentials are returned. If you retrieve the
        /// IAM role credentials using a valid signed token, the version 2.0 role credentials
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If the state is <c>required</c>, you must send a signed token header with any instance
        /// metadata retrieval requests. In this state, retrieving the IAM role credentials always
        /// returns the version 2.0 credentials; the version 1.0 credentials are not available.
        /// </para>
        /// </summary>
        public InstanceMetadataHttpTokensState HttpTokens
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