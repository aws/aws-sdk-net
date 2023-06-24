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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Schedule configuration parameters. A channel must be stopped before changes can be
    /// made to the schedule.
    /// </summary>
    public partial class ScheduleConfiguration
    {
        private ClipRange _clipRange;
        private Transition _transition;

        /// <summary>
        /// Gets and sets the property ClipRange. 
        /// <para>
        /// Program clip range configuration.
        /// </para>
        /// </summary>
        public ClipRange ClipRange
        {
            get { return this._clipRange; }
            set { this._clipRange = value; }
        }

        // Check to see if ClipRange property is set
        internal bool IsSetClipRange()
        {
            return this._clipRange != null;
        }

        /// <summary>
        /// Gets and sets the property Transition. 
        /// <para>
        /// Program transition configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Transition Transition
        {
            get { return this._transition; }
            set { this._transition = value; }
        }

        // Check to see if Transition property is set
        internal bool IsSetTransition()
        {
            return this._transition != null;
        }

    }
}