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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateFindings operation.
    /// </summary>
    public partial class BatchUpdateFindingsResponse : AmazonWebServiceResponse
    {
        private List<AwsSecurityFindingIdentifier> _processedFindings = AWSConfigs.InitializeCollections ? new List<AwsSecurityFindingIdentifier>() : null;
        private List<BatchUpdateFindingsUnprocessedFinding> _unprocessedFindings = AWSConfigs.InitializeCollections ? new List<BatchUpdateFindingsUnprocessedFinding>() : null;

        /// <summary>
        /// Gets and sets the property ProcessedFindings. 
        /// <para>
        /// The list of findings that were updated successfully.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AwsSecurityFindingIdentifier> ProcessedFindings
        {
            get { return this._processedFindings; }
            set { this._processedFindings = value; }
        }

        // Check to see if ProcessedFindings property is set
        internal bool IsSetProcessedFindings()
        {
            return this._processedFindings != null && (this._processedFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedFindings. 
        /// <para>
        /// The list of findings that were not updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchUpdateFindingsUnprocessedFinding> UnprocessedFindings
        {
            get { return this._unprocessedFindings; }
            set { this._unprocessedFindings = value; }
        }

        // Check to see if UnprocessedFindings property is set
        internal bool IsSetUnprocessedFindings()
        {
            return this._unprocessedFindings != null && (this._unprocessedFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}