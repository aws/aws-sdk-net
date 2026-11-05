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
    /// A condition that sets which findings from an on-demand AMI scan fail the image. Image
    /// Builder checks the output AMI's findings against this condition during the test phase.
    /// </summary>
    public partial class ScanResultCondition
    {
        /// <summary>
        /// Gets and sets the property FixAvailable. 
        /// <para>
        /// Specifies whether only findings that have a fix available count toward <c>maximumSeverityLabel</c>.
        /// When <c>false</c>, Image Builder counts every finding. The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? FixAvailable { get; set; }

        /// <summary>
        /// Checks to see if the FixAvailable property is set.
        /// </summary>
        internal bool IsSetFixAvailable() => this.FixAvailable.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumSeverityLabel. 
        /// <para>
        /// The maximum severity allowed for findings on the output AMI. A finding above this
        /// severity fails the image, unless <c>fixAvailable</c> excludes it. Valid values are
        /// <c>INFORMATIONAL</c>, <c>LOW</c>, <c>MEDIUM</c>, and <c>HIGH</c>. A <c>CRITICAL</c>
        /// finding that counts always fails the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MaximumSeverityLabel MaximumSeverityLabel { get; set; }

        /// <summary>
        /// Checks to see if the MaximumSeverityLabel property is set.
        /// </summary>
        internal bool IsSetMaximumSeverityLabel() => this.MaximumSeverityLabel != null;
    }
}
