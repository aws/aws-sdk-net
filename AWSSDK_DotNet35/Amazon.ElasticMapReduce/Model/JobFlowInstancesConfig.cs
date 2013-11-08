/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>A description of the Amazon EC2 instance running the job flow. </para>
    /// </summary>
    public class JobFlowInstancesConfig
    {
        
        private string masterInstanceType;
        private string slaveInstanceType;
        private int? instanceCount;
        private List<InstanceGroupConfig> instanceGroups = new List<InstanceGroupConfig>();
        private string ec2KeyName;
        private PlacementType placement;
        private bool? keepJobFlowAliveWhenNoSteps;
        private bool? terminationProtected;
        private string hadoopVersion;
        private string ec2SubnetId;


        /// <summary>
        /// The EC2 instance type of the master node.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MasterInstanceType
        {
            get { return this.masterInstanceType; }
            set { this.masterInstanceType = value; }
        }

        // Check to see if MasterInstanceType property is set
        internal bool IsSetMasterInstanceType()
        {
            return this.masterInstanceType != null;
        }

        /// <summary>
        /// The EC2 instance type of the slave nodes.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SlaveInstanceType
        {
            get { return this.slaveInstanceType; }
            set { this.slaveInstanceType = value; }
        }

        // Check to see if SlaveInstanceType property is set
        internal bool IsSetSlaveInstanceType()
        {
            return this.slaveInstanceType != null;
        }

        /// <summary>
        /// The number of Amazon EC2 instances used to execute the job flow.
        ///  
        /// </summary>
        public int InstanceCount
        {
            get { return this.instanceCount ?? default(int); }
            set { this.instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this.instanceCount.HasValue;
        }

        /// <summary>
        /// Configuration for the job flow's instance groups.
        ///  
        /// </summary>
        public List<InstanceGroupConfig> InstanceGroups
        {
            get { return this.instanceGroups; }
            set { this.instanceGroups = value; }
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this.instanceGroups.Count > 0;
        }

        /// <summary>
        /// The name of the Amazon EC2 key pair that can be used to ssh to the master node as the user called "hadoop."
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Ec2KeyName
        {
            get { return this.ec2KeyName; }
            set { this.ec2KeyName = value; }
        }

        // Check to see if Ec2KeyName property is set
        internal bool IsSetEc2KeyName()
        {
            return this.ec2KeyName != null;
        }

        /// <summary>
        /// The Availability Zone the job flow will run in.
        ///  
        /// </summary>
        public PlacementType Placement
        {
            get { return this.placement; }
            set { this.placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this.placement != null;
        }

        /// <summary>
        /// Specifies whether the job flow should terminate after completing all steps.
        ///  
        /// </summary>
        public bool KeepJobFlowAliveWhenNoSteps
        {
            get { return this.keepJobFlowAliveWhenNoSteps ?? default(bool); }
            set { this.keepJobFlowAliveWhenNoSteps = value; }
        }

        // Check to see if KeepJobFlowAliveWhenNoSteps property is set
        internal bool IsSetKeepJobFlowAliveWhenNoSteps()
        {
            return this.keepJobFlowAliveWhenNoSteps.HasValue;
        }

        /// <summary>
        /// Specifies whether to lock the job flow to prevent the Amazon EC2 instances from being terminated by API call, user intervention, or in the
        /// event of a job flow error.
        ///  
        /// </summary>
        public bool TerminationProtected
        {
            get { return this.terminationProtected ?? default(bool); }
            set { this.terminationProtected = value; }
        }

        // Check to see if TerminationProtected property is set
        internal bool IsSetTerminationProtected()
        {
            return this.terminationProtected.HasValue;
        }

        /// <summary>
        /// The Hadoop version for the job flow. Valid inputs are "0.18", "0.20", or "0.20.205". If you do not set this value, the default of 0.18 is
        /// used, unless the AmiVersion parameter is set in the RunJobFlow call, in which case the default version of Hadoop for that AMI version is
        /// used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HadoopVersion
        {
            get { return this.hadoopVersion; }
            set { this.hadoopVersion = value; }
        }

        // Check to see if HadoopVersion property is set
        internal bool IsSetHadoopVersion()
        {
            return this.hadoopVersion != null;
        }

        /// <summary>
        /// To launch the job flow in Amazon Virtual Private Cloud (Amazon VPC), set this parameter to the identifier of the Amazon VPC subnet where you
        /// want the job flow to launch. If you do not specify this value, the job flow is launched in the normal Amazon Web Services cloud, outside of
        /// an Amazon VPC. Amazon VPC currently does not support cluster compute quadruple extra large (cc1.4xlarge) instances. Thus you cannot specify
        /// the cc1.4xlarge instance type for nodes of a job flow launched in a Amazon VPC.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Ec2SubnetId
        {
            get { return this.ec2SubnetId; }
            set { this.ec2SubnetId = value; }
        }

        // Check to see if Ec2SubnetId property is set
        internal bool IsSetEc2SubnetId()
        {
            return this.ec2SubnetId != null;
        }
    }
}
