/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Includes information about the specified association execution.
    /// </summary>
    public partial class AssociationExecutionTarget
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property AssociationVersion. 
        /// <para>
        /// The association version.
        /// </para>
        /// </summary>
        public string AssociationVersion { get; set; }

        /// <summary>
        /// Checks to see if the AssociationVersion property is set.
        /// </summary>
        internal bool IsSetAssociationVersion() => this.AssociationVersion != null;

        /// <summary>
        /// Gets and sets the property DetailedStatus. 
        /// <para>
        /// Detailed information about the execution status.
        /// </para>
        /// </summary>
        public string DetailedStatus { get; set; }

        /// <summary>
        /// Checks to see if the DetailedStatus property is set.
        /// </summary>
        internal bool IsSetDetailedStatus() => this.DetailedStatus != null;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The execution ID.
        /// </para>
        /// </summary>
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property LastExecutionDate. 
        /// <para>
        /// The date of the last execution.
        /// </para>
        /// </summary>
        public DateTime? LastExecutionDate { get; set; }

        /// <summary>
        /// Checks to see if the LastExecutionDate property is set.
        /// </summary>
        internal bool IsSetLastExecutionDate() => this.LastExecutionDate.HasValue;

        /// <summary>
        /// Gets and sets the property OutputSource. 
        /// <para>
        /// The location where the association details are saved.
        /// </para>
        /// </summary>
        public OutputSource OutputSource { get; set; }

        /// <summary>
        /// Checks to see if the OutputSource property is set.
        /// </summary>
        internal bool IsSetOutputSource() => this.OutputSource != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID, for example, the managed node ID where the association ran.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type, for example, EC2.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The association execution status.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
