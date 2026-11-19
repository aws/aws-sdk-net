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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Status information for a single Multi-Region Access Point Region.
    /// </summary>
    public partial class MultiRegionAccessPointRegionalResponse
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Region in the Multi-Region Access Point.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestStatus. 
        /// <para>
        /// The current status of the Multi-Region Access Point in this Region.
        /// </para>
        /// </summary>
        public string RequestStatus { get; set; }

        /// <summary>
        /// Checks to see if the RequestStatus property is set.
        /// </summary>
        internal bool IsSetRequestStatus() => this.RequestStatus != null;
    }
}
