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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Specifies the first IP address in an HTTP header as an aggregate key for a rate-based
    /// rule. Each distinct forwarded IP address contributes to the aggregation instance.
    /// 
    ///  
    /// <para>
    /// This setting is used only in the <c>RateBasedStatementCustomKey</c> specification
    /// of a rate-based rule statement. When you specify an IP or forwarded IP in the custom
    /// key settings, you must also specify at least one other key to use. You can aggregate
    /// on only the forwarded IP address by specifying <c>FORWARDED_IP</c> in your rate-based
    /// statement's <c>AggregateKeyType</c>. 
    /// </para>
    ///  
    /// <para>
    /// This data type supports using the forwarded IP address in the web request aggregation
    /// for a rate-based rule, in <c>RateBasedStatementCustomKey</c>. The JSON specification
    /// for using the forwarded IP address doesn't explicitly use this data type. 
    /// </para>
    ///  
    /// <para>
    /// JSON specification: <c>"ForwardedIP": {}</c> 
    /// </para>
    ///  
    /// <para>
    /// When you use this specification, you must also configure the forwarded IP address
    /// in the rate-based statement's <c>ForwardedIPConfig</c>. 
    /// </para>
    /// </summary>
    public partial class RateLimitForwardedIP
    {

    }
}