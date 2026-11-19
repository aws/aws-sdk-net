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
    /// The configuration settings for the RTMP (Real-Time Messaging Protocol) application
    /// and stream names.
    /// </summary>
    public partial class RtmpPushNamingConfiguration
    {
        /// <summary>
        /// Gets and sets the property Automatic. 
        /// <para>
        /// The naming configuration where MediaConnect generates the application and stream names.
        /// </para>
        /// </summary>
        public AutomaticRtmpPushNamingConfiguration Automatic { get; set; }

        /// <summary>
        /// Checks to see if the Automatic property is set.
        /// </summary>
        internal bool IsSetAutomatic() => this.Automatic != null;

        /// <summary>
        /// Gets and sets the property Manual. 
        /// <para>
        /// The naming configuration where you specify the application and stream names.
        /// </para>
        /// </summary>
        public ManualRtmpPushNamingConfiguration Manual { get; set; }

        /// <summary>
        /// Checks to see if the Manual property is set.
        /// </summary>
        internal bool IsSetManual() => this.Manual != null;
    }
}
