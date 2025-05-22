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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Gets the Amazon EC2 Container Registry path of the docker image of the model that
    /// is hosted in this <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ProductionVariant.html">ProductionVariant</a>.
    /// 
    ///  
    /// <para>
    /// If you used the <c>registry/repository[:tag]</c> form to specify the image path of
    /// the primary container when you created the model hosted in this <c>ProductionVariant</c>,
    /// the path resolves to a path of the form <c>registry/repository[@digest]</c>. A digest
    /// is a hash value that identifies a specific version of an image. For information about
    /// Amazon ECR paths, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/docker-pull-ecr-image.html">Pulling
    /// an Image</a> in the <i>Amazon ECR User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeployedImage
    {
        private DateTime? _resolutionTime;
        private string _resolvedImage;
        private string _specifiedImage;

        /// <summary>
        /// Gets and sets the property ResolutionTime. 
        /// <para>
        /// The date and time when the image path for the model resolved to the <c>ResolvedImage</c>
        /// 
        /// </para>
        /// </summary>
        public DateTime? ResolutionTime
        {
            get { return this._resolutionTime; }
            set { this._resolutionTime = value; }
        }

        // Check to see if ResolutionTime property is set
        internal bool IsSetResolutionTime()
        {
            return this._resolutionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResolvedImage. 
        /// <para>
        /// The specific digest path of the image hosted in this <c>ProductionVariant</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string ResolvedImage
        {
            get { return this._resolvedImage; }
            set { this._resolvedImage = value; }
        }

        // Check to see if ResolvedImage property is set
        internal bool IsSetResolvedImage()
        {
            return this._resolvedImage != null;
        }

        /// <summary>
        /// Gets and sets the property SpecifiedImage. 
        /// <para>
        /// The image path you specified when you created the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string SpecifiedImage
        {
            get { return this._specifiedImage; }
            set { this._specifiedImage = value; }
        }

        // Check to see if SpecifiedImage property is set
        internal bool IsSetSpecifiedImage()
        {
            return this._specifiedImage != null;
        }

    }
}