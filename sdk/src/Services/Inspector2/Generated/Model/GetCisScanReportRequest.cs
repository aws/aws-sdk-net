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
    /// Container for the parameters to the GetCisScanReport operation.
    /// Retrieves a CIS scan report.
    /// </summary>
    public partial class GetCisScanReportRequest : AmazonInspector2Request
    {
        private string _scanArn;
        private List<string> _targetAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ScanArn. 
        /// <para>
        /// The scan ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanArn
        {
            get { return this._scanArn; }
            set { this._scanArn = value; }
        }

        // Check to see if ScanArn property is set
        internal bool IsSetScanArn()
        {
            return this._scanArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAccounts. 
        /// <para>
        /// The target accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> TargetAccounts
        {
            get { return this._targetAccounts; }
            set { this._targetAccounts = value; }
        }

        // Check to see if TargetAccounts property is set
        internal bool IsSetTargetAccounts()
        {
            return this._targetAccounts != null && (this._targetAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}