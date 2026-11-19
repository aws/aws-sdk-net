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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// A reference material that comes with a campaign template: a file the partner downloads
    /// as-is. Not a blueprint: it carries no fields, cannot be instantiated, and is not activated.
    /// Not the `ReferenceMaterial` resource deleted on 2026-09-22 (its six operations, ARN
    /// and record are gone). That was partner-uploaded and addressable; this is AWS-authored
    /// template content with no identity of its own.
    /// </summary>
    public partial class ReferenceMaterial
    {
        /// <summary>
        /// Gets and sets the property Name. The display name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Url. A stable public CDN URL for the file. AWS-authored
        /// content, so it is not presigned and carries no expiry — the same treatment as `LayoutPreview.url`,
        /// and withheld on the same condition: absent while the template's `EffectiveDateBegin`
        /// is in the future.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
