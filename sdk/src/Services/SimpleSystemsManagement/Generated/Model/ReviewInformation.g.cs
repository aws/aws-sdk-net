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
    /// Information about the result of a document review request.
    /// </summary>
    public partial class ReviewInformation
    {
        /// <summary>
        /// Gets and sets the property ReviewedTime. 
        /// <para>
        /// The time that the reviewer took action on the document review request.
        /// </para>
        /// </summary>
        public DateTime? ReviewedTime { get; set; }

        /// <summary>
        /// Checks to see if the ReviewedTime property is set.
        /// </summary>
        internal bool IsSetReviewedTime() => this.ReviewedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Reviewer. 
        /// <para>
        /// The reviewer assigned to take action on the document review request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string Reviewer { get; set; }

        /// <summary>
        /// Checks to see if the Reviewer property is set.
        /// </summary>
        internal bool IsSetReviewer() => this.Reviewer != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the document review request.
        /// </para>
        /// </summary>
        public ReviewStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
