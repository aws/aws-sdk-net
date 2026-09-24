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
    /// The notification that informs a user of an update in Audit Manager. For example,
    /// this includes the notification that's sent when a control set is delegated for review.
    /// </summary>
    public partial class Notification
    {
        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The identifier for the assessment. 
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
        ///  The name of the related assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 300)]
        public string AssessmentName { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentName property is set.
        /// </summary>
        internal bool IsSetAssessmentName() => this.AssessmentName != null;

        /// <summary>
        /// Gets and sets the property ControlSetId. 
        /// <para>
        ///  The identifier for the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string ControlSetId { get; set; }

        /// <summary>
        /// Checks to see if the ControlSetId property is set.
        /// </summary>
        internal bool IsSetControlSetId() => this.ControlSetId != null;

        /// <summary>
        /// Gets and sets the property ControlSetName. 
        /// <para>
        ///  Specifies the name of the control set that the notification is about. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ControlSetName { get; set; }

        /// <summary>
        /// Checks to see if the ControlSetName property is set.
        /// </summary>
        internal bool IsSetControlSetName() => this.ControlSetName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the notification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        ///  The time when the notification was sent. 
        /// </para>
        /// </summary>
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// Checks to see if the EventTime property is set.
        /// </summary>
        internal bool IsSetEventTime() => this.EventTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the notification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 47, Max = 50)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        ///  The sender of the notification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
