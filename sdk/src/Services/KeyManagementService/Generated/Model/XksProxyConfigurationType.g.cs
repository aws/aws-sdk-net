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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Detailed information about the external key store proxy (XKS proxy). Your external
    /// key store proxy translates KMS requests into a format that your external key manager
    /// can understand. These fields appear in a <a>DescribeCustomKeyStores</a> response only
    /// when the <c>CustomKeyStoreType</c> is <c>EXTERNAL_KEY_STORE</c>.
    /// </summary>
    public partial class XksProxyConfigurationType
    {
        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The part of the external key store <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateCustomKeyStore.html#KMS-CreateCustomKeyStore-request-XksProxyAuthenticationCredential">proxy
        /// authentication credential</a> that uniquely identifies the secret access key.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 20, Max = 30)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AccessKeyId property is set.
        /// </summary>
        internal bool IsSetAccessKeyId() => this.AccessKeyId != null;

        /// <summary>
        /// Gets and sets the property Connectivity. 
        /// <para>
        /// Indicates whether the external key store proxy uses a public endpoint or an Amazon
        /// VPC endpoint service to communicate with KMS.
        /// </para>
        /// </summary>
        public XksProxyConnectivityType Connectivity { get; set; }

        /// <summary>
        /// Checks to see if the Connectivity property is set.
        /// </summary>
        internal bool IsSetConnectivity() => this.Connectivity != null;

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
        [AWSProperty(Min = 10, Max = 128)]
        public string UriEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UriEndpoint property is set.
        /// </summary>
        internal bool IsSetUriEndpoint() => this.UriEndpoint != null;

        /// <summary>
        /// Gets and sets the property UriPath. 
        /// <para>
        /// The path to the external key store proxy APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 128)]
        public string UriPath { get; set; }

        /// <summary>
        /// Checks to see if the UriPath property is set.
        /// </summary>
        internal bool IsSetUriPath() => this.UriPath != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointServiceName. 
        /// <para>
        /// The Amazon VPC endpoint service used to communicate with the external key store proxy.
        /// This field appears only when the external key store proxy uses an Amazon VPC endpoint
        /// service to communicate with KMS.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 64)]
        public string VpcEndpointServiceName { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointServiceName property is set.
        /// </summary>
        internal bool IsSetVpcEndpointServiceName() => this.VpcEndpointServiceName != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointServiceOwner. 
        /// <para>
        /// The Amazon Web Services account ID that owns the Amazon VPC endpoint service used
        /// to communicate with the external key store proxy (XKS). This field appears only when
        /// the XKS uses an VPC endpoint service to communicate with KMS.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string VpcEndpointServiceOwner { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointServiceOwner property is set.
        /// </summary>
        internal bool IsSetVpcEndpointServiceOwner() => this.VpcEndpointServiceOwner != null;
    }
}
