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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about the state of transitions between one stage and another
    /// stage.
    /// </summary>
    public partial class TransitionState
    {
        private string _disabledReason;
        private bool? _enabled;
        private DateTime? _lastChangedAt;
        private string _lastChangedBy;

        /// <summary>
        /// Gets and sets the property DisabledReason. 
        /// <para>
        /// The user-specified reason why the transition between two stages of a pipeline was
        /// disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string DisabledReason
        {
            get { return this._disabledReason; }
            set { this._disabledReason = value; }
        }

        // Check to see if DisabledReason property is set
        internal bool IsSetDisabledReason()
        {
            return this._disabledReason != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the transition between stages is enabled (true) or disabled (false).
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastChangedAt. 
        /// <para>
        /// The timestamp when the transition state was last changed.
        /// </para>
        /// </summary>
        public DateTime? LastChangedAt
        {
            get { return this._lastChangedAt; }
            set { this._lastChangedAt = value; }
        }

        // Check to see if LastChangedAt property is set
        internal bool IsSetLastChangedAt()
        {
            return this._lastChangedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastChangedBy. 
        /// <para>
        /// The ID of the user who last changed the transition state.
        /// </para>
        /// </summary>
        public string LastChangedBy
        {
            get { return this._lastChangedBy; }
            set { this._lastChangedBy = value; }
        }

        // Check to see if LastChangedBy property is set
        internal bool IsSetLastChangedBy()
        {
            return this._lastChangedBy != null;
        }

    }
}