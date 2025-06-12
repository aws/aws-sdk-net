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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
    /// DescribeTapeArchivesOutput
    /// </summary>
    public partial class DescribeTapeArchivesResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<TapeArchive> _tapeArchives = AWSConfigs.InitializeCollections ? new List<TapeArchive>() : null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string that indicates the position at which the virtual tapes that were
        /// fetched for description ended. Use this marker in your next request to fetch the next
        /// set of virtual tapes in the virtual tape shelf (VTS). If there are no more virtual
        /// tapes to describe, this field does not appear in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property TapeArchives. 
        /// <para>
        /// An array of virtual tape objects in the virtual tape shelf (VTS). The description
        /// includes of the Amazon Resource Name (ARN) of the virtual tapes. The information returned
        /// includes the Amazon Resource Names (ARNs) of the tapes, size of the tapes, status
        /// of the tapes, progress of the description, and tape barcode.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TapeArchive> TapeArchives
        {
            get { return this._tapeArchives; }
            set { this._tapeArchives = value; }
        }

        // Check to see if TapeArchives property is set
        internal bool IsSetTapeArchives()
        {
            return this._tapeArchives != null && (this._tapeArchives.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}