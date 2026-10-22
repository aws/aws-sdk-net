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

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateQualificationWithWorker operation. The
    /// <c>AssociateQualificationWithWorker</c> operation gives a Worker a Qualification.
    /// <c>AssociateQualificationWithWorker</c> does not require that the Worker submit a
    /// Qualification request. It gives the Qualification directly to the Worker. <para> You
    /// can only assign a Qualification of a Qualification type that you created (using the
    /// <c>CreateQualificationType</c> operation). </para> <note> <para> Note: <c>AssociateQualificationWithWorker</c>
    /// does not affect any pending Qualification requests for the Qualification by the Worker.
    /// If you assign a Qualification to a Worker, then later grant a Qualification request
    /// made by the Worker, the granting of the request may modify the Qualification score.
    /// To resolve a pending Qualification request without affecting the Qualification the
    /// Worker already has, reject the request with the <c>RejectQualificationRequest</c>
    /// operation. </para> </note>
    /// </summary>
    public partial class AssociateQualificationWithWorkerRequest : AmazonMTurkRequest
    {
        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// The value of the Qualification to assign.
        /// </para>
        /// </summary>
        public int? IntegerValue { get; set; }

        /// <summary>
        /// Checks to see if the IntegerValue property is set.
        /// </summary>
        internal bool IsSetIntegerValue() => this.IntegerValue.HasValue;

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        /// The ID of the Qualification type to use for the assigned Qualification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string QualificationTypeId { get; set; }

        /// <summary>
        /// Checks to see if the QualificationTypeId property is set.
        /// </summary>
        internal bool IsSetQualificationTypeId() => this.QualificationTypeId != null;

        /// <summary>
        /// Gets and sets the property SendNotification. 
        /// <para>
        ///  Specifies whether to send a notification email message to the Worker saying that
        /// the qualification was assigned to the Worker. Note: this is true by default. 
        /// </para>
        /// </summary>
        public bool? SendNotification { get; set; }

        /// <summary>
        /// Checks to see if the SendNotification property is set.
        /// </summary>
        internal bool IsSetSendNotification() => this.SendNotification.HasValue;

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        ///  The ID of the Worker to whom the Qualification is being assigned. Worker IDs are
        /// included with submitted HIT assignments and Qualification requests. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkerId property is set.
        /// </summary>
        internal bool IsSetWorkerId() => this.WorkerId != null;
    }
}
