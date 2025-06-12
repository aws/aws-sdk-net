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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the StartResourceScan operation.
    /// Starts a scan of the resources in this account in this Region. You can the status
    /// of a scan using the <c>ListResourceScans</c> API action.
    /// </summary>
    public partial class StartResourceScanRequest : AmazonCloudFormationRequest
    {
        private string _clientRequestToken;
        private List<ScanFilter> _scanFilters = AWSConfigs.InitializeCollections ? new List<ScanFilter>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for this <c>StartResourceScan</c> request. Specify this token
        /// if you plan to retry requests so that CloudFormation knows that you're not attempting
        /// to start a new resource scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ScanFilters. 
        /// <para>
        /// The scan filters to use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ScanFilter> ScanFilters
        {
            get { return this._scanFilters; }
            set { this._scanFilters = value; }
        }

        // Check to see if ScanFilters property is set
        internal bool IsSetScanFilters()
        {
            return this._scanFilters != null && (this._scanFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}