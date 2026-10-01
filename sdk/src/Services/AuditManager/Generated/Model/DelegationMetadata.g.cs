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
    /// The metadata that's associated with the delegation.
    /// </summary>
    public partial class DelegationMetadata
    {
        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The unique identifier for the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AssessmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentId property is set.
        /// </summary>
        internal bool IsSetAssessmentId() => this.AssessmentId != null;

        /// <summary>
        /// Gets and sets the property AssessmentName. 
        /// <para>
        ///  The name of the associated assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 300)]
        public string AssessmentName { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentName property is set.
        /// </summary>
        internal bool IsSetAssessmentName() => this.AssessmentName != null;

        /// <summary>
        /// Gets and sets the property ControlSetName. 
        /// <para>
        ///  Specifies the name of the control set that was delegated for review. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ControlSetName { get; set; }

        /// <summary>
        /// Checks to see if the ControlSetName property is set.
        /// </summary>
        internal bool IsSetControlSetName() => this.ControlSetName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  Specifies when the delegation was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the delegation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the delegation. 
        /// </para>
        /// </summary>
        public DelegationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
