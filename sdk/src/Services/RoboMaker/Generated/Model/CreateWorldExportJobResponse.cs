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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the CreateWorldExportJob operation.
    /// </summary>
    public partial class CreateWorldExportJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _clientRequestToken;
        private DateTime? _createdAt;
        private WorldExportJobErrorCode _failureCode;
        private string _iamRole;
        private OutputLocation _outputLocation;
        private WorldExportJobStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        ///  </dd> <dt>AllWorldGenerationFailed</dt> <dd> 
        /// <para>
        /// All of the worlds in the world generation job failed. This can happen if your <c>worldCount</c>
        /// is greater than 50 or less than 1. 
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For more information about troubleshooting WorldForge, see <a href="https://docs.aws.amazon.com/robomaker/latest/dg/troubleshooting-worldforge.html">Troubleshooting
        /// Simulation WorldForge</a>. 
        /// </para>
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
        /// The world export job failed. See <c>failureCode</c> for more information. 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}