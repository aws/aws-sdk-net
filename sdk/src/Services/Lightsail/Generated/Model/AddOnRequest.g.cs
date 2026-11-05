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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a request to enable, modify, or disable an add-on for an Amazon Lightsail
    /// resource.
    /// 
    ///  <note> 
    /// <para>
    /// An additional cost may be associated with enabling add-ons. For more information,
    /// see the <a href="https://aws.amazon.com/lightsail/pricing/">Lightsail pricing page</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AddOnRequest
    {
        /// <summary>
        /// Gets and sets the property AddOnType. 
        /// <para>
        /// The add-on type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AddOnType AddOnType { get; set; }

        /// <summary>
        /// Checks to see if the AddOnType property is set.
        /// </summary>
        internal bool IsSetAddOnType() => this.AddOnType != null;

        /// <summary>
        /// Gets and sets the property AutoSnapshotAddOnRequest. 
        /// <para>
        /// An object that represents additional parameters when enabling or modifying the automatic
        /// snapshot add-on.
        /// </para>
        /// </summary>
        public AutoSnapshotAddOnRequest AutoSnapshotAddOnRequest { get; set; }

        /// <summary>
        /// Checks to see if the AutoSnapshotAddOnRequest property is set.
        /// </summary>
        internal bool IsSetAutoSnapshotAddOnRequest() => this.AutoSnapshotAddOnRequest != null;

        /// <summary>
        /// Gets and sets the property StopInstanceOnIdleRequest. 
        /// <para>
        /// An object that represents additional parameters when enabling or modifying the <c>StopInstanceOnIdle</c>
        /// add-on.
        /// </para>
        ///  <important> 
        /// <para>
        /// This object only applies to Lightsail for Research resources.
        /// </para>
        ///  </important>
        /// </summary>
        public StopInstanceOnIdleRequest StopInstanceOnIdleRequest { get; set; }

        /// <summary>
        /// Checks to see if the StopInstanceOnIdleRequest property is set.
        /// </summary>
        internal bool IsSetStopInstanceOnIdleRequest() => this.StopInstanceOnIdleRequest != null;
    }
}
