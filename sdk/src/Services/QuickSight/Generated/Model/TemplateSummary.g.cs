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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The template summary.
    /// </summary>
    public partial class TemplateSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// A summary of a template.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The last time that this template was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that this template was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestVersionNumber. 
        /// <para>
        /// A structure containing a list of version numbers for the template summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? LatestVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionNumber property is set.
        /// </summary>
        internal bool IsSetLatestVersionNumber() => this.LatestVersionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID of the template. This ID is unique per Amazon Web Services Region for each
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;
    }
}
