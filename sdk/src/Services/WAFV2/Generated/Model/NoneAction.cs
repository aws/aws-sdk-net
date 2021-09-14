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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Specifies that WAF should do nothing. This is generally used to try out a rule without
    /// performing any actions. You set the <code>OverrideAction</code> on the <a>Rule</a>.
    /// 
    /// 
    ///  
    /// <para>
    /// This is used in the context of other settings, for example to specify values for <a>RuleAction</a>
    /// and web ACL <a>DefaultAction</a>. 
    /// </para>
    ///  
    /// <para>
    /// JSON specification: <code>"None": {}</code> 
    /// </para>
    /// </summary>
    public partial class NoneAction
    {

    }
}