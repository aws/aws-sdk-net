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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApplicationProvider operation.
    /// Retrieves details about a provider that can be used to connect an Amazon Web Services
    /// managed application or customer managed application to IAM Identity Center.
    /// </summary>
    public partial class DescribeApplicationProviderRequest : AmazonSSOAdminRequest
    {
        private string _applicationProviderArn;

        /// <summary>
        /// Gets and sets the property ApplicationProviderArn. 
        /// <para>
        /// Specifies the ARN of the application provider for which you want details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string ApplicationProviderArn
        {
            get { return this._applicationProviderArn; }
            set { this._applicationProviderArn = value; }
        }

        // Check to see if ApplicationProviderArn property is set
        internal bool IsSetApplicationProviderArn()
        {
            return this._applicationProviderArn != null;
        }

    }
}