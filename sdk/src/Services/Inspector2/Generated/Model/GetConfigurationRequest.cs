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
    /// Container for the parameters to the GetConfiguration operation.
    /// Retrieves setting configurations for Amazon Inspector scans. If you specify an <c>accountId</c>,
    /// this operation returns the scan configuration for that member account. You must be
    /// the delegated administrator for the specified member account. If you do not specify
    /// an <c>accountId</c>, this operation returns your own scan configuration.
    /// </summary>
    public partial class GetConfigurationRequest : AmazonInspector2Request
    {
        private string _accountId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit Amazon Web Services account ID of the member account whose scan configuration
        /// you want to retrieve. When specified, you must be the delegated administrator for
        /// this member account. If not specified, the operation returns your own configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

    }
}