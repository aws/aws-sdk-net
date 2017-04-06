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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information to use when checking for a successful response from a target.
    /// </summary>
    public partial class Matcher
    {
        private string _httpCode;

        /// <summary>
        /// Gets and sets the property HttpCode. 
        /// <para>
        /// The HTTP codes. You can specify values between 200 and 499. The default value is 200.
        /// You can specify multiple values (for example, "200,202") or a range of values (for
        /// example, "200-299").
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