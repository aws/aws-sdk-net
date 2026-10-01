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

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Details about the investigation related to a potential security event identified by
    /// Detective.
    /// </summary>
    public partial class InvestigationDetail
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time stamp of the creation time of the investigation report. The value is an UTC
        /// ISO8601 formatted string. For example, <c>2021-08-18T16:35:56.284Z</c>.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the IAM user and IAM role.
        /// </para>
        /// </summary>
        public string EntityArn { get; set; }

        /// <summary>
        /// Checks to see if the EntityArn property is set.
        /// </summary>
        internal bool IsSetEntityArn() => this.EntityArn != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// Type of entity. For example, Amazon Web Services accounts, such as IAM user and role.
        /// </para>
        /// </summary>
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property InvestigationId. 
        /// <para>
        /// The investigation ID of the investigation report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string InvestigationId { get; set; }

        /// <summary>
        /// Checks to see if the InvestigationId property is set.
        /// </summary>
        internal bool IsSetInvestigationId() => this.InvestigationId != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// Severity based on the likelihood and impact of the indicators of compromise discovered
        /// in the investigation.
        /// </para>
        /// </summary>
        public Severity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the investigation. An archived investigation indicates you have
        /// completed reviewing the investigation.
        /// </para>
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status based on the completion status of the investigation.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
