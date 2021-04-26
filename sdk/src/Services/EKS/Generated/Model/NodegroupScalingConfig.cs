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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing the scaling configuration details for the Auto Scaling group
    /// that is associated with your node group. If you specify a value for any property,
    /// then you must specify values for all of the properties.
    /// </summary>
    public partial class NodegroupScalingConfig
    {
        private int? _desiredSize;
        private int? _maxSize;
        private int? _minSize;

        /// <summary>
        /// Gets and sets the property DesiredSize. 
        /// <para>
        /// The current number of nodes that the managed node group should maintain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int DesiredSize
        {
            get { return this._desiredSize.GetValueOrDefault(); }
            set { this._desiredSize = value; }
        }

        // Check to see if DesiredSize property is set
        internal bool IsSetDesiredSize()
        {
            return this._desiredSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum number of nodes that the managed node group can scale out to. For information
        /// about the maximum number that you can specify, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/service-quotas.html">Amazon
        /// EKS service quotas</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum number of nodes that the managed node group can scale in to. This number
        /// must be greater than zero.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

    }
}