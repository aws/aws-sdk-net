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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
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
    /// Summary of details about the application.
    /// </summary>
    public partial class ApplicationSummary
    {
        private string _applicationId;
        private string _author;
        private string _creationTime;
        private string _description;
        private string _homePageUrl;
        private List<string> _labels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _spdxLicenseId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Author. 
        /// <para>
        /// The name of the author publishing the app.
        /// </para>
        /// 
        /// <para>
        /// Minimum length=1. Maximum length=127.
        /// </para>
        /// 
        /// <para>
        /// Pattern "^[a-z0-9](([a-z0-9]|-(?!-))*[a-z0-9])?$";
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time this resource was created.
        /// </para>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// 
        /// <para>
        /// Minimum length=1. Maximum length=256
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property HomePageUrl. 
        /// <para>
        /// A URL with more information about the application, for example the location of your
        /// GitHub repository for the application.
        /// </para>
        /// </summary>
        public string HomePageUrl
        {
            get { return this._homePageUrl; }
            set { this._homePageUrl = value; }
        }

        // Check to see if HomePageUrl property is set
        internal bool IsSetHomePageUrl()
        {
            return this._homePageUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Labels to improve discovery of apps in search results.
        /// </para>
        /// 
        /// <para>
        /// Minimum length=1. Maximum length=127. Maximum number of labels: 10
        /// </para>
        /// 
        /// <para>
        /// Pattern: "^[a-zA-Z0-9+\\-_:\\/@]+$";
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// 
        /// <para>
        /// Minimum length=1. Maximum length=140
        /// </para>
        /// 
        /// <para>
        /// Pattern: "[a-zA-Z0-9\\-]+";
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SpdxLicenseId. 
        /// <para>
        /// A valid identifier from <a href="https://spdx.org/licenses/">https://spdx.org/licenses/</a>.
        /// </para>
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