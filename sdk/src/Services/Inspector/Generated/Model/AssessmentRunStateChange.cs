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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Used as one of the elements of the <a>AssessmentRun</a> data type.
    /// </summary>
    public partial class AssessmentRunStateChange
    {
        private AssessmentRunState _state;
        private DateTime? _stateChangedAt;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The assessment run state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssessmentRunState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateChangedAt. 
        /// <para>
        /// The last time the assessment run state changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StateChangedAt
        {
            get { return this._stateChangedAt; }
            set { this._stateChangedAt = value; }
        }

        // Check to see if StateChangedAt property is set
        internal bool IsSetStateChangedAt()
        {
            return this._stateChangedAt.HasValue; 
        }

    }
}