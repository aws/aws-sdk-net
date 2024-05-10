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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
    /// This is the response object from the ListReviewPolicyResultsForHIT operation.
    /// </summary>
    public partial class ListReviewPolicyResultsForHITResponse : AmazonWebServiceResponse
    {
        private ReviewPolicy _assignmentReviewPolicy;
        private ReviewReport _assignmentReviewReport;
        private string _hitId;
        private ReviewPolicy _hitReviewPolicy;
        private ReviewReport _hitReviewReport;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssignmentReviewPolicy. 
        /// <para>
        ///  The name of the Assignment-level Review Policy. This contains only the PolicyName
        /// element. 
        /// </para>
        /// </summary>
        public ReviewPolicy AssignmentReviewPolicy
        {
            get { return this._assignmentReviewPolicy; }
            set { this._assignmentReviewPolicy = value; }
        }

        // Check to see if AssignmentReviewPolicy property is set
        internal bool IsSetAssignmentReviewPolicy()
        {
            return this._assignmentReviewPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AssignmentReviewReport. 
        /// <para>
        ///  Contains both ReviewResult and ReviewAction elements for an Assignment. 
        /// </para>
        /// </summary>
        public ReviewReport AssignmentReviewReport
        {
            get { return this._assignmentReviewReport; }
            set { this._assignmentReviewReport = value; }
        }

        // Check to see if AssignmentReviewReport property is set
        internal bool IsSetAssignmentReviewReport()
        {
            return this._assignmentReviewReport != null;
        }

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        /// The HITId of the HIT for which results have been returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string HITId
        {
            get { return this._hitId; }
            set { this._hitId = value; }
        }

        // Check to see if HITId property is set
        internal bool IsSetHITId()
        {
            return this._hitId != null;
        }

        /// <summary>
        /// Gets and sets the property HITReviewPolicy. 
        /// <para>
        /// The name of the HIT-level Review Policy. This contains only the PolicyName element.
        /// </para>
        /// </summary>
        public ReviewPolicy HITReviewPolicy
        {
            get { return this._hitReviewPolicy; }
            set { this._hitReviewPolicy = value; }
        }

        // Check to see if HITReviewPolicy property is set
        internal bool IsSetHITReviewPolicy()
        {
            return this._hitReviewPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property HITReviewReport. 
        /// <para>
        /// Contains both ReviewResult and ReviewAction elements for a particular HIT. 
        /// </para>
        /// </summary>
        public ReviewReport HITReviewReport
        {
            get { return this._hitReviewReport; }
            set { this._hitReviewReport = value; }
        }

        // Check to see if HITReviewReport property is set
        internal bool IsSetHITReviewReport()
        {
            return this._hitReviewReport != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}