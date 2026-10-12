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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnvironmentTemplateVersion operation. Update
    /// a major or minor version of an environment template.
    /// </summary>
    public partial class UpdateEnvironmentTemplateVersionRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of environment template version to update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MajorVersion. 
        /// <para>
        /// To update a major version of an environment template, include <c>major Version</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorVersion property is set.
        /// </summary>
        internal bool IsSetMajorVersion() => this.MajorVersion != null;

        /// <summary>
        /// Gets and sets the property MinorVersion. 
        /// <para>
        /// To update a minor version of an environment template, include <c>minorVersion</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string MinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinorVersion property is set.
        /// </summary>
        internal bool IsSetMinorVersion() => this.MinorVersion != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the environment template minor version to update.
        /// </para>
        /// </summary>
        public TemplateVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the environment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
