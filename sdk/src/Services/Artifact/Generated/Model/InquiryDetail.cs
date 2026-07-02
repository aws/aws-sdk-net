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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
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
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Detailed information about a compliance inquiry.
    /// </summary>
    public partial class InquiryDetail
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _id;
        private InputSource _inputSource;
        private string _name;
        private InquiryStatus _status;
        private InquiryStatusMessage _statusMessage;
        private InquirySupportMode _supportMode;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the compliance inquiry resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp indicating when the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique resource ID for the compliance inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InputSource. 
        /// <para>
        /// Type of inquiry content (text or file).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputSource InputSource
        {
            get { return this._inputSource; }
            set { this._inputSource = value; }
        }

        // Check to see if InputSource property is set
        internal bool IsSetInputSource()
        {
            return this._inputSource != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Title of the inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current processing status of the inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InquiryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Status message providing additional context.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InquiryStatusMessage StatusMessage
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
        /// Gets and sets the property SupportMode. 
        /// <para>
        /// Support mode for this inquiry. AI_ONLY provides AI-generated responses. FULL_SUPPORT
        /// includes human expert review.
        /// </para>
        /// </summary>
        public InquirySupportMode SupportMode
        {
            get { return this._supportMode; }
            set { this._supportMode = value; }
        }

        // Check to see if SupportMode property is set
        internal bool IsSetSupportMode()
        {
            return this._supportMode != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp indicating when the resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}