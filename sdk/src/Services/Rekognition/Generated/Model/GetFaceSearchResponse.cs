/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the GetFaceSearch operation.
    /// </summary>
    public partial class GetFaceSearchResponse : AmazonWebServiceResponse
    {
        private int? _billableDurationSeconds;
        private string _errorCode;
        private VideoJobStatus _jobStatus;
        private string _nextToken;
        private List<PersonMatch> _persons = new List<PersonMatch>();
        private string _statusMessage;
        private VideoMetadata _videoMetadata;
        private List<Warning> _warnings = new List<Warning>();

        /// <summary>
        /// Gets and sets the property BillableDurationSeconds.
        /// </summary>
        public int BillableDurationSeconds
        {
            get { return this._billableDurationSeconds.GetValueOrDefault(); }
            set { this._billableDurationSeconds = value; }
        }

        // Check to see if BillableDurationSeconds property is set
        internal bool IsSetBillableDurationSeconds()
        {
            return this._billableDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode.
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the face search job.
        /// </para>
        /// </summary>
        public VideoJobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Rekognition Video returns this token that you
        /// can use in the subsequent request to retrieve the next set of search results. 
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Persons. 
        /// <para>
        /// An array of persons, , in the video whose face(s) match the face(s) in an Amazon Rekognition
        /// collection. It also includes time information for when persons are matched in the
        /// video. You specify the input collection in an initial call to <code>StartFaceSearch</code>.
        /// Each <code>Persons</code> element includes a time the person was matched, face match
        /// details (<code>FaceMatches</code>) for matching faces in the collection, and person
        /// information (<code>Person</code>) for the matched person. 
        /// </para>
        /// </summary>
        public List<PersonMatch> Persons
        {
            get { return this._persons; }
            set { this._persons = value; }
        }

        // Check to see if Persons property is set
        internal bool IsSetPersons()
        {
            return this._persons != null && this._persons.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// If the job fails, <code>StatusMessage</code> provides a descriptive error message.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property VideoMetadata. 
        /// <para>
        /// Information about a video that Amazon Rekognition analyzed. <code>Videometadata</code>
        /// is returned in every page of paginated responses from a Amazon Rekognition Video operation.
        /// 
        /// </para>
        /// </summary>
        public VideoMetadata VideoMetadata
        {
            get { return this._videoMetadata; }
            set { this._videoMetadata = value; }
        }

        // Check to see if VideoMetadata property is set
        internal bool IsSetVideoMetadata()
        {
            return this._videoMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings.
        /// </summary>
        public List<Warning> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && this._warnings.Count > 0; 
        }

    }
}