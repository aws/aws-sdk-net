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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// The streaming protocol you want your stack to prefer. This can be UDP or TCP. Currently,
    /// UDP is only supported in the Windows native client.
    /// </summary>
    public partial class StreamingExperienceSettings
    {
        /// <summary>
        /// Gets and sets the property PreferredProtocol. 
        /// <para>
        /// The preferred protocol that you want to use while streaming your application.
        /// </para>
        /// </summary>
        public PreferredProtocol PreferredProtocol { get; set; }

        /// <summary>
        /// Checks to see if the PreferredProtocol property is set.
        /// </summary>
        internal bool IsSetPreferredProtocol() => this.PreferredProtocol != null;
    }
}
