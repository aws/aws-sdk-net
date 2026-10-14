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

namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// Container for the parameters to the PutCorsPolicy operation. Sets the cross-origin
    /// resource sharing (CORS) configuration on a container so that the container can service
    /// cross-origin requests. For example, you might want to enable a request whose origin
    /// is http://www.example.com to access your AWS Elemental MediaStore container at my.example.container.com
    /// by using the browser's XMLHttpRequest capability. <para> To enable CORS on a container,
    /// you attach a CORS policy to the container. In the CORS policy, you configure rules
    /// that identify origins and the HTTP methods that can be executed on your container.
    /// The policy can contain up to 398,000 characters. You can add up to 100 rules to a
    /// CORS policy. If more than one rule applies, the service uses the first applicable
    /// rule listed. </para> <para> To learn more about CORS, see <a href="https://docs.aws.amazon.com/mediastore/latest/ug/cors-policy.html">Cross-Origin
    /// Resource Sharing (CORS) in AWS Elemental MediaStore</a>. </para>
    /// </summary>
    public partial class PutCorsPolicyRequest : AmazonMediaStoreRequest
    {
        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container that you want to assign the CORS policy to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ContainerName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerName property is set.
        /// </summary>
        internal bool IsSetContainerName() => this.ContainerName != null;

        /// <summary>
        /// Gets and sets the property CorsPolicy. 
        /// <para>
        /// The CORS policy to apply to the container. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<CorsRule> CorsPolicy { get; set; } = AWSConfigs.InitializeCollections ? new List<CorsRule>() : null;

        /// <summary>
        /// Checks to see if the CorsPolicy property is set.
        /// </summary>
        internal bool IsSetCorsPolicy() => this.CorsPolicy != null && (this.CorsPolicy.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
