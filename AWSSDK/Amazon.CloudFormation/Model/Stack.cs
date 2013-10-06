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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The Stack data type.</para>
    /// </summary>
    public class Stack
    {
        
        private string stackId;
        private string stackName;
        private string description;
        private List<Parameter> parameters = new List<Parameter>();
        private DateTime? creationTime;
        private DateTime? lastUpdatedTime;
        private string stackStatus;
        private string stackStatusReason;
        private bool? disableRollback;
        private List<string> notificationARNs = new List<string>();
        private int? timeoutInMinutes;
        private List<string> capabilities = new List<string>();
        private List<Output> outputs = new List<Output>();
        private List<Tag> tags = new List<Tag>();

        /// <summary>
        /// Unique identifier of the stack.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The name associated with the stack.
        ///  
        /// </summary>
        public string StackName
        {
            get { return this.stackName; }
            set { this.stackName = value; }
        }

        /// <summary>
        /// Sets the StackName property
        /// </summary>
        /// <param name="stackName">The value to set for the StackName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithStackName(string stackName)
        {
            this.stackName = stackName;
            return this;
        }
            

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this.stackName != null;
        }

        /// <summary>
        /// User defined description associated with the stack.
        ///  
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
        public Stack WithDescription(string description)
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
        /// A list of <c>Parameter</c> structures.
        ///  
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }
        /// <summary>
        /// Adds elements to the Parameters collection
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithParameters(params Parameter[] parameters)
        {
            foreach (Parameter element in parameters)
            {
                this.parameters.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Parameters collection
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithParameters(IEnumerable<Parameter> parameters)
        {
            foreach (Parameter element in parameters)
            {
                this.parameters.Add(element);
            }

            return this;
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;
        }

        /// <summary>
        /// Time at which the stack was created.
        ///  
        /// </summary>
        public DateTime CreationTime
        {
            get { return this.creationTime ?? default(DateTime); }
            set { this.creationTime = value; }
        }

        /// <summary>
        /// Sets the CreationTime property
        /// </summary>
        /// <param name="creationTime">The value to set for the CreationTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithCreationTime(DateTime creationTime)
        {
            this.creationTime = creationTime;
            return this;
        }
            

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this.creationTime.HasValue;
        }

        /// <summary>
        /// The time the stack was last updated. This field will only be returned if the stack has been updated at least once.
        ///  
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this.lastUpdatedTime ?? default(DateTime); }
            set { this.lastUpdatedTime = value; }
        }

        /// <summary>
        /// Sets the LastUpdatedTime property
        /// </summary>
        /// <param name="lastUpdatedTime">The value to set for the LastUpdatedTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithLastUpdatedTime(DateTime lastUpdatedTime)
        {
            this.lastUpdatedTime = lastUpdatedTime;
            return this;
        }
            

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this.lastUpdatedTime.HasValue;
        }

        /// <summary>
        /// Current status of the stack.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>CREATE_IN_PROGRESS, CREATE_FAILED, CREATE_COMPLETE, ROLLBACK_IN_PROGRESS, ROLLBACK_FAILED, ROLLBACK_COMPLETE, DELETE_IN_PROGRESS, DELETE_FAILED, DELETE_COMPLETE, UPDATE_IN_PROGRESS, UPDATE_COMPLETE_CLEANUP_IN_PROGRESS, UPDATE_COMPLETE, UPDATE_ROLLBACK_IN_PROGRESS, UPDATE_ROLLBACK_FAILED, UPDATE_ROLLBACK_COMPLETE_CLEANUP_IN_PROGRESS, UPDATE_ROLLBACK_COMPLETE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StackStatus
        {
            get { return this.stackStatus; }
            set { this.stackStatus = value; }
        }

        /// <summary>
        /// Sets the StackStatus property
        /// </summary>
        /// <param name="stackStatus">The value to set for the StackStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithStackStatus(string stackStatus)
        {
            this.stackStatus = stackStatus;
            return this;
        }
            

        // Check to see if StackStatus property is set
        internal bool IsSetStackStatus()
        {
            return this.stackStatus != null;
        }

        /// <summary>
        /// Success/failure message associated with the stack status.
        ///  
        /// </summary>
        public string StackStatusReason
        {
            get { return this.stackStatusReason; }
            set { this.stackStatusReason = value; }
        }

        /// <summary>
        /// Sets the StackStatusReason property
        /// </summary>
        /// <param name="stackStatusReason">The value to set for the StackStatusReason property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithStackStatusReason(string stackStatusReason)
        {
            this.stackStatusReason = stackStatusReason;
            return this;
        }
            

        // Check to see if StackStatusReason property is set
        internal bool IsSetStackStatusReason()
        {
            return this.stackStatusReason != null;
        }

        /// <summary>
        /// Boolean to enable or disable rollback on stack creation failures: <ul> <li><c>true</c>: disable rollback</li> <li><c>false</c>: enable
        /// rollback</li> </ul>
        ///  
        /// </summary>
        public bool DisableRollback
        {
            get { return this.disableRollback ?? default(bool); }
            set { this.disableRollback = value; }
        }

        /// <summary>
        /// Sets the DisableRollback property
        /// </summary>
        /// <param name="disableRollback">The value to set for the DisableRollback property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithDisableRollback(bool disableRollback)
        {
            this.disableRollback = disableRollback;
            return this;
        }
            

        // Check to see if DisableRollback property is set
        internal bool IsSetDisableRollback()
        {
            return this.disableRollback.HasValue;
        }

        /// <summary>
        /// SNS topic ARNs to which stack related events are published.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 5</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> NotificationARNs
        {
            get { return this.notificationARNs; }
            set { this.notificationARNs = value; }
        }
        /// <summary>
        /// Adds elements to the NotificationARNs collection
        /// </summary>
        /// <param name="notificationARNs">The values to add to the NotificationARNs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithNotificationARNs(params string[] notificationARNs)
        {
            foreach (string element in notificationARNs)
            {
                this.notificationARNs.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the NotificationARNs collection
        /// </summary>
        /// <param name="notificationARNs">The values to add to the NotificationARNs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithNotificationARNs(IEnumerable<string> notificationARNs)
        {
            foreach (string element in notificationARNs)
            {
                this.notificationARNs.Add(element);
            }

            return this;
        }

        // Check to see if NotificationARNs property is set
        internal bool IsSetNotificationARNs()
        {
            return this.notificationARNs.Count > 0;
        }

        /// <summary>
        /// The amount of time within which stack creation should complete.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int TimeoutInMinutes
        {
            get { return this.timeoutInMinutes ?? default(int); }
            set { this.timeoutInMinutes = value; }
        }

        /// <summary>
        /// Sets the TimeoutInMinutes property
        /// </summary>
        /// <param name="timeoutInMinutes">The value to set for the TimeoutInMinutes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithTimeoutInMinutes(int timeoutInMinutes)
        {
            this.timeoutInMinutes = timeoutInMinutes;
            return this;
        }
            

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this.timeoutInMinutes.HasValue;
        }

        /// <summary>
        /// The capabilities allowed in the stack.
        ///  
        /// </summary>
        public List<string> Capabilities
        {
            get { return this.capabilities; }
            set { this.capabilities = value; }
        }
        /// <summary>
        /// Adds elements to the Capabilities collection
        /// </summary>
        /// <param name="capabilities">The values to add to the Capabilities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithCapabilities(params string[] capabilities)
        {
            foreach (string element in capabilities)
            {
                this.capabilities.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Capabilities collection
        /// </summary>
        /// <param name="capabilities">The values to add to the Capabilities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithCapabilities(IEnumerable<string> capabilities)
        {
            foreach (string element in capabilities)
            {
                this.capabilities.Add(element);
            }

            return this;
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this.capabilities.Count > 0;
        }

        /// <summary>
        /// A list of output structures.
        ///  
        /// </summary>
        public List<Output> Outputs
        {
            get { return this.outputs; }
            set { this.outputs = value; }
        }
        /// <summary>
        /// Adds elements to the Outputs collection
        /// </summary>
        /// <param name="outputs">The values to add to the Outputs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithOutputs(params Output[] outputs)
        {
            foreach (Output element in outputs)
            {
                this.outputs.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Outputs collection
        /// </summary>
        /// <param name="outputs">The values to add to the Outputs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithOutputs(IEnumerable<Output> outputs)
        {
            foreach (Output element in outputs)
            {
                this.outputs.Add(element);
            }

            return this;
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this.outputs.Count > 0;
        }

        /// <summary>
        /// A list of <c>Tag</c>s that specify cost allocation information for the stack.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }
        /// <summary>
        /// Adds elements to the Tags collection
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithTags(params Tag[] tags)
        {
            foreach (Tag element in tags)
            {
                this.tags.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Tags collection
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithTags(IEnumerable<Tag> tags)
        {
            foreach (Tag element in tags)
            {
                this.tags.Add(element);
            }

            return this;
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
