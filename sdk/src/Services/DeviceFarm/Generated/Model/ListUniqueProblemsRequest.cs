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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the ListUniqueProblems operation.
    /// Gets information about unique problems, such as exceptions or crashes.
    /// 
    ///  
    /// <para>
    /// Unique problems are defined as a single instance of an error across a run, job, or
    /// suite. For example, if a call in your application consistently raises an exception
    /// (<code>OutOfBoundsException in MyActivity.java:386</code>), <code>ListUniqueProblems</code>
    /// returns a single entry instead of many individual entries for that exception.
    /// </para>
    /// </summary>
    public partial class ListUniqueProblemsRequest : AmazonDeviceFarmRequest
    {
        private string _arn;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique problems' ARNs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}