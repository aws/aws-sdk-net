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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// A set of dedicated instances for your build environment.
    /// </summary>
    public partial class Fleet
    {
        private string _arn;
        private int? _baseCapacity;
        private ComputeType _computeType;
        private DateTime? _created;
        private EnvironmentType _environmentType;
        private string _id;
        private DateTime? _lastModified;
        private string _name;
        private FleetOverflowBehavior _overflowBehavior;
        private ScalingConfigurationOutput _scalingConfiguration;
        private FleetStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the compute fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BaseCapacity. 
        /// <para>
        /// The initial number of machines allocated to the compute ﬂeet, which deﬁnes the number
        /// of builds that can run in parallel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? BaseCapacity
        {
            get { return this._baseCapacity; }
            set { this._baseCapacity = value; }
        }

        // Check to see if BaseCapacity property is set
        internal bool IsSetBaseCapacity()
        {
            return this._baseCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// Information about the compute resources the compute fleet uses. Available values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_SMALL</c>: Use up to 3 GB memory and 2 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_MEDIUM</c>: Use up to 7 GB memory and 4 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_LARGE</c>: Use up to 16 GB memory and 8 vCPUs for builds, depending
        /// on your environment type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_XLARGE</c>: Use up to 70 GB memory and 36 vCPUs for builds, depending
        /// on your environment type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_2XLARGE</c>: Use up to 145 GB memory, 72 vCPUs, and 824 GB of SSD
        /// storage for builds. This compute type supports Docker images up to 100 GB uncompressed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you use <c>BUILD_GENERAL1_SMALL</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For environment type <c>LINUX_CONTAINER</c>, you can use up to 3 GB memory and 2
        /// vCPUs for builds. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>LINUX_GPU_CONTAINER</c>, you can use up to 16 GB memory,
        /// 4 vCPUs, and 1 NVIDIA A10G Tensor Core GPU for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>ARM_CONTAINER</c>, you can use up to 4 GB memory and 2 vCPUs
        /// on ARM-based processors for builds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you use <c>BUILD_GENERAL1_LARGE</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For environment type <c>LINUX_CONTAINER</c>, you can use up to 15 GB memory and 8
        /// vCPUs for builds. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>LINUX_GPU_CONTAINER</c>, you can use up to 255 GB memory,
        /// 32 vCPUs, and 4 NVIDIA Tesla V100 GPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>ARM_CONTAINER</c>, you can use up to 16 GB memory and 8 vCPUs
        /// on ARM-based processors for builds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html">Build
        /// environment compute types</a> in the <i>CodeBuild User Guide.</i> 
        /// </para>
        /// </summary>
        public ComputeType ComputeType
        {
            get { return this._computeType; }
            set { this._computeType = value; }
        }

        // Check to see if ComputeType property is set
        internal bool IsSetComputeType()
        {
            return this._computeType != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The time at which the compute fleet was created.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentType. 
        /// <para>
        /// The environment type of the compute fleet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The environment type <c>ARM_CONTAINER</c> is available only in regions US East (N.
        /// Virginia), US East (Ohio), US West (Oregon), EU (Ireland), Asia Pacific (Mumbai),
        /// Asia Pacific (Tokyo), Asia Pacific (Singapore), Asia Pacific (Sydney), EU (Frankfurt),
        /// and South America (São Paulo).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>LINUX_CONTAINER</c> is available only in regions US East (N.
        /// Virginia), US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt), Asia Pacific
        /// (Tokyo), Asia Pacific (Singapore), Asia Pacific (Sydney), South America (São Paulo),
        /// and Asia Pacific (Mumbai).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>LINUX_GPU_CONTAINER</c> is available only in regions US East
        /// (N. Virginia), US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt), Asia
        /// Pacific (Tokyo), and Asia Pacific (Sydney).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>WINDOWS_SERVER_2019_CONTAINER</c> is available only in regions
        /// US East (N. Virginia), US East (Ohio), US West (Oregon), Asia Pacific (Sydney), Asia
        /// Pacific (Tokyo), Asia Pacific (Mumbai) and EU (Ireland).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>WINDOWS_SERVER_2022_CONTAINER</c> is available only in regions
        /// US East (N. Virginia), US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt),
        /// Asia Pacific (Sydney), Asia Pacific (Singapore), Asia Pacific (Tokyo), South America
        /// (São Paulo) and Asia Pacific (Mumbai).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html">Build
        /// environment compute types</a> in the <i>CodeBuild user guide</i>.
        /// </para>
        /// </summary>
        public EnvironmentType EnvironmentType
        {
            get { return this._environmentType; }
            set { this._environmentType = value; }
        }

        // Check to see if EnvironmentType property is set
        internal bool IsSetEnvironmentType()
        {
            return this._environmentType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the compute fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The time at which the compute fleet was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the compute fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OverflowBehavior. 
        /// <para>
        /// The compute fleet overflow behavior.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For overflow behavior <c>QUEUE</c>, your overflow builds need to wait on the existing
        /// fleet instance to become available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For overflow behavior <c>ON_DEMAND</c>, your overflow builds run on CodeBuild on-demand.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FleetOverflowBehavior OverflowBehavior
        {
            get { return this._overflowBehavior; }
            set { this._overflowBehavior = value; }
        }

        // Check to see if OverflowBehavior property is set
        internal bool IsSetOverflowBehavior()
        {
            return this._overflowBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingConfiguration. 
        /// <para>
        /// The scaling configuration of the compute fleet.
        /// </para>
        /// </summary>
        public ScalingConfigurationOutput ScalingConfiguration
        {
            get { return this._scalingConfiguration; }
            set { this._scalingConfiguration = value; }
        }

        // Check to see if ScalingConfiguration property is set
        internal bool IsSetScalingConfiguration()
        {
            return this._scalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the compute fleet.
        /// </para>
        /// </summary>
        public FleetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag key and value pairs associated with this compute fleet.
        /// </para>
        ///  
        /// <para>
        /// These tags are available for use by Amazon Web Services services that support CodeBuild
        /// build project tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}