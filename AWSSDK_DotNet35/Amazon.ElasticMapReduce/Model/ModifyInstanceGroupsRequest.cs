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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceGroups operation.
    /// ModifyInstanceGroups modifies the number of nodes and configuration settings of an
    /// instance         group. The input parameters include the new target instance count
    /// for the group and the         instance group ID. The call will either succeed or fail
    /// atomically.
    /// </summary>
    public partial class ModifyInstanceGroupsRequest : AmazonElasticMapReduceRequest
    {
        private List<InstanceGroupModifyConfig> _instanceGroups = new List<InstanceGroupModifyConfig>();


        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// Instance groups to change.
        /// </para>
        /// </summary>
        public List<InstanceGroupModifyConfig> InstanceGroups
        {
            get { return this._instanceGroups; }
            set { this._instanceGroups = value; }
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && this._instanceGroups.Count > 0; 
        }

    }
}