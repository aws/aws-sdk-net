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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCaseComment operation. Updates an existing
    /// case comment.
    /// </summary>
    public partial class UpdateCaseCommentRequest : AmazonSecurityIRRequest
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// Required element for UpdateCaseComment to identify the content for the comment to
        /// be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 12000)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// Required element for UpdateCaseComment to identify the case ID containing the comment
        /// to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 32)]
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// Required element for UpdateCaseComment to identify the case ID to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 6)]
        public string CommentId { get; set; }

        /// <summary>
        /// Checks to see if the CommentId property is set.
        /// </summary>
        internal bool IsSetCommentId() => this.CommentId != null;
    }
}
