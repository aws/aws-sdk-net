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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// A message returned by the <c>GetMetricData</c>API, including a code and a description.
    /// 
    ///  
    /// <para>
    /// If a cross-Region <c>GetMetricData</c> operation fails with a code of <c>Forbidden</c>
    /// and a value of <c>Authentication too complex to retrieve cross region data</c>, you
    /// can correct the problem by running the <c>GetMetricData</c> operation in the same
    /// Region where the metric data is.
    /// </para>
    /// </summary>
    public partial class MessageData
    {
        private string _code;
        private string _value;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code or status code associated with the message.
        /// </para>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The message text.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}