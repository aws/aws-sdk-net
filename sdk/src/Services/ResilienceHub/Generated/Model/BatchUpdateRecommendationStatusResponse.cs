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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateRecommendationStatus operation.
    /// </summary>
    public partial class BatchUpdateRecommendationStatusResponse : AmazonWebServiceResponse
    {
        private string _appArn;
        private List<BatchUpdateRecommendationStatusFailedEntry> _failedEntries = AWSConfigs.InitializeCollections ? new List<BatchUpdateRecommendationStatusFailedEntry>() : null;
        private List<BatchUpdateRecommendationStatusSuccessfulEntry> _successfulEntries = AWSConfigs.InitializeCollections ? new List<BatchUpdateRecommendationStatusSuccessfulEntry>() : null;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property FailedEntries. 
        /// <para>
        /// A list of items with error details about each item, which could not be included or
        /// excluded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchUpdateRecommendationStatusFailedEntry> FailedEntries
        {
            get { return this._failedEntries; }
            set { this._failedEntries = value; }
        }

        // Check to see if FailedEntries property is set
        internal bool IsSetFailedEntries()
        {
            return this._failedEntries != null && (this._failedEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulEntries. 
        /// <para>
        /// A list of items that were included or excluded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchUpdateRecommendationStatusSuccessfulEntry> SuccessfulEntries
        {
            get { return this._successfulEntries; }
            set { this._successfulEntries = value; }
        }

        // Check to see if SuccessfulEntries property is set
        internal bool IsSetSuccessfulEntries()
        {
            return this._successfulEntries != null && (this._successfulEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}