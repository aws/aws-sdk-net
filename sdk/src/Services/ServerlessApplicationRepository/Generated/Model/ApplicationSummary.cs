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
    /// Summary of details about the application.
    /// </summary>
    public partial class ApplicationSummary
    {
        private string _applicationId;
        private string _author;
        private string _creationTime;
        private string _description;
        private List<string> _labels = new List<string>();
        private string _name;
        private string _spdxLicenseId;

        /// <summary>
        /// Gets and sets the property ApplicationId. The application ARN.
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
        /// Gets and sets the property Author. The name of the author publishing the app\nMin
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
        /// Gets and sets the property CreationTime. The date/time this resource was created.
        /// </summary>
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
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
        /// Gets and sets the property Name. The name of the application.\nMin Length=1. Max Length=140\nPattern:
        /// "[a-zA-Z0-9\\-]+";
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

    }
}