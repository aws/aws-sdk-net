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
    /// <para>Contains high-level information about the specified stack resource.</para>
    /// </summary>
    public class StackResourceSummary
    {
        
        private string logicalResourceId;
        private string physicalResourceId;
        private string resourceType;
        private DateTime? lastUpdatedTimestamp;
        private string resourceStatus;
        private string resourceStatusReason;

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
        public StackResourceSummary WithLogicalResourceId(string logicalResourceId)
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
        /// The name or unique identifier that corresponds to a physical instance ID of the resource.
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
        public StackResourceSummary WithPhysicalResourceId(string physicalResourceId)
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
        public StackResourceSummary WithResourceType(string resourceType)
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
        public DateTime LastUpdatedTimestamp
        {
            get { return this.lastUpdatedTimestamp ?? default(DateTime); }
            set { this.lastUpdatedTimestamp = value; }
        }

        /// <summary>
        /// Sets the LastUpdatedTimestamp property
        /// </summary>
        /// <param name="lastUpdatedTimestamp">The value to set for the LastUpdatedTimestamp property </param>
        /// <returns>this instance</returns>
        public StackResourceSummary WithLastUpdatedTimestamp(DateTime lastUpdatedTimestamp)
        {
            this.lastUpdatedTimestamp = lastUpdatedTimestamp;
            return this;
        }
            

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this.lastUpdatedTimestamp.HasValue;
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
        public StackResourceSummary WithResourceStatus(string resourceStatus)
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
        public StackResourceSummary WithResourceStatusReason(string resourceStatusReason)
        {
            this.resourceStatusReason = resourceStatusReason;
            return this;
        }
            

        // Check to see if ResourceStatusReason property is set
        internal bool IsSetResourceStatusReason()
        {
            return this.resourceStatusReason != null;
        }
    }
}
