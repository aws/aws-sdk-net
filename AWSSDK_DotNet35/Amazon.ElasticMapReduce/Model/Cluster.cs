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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
    /// The detailed description of the cluster.
    /// </summary>
    public partial class Cluster
    {
        private List<Application> _applications = new List<Application>();
        private bool? _autoTerminate;
        private Ec2InstanceAttributes _ec2InstanceAttributes;
        private string _id;
        private string _logUri;
        private string _name;
        private string _requestedAmiVersion;
        private string _runningAmiVersion;
        private string _serviceRole;
        private ClusterStatus _status;
        private List<Tag> _tags = new List<Tag>();
        private bool? _terminationProtected;
        private bool? _visibleToAllUsers;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The applications installed on this cluster.
        /// </para>
        /// </summary>
        public List<Application> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && this._applications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoTerminate. 
        /// <para>
        /// Specifies whether the cluster should terminate after completing all steps.
        /// </para>
        /// </summary>
        public bool AutoTerminate
        {
            get { return this._autoTerminate.GetValueOrDefault(); }
            set { this._autoTerminate = value; }
        }

        // Check to see if AutoTerminate property is set
        internal bool IsSetAutoTerminate()
        {
            return this._autoTerminate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceAttributes.
        /// </summary>
        public Ec2InstanceAttributes Ec2InstanceAttributes
        {
            get { return this._ec2InstanceAttributes; }
            set { this._ec2InstanceAttributes = value; }
        }

        // Check to see if Ec2InstanceAttributes property is set
        internal bool IsSetEc2InstanceAttributes()
        {
            return this._ec2InstanceAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the cluster.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The path to the Amazon S3 location where logs for this cluster are stored.
        /// </para>
        /// </summary>
        public string LogUri
        {
            get { return this._logUri; }
            set { this._logUri = value; }
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this._logUri != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RequestedAmiVersion. 
        /// <para>
        /// The AMI version requested for this cluster.
        /// </para>
        /// </summary>
        public string RequestedAmiVersion
        {
            get { return this._requestedAmiVersion; }
            set { this._requestedAmiVersion = value; }
        }

        // Check to see if RequestedAmiVersion property is set
        internal bool IsSetRequestedAmiVersion()
        {
            return this._requestedAmiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RunningAmiVersion. 
        /// <para>
        /// The AMI version running on this cluster. This differs from the requested version only
        /// if the requested version is a meta version, such as "latest". 
        /// </para>
        /// </summary>
        public string RunningAmiVersion
        {
            get { return this._runningAmiVersion; }
            set { this._runningAmiVersion = value; }
        }

        // Check to see if RunningAmiVersion property is set
        internal bool IsSetRunningAmiVersion()
        {
            return this._runningAmiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM role that was specified when the job flow was launched. Amazon ElasticMapReduce
        /// will assume this role to work with AWS resources on your behalf.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status details about the cluster.
        /// </para>
        /// </summary>
        public ClusterStatus Status
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
        /// A list of tags associated with a cluster.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TerminationProtected. 
        /// <para>
        /// Indicates whether Amazon EMR will lock the cluster to prevent the EC2 instances from
        /// being terminated by an API call or       user intervention, or in the event of a cluster
        /// error.
        /// </para>
        /// </summary>
        public bool TerminationProtected
        {
            get { return this._terminationProtected.GetValueOrDefault(); }
            set { this._terminationProtected = value; }
        }

        // Check to see if TerminationProtected property is set
        internal bool IsSetTerminationProtected()
        {
            return this._terminationProtected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VisibleToAllUsers. 
        /// <para>
        /// Indicates whether the job flow is visible to all IAM users of the AWS account associated
        /// with the job flow. If this value is set to <code>true</code>, all IAM users of that
        /// AWS account can view and manage the job flow if they have the proper policy permissions
        /// set.          If this value is <code>false</code>, only the IAM user that created
        /// the cluster can view and manage it. This value can be changed using the <a>SetVisibleToAllUsers</a>
        /// action.
        /// </para>
        /// </summary>
        public bool VisibleToAllUsers
        {
            get { return this._visibleToAllUsers.GetValueOrDefault(); }
            set { this._visibleToAllUsers = value; }
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this._visibleToAllUsers.HasValue; 
        }

    }
}