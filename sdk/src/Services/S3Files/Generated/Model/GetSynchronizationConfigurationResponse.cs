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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
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
namespace Amazon.S3Files.Model
{
    /// <summary>
    /// This is the response object from the GetSynchronizationConfiguration operation.
    /// </summary>
    public partial class GetSynchronizationConfigurationResponse : AmazonWebServiceResponse
    {
        private List<ExpirationDataRule> _expirationDataRules = AWSConfigs.InitializeCollections ? new List<ExpirationDataRule>() : null;
        private List<ImportDataRule> _importDataRules = AWSConfigs.InitializeCollections ? new List<ImportDataRule>() : null;
        private int? _latestVersionNumber;

        /// <summary>
        /// Gets and sets the property ExpirationDataRules. 
        /// <para>
        /// An array of expiration data rules that control when cached data expires from the file
        /// system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<ExpirationDataRule> ExpirationDataRules
        {
            get { return this._expirationDataRules; }
            set { this._expirationDataRules = value; }
        }

        // Check to see if ExpirationDataRules property is set
        internal bool IsSetExpirationDataRules()
        {
            return this._expirationDataRules != null && (this._expirationDataRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImportDataRules. 
        /// <para>
        /// An array of import data rules that control how data is imported from S3 into the file
        /// system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<ImportDataRule> ImportDataRules
        {
            get { return this._importDataRules; }
            set { this._importDataRules = value; }
        }

        // Check to see if ImportDataRules property is set
        internal bool IsSetImportDataRules()
        {
            return this._importDataRules != null && (this._importDataRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LatestVersionNumber. 
        /// <para>
        /// The version number of the synchronization configuration. Use this value with <c>PutSynchronizationConfiguration</c>
        /// to ensure optimistic concurrency control.
        /// </para>
        /// </summary>
        public int? LatestVersionNumber
        {
            get { return this._latestVersionNumber; }
            set { this._latestVersionNumber = value; }
        }

        // Check to see if LatestVersionNumber property is set
        internal bool IsSetLatestVersionNumber()
        {
            return this._latestVersionNumber.HasValue; 
        }

    }
}