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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSdiSource operation. Change some of the
    /// settings in an SdiSource.
    /// </summary>
    public partial class UpdateSdiSourceRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property Mode. Include this parameter only if you want to change
        /// the name of the SdiSource. Specify a name that is unique in the AWS account. We recommend
        /// you assign a name that describes the source, for example curling-cameraA. Names are
        /// case-sensitive.
        /// </summary>
        public SdiSourceMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Name. Include this parameter only if you want to change
        /// the name of the SdiSource. Specify a name that is unique in the AWS account. We recommend
        /// you assign a name that describes the source, for example curling-cameraA. Names are
        /// case-sensitive.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SdiSourceId. The ID of the SdiSource
        /// </summary>
        [AWSProperty(Required = true)]
        public string SdiSourceId { get; set; }

        /// <summary>
        /// Checks to see if the SdiSourceId property is set.
        /// </summary>
        internal bool IsSetSdiSourceId() => this.SdiSourceId != null;

        /// <summary>
        /// Gets and sets the property Type. Include this parameter only if you want to change
        /// the mode. Specify the type of the SDI source: SINGLE: The source is a single-link
        /// source. QUAD: The source is one part of a quad-link source.
        /// </summary>
        public SdiSourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
