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

namespace Amazon.ELBProxy.Model
{
    /// <summary>
    /// This is the response object from the GetProxy operation.
    /// </summary>
    public partial class GetProxyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. The Amazon Resource Name (ARN) of the proxy.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationMetadata. The configuration metadata for the
        /// proxy.
        /// </summary>
        public ConfigurationMetadata ConfigurationMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationMetadata property is set.
        /// </summary>
        internal bool IsSetConfigurationMetadata() => this.ConfigurationMetadata != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The date and time that the proxy was created.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerKmsKeyArn. The Amazon Resource Name (ARN) of the
        /// customer managed KMS key used to encrypt the proxy's configuration content. This value
        /// is absent when the proxy uses the default service-owned key.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerKmsKeyArn() => this.CustomerKmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property DnsName. The DNS name of the proxy.
        /// </summary>
        public string DnsName { get; set; }

        /// <summary>
        /// Checks to see if the DnsName property is set.
        /// </summary>
        internal bool IsSetDnsName() => this.DnsName != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the proxy.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. The network configuration for the
        /// proxy.
        /// </summary>
        public ProxyNetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProxyVersion. The version of the proxy software.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ProxyVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProxyVersion property is set.
        /// </summary>
        internal bool IsSetProxyVersion() => this.ProxyVersion != null;

        /// <summary>
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of the IAM role
        /// that provides permissions to the code that your Envoy configuration runs on the proxy,
        /// such as filters and extensions. These are the permissions that this code needs when
        /// it calls AWS services.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. The status of the proxy.
        /// </summary>
        public ProxyStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. The type of proxy.
        /// </summary>
        public ProxyType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
