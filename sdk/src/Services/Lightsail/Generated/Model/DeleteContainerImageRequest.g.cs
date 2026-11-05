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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteContainerImage operation. Deletes a container
    /// image that is registered to your Amazon Lightsail container service.
    /// </summary>
    public partial class DeleteContainerImageRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The name of the container image to delete from the container service.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetContainerImages</c> action to get the name of the container images that
        /// are registered to a container service.
        /// </para>
        ///  <note> 
        /// <para>
        /// Container images sourced from your Lightsail container service, that are registered
        /// and stored on your service, start with a colon (<c>:</c>). For example, <c>:container-service-1.mystaticwebsite.1</c>.
        /// Container images sourced from a public registry like Docker Hub don't start with a
        /// colon. For example, <c>nginx:latest</c> or <c>nginx</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the container service for which to delete a registered container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;
    }
}
