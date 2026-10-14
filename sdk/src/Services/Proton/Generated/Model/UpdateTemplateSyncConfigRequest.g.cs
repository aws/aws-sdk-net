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
    /// Container for the parameters to the UpdateTemplateSyncConfig operation. Update template
    /// sync configuration parameters, except for the <c>templateName</c> and <c>templateType</c>.
    /// Repository details (branch, name, and provider) should be of a linked repository.
    /// A linked repository is a repository that has been registered with Proton. For more
    /// information, see <a>CreateRepository</a>.
    /// </summary>
    public partial class UpdateTemplateSyncConfigRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The repository branch for your template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name (for example, <c>myrepos/myrepo</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property RepositoryProvider. 
        /// <para>
        /// The repository provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RepositoryProvider RepositoryProvider { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryProvider property is set.
        /// </summary>
        internal bool IsSetRepositoryProvider() => this.RepositoryProvider != null;

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// A subdirectory path to your template bundle version. When included, limits the template
        /// bundle search to this repository directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Subdirectory { get; set; }

        /// <summary>
        /// Checks to see if the Subdirectory property is set.
        /// </summary>
        internal bool IsSetSubdirectory() => this.Subdirectory != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The synced template name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The synced template type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TemplateType TemplateType { get; set; }

        /// <summary>
        /// Checks to see if the TemplateType property is set.
        /// </summary>
        internal bool IsSetTemplateType() => this.TemplateType != null;
    }
}
