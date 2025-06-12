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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// The following data is returned in JSON format by the service.
    /// </summary>
    public partial class SendBulkEmailResponse : AmazonWebServiceResponse
    {
        private List<BulkEmailEntryResult> _bulkEmailEntryResults = AWSConfigs.InitializeCollections ? new List<BulkEmailEntryResult>() : null;

        /// <summary>
        /// Gets and sets the property BulkEmailEntryResults. 
        /// <para>
        /// One object per intended recipient. Check each response object and retry any messages
        /// with a failure status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BulkEmailEntryResult> BulkEmailEntryResults
        {
            get { return this._bulkEmailEntryResults; }
            set { this._bulkEmailEntryResults = value; }
        }

        // Check to see if BulkEmailEntryResults property is set
        internal bool IsSetBulkEmailEntryResults()
        {
            return this._bulkEmailEntryResults != null && (this._bulkEmailEntryResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}