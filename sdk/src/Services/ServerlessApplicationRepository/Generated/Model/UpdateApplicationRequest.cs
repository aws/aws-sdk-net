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
    /// Container for the parameters to the UpdateApplication operation.
    /// Updates the specified application.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonServerlessApplicationRepositoryRequest
    {
        private string _applicationId;
        private string _author;
        private string _description;
        private string _homePageUrl;
        private List<string> _labels = new List<string>();
        private string _readmeBody;
        private string _readmeUrl;

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
        /// Gets and sets the property Author. 
        /// <para>
        /// The name of the author publishing the app.
        /// </para>
        /// 
        /// <para>
        /// Min Length=1. Max Length=127.
        /// </para>
        /// 
        /// <para>
        /// Pattern "^[a-z0-9](([a-z0-9]|-(?!-))*[a-z0-9])?$";
        /// </para>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// 
        /// <para>
        /// Min Length=1. Max Length=256
        /// </para>
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
        /// Min Length=1. Max Length=127. Maximum number of labels: 10
        /// </para>
        /// 
        /// <para>
        /// Pattern: "^[a-zA-Z0-9+\\-_:\\/@]+$";
        /// </para>
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
        /// Gets and sets the property ReadmeBody. 
        /// <para>
        /// A raw text Readme file that contains a more detailed description of the application
        /// and how it works in markdown language.
        /// </para>
        /// 
        /// <para>
        /// Max size 5 MB
        /// </para>
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
        /// Gets and sets the property ReadmeUrl. 
        /// <para>
        /// A link to the Readme file that contains a more detailed description of the application
        /// and how it works in markdown language.
        /// </para>
        /// 
        /// <para>
        /// Max size 5 MB
        /// </para>
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

    }
}