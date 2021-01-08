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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// A set of Docker images that are related by programming language and are managed by
    /// AWS CodeBuild.
    /// </summary>
    public partial class EnvironmentLanguage
    {
        private List<EnvironmentImage> _images = new List<EnvironmentImage>();
        private LanguageType _language;

        /// <summary>
        /// Gets and sets the property Images. 
        /// <para>
        /// The list of Docker images that are related by the specified programming language.
        /// </para>
        /// </summary>
        public List<EnvironmentImage> Images
        {
            get { return this._images; }
            set { this._images = value; }
        }

        // Check to see if Images property is set
        internal bool IsSetImages()
        {
            return this._images != null && this._images.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The programming language for the Docker images.
        /// </para>
        /// </summary>
        public LanguageType Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

    }
}