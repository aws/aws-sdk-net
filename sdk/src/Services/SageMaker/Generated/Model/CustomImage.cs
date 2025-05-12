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
    /// A custom SageMaker AI image. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-byoi.html">Bring
    /// your own SageMaker AI image</a>.
    /// </summary>
    public partial class CustomImage
    {
        private string _appImageConfigName;
        private string _imageName;
        private int? _imageVersionNumber;

        /// <summary>
        /// Gets and sets the property AppImageConfigName. 
        /// <para>
        /// The name of the AppImageConfig.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string AppImageConfigName
        {
            get { return this._appImageConfigName; }
            set { this._appImageConfigName = value; }
        }

        // Check to see if AppImageConfigName property is set
        internal bool IsSetAppImageConfigName()
        {
            return this._appImageConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The name of the CustomImage. Must be unique to your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ImageName
        {
            get { return this._imageName; }
            set { this._imageName = value; }
        }

        // Check to see if ImageName property is set
        internal bool IsSetImageName()
        {
            return this._imageName != null;
        }

        /// <summary>
        /// Gets and sets the property ImageVersionNumber. 
        /// <para>
        /// The version number of the CustomImage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ImageVersionNumber
        {
            get { return this._imageVersionNumber; }
            set { this._imageVersionNumber = value; }
        }

        // Check to see if ImageVersionNumber property is set
        internal bool IsSetImageVersionNumber()
        {
            return this._imageVersionNumber.HasValue; 
        }

    }
}