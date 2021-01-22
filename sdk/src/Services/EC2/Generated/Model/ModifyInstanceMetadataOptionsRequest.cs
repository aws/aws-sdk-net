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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceMetadataOptions operation.
    /// Modify the instance metadata parameters on a running or stopped instance. When you
    /// modify the parameters on a stopped instance, they are applied when the instance is
    /// started. When you modify the parameters on a running instance, the API responds with
    /// a state of “pending”. After the parameter modifications are successfully applied to
    /// the instance, the state of the modifications changes from “pending” to “applied” in
    /// subsequent describe-instances API calls. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html">Instance
    /// metadata and user data</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class ModifyInstanceMetadataOptionsRequest : AmazonEC2Request
    {
        private InstanceMetadataEndpointState _httpEndpoint;
        private int? _httpPutResponseHopLimit;
        private HttpTokensState _httpTokens;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// This parameter enables or disables the HTTP metadata endpoint on your instances. If
        /// the parameter is not specified, the existing state is maintained.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify a value of <code>disabled</code>, you will not be able to access your
        /// instance metadata.
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
        /// the number, the further instance metadata requests can travel. If no parameter is
        /// specified, the existing state is maintained.
        /// </para>
        ///  
        /// <para>
        /// Possible values: Integers from 1 to 64
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
        /// The state of token usage for your instance metadata requests. If the parameter is
        /// not specified in the request, the default state is <code>optional</code>.
        /// </para>
        ///  
        /// <para>
        /// If the state is <code>optional</code>, you can choose to retrieve instance metadata
        /// with or without a signed token header on your request. If you retrieve the IAM role
        /// credentials without a token, the version 1.0 role credentials are returned. If you
        /// retrieve the IAM role credentials using a valid signed token, the version 2.0 role
        /// credentials are returned.
        /// </para>
        ///  
        /// <para>
        /// If the state is <code>required</code>, you must send a signed token header with any
        /// instance metadata retrieval requests. In this state, retrieving the IAM role credential
        /// always returns the version 2.0 credentials; the version 1.0 credentials are not available.
        /// </para>
        /// </summary>
        public HttpTokensState HttpTokens
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}