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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the SendCommand operation.
    /// Executes commands on one or more remote instances.
    /// </summary>
    public partial class SendCommandRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _comment;
        private string _documentHash;
        private DocumentHashType _documentHashType;
        private string _documentName;
        private List<string> _instanceIds = new List<string>();
        private string _outputS3BucketName;
        private string _outputS3KeyPrefix;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private int? _timeoutSeconds;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendCommandRequest() { }

        /// <summary>
        /// Instantiates SendCommandRequest with the parameterized properties
        /// </summary>
        /// <param name="documentName">Required. The name of the SSM document to execute. This can be an SSM public document or a custom document.</param>
        /// <param name="instanceIds">Required. The instance IDs where the command should execute.</param>
        public SendCommandRequest(string documentName, List<string> instanceIds)
        {
            _documentName = documentName;
            _instanceIds = instanceIds;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// User-specified information about the command, such as a brief description of what
        /// the command should do.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentHash. 
        /// <para>
        /// The Sha256 or Sha1 hash created by the system when the document was created. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Sha1 hashes have been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        public string DocumentHash
        {
            get { return this._documentHash; }
            set { this._documentHash = value; }
        }

        // Check to see if DocumentHash property is set
        internal bool IsSetDocumentHash()
        {
            return this._documentHash != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentHashType. 
        /// <para>
        /// Sha256 or Sha1.
        /// </para>
        ///  <note> 
        /// <para>
        /// Sha1 hashes have been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        public DocumentHashType DocumentHashType
        {
            get { return this._documentHashType; }
            set { this._documentHashType = value; }
        }

        // Check to see if DocumentHashType property is set
        internal bool IsSetDocumentHashType()
        {
            return this._documentHashType != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// Required. The name of the SSM document to execute. This can be an SSM public document
        /// or a custom document.
        /// </para>
        /// </summary>
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// Required. The instance IDs where the command should execute.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputS3BucketName. 
        /// <para>
        /// The name of the S3 bucket where command execution responses should be stored.
        /// </para>
        /// </summary>
        public string OutputS3BucketName
        {
            get { return this._outputS3BucketName; }
            set { this._outputS3BucketName = value; }
        }

        // Check to see if OutputS3BucketName property is set
        internal bool IsSetOutputS3BucketName()
        {
            return this._outputS3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3KeyPrefix. 
        /// <para>
        /// The directory structure within the S3 bucket where the responses should be stored.
        /// </para>
        /// </summary>
        public string OutputS3KeyPrefix
        {
            get { return this._outputS3KeyPrefix; }
            set { this._outputS3KeyPrefix = value; }
        }

        // Check to see if OutputS3KeyPrefix property is set
        internal bool IsSetOutputS3KeyPrefix()
        {
            return this._outputS3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The required and optional parameters specified in the SSM document being executed.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// If this time is reached and the command has not already started executing, it will
        /// not execute.
        /// </para>
        /// </summary>
        public int TimeoutSeconds
        {
            get { return this._timeoutSeconds.GetValueOrDefault(); }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

    }
}