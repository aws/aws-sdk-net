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
    /// Settings for the model sharding technique that's applied by a model optimization job.
    /// </summary>
    public partial class ModelShardingConfig
    {
        private string _image;
        private Dictionary<string, string> _overrideEnvironment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The URI of an LMI DLC in Amazon ECR. SageMaker uses this image to run the optimization.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Gets and sets the property OverrideEnvironment. 
        /// <para>
        /// Environment variables that override the default ones in the model container.
        /// </para>
        /// </summary>
        [AWSProperty(Max=25)]
        public Dictionary<string, string> OverrideEnvironment
        {
            get { return this._overrideEnvironment; }
            set { this._overrideEnvironment = value; }
        }

        // Check to see if OverrideEnvironment property is set
        internal bool IsSetOverrideEnvironment()
        {
            return this._overrideEnvironment != null && (this._overrideEnvironment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}