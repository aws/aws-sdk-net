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
    /// Configure image tests for your pipeline build. Tests run after building the image,
    /// to verify that the AMI or container image is valid before distributing it.
    /// </summary>
    public partial class ImageTestsConfiguration
    {
        /// <summary>
        /// Gets and sets the property ImageTestsEnabled. 
        /// <para>
        /// Specifies whether tests run after building the image. When enabled, tests run after
        /// the image build and before image distribution. Defaults to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? ImageTestsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ImageTestsEnabled property is set.
        /// </summary>
        internal bool IsSetImageTestsEnabled() => this.ImageTestsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The maximum time in minutes that tests are permitted to run. If you don't specify
        /// a value, Image Builder stores and returns 720.
        /// </para>
        ///  <note> 
        /// <para>
        /// The timeout property is not currently active. This value is ignored.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 60, Max = 1440)]
        public int? TimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutMinutes() => this.TimeoutMinutes.HasValue;
    }
}
