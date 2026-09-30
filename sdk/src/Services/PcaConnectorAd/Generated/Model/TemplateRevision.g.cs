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

namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// The revision version of the template. Template updates will increment the minor revision.
    /// Re-enrolling all certificate holders will increment the major revision.
    /// </summary>
    public partial class TemplateRevision
    {
        /// <summary>
        /// Gets and sets the property MajorRevision. 
        /// <para>
        /// The revision version of the template. Re-enrolling all certificate holders will increment
        /// the major revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MajorRevision { get; set; }

        /// <summary>
        /// Checks to see if the MajorRevision property is set.
        /// </summary>
        internal bool IsSetMajorRevision() => this.MajorRevision.HasValue;

        /// <summary>
        /// Gets and sets the property MinorRevision. 
        /// <para>
        /// The revision version of the template. Re-enrolling all certificate holders will increment
        /// the major revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MinorRevision { get; set; }

        /// <summary>
        /// Checks to see if the MinorRevision property is set.
        /// </summary>
        internal bool IsSetMinorRevision() => this.MinorRevision.HasValue;
    }
}
