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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an exposure finding and the effect the specific remediation
    /// target has on it.
    /// </summary>
    public partial class ExposureFinding
    {
        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The impact resolving a remediation target has on the exposure finding.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Reduces</c> specifies that resolving the remediation target lowers the severity
        /// of the exposure finding, but does not resolve it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Resolves</c> specifies that resolving the remediation target resolves the exposure
        /// finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Unchanged</c> specifies that resolving the remediation target does not change
        /// the severity of the exposure finding.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExposureImpact Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact != null;

        /// <summary>
        /// Gets and sets the property MetadataUid. 
        /// <para>
        /// The unique identifier (ID) of the Security Hub exposure finding, found under the <c>metadata.uid</c>
        /// field of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MetadataUid { get; set; }

        /// <summary>
        /// Checks to see if the MetadataUid property is set.
        /// </summary>
        internal bool IsSetMetadataUid() => this.MetadataUid != null;

        /// <summary>
        /// Gets and sets the property PreviousSeverity. 
        /// <para>
        /// The severity of the exposure finding before the remediation target is resolved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExposureSeverity PreviousSeverity { get; set; }

        /// <summary>
        /// Checks to see if the PreviousSeverity property is set.
        /// </summary>
        internal bool IsSetPreviousSeverity() => this.PreviousSeverity != null;

        /// <summary>
        /// Gets and sets the property ProjectedSeverity. 
        /// <para>
        /// The severity of the exposure finding after the remediation target is resolved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExposureSeverity ProjectedSeverity { get; set; }

        /// <summary>
        /// Checks to see if the ProjectedSeverity property is set.
        /// </summary>
        internal bool IsSetProjectedSeverity() => this.ProjectedSeverity != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the exposure finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
