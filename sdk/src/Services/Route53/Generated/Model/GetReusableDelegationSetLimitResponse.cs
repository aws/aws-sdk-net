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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the requested limit.
    /// </summary>
    public partial class GetReusableDelegationSetLimitResponse : AmazonWebServiceResponse
    {
        private ReusableDelegationSetLimit _limit;
        private long? _count;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The current setting for the limit on hosted zones that you can associate with the
        /// specified reusable delegation set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReusableDelegationSetLimit Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The current number of hosted zones that you can associate with the specified reusable
        /// delegation set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

    }
}