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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
        private DateTime? _reviewedTime;
        private string _reviewer;
        private ReviewStatus _status;

        /// <summary>
        /// Gets and sets the property ReviewedTime. 
        /// <para>
        /// The time that the reviewer took action on the document review request.
        /// </para>
        /// </summary>
        public DateTime? ReviewedTime
        {
            get { return this._reviewedTime; }
            set { this._reviewedTime = value; }
        }

        // Check to see if ReviewedTime property is set
        internal bool IsSetReviewedTime()
        {
            return this._reviewedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Reviewer. 
        /// <para>
        /// The reviewer assigned to take action on the document review request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string Reviewer
        {
            get { return this._reviewer; }
            set { this._reviewer = value; }
        }

        // Check to see if Reviewer property is set
        internal bool IsSetReviewer()
        {
            return this._reviewer != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the document review request.
        /// </para>
        /// </summary>
        public ReviewStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}