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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEntityAggregates operation.
    /// 
    /// </summary>
    public partial class DescribeEntityAggregatesRequest : AmazonAWSHealthRequest
    {
        private List<string> _eventArns = new List<string>();

        /// <summary>
        /// Gets and sets the property EventArns. 
        /// <para>
        /// A list of event ARNs (unique identifiers). For example: <code>arn:aws:silvermine:<i>region</i>:<i>service</i>:event/<i>123453434</i>
        /// </code>.)
        /// </para>
        /// </summary>
        public List<string> EventArns
        {
            get { return this._eventArns; }
            set { this._eventArns = value; }
        }

        // Check to see if EventArns property is set
        internal bool IsSetEventArns()
        {
            return this._eventArns != null && this._eventArns.Count > 0; 
        }

    }
}