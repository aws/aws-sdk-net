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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// TCP or UDP protocols: The range of ports the rule applies to.
    /// </summary>
    public partial class NetworkAclPortRange
    {
        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The beginning port number of the range. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From.HasValue;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The ending port number of the range. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To.HasValue;
    }
}
