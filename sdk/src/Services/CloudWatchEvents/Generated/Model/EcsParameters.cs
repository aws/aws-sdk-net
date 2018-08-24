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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// The custom parameters to be used when the target is an Amazon ECS task.
    /// </summary>
    public partial class EcsParameters
    {
        private string _group;
        private LaunchType _launchType;
        private NetworkConfiguration _networkConfiguration;
        private string _platformVersion;
        private int? _taskCount;
        private string _taskDefinitionArn;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// Specifies an ECS task group for the task. The maximum length is 255 characters.
        /// </para>
        /// </summary>
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// Specifies the launch type on which your task is running. The launch type that you
        /// specify here must match one of the launch type (compatibilities) of the target task.
        /// The <code>FARGATE</code> value is supported only in the Regions where AWS Fargate
        /// with Amazon ECS is supported. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/AWS-Fargate.html">AWS
        /// Fargate on Amazon ECS</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public LaunchType LaunchType
        {
            get { return this._launchType; }
            set { this._launchType = value; }
        }

        // Check to see if LaunchType property is set
        internal bool IsSetLaunchType()
        {
            return this._launchType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Use this structure if the ECS task uses the <code>awsvpc</code> network mode. This
        /// structure specifies the VPC subnets and security groups associated with the task,
        /// and whether a public IP address is to be used. This structure is required if <code>LaunchType</code>
        /// is <code>FARGATE</code> because the <code>awsvpc</code> mode is required for Fargate
        /// tasks.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>NetworkConfiguration</code> when the target ECS task does not
        /// use the <code>awsvpc</code> network mode, the task fails.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// Specifies the platform version for the task. Specify only the numeric portion of the
        /// platform version, such as <code>1.1.0</code>.
        /// </para>
        ///  
        /// <para>
        /// This structure is used only if <code>LaunchType</code> is <code>FARGATE</code>. For
        /// more information about valid platform versions, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">AWS
        /// Fargate Platform Versions</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformVersion
        {
            get { return this._platformVersion; }
            set { this._platformVersion = value; }
        }

        // Check to see if PlatformVersion property is set
        internal bool IsSetPlatformVersion()
        {
            return this._platformVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TaskCount. 
        /// <para>
        /// The number of tasks to create based on <code>TaskDefinition</code>. The default is
        /// 1.
        /// </para>
        /// </summary>
        public int TaskCount
        {
            get { return this._taskCount.GetValueOrDefault(); }
            set { this._taskCount = value; }
        }

        // Check to see if TaskCount property is set
        internal bool IsSetTaskCount()
        {
            return this._taskCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The ARN of the task definition to use if the event target is an Amazon ECS task. 
        /// </para>
        /// </summary>
        public string TaskDefinitionArn
        {
            get { return this._taskDefinitionArn; }
            set { this._taskDefinitionArn = value; }
        }

        // Check to see if TaskDefinitionArn property is set
        internal bool IsSetTaskDefinitionArn()
        {
            return this._taskDefinitionArn != null;
        }

    }
}