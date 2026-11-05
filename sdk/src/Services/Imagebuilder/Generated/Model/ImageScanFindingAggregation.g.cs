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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This returns exactly one type of aggregation, based on the filter that Image Builder
    /// applies in its API action.
    /// </summary>
    public partial class ImageScanFindingAggregation
    {
        /// <summary>
        /// Gets and sets the property AccountAggregation. 
        /// <para>
        /// Returns an object that contains severity counts based on an account ID.
        /// </para>
        /// </summary>
        public AccountAggregation AccountAggregation { get; set; }

        /// <summary>
        /// Checks to see if the AccountAggregation property is set.
        /// </summary>
        internal bool IsSetAccountAggregation() => this.AccountAggregation != null;

        /// <summary>
        /// Gets and sets the property ImageAggregation. 
        /// <para>
        /// Returns an object that contains severity counts based on the Amazon Resource Name
        /// (ARN) for a specific image.
        /// </para>
        /// </summary>
        public ImageAggregation ImageAggregation { get; set; }

        /// <summary>
        /// Checks to see if the ImageAggregation property is set.
        /// </summary>
        internal bool IsSetImageAggregation() => this.ImageAggregation != null;

        /// <summary>
        /// Gets and sets the property ImagePipelineAggregation. 
        /// <para>
        /// Returns an object that contains severity counts based on an image pipeline ARN.
        /// </para>
        /// </summary>
        public ImagePipelineAggregation ImagePipelineAggregation { get; set; }

        /// <summary>
        /// Checks to see if the ImagePipelineAggregation property is set.
        /// </summary>
        internal bool IsSetImagePipelineAggregation() => this.ImagePipelineAggregation != null;

        /// <summary>
        /// Gets and sets the property VulnerabilityIdAggregation. 
        /// <para>
        /// Returns an object that contains severity counts based on vulnerability ID.
        /// </para>
        /// </summary>
        public VulnerabilityIdAggregation VulnerabilityIdAggregation { get; set; }

        /// <summary>
        /// Checks to see if the VulnerabilityIdAggregation property is set.
        /// </summary>
        internal bool IsSetVulnerabilityIdAggregation() => this.VulnerabilityIdAggregation != null;
    }
}
