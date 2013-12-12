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
    /// <para>The detailed description of the cluster.</para>
    /// </summary>
    public class Cluster
    {
        
        private string id;
        private string name;
        private ClusterStatus status;
        private Ec2InstanceAttributes ec2InstanceAttributes;
        private string logUri;
        private string requestedAmiVersion;
        private string runningAmiVersion;
        private bool? autoTerminate;
        private bool? terminationProtected;
        private bool? visibleToAllUsers;
        private List<Application> applications = new List<Application>();
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// The unique identifier for the cluster.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The name of the cluster.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The current status details about the cluster.
        ///  
        /// </summary>
        public ClusterStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Provides information about the EC2 instances in a cluster grouped by category. For example, EC2 Key Name, Subnet Id, Instance Profile, and
        /// so on.
        ///  
        /// </summary>
        public Ec2InstanceAttributes Ec2InstanceAttributes
        {
            get { return this.ec2InstanceAttributes; }
            set { this.ec2InstanceAttributes = value; }
        }

        // Check to see if Ec2InstanceAttributes property is set
        internal bool IsSetEc2InstanceAttributes()
        {
            return this.ec2InstanceAttributes != null;
        }

        /// <summary>
        /// The path to the Amazon S3 location where logs for this cluster are stored.
        ///  
        /// </summary>
        public string LogUri
        {
            get { return this.logUri; }
            set { this.logUri = value; }
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this.logUri != null;
        }

        /// <summary>
        /// The AMI version requested for this cluster.<!-- For more information, see <a>JobFlowDetail$AmiVersion</a>.-->
        ///  
        /// </summary>
        public string RequestedAmiVersion
        {
            get { return this.requestedAmiVersion; }
            set { this.requestedAmiVersion = value; }
        }

        // Check to see if RequestedAmiVersion property is set
        internal bool IsSetRequestedAmiVersion()
        {
            return this.requestedAmiVersion != null;
        }

        /// <summary>
        /// The AMI version running on this cluster. This differs from the requested version only if the requested version is a meta version, such as
        /// "latest". <!--For more information, see <a>JobFlowDetail$AmiVersion</a>.-->
        ///  
        /// </summary>
        public string RunningAmiVersion
        {
            get { return this.runningAmiVersion; }
            set { this.runningAmiVersion = value; }
        }

        // Check to see if RunningAmiVersion property is set
        internal bool IsSetRunningAmiVersion()
        {
            return this.runningAmiVersion != null;
        }

        /// <summary>
        /// Specifies whether the cluster should terminate after completing all steps.
        ///  
        /// </summary>
        public bool AutoTerminate
        {
            get { return this.autoTerminate ?? default(bool); }
            set { this.autoTerminate = value; }
        }

        // Check to see if AutoTerminate property is set
        internal bool IsSetAutoTerminate()
        {
            return this.autoTerminate.HasValue;
        }

        /// <summary>
        /// Indicates whether Amazon EMR will lock the cluster to prevent the EC2 instances from being terminated by an API call or user intervention,
        /// or in the event of a cluster error.
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
        /// Indicates whether the job flow is visible to all IAM users of the AWS account associated with the job flow. If this value is set to
        /// <c>true</c>, all IAM users of that AWS account can view and manage the job flow if they have the proper policy permissions set. If this
        /// value is <c>false</c>, only the IAM user that created the cluster can view and manage it. This value can be changed using the
        /// <a>SetVisibleToAllUsers</a> action.
        ///  
        /// </summary>
        public bool VisibleToAllUsers
        {
            get { return this.visibleToAllUsers ?? default(bool); }
            set { this.visibleToAllUsers = value; }
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this.visibleToAllUsers.HasValue;
        }

        /// <summary>
        /// The applications installed on this cluster.
        ///  
        /// </summary>
        public List<Application> Applications
        {
            get { return this.applications; }
            set { this.applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this.applications.Count > 0;
        }

        /// <summary>
        /// A list of tags associated with cluster.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
