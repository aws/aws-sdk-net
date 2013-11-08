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
        private ResourceStatus resourceStatus;
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

        // Check to see if PhysicalResourceId property is set
        internal bool IsSetPhysicalResourceId()
        {
            return this.physicalResourceId != null;
        }

        /// <summary>
        /// Type of the resource. (For more information, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS
        /// CloudFormation User Guide</a>.)
        ///  
        /// </summary>
        public string ResourceType
        {
            get { return this.resourceType; }
            set { this.resourceType = value; }
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
        public ResourceStatus ResourceStatus
        {
            get { return this.resourceStatus; }
            set { this.resourceStatus = value; }
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

        // Check to see if ResourceStatusReason property is set
        internal bool IsSetResourceStatusReason()
        {
            return this.resourceStatusReason != null;
        }
    }
}
