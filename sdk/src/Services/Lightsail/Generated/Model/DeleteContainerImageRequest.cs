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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
    /// Container for the parameters to the DeleteContainerImage operation.
    /// Deletes a container image that is registered to your Amazon Lightsail container service.
    /// </summary>
    public partial class DeleteContainerImageRequest : AmazonLightsailRequest
    {
        private string _image;
        private string _serviceName;

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
        [AWSProperty(Required=true)]
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the container service for which to delete a registered container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}