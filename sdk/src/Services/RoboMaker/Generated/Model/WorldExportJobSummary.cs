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
    /// Information about a world export job.
    /// </summary>
    public partial class WorldExportJobSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private OutputLocation _outputLocation;
        private WorldExportJobStatus _status;
        private List<string> _worlds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property Worlds. 
        /// <para>
        /// A list of worlds.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._worlds != null && (this._worlds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}