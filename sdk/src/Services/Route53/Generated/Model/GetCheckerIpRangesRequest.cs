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
    /// Container for the parameters to the GetCheckerIpRanges operation.
    /// Route 53 does not perform authorization for this API because it retrieves information
    /// that is already available to the public.
    /// 
    ///  <important> 
    /// <para>
    ///  <c>GetCheckerIpRanges</c> still works, but we recommend that you download ip-ranges.json,
    /// which includes IP address ranges for all Amazon Web Services services. For more information,
    /// see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/route-53-ip-addresses.html">IP
    /// Address Ranges of Amazon Route 53 Servers</a> in the <i>Amazon Route 53 Developer
    /// Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetCheckerIpRangesRequest : AmazonRoute53Request
    {

    }
}