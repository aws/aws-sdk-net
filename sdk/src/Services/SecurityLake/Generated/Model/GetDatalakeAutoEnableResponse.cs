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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// This is the response object from the GetDatalakeAutoEnable operation.
    /// </summary>
    public partial class GetDatalakeAutoEnableResponse : AmazonWebServiceResponse
    {
        private List<AutoEnableNewRegionConfiguration> _autoEnableNewAccounts = new List<AutoEnableNewRegionConfiguration>();

        /// <summary>
        /// Gets and sets the property AutoEnableNewAccounts. 
        /// <para>
        /// The configuration for new accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutoEnableNewRegionConfiguration> AutoEnableNewAccounts
        {
            get { return this._autoEnableNewAccounts; }
            set { this._autoEnableNewAccounts = value; }
        }

        // Check to see if AutoEnableNewAccounts property is set
        internal bool IsSetAutoEnableNewAccounts()
        {
            return this._autoEnableNewAccounts != null && this._autoEnableNewAccounts.Count > 0; 
        }

    }
}