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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeApplicationStatus operation.
    /// </summary>
    public partial class DescribeApplicationStatusResponse : AmazonWebServiceResponse
    {
        private ApplicationStatusesResponseType _applicationStatuses;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApplicationStatuses. 
        /// <para>
        /// The application statuses for the specified instances.
        /// </para>
        /// </summary>
        public ApplicationStatusesResponseType ApplicationStatuses
        {
            get { return this._applicationStatuses; }
            set { this._applicationStatuses = value; }
        }

        // Check to see if ApplicationStatuses property is set
        internal bool IsSetApplicationStatuses()
        {
            return this._applicationStatuses != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to include in another request to get the next page of items. This value
        /// is &lt;code&gt;null&lt;/code&gt; when there are no more items to return.
        /// </para>
        /// </summary>
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