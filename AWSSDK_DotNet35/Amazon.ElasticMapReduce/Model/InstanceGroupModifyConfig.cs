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
    /// Modify an instance group size.
    /// </summary>
    public partial class InstanceGroupModifyConfig
    {
        private List<string> _eC2InstanceIdsToTerminate = new List<string>();
        private int? _instanceCount;
        private string _instanceGroupId;


        /// <summary>
        /// Gets and sets the property EC2InstanceIdsToTerminate. 
        /// <para>
        /// The EC2 InstanceIds to terminate. For advanced users only.                       
        ///                                                                                  
        ///                            Once you terminate the instances, the instance group will
        /// not return to its original requested size.
        /// </para>
        /// </summary>
        public List<string> EC2InstanceIdsToTerminate
        {
            get { return this._eC2InstanceIdsToTerminate; }
            set { this._eC2InstanceIdsToTerminate = value; }
        }

        // Check to see if EC2InstanceIdsToTerminate property is set
        internal bool IsSetEC2InstanceIdsToTerminate()
        {
            return this._eC2InstanceIdsToTerminate != null && this._eC2InstanceIdsToTerminate.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Target size for the instance group.
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// Unique ID of the instance group to expand or shrink.
        /// </para>
        /// </summary>
        public string InstanceGroupId
        {
            get { return this._instanceGroupId; }
            set { this._instanceGroupId = value; }
        }

        // Check to see if InstanceGroupId property is set
        internal bool IsSetInstanceGroupId()
        {
            return this._instanceGroupId != null;
        }

    }
}