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
    /// Container for the parameters to the GetFileUploadURL operation.
    /// The <c>GetFileUploadURL</c> operation generates and returns a temporary URL. You
    /// use the temporary URL to retrieve a file uploaded by a Worker as an answer to a FileUploadAnswer
    /// question for a HIT. The temporary URL is generated the instant the GetFileUploadURL
    /// operation is called, and is valid for 60 seconds. You can get a temporary file upload
    /// URL any time until the HIT is disposed. After the HIT is disposed, any uploaded files
    /// are deleted, and cannot be retrieved. Pending Deprecation on December 12, 2017. The
    /// Answer Specification structure will no longer support the <c>FileUploadAnswer</c>
    /// element to be used for the QuestionForm data structure. Instead, we recommend that
    /// Requesters who want to create HITs asking Workers to upload files to use Amazon S3.
    /// </summary>
    public partial class GetFileUploadURLRequest : AmazonMTurkRequest
    {
        private string _assignmentId;
        private string _questionIdentifier;

        /// <summary>
        /// Gets and sets the property AssignmentId. 
        /// <para>
        /// The ID of the assignment that contains the question with a FileUploadAnswer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AssignmentId
        {
            get { return this._assignmentId; }
            set { this._assignmentId = value; }
        }

        // Check to see if AssignmentId property is set
        internal bool IsSetAssignmentId()
        {
            return this._assignmentId != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionIdentifier. 
        /// <para>
        /// The identifier of the question with a FileUploadAnswer, as specified in the QuestionForm
        /// of the HIT.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QuestionIdentifier
        {
            get { return this._questionIdentifier; }
            set { this._questionIdentifier = value; }
        }

        // Check to see if QuestionIdentifier property is set
        internal bool IsSetQuestionIdentifier()
        {
            return this._questionIdentifier != null;
        }

    }
}