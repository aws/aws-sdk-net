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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// This is the response object from the DescribeWarmPool operation.
    /// </summary>
    public partial class DescribeWarmPoolResponse : AmazonWebServiceResponse
    {
        private List<Instance> _instances = new List<Instance>();
        private string _nextToken;
        private WarmPoolConfiguration _warmPoolConfiguration;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The instances that are currently in the warm pool.
        /// </para>
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// This string indicates that the response contains more items than can be returned in
        /// a single response. To receive additional items, specify this string for the <code>NextToken</code>
        /// value when requesting the next set of items. This value is null when there are no
        /// more items to return.
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

        /// <summary>
        /// Gets and sets the property WarmPoolConfiguration. 
        /// <para>
        /// The warm pool configuration details. 
        /// </para>
        /// </summary>
        public WarmPoolConfiguration WarmPoolConfiguration
        {
            get { return this._warmPoolConfiguration; }
            set { this._warmPoolConfiguration = value; }
        }

        // Check to see if WarmPoolConfiguration property is set
        internal bool IsSetWarmPoolConfiguration()
        {
            return this._warmPoolConfiguration != null;
        }

    }
}