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
    /// Container for the parameters to the CreateInstanceAccessControlAttributeConfiguration operation.
    /// Enables the attributes-based access control (ABAC) feature for the specified AWS SSO
    /// instance. You can also specify new attributes to add to your ABAC configuration during
    /// the enabling process. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
    /// Access Control</a> in the <i>AWS SSO User Guide</i>.
    /// </summary>
    public partial class CreateInstanceAccessControlAttributeConfigurationRequest : AmazonSSOAdminRequest
    {
        private InstanceAccessControlAttributeConfiguration _instanceAccessControlAttributeConfiguration;
        private string _instanceArn;

        /// <summary>
        /// Gets and sets the property InstanceAccessControlAttributeConfiguration. 
        /// <para>
        /// Specifies the AWS SSO identity store attributes to add to your ABAC configuration.
        /// When using an external identity provider as an identity source, you can pass attributes
        /// through the SAML assertion as an alternative to configuring attributes from the AWS
        /// SSO identity store. If a SAML assertion passes any of these attributes, AWS SSO will
        /// replace the attribute value with the value from the AWS SSO identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceAccessControlAttributeConfiguration InstanceAccessControlAttributeConfiguration
        {
            get { return this._instanceAccessControlAttributeConfiguration; }
            set { this._instanceAccessControlAttributeConfiguration = value; }
        }

        // Check to see if InstanceAccessControlAttributeConfiguration property is set
        internal bool IsSetInstanceAccessControlAttributeConfiguration()
        {
            return this._instanceAccessControlAttributeConfiguration != null;
        }

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