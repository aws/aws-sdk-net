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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
    /// A comment that's posted by a user on a control. This includes the author's name,
    /// the comment text, and a timestamp.
    /// </summary>
    public partial class ControlComment
    {
        private string _authorName;
        private string _commentBody;
        private DateTime? _postedDate;

        /// <summary>
        /// Gets and sets the property AuthorName. 
        /// <para>
        ///  The name of the user who authored the comment. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string AuthorName
        {
            get { return this._authorName; }
            set { this._authorName = value; }
        }

        // Check to see if AuthorName property is set
        internal bool IsSetAuthorName()
        {
            return this._authorName != null;
        }

        /// <summary>
        /// Gets and sets the property CommentBody. 
        /// <para>
        ///  The body text of a control comment. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=500)]
        public string CommentBody
        {
            get { return this._commentBody; }
            set { this._commentBody = value; }
        }

        // Check to see if CommentBody property is set
        internal bool IsSetCommentBody()
        {
            return this._commentBody != null;
        }

        /// <summary>
        /// Gets and sets the property PostedDate. 
        /// <para>
        ///  The time when the comment was posted. 
        /// </para>
        /// </summary>
        public DateTime? PostedDate
        {
            get { return this._postedDate; }
            set { this._postedDate = value; }
        }

        // Check to see if PostedDate property is set
        internal bool IsSetPostedDate()
        {
            return this._postedDate.HasValue; 
        }

    }
}