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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
    /// This is the response object from the CreateCaseComment operation.
    /// </summary>
    public partial class CreateCaseCommentResponse : AmazonWebServiceResponse
    {
        private string _commentId;

        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// Response element indicating the new comment ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=6)]
        public string CommentId
        {
            get { return this._commentId; }
            set { this._commentId = value; }
        }

        // Check to see if CommentId property is set
        internal bool IsSetCommentId()
        {
            return this._commentId != null;
        }

    }
}