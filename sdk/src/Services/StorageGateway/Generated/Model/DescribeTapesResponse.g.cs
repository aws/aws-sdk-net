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
    /// This is the response object from the DescribeTapes operation.
    /// </summary>
    public partial class DescribeTapesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string that can be used as part of a subsequent <c>DescribeTapes</c> call
        /// to retrieve the next page of results.
        /// </para>
        ///  
        /// <para>
        /// If a response does not contain a marker, then there are no more results to be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property Tapes. 
        /// <para>
        /// An array of virtual tape descriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tape> Tapes { get; set; } = AWSConfigs.InitializeCollections ? new List<Tape>() : null;

        /// <summary>
        /// Checks to see if the Tapes property is set.
        /// </summary>
        internal bool IsSetTapes() => this.Tapes != null && (this.Tapes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
