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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEndpoints operation.
    /// Returns a list of available endpoints to make Timestream API calls against. This API
    /// operation is available through both the Write and Query APIs.
    /// 
    ///  
    /// <para>
    /// Because the Timestream SDKs are designed to transparently work with the service’s
    /// architecture, including the management and mapping of the service endpoints, <i>we
    /// don't recommend that you use this API operation unless</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You are using <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/VPCEndpoints">VPC
    /// endpoints (Amazon Web Services PrivateLink) with Timestream</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your application uses a programming language that does not yet have SDK support
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You require better control over the client-side implementation
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For detailed information on how and when to use and implement DescribeEndpoints, see
    /// <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/Using.API.html#Using-API.endpoint-discovery">The
    /// Endpoint Discovery Pattern</a>.
    /// </para>
    /// </summary>
    public partial class DescribeEndpointsRequest : AmazonTimestreamWriteRequest
    {

    }
}