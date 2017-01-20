/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Container for the parameters to the GetChangeToken operation.
    /// When you want to create, update, or delete AWS WAF objects, get a change token and
    /// include the change token in the create, update, or delete request. Change tokens ensure
    /// that your application doesn't submit conflicting requests to AWS WAF.
    /// 
    ///  
    /// <para>
    /// Each create, update, or delete request must use a unique change token. If your application
    /// submits a <code>GetChangeToken</code> request and then submits a second <code>GetChangeToken</code>
    /// request before submitting a create, update, or delete request, the second <code>GetChangeToken</code>
    /// request returns the same value as the first <code>GetChangeToken</code> request.
    /// </para>
    ///  
    /// <para>
    /// When you use a change token in a create, update, or delete request, the status of
    /// the change token changes to <code>PENDING</code>, which indicates that AWS WAF is
    /// propagating the change to all AWS WAF servers. Use <code>GetChangeTokenStatus</code>
    /// to determine the status of your change token.
    /// </para>
    /// </summary>
    public partial class GetChangeTokenRequest : AmazonWAFRegionalRequest
    {

    }
}