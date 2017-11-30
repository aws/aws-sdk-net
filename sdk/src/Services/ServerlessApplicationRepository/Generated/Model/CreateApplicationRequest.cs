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
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an application, optionally including an AWS SAM file to create the first application
    /// version in the same call.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonServerlessApplicationRepositoryRequest
    {
        private string _author;
        private string _description;
        private List<string> _labels = new List<string>();
        private string _licenseBody;
        private string _licenseUrl;
        private string _name;
        private string _readmeBody;
        private string _readmeUrl;
        private string _semanticVersion;
        private string _sourceCodeUrl;
        private string _spdxLicenseId;
        private string _templateBody;
        private string _templateUrl;

        /// <summary>
        /// Gets and sets the property Author. The name of the author publishing the app.\nMin
        /// Length=1. Max Length=127.\nPattern "^[a-z0-9](([a-z0-9]|-(?!-))*[a-z0-9])?$";
        /// </summary>
        public string Author
        {
            get { return this._author; }
            set { this._author = value; }
        }

        // Check to see if Author property is set
        internal bool IsSetAuthor()
        {
            return this._author != null;
        }

        /// <summary>
        /// Gets and sets the property Description. The description of the application.\nMin Length=1.
        /// Max Length=256
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Labels. Labels to improve discovery of apps in search results.\nMin
        /// Length=1. Max Length=127. Maximum number of labels: 10\nPattern: "^[a-zA-Z0-9+\\-_:\\/@]+$";
        /// </summary>
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && this._labels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LicenseBody. A raw text file that contains the license
        /// of the app that matches the spdxLicenseID of your application.\nMax size 5 MB
        /// </summary>
        public string LicenseBody
        {
            get { return this._licenseBody; }
            set { this._licenseBody = value; }
        }

        // Check to see if LicenseBody property is set
        internal bool IsSetLicenseBody()
        {
            return this._licenseBody != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseUrl. A link to a license file of the app that matches
        /// the spdxLicenseID of your application.\nMax size 5 MB
        /// </summary>
        public string LicenseUrl
        {
            get { return this._licenseUrl; }
            set { this._licenseUrl = value; }
        }

        // Check to see if LicenseUrl property is set
        internal bool IsSetLicenseUrl()
        {
            return this._licenseUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the application you want to publish.\nMin
        /// Length=1. Max Length=140\nPattern: "[a-zA-Z0-9\\-]+";
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ReadmeBody. A raw text Readme file that contains a more
        /// detailed description of the application and how it works in markdown language.\nMax
        /// size 5 MB
        /// </summary>
        public string ReadmeBody
        {
            get { return this._readmeBody; }
            set { this._readmeBody = value; }
        }

        // Check to see if ReadmeBody property is set
        internal bool IsSetReadmeBody()
        {
            return this._readmeBody != null;
        }

        /// <summary>
        /// Gets and sets the property ReadmeUrl. A link to the Readme file that contains a more
        /// detailed description of the application and how it works in markdown language.\nMax
        /// size 5 MB
        /// </summary>
        public string ReadmeUrl
        {
            get { return this._readmeUrl; }
            set { this._readmeUrl = value; }
        }

        // Check to see if ReadmeUrl property is set
        internal bool IsSetReadmeUrl()
        {
            return this._readmeUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SemanticVersion. The semantic version of the application:\n\n
        /// https://semver.org/
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
        /// Gets and sets the property SourceCodeUrl. A link to a public repository for the source
        /// code of your application.
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
        /// Gets and sets the property SpdxLicenseId. A valid identifier from https://spdx.org/licenses/
        /// .
        /// </summary>
        public string SpdxLicenseId
        {
            get { return this._spdxLicenseId; }
            set { this._spdxLicenseId = value; }
        }

        // Check to see if SpdxLicenseId property is set
        internal bool IsSetSpdxLicenseId()
        {
            return this._spdxLicenseId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. The raw packaged SAM template of your application.
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
        /// Gets and sets the property TemplateUrl. A link to the packaged SAM template of your
        /// application.
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