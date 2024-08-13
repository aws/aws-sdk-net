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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The metadata transfer job status.
    /// </summary>
    public partial class MetadataTransferJobStatus
    {
        private ErrorDetails _error;
        private int? _queuedPosition;
        private MetadataTransferJobState _state;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The metadata transfer job error.
        /// </para>
        /// </summary>
        public ErrorDetails Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property QueuedPosition. 
        /// <para>
        /// The queued position.
        /// </para>
        /// </summary>
        public int? QueuedPosition
        {
            get { return this._queuedPosition; }
            set { this._queuedPosition = value; }
        }

        // Check to see if QueuedPosition property is set
        internal bool IsSetQueuedPosition()
        {
            return this._queuedPosition.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The metadata transfer job state.
        /// </para>
        /// </summary>
        public MetadataTransferJobState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}