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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// The codes to use when checking for a successful response from a target. If the protocol
    /// version is gRPC, these are gRPC codes. Otherwise, these are HTTP codes.
    /// </summary>
    public partial class Matcher
    {
        private string _grpcCode;
        private string _httpCode;

        /// <summary>
        /// Gets and sets the property GrpcCode. 
        /// <para>
        /// You can specify values between 0 and 99. You can specify multiple values (for example,
        /// "0,1") or a range of values (for example, "0-5"). The default value is 12.
        /// </para>
        /// </summary>
        public string GrpcCode
        {
            get { return this._grpcCode; }
            set { this._grpcCode = value; }
        }

        // Check to see if GrpcCode property is set
        internal bool IsSetGrpcCode()
        {
            return this._grpcCode != null;
        }

        /// <summary>
        /// Gets and sets the property HttpCode. 
        /// <para>
        /// For Application Load Balancers, you can specify values between 200 and 499, with the
        /// default value being 200. You can specify multiple values (for example, "200,202")
        /// or a range of values (for example, "200-299").
        /// </para>
        ///  
        /// <para>
        /// For Network Load Balancers, you can specify values between 200 and 599, with the default
        /// value being 200-399. You can specify multiple values (for example, "200,202") or a
        /// range of values (for example, "200-299").
        /// </para>
        ///  
        /// <para>
        /// For Gateway Load Balancers, this must be "200–399".
        /// </para>
        ///  
        /// <para>
        /// Note that when using shorthand syntax, some values such as commas need to be escaped.
        /// </para>
        /// </summary>
        public string HttpCode
        {
            get { return this._httpCode; }
            set { this._httpCode = value; }
        }

        // Check to see if HttpCode property is set
        internal bool IsSetHttpCode()
        {
            return this._httpCode != null;
        }

    }
}