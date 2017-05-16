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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about the load balancer used in a deployment.
    /// </summary>
    public partial class LoadBalancerInfo
    {
        private List<ELBInfo> _elbInfoList = new List<ELBInfo>();

        /// <summary>
        /// Gets and sets the property ElbInfoList. 
        /// <para>
        /// An array containing information about the load balancer in Elastic Load Balancing
        /// to use in a deployment.
        /// </para>
        /// </summary>
        public List<ELBInfo> ElbInfoList
        {
            get { return this._elbInfoList; }
            set { this._elbInfoList = value; }
        }

        // Check to see if ElbInfoList property is set
        internal bool IsSetElbInfoList()
        {
            return this._elbInfoList != null && this._elbInfoList.Count > 0; 
        }

    }
}