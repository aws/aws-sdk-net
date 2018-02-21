/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplicationVersion operation.
    /// Creates an application version.
    /// </summary>
    public partial class CreateApplicationVersionRequest : AmazonServerlessApplicationRepositoryRequest
    {
        private string _applicationId;
        private string _semanticVersion;
        private string _sourceCodeUrl;
        private string _templateBody;
        private string _templateUrl;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application to get.
        /// </para>
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The semantic version of the new version.
        /// </para>
        /// </summary>
        public string SemanticVersion
        {
            get { return this._semanticVersion; }
            set { this._semanticVersion = value; }
        }

        // Check to see if SemanticVersion property is set
        internal bool IsSetSemanticVersion()
        {
            return this._semanticVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCodeUrl. 
        /// <para>
        /// A link to a public repository for the source code of your application.
        /// </para>
        /// </summary>
        public string SourceCodeUrl
        {
            get { return this._sourceCodeUrl; }
            set { this._sourceCodeUrl = value; }
        }

        // Check to see if SourceCodeUrl property is set
        internal bool IsSetSourceCodeUrl()
        {
            return this._sourceCodeUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The raw packaged AWS SAM template of your application.
        /// </para>
        /// </summary>
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateUrl. 
        /// <para>
        /// A link to the packaged AWS SAM template of your application.
        /// </para>
        /// </summary>
        public string TemplateUrl
        {
            get { return this._templateUrl; }
            set { this._templateUrl = value; }
        }

        // Check to see if TemplateUrl property is set
        internal bool IsSetTemplateUrl()
        {
            return this._templateUrl != null;
        }

    }
}