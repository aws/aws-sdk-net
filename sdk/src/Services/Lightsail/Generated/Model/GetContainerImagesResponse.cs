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
    /// This is the response object from the GetContainerImages operation.
    /// </summary>
    public partial class GetContainerImagesResponse : AmazonWebServiceResponse
    {
        private List<ContainerImage> _containerImages = AWSConfigs.InitializeCollections ? new List<ContainerImage>() : null;

        /// <summary>
        /// Gets and sets the property ContainerImages. 
        /// <para>
        /// An array of objects that describe container images that are registered to the container
        /// service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerImage> ContainerImages
        {
            get { return this._containerImages; }
            set { this._containerImages = value; }
        }

        // Check to see if ContainerImages property is set
        internal bool IsSetContainerImages()
        {
            return this._containerImages != null && (this._containerImages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}