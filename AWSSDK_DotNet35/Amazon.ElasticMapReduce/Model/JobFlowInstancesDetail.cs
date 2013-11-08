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
    /// <para>Specify the type of Amazon EC2 instances to run the job flow on.</para>
    /// </summary>
    public class JobFlowInstancesDetail
    {
        
        private string masterInstanceType;
        private string masterPublicDnsName;
        private string masterInstanceId;
        private string slaveInstanceType;
        private int? instanceCount;
        private List<InstanceGroupDetail> instanceGroups = new List<InstanceGroupDetail>();
        private int? normalizedInstanceHours;
        private string ec2KeyName;
        private string ec2SubnetId;
        private PlacementType placement;
        private bool? keepJobFlowAliveWhenNoSteps;
        private bool? terminationProtected;
        private string hadoopVersion;


        /// <summary>
        /// The Amazon EC2 master node instance type.
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
        /// The DNS name of the master node.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10280</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MasterPublicDnsName
        {
            get { return this.masterPublicDnsName; }
            set { this.masterPublicDnsName = value; }
        }

        // Check to see if MasterPublicDnsName property is set
        internal bool IsSetMasterPublicDnsName()
        {
            return this.masterPublicDnsName != null;
        }

        /// <summary>
        /// The Amazon EC2 instance identifier of the master node.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10280</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MasterInstanceId
        {
            get { return this.masterInstanceId; }
            set { this.masterInstanceId = value; }
        }

        // Check to see if MasterInstanceId property is set
        internal bool IsSetMasterInstanceId()
        {
            return this.masterInstanceId != null;
        }

        /// <summary>
        /// The Amazon EC2 slave node instance type.
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
        /// The number of Amazon EC2 instances in the cluster. If the value is 1, the same instance serves as both the master and slave node. If the
        /// value is greater than 1, one instance is the master node and all others are slave nodes.
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
        /// Details about the job flow's instance groups.
        ///  
        /// </summary>
        public List<InstanceGroupDetail> InstanceGroups
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
        /// An approximation of the cost of the job flow, represented in m1.small/hours. This value is incremented once for every hour an m1.small runs.
        /// Larger instances are weighted more, so an Amazon EC2 instance that is roughly four times more expensive would result in the normalized
        /// instance hours being incremented by four. This result is only an approximation and does not reflect the actual billing rate.
        ///  
        /// </summary>
        public int NormalizedInstanceHours
        {
            get { return this.normalizedInstanceHours ?? default(int); }
            set { this.normalizedInstanceHours = value; }
        }

        // Check to see if NormalizedInstanceHours property is set
        internal bool IsSetNormalizedInstanceHours()
        {
            return this.normalizedInstanceHours.HasValue;
        }

        /// <summary>
        /// The name of an Amazon EC2 key pair that can be used to ssh to the master node of job flow.
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
        /// For job flows launched within Amazon Virtual Private Cloud, this value specifies the identifier of the subnet where the job flow was
        /// launched.
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

        /// <summary>
        /// The Amazon EC2 Availability Zone for the job flow.
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
        /// Specifies whether the Amazon EC2 instances in the cluster are protected from termination by API calls, user intervention, or in the event of
        /// a job flow error.
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
        /// The Hadoop version for the job flow.
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
    }
}
