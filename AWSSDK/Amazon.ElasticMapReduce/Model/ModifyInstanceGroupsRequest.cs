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
    public partial class ModifyInstanceGroupsRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the InstanceGroups property
        /// </summary>
        /// <param name="instanceGroups">The values to add to the InstanceGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyInstanceGroupsRequest WithInstanceGroups(params InstanceGroupModifyConfig[] instanceGroups)
        {
            foreach (var element in instanceGroups)
            {
                this._instanceGroups.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the InstanceGroups property
        /// </summary>
        /// <param name="instanceGroups">The values to add to the InstanceGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyInstanceGroupsRequest WithInstanceGroups(IEnumerable<InstanceGroupModifyConfig> instanceGroups)
        {
            foreach (var element in instanceGroups)
            {
                this._instanceGroups.Add(element);
            }
            return this;
        }
        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && this._instanceGroups.Count > 0; 
        }

    }
}