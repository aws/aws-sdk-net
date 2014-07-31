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
    /// The <code>AutoScalingInstancesType</code> data type.
    /// </summary>
    public partial class DescribeAutoScalingInstancesResult : AmazonWebServiceResponse
    {
        private List<AutoScalingInstanceDetails> _autoScalingInstances = new List<AutoScalingInstanceDetails>();
        private string _nextToken;


        /// <summary>
        /// Gets and sets the property AutoScalingInstances. 
        /// <para>
        ///  A list of Auto Scaling instances. 
        /// </para>
        /// </summary>
        public List<AutoScalingInstanceDetails> AutoScalingInstances
        {
            get { return this._autoScalingInstances; }
            set { this._autoScalingInstances = value; }
        }

        // Check to see if AutoScalingInstances property is set
        internal bool IsSetAutoScalingInstances()
        {
            return this._autoScalingInstances != null && this._autoScalingInstances.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A string that marks the start of the next batch of returned results. 
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