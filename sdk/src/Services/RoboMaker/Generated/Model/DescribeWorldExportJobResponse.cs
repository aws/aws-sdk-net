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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeWorldExportJob operation.
    /// </summary>
    public partial class DescribeWorldExportJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _clientRequestToken;
        private DateTime? _createdAt;
        private WorldExportJobErrorCode _failureCode;
        private string _failureReason;
        private string _iamRole;
        private OutputLocation _outputLocation;
        private WorldExportJobStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<string> _worlds = new List<string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the world export job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the world export job was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code of the world export job if it failed:
        /// </para>
        ///  <dl> <dt>InternalServiceError</dt> <dd> 
        /// <para>
        /// Internal service error.
        /// </para>
        ///  </dd> <dt>LimitExceeded</dt> <dd> 
        /// <para>
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed. 
        /// </para>
        ///  </dd> <dt>ResourceNotFound</dt> <dd> 
        /// <para>
        /// The specified resource could not be found. 
        /// </para>
        ///  </dd> <dt>RequestThrottled</dt> <dd> 
        /// <para>
        /// The request was throttled.
        /// </para>
        ///  </dd> <dt>InvalidInput</dt> <dd> 
        /// <para>
        /// An input parameter in the request is not valid.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public WorldExportJobErrorCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why the world export job failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The IAM role that the world export process uses to access the Amazon S3 bucket and
        /// put the export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation.
        /// </summary>
        public OutputLocation OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the world export job.
        /// </para>
        ///  <dl> <dt>Pending</dt> <dd> 
        /// <para>
        /// The world export job request is pending.
        /// </para>
        ///  </dd> <dt>Running</dt> <dd> 
        /// <para>
        /// The world export job is running. 
        /// </para>
        ///  </dd> <dt>Completed</dt> <dd> 
        /// <para>
        /// The world export job completed. 
        /// </para>
        ///  </dd> <dt>Failed</dt> <dd> 
        /// <para>
        /// The world export job failed. See <code>failureCode</code> and <code>failureReason</code>
        /// for more information. 
        /// </para>
        ///  </dd> <dt>Canceled</dt> <dd> 
        /// <para>
        /// The world export job was cancelled.
        /// </para>
        ///  </dd> <dt>Canceling</dt> <dd> 
        /// <para>
        /// The world export job is being cancelled.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public WorldExportJobStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains tag keys and tag values that are attached to the world export
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Worlds. 
        /// <para>
        /// A list of Amazon Resource Names (arns) that correspond to worlds to be exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Worlds
        {
            get { return this._worlds; }
            set { this._worlds = value; }
        }

        // Check to see if Worlds property is set
        internal bool IsSetWorlds()
        {
            return this._worlds != null && this._worlds.Count > 0; 
        }

    }
}