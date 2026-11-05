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
    /// Container for the parameters to the RegisterContainerImage operation. Registers a
    /// container image to your Amazon Lightsail container service. <note> <para> This action
    /// is not required if you install and use the Lightsail Control (lightsailctl) plugin
    /// to push container images to your Lightsail container service. For more information,
    /// see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-pushing-container-images">Pushing
    /// and managing container images on your Amazon Lightsail container services</a> in the
    /// <i>Amazon Lightsail Developer Guide</i>. </para> </note>
    /// </summary>
    public partial class RegisterContainerImageRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property Digest. 
        /// <para>
        /// The digest of the container image to be registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Digest { get; set; }

        /// <summary>
        /// Checks to see if the Digest property is set.
        /// </summary>
        internal bool IsSetDigest() => this.Digest != null;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label for the container image when it's registered to the container service.
        /// </para>
        ///  
        /// <para>
        /// Use a descriptive label that you can use to track the different versions of your registered
        /// container images.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetContainerImages</c> action to return the container images registered
        /// to a Lightsail container service. The label is the <c>&lt;imagelabel&gt;</c> portion
        /// of the following image name example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>:container-service-1.&lt;imagelabel&gt;.1</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the name of your container service is <c>mycontainerservice</c>, and the label
        /// that you specify is <c>mystaticwebsite</c>, then the name of the registered container
        /// image will be <c>:mycontainerservice.mystaticwebsite.1</c>.
        /// </para>
        ///  
        /// <para>
        /// The number at the end of these image name examples represents the version of the registered
        /// container image. If you push and register another container image to the same Lightsail
        /// container service, with the same label, then the version number for the new registered
        /// container image will be <c>2</c>. If you push and register another container image,
        /// the version number will be <c>3</c>, and so on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 53)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the container service for which to register a container image.
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
