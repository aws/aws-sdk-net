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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceAccessControlAttributeConfiguration operation.
    /// Returns the list of AWS SSO identity store attributes that have been configured to
    /// work with attributes-based access control (ABAC) for the specified AWS SSO instance.
    /// This will not return attributes configured and sent by an external identity provider.
    /// For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
    /// Access Control</a> in the <i>AWS SSO User Guide</i>.
    /// </summary>
    public partial class DescribeInstanceAccessControlAttributeConfigurationRequest : AmazonSSOAdminRequest
    {
        private string _instanceArn;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the SSO instance under which the operation will be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

    }
}