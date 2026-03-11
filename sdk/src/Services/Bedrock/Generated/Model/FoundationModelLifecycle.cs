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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Details about whether a model version is available or deprecated.
    /// </summary>
    public partial class FoundationModelLifecycle
    {
        private DateTime? _endOfLifeTime;
        private DateTime? _legacyTime;
        private DateTime? _publicExtendedAccessTime;
        private DateTime? _startOfLifeTime;
        private FoundationModelLifecycleStatus _status;

        /// <summary>
        /// Gets and sets the property EndOfLifeTime. 
        /// <para>
        /// Time when the model is no longer available for use
        /// </para>
        /// </summary>
        public DateTime? EndOfLifeTime
        {
            get { return this._endOfLifeTime; }
            set { this._endOfLifeTime = value; }
        }

        // Check to see if EndOfLifeTime property is set
        internal bool IsSetEndOfLifeTime()
        {
            return this._endOfLifeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LegacyTime. 
        /// <para>
        /// Time when the model enters legacy state. Models in legacy state can still be used,
        /// but users should plan to transition to an Active model before the end of life time
        /// </para>
        /// </summary>
        public DateTime? LegacyTime
        {
            get { return this._legacyTime; }
            set { this._legacyTime = value; }
        }

        // Check to see if LegacyTime property is set
        internal bool IsSetLegacyTime()
        {
            return this._legacyTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicExtendedAccessTime. 
        /// <para>
        /// Public extended access portion of the legacy period, when users should expect higher
        /// pricing
        /// </para>
        /// </summary>
        public DateTime? PublicExtendedAccessTime
        {
            get { return this._publicExtendedAccessTime; }
            set { this._publicExtendedAccessTime = value; }
        }

        // Check to see if PublicExtendedAccessTime property is set
        internal bool IsSetPublicExtendedAccessTime()
        {
            return this._publicExtendedAccessTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartOfLifeTime. 
        /// <para>
        /// Launch time when the model first becomes available
        /// </para>
        /// </summary>
        public DateTime? StartOfLifeTime
        {
            get { return this._startOfLifeTime; }
            set { this._startOfLifeTime = value; }
        }

        // Check to see if StartOfLifeTime property is set
        internal bool IsSetStartOfLifeTime()
        {
            return this._startOfLifeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether a model version is available (<c>ACTIVE</c>) or deprecated (<c>LEGACY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FoundationModelLifecycleStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}