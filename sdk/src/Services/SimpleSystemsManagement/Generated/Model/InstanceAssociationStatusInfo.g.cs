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
    /// Status information about the association.
    /// </summary>
    public partial class InstanceAssociationStatusInfo
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
        /// Gets and sets the property AssociationName. 
        /// <para>
        /// The name of the association applied to the managed node.
        /// </para>
        /// </summary>
        public string AssociationName { get; set; }

        /// <summary>
        /// Checks to see if the AssociationName property is set.
        /// </summary>
        internal bool IsSetAssociationName() => this.AssociationName != null;

        /// <summary>
        /// Gets and sets the property AssociationVersion. 
        /// <para>
        /// The version of the association applied to the managed node.
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
        /// Detailed status information about the association.
        /// </para>
        /// </summary>
        public string DetailedStatus { get; set; }

        /// <summary>
        /// Checks to see if the DetailedStatus property is set.
        /// </summary>
        internal bool IsSetDetailedStatus() => this.DetailedStatus != null;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The association document versions.
        /// </para>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error code returned by the request to create the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ExecutionDate. 
        /// <para>
        /// The date the association ran. 
        /// </para>
        /// </summary>
        public DateTime? ExecutionDate { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionDate property is set.
        /// </summary>
        internal bool IsSetExecutionDate() => this.ExecutionDate.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionSummary. 
        /// <para>
        /// Summary information about association execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ExecutionSummary { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionSummary property is set.
        /// </summary>
        internal bool IsSetExecutionSummary() => this.ExecutionSummary != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The managed node ID where the association was created.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the association.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputUrl. 
        /// <para>
        /// A URL for an S3 bucket where you want to store the results of this request.
        /// </para>
        /// </summary>
        public InstanceAssociationOutputUrl OutputUrl { get; set; }

        /// <summary>
        /// Checks to see if the OutputUrl property is set.
        /// </summary>
        internal bool IsSetOutputUrl() => this.OutputUrl != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status information about the association.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
