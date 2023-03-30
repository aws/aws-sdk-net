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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This returns exactly one type of aggregation, based on the filter that Image Builder
    /// applies in its API action.
    /// </summary>
    public partial class ImageScanFindingAggregation
    {
        private AccountAggregation _accountAggregation;
        private ImageAggregation _imageAggregation;
        private ImagePipelineAggregation _imagePipelineAggregation;
        private VulnerabilityIdAggregation _vulnerabilityIdAggregation;

        /// <summary>
        /// Gets and sets the property AccountAggregation. 
        /// <para>
        /// Returns an object that contains severity counts based on an account ID.
        /// </para>
        /// </summary>
        public AccountAggregation AccountAggregation
        {
            get { return this._accountAggregation; }
            set { this._accountAggregation = value; }
        }

        // Check to see if AccountAggregation property is set
        internal bool IsSetAccountAggregation()
        {
            return this._accountAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property ImageAggregation. 
        /// <para>
        /// Returns an object that contains severity counts based on the Amazon Resource Name
        /// (ARN) for a specific image.
        /// </para>
        /// </summary>
        public ImageAggregation ImageAggregation
        {
            get { return this._imageAggregation; }
            set { this._imageAggregation = value; }
        }

        // Check to see if ImageAggregation property is set
        internal bool IsSetImageAggregation()
        {
            return this._imageAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property ImagePipelineAggregation. 
        /// <para>
        /// Returns an object that contains severity counts based on an image pipeline ARN.
        /// </para>
        /// </summary>
        public ImagePipelineAggregation ImagePipelineAggregation
        {
            get { return this._imagePipelineAggregation; }
            set { this._imagePipelineAggregation = value; }
        }

        // Check to see if ImagePipelineAggregation property is set
        internal bool IsSetImagePipelineAggregation()
        {
            return this._imagePipelineAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property VulnerabilityIdAggregation. 
        /// <para>
        /// Returns an object that contains severity counts based on vulnerability ID.
        /// </para>
        /// </summary>
        public VulnerabilityIdAggregation VulnerabilityIdAggregation
        {
            get { return this._vulnerabilityIdAggregation; }
            set { this._vulnerabilityIdAggregation = value; }
        }

        // Check to see if VulnerabilityIdAggregation property is set
        internal bool IsSetVulnerabilityIdAggregation()
        {
            return this._vulnerabilityIdAggregation != null;
        }

    }
}