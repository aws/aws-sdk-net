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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The object that represents any node overrides to a job definition that's used in a
    /// <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_SubmitJob.html">SubmitJob</a>
    /// API operation.
    /// </summary>
    public partial class NodePropertyOverride
    {
        private ContainerOverrides _containerOverrides;
        private EcsPropertiesOverride _ecsPropertiesOverride;
        private List<string> _instanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _targetNodes;

        /// <summary>
        /// Gets and sets the property ContainerOverrides. 
        /// <para>
        /// The overrides that are sent to a node range.
        /// </para>
        /// </summary>
        public ContainerOverrides ContainerOverrides
        {
            get { return this._containerOverrides; }
            set { this._containerOverrides = value; }
        }

        // Check to see if ContainerOverrides property is set
        internal bool IsSetContainerOverrides()
        {
            return this._containerOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property EcsPropertiesOverride. 
        /// <para>
        /// An object that contains the properties that you want to replace for the existing Amazon
        /// ECS resources of a job.
        /// </para>
        /// </summary>
        public EcsPropertiesOverride EcsPropertiesOverride
        {
            get { return this._ecsPropertiesOverride; }
            set { this._ecsPropertiesOverride = value; }
        }

        // Check to see if EcsPropertiesOverride property is set
        internal bool IsSetEcsPropertiesOverride()
        {
            return this._ecsPropertiesOverride != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// An object that contains the instance types that you want to replace for the existing
        /// resources of a job.
        /// </para>
        /// </summary>
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && (this._instanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetNodes. 
        /// <para>
        /// The range of nodes, using node index values, that's used to override. A range of <c>0:3</c>
        /// indicates nodes with index values of <c>0</c> through <c>3</c>. If the starting range
        /// value is omitted (<c>:n</c>), then <c>0</c> is used to start the range. If the ending
        /// range value is omitted (<c>n:</c>), then the highest possible node index is used to
        /// end the range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetNodes
        {
            get { return this._targetNodes; }
            set { this._targetNodes = value; }
        }

        // Check to see if TargetNodes property is set
        internal bool IsSetTargetNodes()
        {
            return this._targetNodes != null;
        }

    }
}