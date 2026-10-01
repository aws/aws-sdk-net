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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The configuration that controls the content key period timing information that MediaPackage
    /// signals to your DRM key provider.
    /// </summary>
    public partial class ContentKeyPeriodConfiguration
    {
        /// <summary>
        /// Gets and sets the property ContentKeyPeriodTiming. 
        /// <para>
        /// Specifies what timing information MediaPackage signals in the <c>ContentKeyPeriod</c>
        /// to your DRM key provider. If you don't specify a value, the default is <c>INDEX_ONLY</c>.
        /// Signaling start and end times (<c>START_END_ONLY</c> or <c>INDEX_WITH_START_END</c>)
        /// also requires key rotation to be enabled.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INDEX_ONLY</c> - Signals only the content key index. This is the default and matches
        /// the current behavior. It's supported for both SPEKE Version 2.0 and 2.1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>START_END_ONLY</c> - Signals only the start and end times the key is used for.
        /// Requires <c>SpekeVersion</c> <c>V2_1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INDEX_WITH_START_END</c> - Signals both the content key index and the start and
        /// end times the key is used for. Requires <c>SpekeVersion</c> <c>V2_1</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContentKeyPeriodTiming ContentKeyPeriodTiming { get; set; }

        /// <summary>
        /// Checks to see if the ContentKeyPeriodTiming property is set.
        /// </summary>
        internal bool IsSetContentKeyPeriodTiming() => this.ContentKeyPeriodTiming != null;
    }
}
