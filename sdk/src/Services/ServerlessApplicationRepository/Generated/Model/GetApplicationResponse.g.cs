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
    /// This is the response object from the GetApplication operation.
    /// </summary>
    public partial class GetApplicationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

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
        public string Author { get; set; }

        /// <summary>
        /// Checks to see if the Author property is set.
        /// </summary>
        internal bool IsSetAuthor() => this.Author != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time this resource was created.
        /// </para>
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

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
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HomePageUrl. 
        /// <para>
        /// A URL with more information about the application, for example the location of your
        /// GitHub repository for the application.
        /// </para>
        /// </summary>
        public string HomePageUrl { get; set; }

        /// <summary>
        /// Checks to see if the HomePageUrl property is set.
        /// </summary>
        internal bool IsSetHomePageUrl() => this.HomePageUrl != null;

        /// <summary>
        /// Gets and sets the property IsVerifiedAuthor. 
        /// <para>
        /// Whether the author of this application has been verified. This means means that AWS
        /// has made a good faith review, as a reasonable and prudent service provider, of the
        /// information provided by the requester and has confirmed that the requester's identity
        /// is as claimed.
        /// </para>
        /// </summary>
        public bool? IsVerifiedAuthor { get; set; }

        /// <summary>
        /// Checks to see if the IsVerifiedAuthor property is set.
        /// </summary>
        internal bool IsSetIsVerifiedAuthor() => this.IsVerifiedAuthor.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Labels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LicenseUrl. 
        /// <para>
        /// A link to a license file of the app that matches the spdxLicenseID value of your application.
        /// </para>
        /// 
        /// <para>
        /// Maximum size 5 MB
        /// </para>
        /// </summary>
        public string LicenseUrl { get; set; }

        /// <summary>
        /// Checks to see if the LicenseUrl property is set.
        /// </summary>
        internal bool IsSetLicenseUrl() => this.LicenseUrl != null;

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
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReadmeUrl. 
        /// <para>
        /// A link to the readme file in Markdown language that contains a more detailed description
        /// of the application and how it works.
        /// </para>
        /// 
        /// <para>
        /// Maximum size 5 MB
        /// </para>
        /// </summary>
        public string ReadmeUrl { get; set; }

        /// <summary>
        /// Checks to see if the ReadmeUrl property is set.
        /// </summary>
        internal bool IsSetReadmeUrl() => this.ReadmeUrl != null;

        /// <summary>
        /// Gets and sets the property SpdxLicenseId. 
        /// <para>
        /// A valid identifier from https://spdx.org/licenses/.
        /// </para>
        /// </summary>
        public string SpdxLicenseId { get; set; }

        /// <summary>
        /// Checks to see if the SpdxLicenseId property is set.
        /// </summary>
        internal bool IsSetSpdxLicenseId() => this.SpdxLicenseId != null;

        /// <summary>
        /// Gets and sets the property VerifiedAuthorUrl. 
        /// <para>
        /// The URL to the public profile of a verified author. This URL is submitted by the author.
        /// </para>
        /// </summary>
        public string VerifiedAuthorUrl { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAuthorUrl property is set.
        /// </summary>
        internal bool IsSetVerifiedAuthorUrl() => this.VerifiedAuthorUrl != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version information about the application.
        /// </para>
        /// </summary>
        public Version Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
