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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Represents a share request for a custom framework in Audit Manager.
    /// </summary>
    public partial class AssessmentFrameworkShareRequest
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        ///  An optional comment from the sender about the share request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The compliance type that the shared custom framework supports, such as CIS or HIPAA.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceType property is set.
        /// </summary>
        internal bool IsSetComplianceType() => this.ComplianceType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time when the share request was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomControlsCount. 
        /// <para>
        /// The number of custom controls that are part of the shared custom framework.
        /// </para>
        /// </summary>
        public int? CustomControlsCount { get; set; }

        /// <summary>
        /// Checks to see if the CustomControlsCount property is set.
        /// </summary>
        internal bool IsSetCustomControlsCount() => this.CustomControlsCount.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationAccount. 
        /// <para>
        ///  The Amazon Web Services account of the recipient. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DestinationAccount { get; set; }

        /// <summary>
        /// Checks to see if the DestinationAccount property is set.
        /// </summary>
        internal bool IsSetDestinationAccount() => this.DestinationAccount != null;

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        ///  The Amazon Web Services Region of the recipient. 
        /// </para>
        /// </summary>
        public string DestinationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRegion property is set.
        /// </summary>
        internal bool IsSetDestinationRegion() => this.DestinationRegion != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        ///  The time when the share request expires. 
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FrameworkDescription. 
        /// <para>
        /// The description of the shared custom framework.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string FrameworkDescription { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkDescription property is set.
        /// </summary>
        internal bool IsSetFrameworkDescription() => this.FrameworkDescription != null;

        /// <summary>
        /// Gets and sets the property FrameworkId. 
        /// <para>
        /// The unique identifier for the shared custom framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string FrameworkId { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkId property is set.
        /// </summary>
        internal bool IsSetFrameworkId() => this.FrameworkId != null;

        /// <summary>
        /// Gets and sets the property FrameworkName. 
        /// <para>
        ///  The name of the custom framework that the share request is for. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string FrameworkName { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkName property is set.
        /// </summary>
        internal bool IsSetFrameworkName() => this.FrameworkName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the share request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        ///  Specifies when the share request was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property SourceAccount. 
        /// <para>
        ///  The Amazon Web Services account of the sender. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string SourceAccount { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccount property is set.
        /// </summary>
        internal bool IsSetSourceAccount() => this.SourceAccount != null;

        /// <summary>
        /// Gets and sets the property StandardControlsCount. 
        /// <para>
        /// The number of standard controls that are part of the shared custom framework. 
        /// </para>
        /// </summary>
        public int? StandardControlsCount { get; set; }

        /// <summary>
        /// Checks to see if the StandardControlsCount property is set.
        /// </summary>
        internal bool IsSetStandardControlsCount() => this.StandardControlsCount.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the share request. 
        /// </para>
        /// </summary>
        public ShareRequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
