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
    /// Information about a world generator job.
    /// </summary>
    public partial class WorldGenerationJobSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private int? _failedWorldCount;
        private WorldGenerationJobStatus _status;
        private int? _succeededWorldCount;
        private string _template;
        private WorldCount _worldCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the world generator job.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the world generator job was created.
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
        /// Gets and sets the property FailedWorldCount. 
        /// <para>
        /// The number of worlds that failed.
        /// </para>
        /// </summary>
        public int? FailedWorldCount
        {
            get { return this._failedWorldCount; }
            set { this._failedWorldCount = value; }
        }

        // Check to see if FailedWorldCount property is set
        internal bool IsSetFailedWorldCount()
        {
            return this._failedWorldCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the world generator job:
        /// </para>
        ///  <dl> <dt>Pending</dt> <dd> 
        /// <para>
        /// The world generator job request is pending.
        /// </para>
        ///  </dd> <dt>Running</dt> <dd> 
        /// <para>
        /// The world generator job is running. 
        /// </para>
        ///  </dd> <dt>Completed</dt> <dd> 
        /// <para>
        /// The world generator job completed. 
        /// </para>
        ///  </dd> <dt>Failed</dt> <dd> 
        /// <para>
        /// The world generator job failed. See <c>failureCode</c> for more information. 
        /// </para>
        ///  </dd> <dt>PartialFailed</dt> <dd> 
        /// <para>
        /// Some worlds did not generate.
        /// </para>
        ///  </dd> <dt>Canceled</dt> <dd> 
        /// <para>
        /// The world generator job was cancelled.
        /// </para>
        ///  </dd> <dt>Canceling</dt> <dd> 
        /// <para>
        /// The world generator job is being cancelled.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public WorldGenerationJobStatus Status
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
        /// Gets and sets the property SucceededWorldCount. 
        /// <para>
        /// The number of worlds that were generated.
        /// </para>
        /// </summary>
        public int? SucceededWorldCount
        {
            get { return this._succeededWorldCount; }
            set { this._succeededWorldCount = value; }
        }

        // Check to see if SucceededWorldCount property is set
        internal bool IsSetSucceededWorldCount()
        {
            return this._succeededWorldCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The Amazon Resource Name (arn) of the world template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

        /// <summary>
        /// Gets and sets the property WorldCount. 
        /// <para>
        /// Information about the world count.
        /// </para>
        /// </summary>
        public WorldCount WorldCount
        {
            get { return this._worldCount; }
            set { this._worldCount = value; }
        }

        // Check to see if WorldCount property is set
        internal bool IsSetWorldCount()
        {
            return this._worldCount != null;
        }

    }
}