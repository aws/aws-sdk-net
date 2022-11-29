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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Detailed information about the external key store proxy (XKS proxy). Your external
    /// key store proxy translates KMS requests into a format that your external key manager
    /// can understand. These fields appear in a <a>DescribeCustomKeyStores</a> response only
    /// when the <code>CustomKeyStoreType</code> is <code>EXTERNAL_KEY_STORE</code>.
    /// </summary>
    public partial class XksProxyConfigurationType
    {
        private string _accessKeyId;
        private XksProxyConnectivityType _connectivity;
        private string _uriEndpoint;
        private string _uriPath;
        private string _vpcEndpointServiceName;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The part of the external key store <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateCustomKeyStore.html#KMS-CreateCustomKeyStore-request-XksProxyAuthenticationCredential">proxy
        /// authentication credential</a> that uniquely identifies the secret access key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=30)]
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Connectivity. 
        /// <para>
        /// Indicates whether the external key store proxy uses a public endpoint or an Amazon
        /// VPC endpoint service to communicate with KMS.
        /// </para>
        /// </summary>
        public XksProxyConnectivityType Connectivity
        {
            get { return this._connectivity; }
            set { this._connectivity = value; }
        }

        // Check to see if Connectivity property is set
        internal bool IsSetConnectivity()
        {
            return this._connectivity != null;
        }

        /// <summary>
        /// Gets and sets the property UriEndpoint. 
        /// <para>
        /// The URI endpoint for the external key store proxy.
        /// </para>
        ///  
        /// <para>
        /// If the external key store proxy has a public endpoint, it is displayed here.
        /// </para>
        ///  
        /// <para>
        /// If the external key store proxy uses an Amazon VPC endpoint service name, this field
        /// displays the private DNS name associated with the VPC endpoint service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=128)]
        public string UriEndpoint
        {
            get { return this._uriEndpoint; }
            set { this._uriEndpoint = value; }
        }

        // Check to see if UriEndpoint property is set
        internal bool IsSetUriEndpoint()
        {
            return this._uriEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property UriPath. 
        /// <para>
        /// The path to the external key store proxy APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=128)]
        public string UriPath
        {
            get { return this._uriPath; }
            set { this._uriPath = value; }
        }

        // Check to see if UriPath property is set
        internal bool IsSetUriPath()
        {
            return this._uriPath != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointServiceName. 
        /// <para>
        /// The Amazon VPC endpoint service used to communicate with the external key store proxy.
        /// This field appears only when the external key store proxy uses an Amazon VPC endpoint
        /// service to communicate with KMS.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=64)]
        public string VpcEndpointServiceName
        {
            get { return this._vpcEndpointServiceName; }
            set { this._vpcEndpointServiceName = value; }
        }

        // Check to see if VpcEndpointServiceName property is set
        internal bool IsSetVpcEndpointServiceName()
        {
            return this._vpcEndpointServiceName != null;
        }

    }
}