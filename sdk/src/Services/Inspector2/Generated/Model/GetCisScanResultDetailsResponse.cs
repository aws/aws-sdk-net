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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// This is the response object from the GetCisScanResultDetails operation.
    /// </summary>
    public partial class GetCisScanResultDetailsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<CisScanResultDetails> _scanResultDetails = AWSConfigs.InitializeCollections ? new List<CisScanResultDetails>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from a previous request that's used to retrieve the next page
        /// of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ScanResultDetails. 
        /// <para>
        /// The scan result details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<CisScanResultDetails> ScanResultDetails
        {
            get { return this._scanResultDetails; }
            set { this._scanResultDetails = value; }
        }

        // Check to see if ScanResultDetails property is set
        internal bool IsSetScanResultDetails()
        {
            return this._scanResultDetails != null && (this._scanResultDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}