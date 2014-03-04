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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterActivityType operation.
    /// <para> Registers a new <i>activity type</i> along with its configuration settings in the specified domain. </para> <para><b>IMPORTANT:</b> A
    /// TypeAlreadyExists fault is returned if the type already exists in the domain. You cannot change any configuration settings of the type after
    /// its registration, and it must be registered as a new version. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to
    /// control this action's access to Amazon SWF resources as follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
    /// <ul>
    /// <li> <c>defaultTaskList.name</c> : String constraint. The key is <c>swf:defaultTaskList.name</c> .</li>
    /// <li> <c>name</c> : String constraint. The key is <c>swf:name</c> .</li>
    /// <li> <c>version</c> : String constraint. The key is <c>swf:version</c> .</li>
    /// 
    /// </ul>
    /// </li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see Using IAM to Manage
    /// Access to Amazon SWF Workflows.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleWorkflow.AmazonSimpleWorkflow.RegisterActivityType"/>
    public class RegisterActivityTypeRequest : AmazonWebServiceRequest
    {
        private string domain;
        private string name;
        private string version;
        private string description;
        private string defaultTaskStartToCloseTimeout;
        private string defaultTaskHeartbeatTimeout;
        private TaskList defaultTaskList;
        private string defaultTaskScheduleToStartTimeout;
        private string defaultTaskScheduleToCloseTimeout;

        /// <summary>
        /// The name of the domain in which this activity is to be registered.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">The value to set for the Domain property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterActivityTypeRequest WithDomain(string domain)
        {
            this.domain = domain;
            return this;
        }
            

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

        /// <summary>
        /// The name of the activity type within the domain. The specified string must not start or end with whitespace. It must not contain a <c>:</c>
        /// (colon), <c>/</c> (slash), <c>|</c> (vertical bar), or any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain
        /// the literal string "arn".
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterActivityTypeRequest WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The version of the activity type. <note> The activity type consists of the name and version, the combination of which must be unique within
        /// the domain. </note> The specified string must not start or end with whitespace. It must not contain a <c>:</c> (colon), <c>/</c> (slash),
        /// <c>|</c> (vertical bar), or any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain the literal string "arn".
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this.version; }
            set { this.version = value; }
        }

        /// <summary>
        /// Sets the Version property
        /// </summary>
        /// <param name="version">The value to set for the Version property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterActivityTypeRequest WithVersion(string version)
        {
            this.version = version;
            return this;
        }
            

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this.version != null;
        }

        /// <summary>
        /// A textual description of the activity type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterActivityTypeRequest WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// If set, specifies the default maximum duration that a worker can take to process tasks of this activity type. This default can be overridden
        /// when scheduling an activity task using the <c>ScheduleActivityTask</c> <a>Decision</a>. The valid values are integers greater than or equal
        /// to <c>0</c>. An integer value can be used to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultTaskStartToCloseTimeout
        {
            get { return this.defaultTaskStartToCloseTimeout; }
            set { this.defaultTaskStartToCloseTimeout = value; }
        }

        /// <summary>
        /// Sets the DefaultTaskStartToCloseTimeout property
        /// </summary>
        /// <param name="defaultTaskStartToCloseTimeout">The value to set for the DefaultTaskStartToCloseTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterActivityTypeRequest WithDefaultTaskStartToCloseTimeout(string defaultTaskStartToCloseTimeout)
        {
            this.defaultTaskStartToCloseTimeout = defaultTaskStartToCloseTimeout;
            return this;
        }
            

        // Check to see if DefaultTaskStartToCloseTimeout property is set
        internal bool IsSetDefaultTaskStartToCloseTimeout()
        {
            return this.defaultTaskStartToCloseTimeout != null;
        }

        /// <summary>
        /// If set, specifies the default maximum time before which a worker processing a task of this type must report progress by calling
        /// <a>RecordActivityTaskHeartbeat</a>. If the timeout is exceeded, the activity task is automatically timed out. This default can be overridden
        /// when scheduling an activity task using the <c>ScheduleActivityTask</c> <a>Decision</a>. If the activity worker subsequently attempts to
        /// record a heartbeat or returns a result, the activity worker receives an <c>UnknownResource</c> fault. In this case, Amazon SWF no longer
        /// considers the activity task to be valid; the activity worker should clean up the activity task. The valid values are integers greater than
        /// or equal to <c>0</c>. An integer value can be used to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited
        /// duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultTaskHeartbeatTimeout
        {
            get { return this.defaultTaskHeartbeatTimeout; }
            set { this.defaultTaskHeartbeatTimeout = value; }
        }

        /// <summary>
        /// Sets the DefaultTaskHeartbeatTimeout property
        /// </summary>
        /// <param name="defaultTaskHeartbeatTimeout">The value to set for the DefaultTaskHeartbeatTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterActivityTypeRequest WithDefaultTaskHeartbeatTimeout(string defaultTaskHeartbeatTimeout)
        {
            this.defaultTaskHeartbeatTimeout = defaultTaskHeartbeatTimeout;
            return this;
        }
            

        // Check to see if DefaultTaskHeartbeatTimeout property is set
        internal bool IsSetDefaultTaskHeartbeatTimeout()
        {
            return this.defaultTaskHeartbeatTimeout != null;
        }

        /// <summary>
        /// If set, specifies the default task list to use for scheduling tasks of this activity type. This default task list is used if a task list is
        /// not provided when a task is scheduled through the <c>ScheduleActivityTask</c> <a>Decision</a>.
        ///  
        /// </summary>
        public TaskList DefaultTaskList
        {
            get { return this.defaultTaskList; }
            set { this.defaultTaskList = value; }
        }

        /// <summary>
        /// Sets the DefaultTaskList property
        /// </summary>
        /// <param name="defaultTaskList">The value to set for the DefaultTaskList property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterActivityTypeRequest WithDefaultTaskList(TaskList defaultTaskList)
        {
            this.defaultTaskList = defaultTaskList;
            return this;
        }
            

        // Check to see if DefaultTaskList property is set
        internal bool IsSetDefaultTaskList()
        {
            return this.defaultTaskList != null;
        }

        /// <summary>
        /// If set, specifies the default maximum duration that a task of this activity type can wait before being assigned to a worker. This default
        /// can be overridden when scheduling an activity task using the <c>ScheduleActivityTask</c> <a>Decision</a>. The valid values are integers
        /// greater than or equal to <c>0</c>. An integer value can be used to specify the duration in seconds while <c>NONE</c> can be used to specify
        /// unlimited duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultTaskScheduleToStartTimeout
        {
            get { return this.defaultTaskScheduleToStartTimeout; }
            set { this.defaultTaskScheduleToStartTimeout = value; }
        }

        /// <summary>
        /// Sets the DefaultTaskScheduleToStartTimeout property
        /// </summary>
        /// <param name="defaultTaskScheduleToStartTimeout">The value to set for the DefaultTaskScheduleToStartTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterActivityTypeRequest WithDefaultTaskScheduleToStartTimeout(string defaultTaskScheduleToStartTimeout)
        {
            this.defaultTaskScheduleToStartTimeout = defaultTaskScheduleToStartTimeout;
            return this;
        }
            

        // Check to see if DefaultTaskScheduleToStartTimeout property is set
        internal bool IsSetDefaultTaskScheduleToStartTimeout()
        {
            return this.defaultTaskScheduleToStartTimeout != null;
        }

        /// <summary>
        /// If set, specifies the default maximum duration for a task of this activity type. This default can be overridden when scheduling an activity
        /// task using the <c>ScheduleActivityTask</c> <a>Decision</a>. The valid values are integers greater than or equal to <c>0</c>. An integer
        /// value can be used to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultTaskScheduleToCloseTimeout
        {
            get { return this.defaultTaskScheduleToCloseTimeout; }
            set { this.defaultTaskScheduleToCloseTimeout = value; }
        }

        /// <summary>
        /// Sets the DefaultTaskScheduleToCloseTimeout property
        /// </summary>
        /// <param name="defaultTaskScheduleToCloseTimeout">The value to set for the DefaultTaskScheduleToCloseTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterActivityTypeRequest WithDefaultTaskScheduleToCloseTimeout(string defaultTaskScheduleToCloseTimeout)
        {
            this.defaultTaskScheduleToCloseTimeout = defaultTaskScheduleToCloseTimeout;
            return this;
        }
            

        // Check to see if DefaultTaskScheduleToCloseTimeout property is set
        internal bool IsSetDefaultTaskScheduleToCloseTimeout()
        {
            return this.defaultTaskScheduleToCloseTimeout != null;
        }
    }
}
    
