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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// The response collected for a Amazon Q App session. This container represents a single
    /// response to a Q App session.
    /// </summary>
    public partial class QAppSessionData
    {
        private string _cardId;
        private string _submissionId;
        private DateTime? _timestamp;
        private User _user;
        private Amazon.Runtime.Documents.Document _value;

        /// <summary>
        /// Gets and sets the property CardId. 
        /// <para>
        /// The card Id associated with the response submitted for a Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CardId
        {
            get { return this._cardId; }
            set { this._cardId = value; }
        }

        // Check to see if CardId property is set
        internal bool IsSetCardId()
        {
            return this._cardId != null;
        }

        /// <summary>
        /// Gets and sets the property SubmissionId. 
        /// <para>
        /// The unique identifier of the submission.
        /// </para>
        /// </summary>
        public string SubmissionId
        {
            get { return this._submissionId; }
            set { this._submissionId = value; }
        }

        // Check to see if SubmissionId property is set
        internal bool IsSetSubmissionId()
        {
            return this._submissionId != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time when the session data is submitted.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user who submitted the response for a Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public User User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The response submitted for a Q App session.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return !this._value.IsNull();
        }

    }
}