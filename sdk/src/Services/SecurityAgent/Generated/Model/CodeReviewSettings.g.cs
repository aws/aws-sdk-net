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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// The code review settings for an agent space, controlling which types of scanning are
    /// enabled.
    /// </summary>
    public partial class CodeReviewSettings
    {
        /// <summary>
        /// Gets and sets the property ControlsScanning. 
        /// <para>
        /// Indicates whether controls scanning is enabled for code reviews.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ControlsScanning { get; set; }

        /// <summary>
        /// Checks to see if the ControlsScanning property is set.
        /// </summary>
        internal bool IsSetControlsScanning() => this.ControlsScanning.HasValue;

        /// <summary>
        /// Gets and sets the property GeneralPurposeScanning. 
        /// <para>
        /// Indicates whether general-purpose scanning is enabled for code reviews.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? GeneralPurposeScanning { get; set; }

        /// <summary>
        /// Checks to see if the GeneralPurposeScanning property is set.
        /// </summary>
        internal bool IsSetGeneralPurposeScanning() => this.GeneralPurposeScanning.HasValue;
    }
}
