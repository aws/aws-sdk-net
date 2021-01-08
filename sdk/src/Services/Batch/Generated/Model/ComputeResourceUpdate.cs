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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object representing the attributes of a compute environment that can be updated.
    /// For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
    /// Environments</a> in the <i>AWS Batch User Guide</i>.
    /// </summary>
    public partial class ComputeResourceUpdate
    {
        private int? _desiredvCpus;
        private int? _maxvCpus;
        private int? _minvCpus;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _subnets = new List<string>();

        /// <summary>
        /// Gets and sets the property DesiredvCpus. 
        /// <para>
        /// The desired number of Amazon EC2 vCPUS in the compute environment.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
        /// </para>
        ///  </note>
        /// </summary>
        public int DesiredvCpus
        {
            get { return this._desiredvCpus.GetValueOrDefault(); }
            set { this._desiredvCpus = value; }
        }

        // Check to see if DesiredvCpus property is set
        internal bool IsSetDesiredvCpus()
        {
            return this._desiredvCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxvCpus. 
        /// <para>
        /// The maximum number of Amazon EC2 vCPUs that an environment can reach.
        /// </para>
        ///  <note> 
        /// <para>
        /// With both <code>BEST_FIT_PROGRESSIVE</code> and <code>SPOT_CAPACITY_OPTIMIZED</code>
        /// allocation strategies, AWS Batch might need to go above <code>maxvCpus</code> to meet
        /// your capacity requirements. In this event, AWS Batch will never go above <code>maxvCpus</code>
        /// by more than a single instance (e.g., no more than a single instance from among those
        /// specified in your compute environment).
        /// </para>
        ///  </note>
        /// </summary>
        public int MaxvCpus
        {
            get { return this._maxvCpus.GetValueOrDefault(); }
            set { this._maxvCpus = value; }
        }

        // Check to see if MaxvCpus property is set
        internal bool IsSetMaxvCpus()
        {
            return this._maxvCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinvCpus. 
        /// <para>
        /// The minimum number of Amazon EC2 vCPUs that an environment should maintain.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
        /// </para>
        ///  </note>
        /// </summary>
        public int MinvCpus
        {
            get { return this._minvCpus.GetValueOrDefault(); }
            set { this._minvCpus = value; }
        }

        // Check to see if MinvCpus property is set
        internal bool IsSetMinvCpus()
        {
            return this._minvCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The Amazon EC2 security groups associated with instances launched in the compute environment.
        /// This parameter is required for Fargate compute resources, where it can contain up
        /// to 5 security groups. This can't be specified for EC2 compute resources. Providing
        /// an empty list is handled as if this parameter wasn't specified and no change is made.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The VPC subnets that the compute resources are launched into. This parameter is required
        /// for jobs running on Fargate compute resources, where it can contain up to 16 subnets.
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">VPCs
        /// and Subnets</a> in the <i>Amazon VPC User Guide</i>. This can't be specified for EC2
        /// compute resources. Providing an empty list will be handled as if this parameter wasn't
        /// specified and no change is made.
        /// </para>
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

    }
}