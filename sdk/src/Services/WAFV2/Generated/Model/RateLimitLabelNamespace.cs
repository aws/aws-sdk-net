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
    /// Specifies a label namespace to use as an aggregate key for a rate-based rule. Each
    /// distinct fully qualified label name that has the specified label namespace contributes
    /// to the aggregation instance. If you use just one label namespace as your custom key,
    /// then each label name fully defines an aggregation instance. 
    /// 
    ///  
    /// <para>
    /// This uses only labels that have been added to the request by rules that are evaluated
    /// before this rate-based rule in the web ACL. 
    /// </para>
    ///  
    /// <para>
    /// For information about label namespaces and names, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-label-requirements.html">Label
    /// syntax and naming requirements</a> in the <i>WAF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RateLimitLabelNamespace
    {
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace to use for aggregation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

    }
}