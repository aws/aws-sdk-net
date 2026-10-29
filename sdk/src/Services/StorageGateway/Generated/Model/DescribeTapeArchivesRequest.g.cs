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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTapeArchives operation. Returns a description
    /// of specified virtual tapes in the virtual tape shelf (VTS). This operation is only
    /// supported in the tape gateway type. <para> If a specific <c>TapeARN</c> is not specified,
    /// Storage Gateway returns a description of all virtual tapes found in the VTS associated
    /// with your account. </para>
    /// </summary>
    public partial class DescribeTapeArchivesRequest : AmazonStorageGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies that the number of virtual tapes described be limited to the specified number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string that indicates the position at which to begin describing virtual
        /// tapes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property TapeARNs. 
        /// <para>
        /// Specifies one or more unique Amazon Resource Names (ARNs) that represent the virtual
        /// tapes you want to describe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TapeARNs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TapeARNs property is set.
        /// </summary>
        internal bool IsSetTapeARNs() => this.TapeARNs != null && (this.TapeARNs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
