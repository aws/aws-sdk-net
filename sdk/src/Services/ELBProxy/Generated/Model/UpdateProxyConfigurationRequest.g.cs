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
    /// Container for the parameters to the UpdateProxyConfiguration operation. Updates the
    /// configuration for the specified proxy. You can update the configuration file, the
    /// configuration archive, or both.
    /// </summary>
    public partial class UpdateProxyConfigurationRequest : AmazonELBProxyRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationArchive. The updated configuration archive
        /// for the proxy. If you don't specify a value, the existing configuration archive is
        /// unchanged.
        /// </summary>
        public ConfigurationArchive ConfigurationArchive { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationArchive property is set.
        /// </summary>
        internal bool IsSetConfigurationArchive() => this.ConfigurationArchive != null;

        /// <summary>
        /// Gets and sets the property ConfigurationFile. The updated configuration file for the
        /// proxy. If you don't specify a value, the existing configuration file is unchanged.
        /// </summary>
        public ConfigurationFile ConfigurationFile { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationFile property is set.
        /// </summary>
        internal bool IsSetConfigurationFile() => this.ConfigurationFile != null;

        /// <summary>
        /// Gets and sets the property CustomerKmsKeyArn. The Amazon Resource Name (ARN) of the
        /// customer managed KMS key used to encrypt the proxy's configuration content. Specify
        /// a new ARN to set or rotate the key. If you don't specify a value, the existing key
        /// is unchanged.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerKmsKeyArn() => this.CustomerKmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property ProxyIdentifier. The Amazon Resource Name (ARN) of the
        /// proxy.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ProxyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProxyIdentifier property is set.
        /// </summary>
        internal bool IsSetProxyIdentifier() => this.ProxyIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResetConfigurationArchive. Indicates whether to remove
        /// the configuration archive from the proxy.
        /// </summary>
        public bool? ResetConfigurationArchive { get; set; }

        /// <summary>
        /// Checks to see if the ResetConfigurationArchive property is set.
        /// </summary>
        internal bool IsSetResetConfigurationArchive() => this.ResetConfigurationArchive.HasValue;

        /// <summary>
        /// Gets and sets the property ResetCustomerKmsKeyArn. Indicates whether to remove the
        /// customer managed KMS key from the proxy and use the default service-owned key.
        /// </summary>
        public bool? ResetCustomerKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the ResetCustomerKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetResetCustomerKmsKeyArn() => this.ResetCustomerKmsKeyArn.HasValue;
    }
}
