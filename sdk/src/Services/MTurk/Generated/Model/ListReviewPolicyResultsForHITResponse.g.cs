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
    /// This is the response object from the ListReviewPolicyResultsForHIT operation.
    /// </summary>
    public partial class ListReviewPolicyResultsForHITResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssignmentReviewPolicy. 
        /// <para>
        ///  The name of the Assignment-level Review Policy. This contains only the PolicyName
        /// element. 
        /// </para>
        /// </summary>
        public ReviewPolicy AssignmentReviewPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentReviewPolicy property is set.
        /// </summary>
        internal bool IsSetAssignmentReviewPolicy() => this.AssignmentReviewPolicy != null;

        /// <summary>
        /// Gets and sets the property AssignmentReviewReport. 
        /// <para>
        ///  Contains both ReviewResult and ReviewAction elements for an Assignment. 
        /// </para>
        /// </summary>
        public ReviewReport AssignmentReviewReport { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentReviewReport property is set.
        /// </summary>
        internal bool IsSetAssignmentReviewReport() => this.AssignmentReviewReport != null;

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        /// The HITId of the HIT for which results have been returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string HITId { get; set; }

        /// <summary>
        /// Checks to see if the HITId property is set.
        /// </summary>
        internal bool IsSetHITId() => this.HITId != null;

        /// <summary>
        /// Gets and sets the property HITReviewPolicy. 
        /// <para>
        /// The name of the HIT-level Review Policy. This contains only the PolicyName element.
        /// </para>
        /// </summary>
        public ReviewPolicy HITReviewPolicy { get; set; }

        /// <summary>
        /// Checks to see if the HITReviewPolicy property is set.
        /// </summary>
        internal bool IsSetHITReviewPolicy() => this.HITReviewPolicy != null;

        /// <summary>
        /// Gets and sets the property HITReviewReport. 
        /// <para>
        /// Contains both ReviewResult and ReviewAction elements for a particular HIT. 
        /// </para>
        /// </summary>
        public ReviewReport HITReviewReport { get; set; }

        /// <summary>
        /// Checks to see if the HITReviewReport property is set.
        /// </summary>
        internal bool IsSetHITReviewReport() => this.HITReviewReport != null;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
