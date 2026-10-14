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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// A track that you can switch the current track to.
    /// </summary>
    public partial class UpdateTarget
    {
        /// <summary>
        /// Gets and sets the property TrackName. 
        /// <para>
        /// The name of the new track.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TrackName { get; set; }

        /// <summary>
        /// Checks to see if the TrackName property is set.
        /// </summary>
        internal bool IsSetTrackName() => this.TrackName != null;

        /// <summary>
        /// Gets and sets the property WorkgroupVersion. 
        /// <para>
        /// The workgroup version for the new track.
        /// </para>
        /// </summary>
        public string WorkgroupVersion { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupVersion property is set.
        /// </summary>
        internal bool IsSetWorkgroupVersion() => this.WorkgroupVersion != null;
    }
}
