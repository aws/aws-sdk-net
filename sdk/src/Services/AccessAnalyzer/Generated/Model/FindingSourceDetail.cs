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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Includes details about how the access that generated the finding is granted. This
    /// is populated for Amazon S3 bucket findings.
    /// </summary>
    public partial class FindingSourceDetail
    {
        private string _accessPointAccount;
        private string _accessPointArn;

        /// <summary>
        /// Gets and sets the property AccessPointAccount. 
        /// <para>
        /// The account of the cross-account access point that generated the finding.
        /// </para>
        /// </summary>
        public string AccessPointAccount
        {
            get { return this._accessPointAccount; }
            set { this._accessPointAccount = value; }
        }

        // Check to see if AccessPointAccount property is set
        internal bool IsSetAccessPointAccount()
        {
            return this._accessPointAccount != null;
        }

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The ARN of the access point that generated the finding. The ARN format depends on
        /// whether the ARN represents an access point or a multi-region access point.
        /// </para>
        /// </summary>
        public string AccessPointArn
        {
            get { return this._accessPointArn; }
            set { this._accessPointArn = value; }
        }

        // Check to see if AccessPointArn property is set
        internal bool IsSetAccessPointArn()
        {
            return this._accessPointArn != null;
        }

    }
}