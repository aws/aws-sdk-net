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
    /// <para>The StackResource data type.</para>
    /// </summary>
    public class StackResource
    {
        
        private string stackName;
        private string stackId;
        private string logicalResourceId;
        private string physicalResourceId;
        private string resourceType;
        private DateTime? timestamp;
        private string resourceStatus;
        private string resourceStatusReason;
        private string description;

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
        public StackResource WithStackName(string stackName)
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
        public StackResource WithStackId(string stackId)
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
        /// The logical name of the resource specified in the template.
        ///  
        /// </summary>
        public string LogicalResourceId
        {
            get { return this.logicalResourceId; }
            set { this.logicalResourceId = value; }
        }

        /// <summary>
        /// Sets the LogicalResourceId property
        /// </summary>
        /// <param name="logicalResourceId">The value to set for the LogicalResourceId property </param>
        /// <returns>this instance</returns>
        public StackResource WithLogicalResourceId(string logicalResourceId)
        {
            this.logicalResourceId = logicalResourceId;
            return this;
        }
            

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this.logicalResourceId != null;
        }

        /// <summary>
        /// The name or unique identifier that corresponds to a physical instance ID of a resource supported by AWS CloudFormation.
        ///  
        /// </summary>
        public string PhysicalResourceId
        {
            get { return this.physicalResourceId; }
            set { this.physicalResourceId = value; }
        }

        /// <summary>
        /// Sets the PhysicalResourceId property
        /// </summary>
        /// <param name="physicalResourceId">The value to set for the PhysicalResourceId property </param>
        /// <returns>this instance</returns>
        public StackResource WithPhysicalResourceId(string physicalResourceId)
        {
            this.physicalResourceId = physicalResourceId;
            return this;
        }
            

        // Check to see if PhysicalResourceId property is set
        internal bool IsSetPhysicalResourceId()
        {
            return this.physicalResourceId != null;
        }

        /// <summary>
        /// Type of the resource. (For more information, go to the <a href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/UserGuide">AWS
        /// CloudFormation User Guide</a>.)
        ///  
        /// </summary>
        public string ResourceType
        {
            get { return this.resourceType; }
            set { this.resourceType = value; }
        }

        /// <summary>
        /// Sets the ResourceType property
        /// </summary>
        /// <param name="resourceType">The value to set for the ResourceType property </param>
        /// <returns>this instance</returns>
        public StackResource WithResourceType(string resourceType)
        {
            this.resourceType = resourceType;
            return this;
        }
            

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this.resourceType != null;
        }

        /// <summary>
        /// Time the status was updated.
        ///  
        /// </summary>
        public DateTime Timestamp
        {
            get { return this.timestamp ?? default(DateTime); }
            set { this.timestamp = value; }
        }

        /// <summary>
        /// Sets the Timestamp property
        /// </summary>
        /// <param name="timestamp">The value to set for the Timestamp property </param>
        /// <returns>this instance</returns>
        public StackResource WithTimestamp(DateTime timestamp)
        {
            this.timestamp = timestamp;
            return this;
        }
            

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this.timestamp.HasValue;
        }

        /// <summary>
        /// Current status of the resource.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>CREATE_IN_PROGRESS, CREATE_FAILED, CREATE_COMPLETE, DELETE_IN_PROGRESS, DELETE_FAILED, DELETE_COMPLETE, UPDATE_IN_PROGRESS, UPDATE_FAILED, UPDATE_COMPLETE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ResourceStatus
        {
            get { return this.resourceStatus; }
            set { this.resourceStatus = value; }
        }

        /// <summary>
        /// Sets the ResourceStatus property
        /// </summary>
        /// <param name="resourceStatus">The value to set for the ResourceStatus property </param>
        /// <returns>this instance</returns>
        public StackResource WithResourceStatus(string resourceStatus)
        {
            this.resourceStatus = resourceStatus;
            return this;
        }
            

        // Check to see if ResourceStatus property is set
        internal bool IsSetResourceStatus()
        {
            return this.resourceStatus != null;
        }

        /// <summary>
        /// Success/failure message associated with the resource.
        ///  
        /// </summary>
        public string ResourceStatusReason
        {
            get { return this.resourceStatusReason; }
            set { this.resourceStatusReason = value; }
        }

        /// <summary>
        /// Sets the ResourceStatusReason property
        /// </summary>
        /// <param name="resourceStatusReason">The value to set for the ResourceStatusReason property </param>
        /// <returns>this instance</returns>
        public StackResource WithResourceStatusReason(string resourceStatusReason)
        {
            this.resourceStatusReason = resourceStatusReason;
            return this;
        }
            

        // Check to see if ResourceStatusReason property is set
        internal bool IsSetResourceStatusReason()
        {
            return this.resourceStatusReason != null;
        }

        /// <summary>
        /// User defined description associated with the resource.
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
        public StackResource WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
    }
}
