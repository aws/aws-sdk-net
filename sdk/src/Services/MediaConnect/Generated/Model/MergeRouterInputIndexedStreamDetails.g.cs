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
    /// Configuration details for an indexed stream in a merge router input setup.
    /// </summary>
    public partial class MergeRouterInputIndexedStreamDetails
    {
        /// <summary>
        /// Gets and sets the property SourceIndex. 
        /// <para>
        /// The index number (0 or 1) assigned to this source in the merge configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SourceIndex { get; set; }

        /// <summary>
        /// Checks to see if the SourceIndex property is set.
        /// </summary>
        internal bool IsSetSourceIndex() => this.SourceIndex.HasValue;

        /// <summary>
        /// Gets and sets the property SourceIpAddress. 
        /// <para>
        /// The IP address of the source for this indexed stream in the merge setup.
        /// </para>
        /// </summary>
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the SourceIpAddress property is set.
        /// </summary>
        internal bool IsSetSourceIpAddress() => this.SourceIpAddress != null;
    }
}
