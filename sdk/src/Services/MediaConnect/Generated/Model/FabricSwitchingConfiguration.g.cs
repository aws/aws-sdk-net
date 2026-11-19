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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The configuration settings for switching between router inputs.
    /// </summary>
    public partial class FabricSwitchingConfiguration
    {
        /// <summary>
        /// Gets and sets the property Immediate. 
        /// <para>
        /// The switching configuration where the router output switches to the new router input
        /// immediately.
        /// </para>
        /// </summary>
        public ImmediateFabricSwitchingConfiguration Immediate { get; set; }

        /// <summary>
        /// Checks to see if the Immediate property is set.
        /// </summary>
        internal bool IsSetImmediate() => this.Immediate != null;

        /// <summary>
        /// Gets and sets the property KeyFrame. 
        /// <para>
        /// The switching configuration where the router output waits for a key frame on the new
        /// router input before it switches.
        /// </para>
        /// </summary>
        public KeyFrameFabricSwitchingConfiguration KeyFrame { get; set; }

        /// <summary>
        /// Checks to see if the KeyFrame property is set.
        /// </summary>
        internal bool IsSetKeyFrame() => this.KeyFrame != null;
    }
}
