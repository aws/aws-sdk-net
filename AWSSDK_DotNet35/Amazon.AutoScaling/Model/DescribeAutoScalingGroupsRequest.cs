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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAutoScalingGroups operation.
    /// Describes one or more Auto Scaling groups. If a list of names is not provided, the
    /// call describes all Auto Scaling groups.
    /// 
    ///  
    /// <para>
    /// You can specify a maximum number of items to be returned with a single call. If there
    /// are more items to return, the call returns a token. To get the next set of items,
    /// repeat the call with the returned token in the <code>NextToken</code> parameter.
    /// </para>
    /// </summary>
    public partial class DescribeAutoScalingGroupsRequest : AmazonAutoScalingRequest
    {
        private List<string> _autoScalingGroupNames = new List<string>();
        private int? _maxRecords;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupNames. 
        /// <para>
        /// The group names.
        /// </para>
        /// </summary>
        public List<string> AutoScalingGroupNames
        {
            get { return this._autoScalingGroupNames; }
            set { this._autoScalingGroupNames = value; }
        }

        // Check to see if AutoScalingGroupNames property is set
        internal bool IsSetAutoScalingGroupNames()
        {
            return this._autoScalingGroupNames != null && this._autoScalingGroupNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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