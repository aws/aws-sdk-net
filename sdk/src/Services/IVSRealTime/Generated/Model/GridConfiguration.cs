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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Configuration information specific to Grid layout, for server-side composition. See
    /// "Layouts" in <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/server-side-composition.html">Server-Side
    /// Composition</a>.
    /// </summary>
    public partial class GridConfiguration
    {
        private string _featuredParticipantAttribute;

        /// <summary>
        /// Gets and sets the property FeaturedParticipantAttribute. 
        /// <para>
        /// This attribute name identifies the featured slot. A participant with this attribute
        /// set to <code>"true"</code> (as a string value) in <a>ParticipantTokenConfiguration</a>
        /// is placed in the featured slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string FeaturedParticipantAttribute
        {
            get { return this._featuredParticipantAttribute; }
            set { this._featuredParticipantAttribute = value; }
        }

        // Check to see if FeaturedParticipantAttribute property is set
        internal bool IsSetFeaturedParticipantAttribute()
        {
            return this._featuredParticipantAttribute != null;
        }

    }
}