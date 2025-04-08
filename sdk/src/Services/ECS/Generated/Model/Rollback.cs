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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Information about the service deployment rollback.
    /// </summary>
    public partial class Rollback
    {
        private string _reason;
        private string _serviceRevisionArn;
        private DateTime? _startedAt;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason the rollback happened. For example, the circuit breaker initiated the rollback
        /// operation.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRevisionArn. 
        /// <para>
        /// The ARN of the service revision deployed as part of the rollback.
        /// </para>
        /// </summary>
        public string ServiceRevisionArn
        {
            get { return this._serviceRevisionArn; }
            set { this._serviceRevisionArn = value; }
        }

        // Check to see if ServiceRevisionArn property is set
        internal bool IsSetServiceRevisionArn()
        {
            return this._serviceRevisionArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// Time time that the rollback started. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

    }
}