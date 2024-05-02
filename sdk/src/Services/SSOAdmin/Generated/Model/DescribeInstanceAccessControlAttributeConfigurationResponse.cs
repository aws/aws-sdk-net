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
    /// This is the response object from the DescribeInstanceAccessControlAttributeConfiguration operation.
    /// </summary>
    public partial class DescribeInstanceAccessControlAttributeConfigurationResponse : AmazonWebServiceResponse
    {
        private InstanceAccessControlAttributeConfiguration _instanceAccessControlAttributeConfiguration;
        private InstanceAccessControlAttributeConfigurationStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property InstanceAccessControlAttributeConfiguration. 
        /// <para>
        /// Gets the list of IAM Identity Center identity store attributes that have been added
        /// to your ABAC configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the attribute configuration process.
        /// </para>
        /// </summary>
        public InstanceAccessControlAttributeConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Provides more details about the current status of the specified attribute.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}