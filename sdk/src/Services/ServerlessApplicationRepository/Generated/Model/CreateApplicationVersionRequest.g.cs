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

namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplicationVersion operation. Creates an
    /// application version.
    /// </summary>
    public partial class CreateApplicationVersionRequest : AmazonServerlessApplicationRepositoryRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The semantic version of the new version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SemanticVersion { get; set; }

        /// <summary>
        /// Checks to see if the SemanticVersion property is set.
        /// </summary>
        internal bool IsSetSemanticVersion() => this.SemanticVersion != null;

        /// <summary>
        /// Gets and sets the property SourceCodeArchiveUrl. 
        /// <para>
        /// A link to the S3 object that contains the ZIP archive of the source code for this
        /// version of your application.
        /// </para>
        /// 
        /// <para>
        /// Maximum size 50 MB
        /// </para>
        /// </summary>
        public string SourceCodeArchiveUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceCodeArchiveUrl property is set.
        /// </summary>
        internal bool IsSetSourceCodeArchiveUrl() => this.SourceCodeArchiveUrl != null;

        /// <summary>
        /// Gets and sets the property SourceCodeUrl. 
        /// <para>
        /// A link to a public repository for the source code of your application, for example
        /// the URL of a specific GitHub commit.
        /// </para>
        /// </summary>
        public string SourceCodeUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceCodeUrl property is set.
        /// </summary>
        internal bool IsSetSourceCodeUrl() => this.SourceCodeUrl != null;

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The raw packaged AWS SAM template of your application.
        /// </para>
        /// </summary>
        public string TemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the TemplateBody property is set.
        /// </summary>
        internal bool IsSetTemplateBody() => this.TemplateBody != null;

        /// <summary>
        /// Gets and sets the property TemplateUrl. 
        /// <para>
        /// A link to the packaged AWS SAM template of your application.
        /// </para>
        /// </summary>
        public string TemplateUrl { get; set; }

        /// <summary>
        /// Checks to see if the TemplateUrl property is set.
        /// </summary>
        internal bool IsSetTemplateUrl() => this.TemplateUrl != null;
    }
}
