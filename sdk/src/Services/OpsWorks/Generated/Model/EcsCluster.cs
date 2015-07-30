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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes a registered Amazon ECS cluster.
    /// </summary>
    public partial class EcsCluster
    {
        private string _ecsClusterArn;
        private string _ecsClusterName;
        private string _registeredAt;
        private string _stackId;

        /// <summary>
        /// Gets and sets the property EcsClusterArn. 
        /// <para>
        /// The cluster's ARN.
        /// </para>
        /// </summary>
        public string EcsClusterArn
        {
            get { return this._ecsClusterArn; }
            set { this._ecsClusterArn = value; }
        }

        // Check to see if EcsClusterArn property is set
        internal bool IsSetEcsClusterArn()
        {
            return this._ecsClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property EcsClusterName. 
        /// <para>
        /// The cluster name.
        /// </para>
        /// </summary>
        public string EcsClusterName
        {
            get { return this._ecsClusterName; }
            set { this._ecsClusterName = value; }
        }

        // Check to see if EcsClusterName property is set
        internal bool IsSetEcsClusterName()
        {
            return this._ecsClusterName != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The time and date that the cluster was registered with the stack.
        /// </para>
        /// </summary>
        public string RegisteredAt
        {
            get { return this._registeredAt; }
            set { this._registeredAt = value; }
        }

        // Check to see if RegisteredAt property is set
        internal bool IsSetRegisteredAt()
        {
            return this._registeredAt != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}