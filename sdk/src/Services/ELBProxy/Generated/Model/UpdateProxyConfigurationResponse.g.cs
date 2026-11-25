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
    /// This is the response object from the UpdateProxyConfiguration operation.
    /// </summary>
    public partial class UpdateProxyConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConfigurationMetadata. The configuration metadata for the
        /// proxy after the update.
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfigurationMetadata ConfigurationMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationMetadata property is set.
        /// </summary>
        internal bool IsSetConfigurationMetadata() => this.ConfigurationMetadata != null;

        /// <summary>
        /// Gets and sets the property CustomerKmsKeyArn. The Amazon Resource Name (ARN) of the
        /// customer managed KMS key used to encrypt the proxy's configuration content after the
        /// update. This value is absent when the proxy uses the default service-owned key.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerKmsKeyArn() => this.CustomerKmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property UpdateId. The ID of the update that was submitted.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string UpdateId { get; set; }

        /// <summary>
        /// Checks to see if the UpdateId property is set.
        /// </summary>
        internal bool IsSetUpdateId() => this.UpdateId != null;
    }
}
