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
    /// Container for the parameters to the CreateApplication operation. Creates an application,
    /// optionally including an AWS SAM file to create the first application version in the
    /// same call.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonServerlessApplicationRepositoryRequest
    {
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
        [AWSProperty(Required = true)]
        public string Author { get; set; }

        /// <summary>
        /// Checks to see if the Author property is set.
        /// </summary>
        internal bool IsSetAuthor() => this.Author != null;

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
        [AWSProperty(Required = true)]
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
        /// Gets and sets the property LicenseBody. 
        /// <para>
        /// A local text file that contains the license of the app that matches the spdxLicenseID
        /// value of your application. The file has the format file://&lt;path>/&lt;filename>.
        /// </para>
        /// 
        /// <para>
        /// Maximum size 5 MB
        /// </para>
        /// 
        /// <para>
        /// You can specify only one of licenseBody and licenseUrl; otherwise, an error results.
        /// </para>
        /// </summary>
        public string LicenseBody { get; set; }

        /// <summary>
        /// Checks to see if the LicenseBody property is set.
        /// </summary>
        internal bool IsSetLicenseBody() => this.LicenseBody != null;

        /// <summary>
        /// Gets and sets the property LicenseUrl. 
        /// <para>
        /// A link to the S3 object that contains the license of the app that matches the spdxLicenseID
        /// value of your application.
        /// </para>
        /// 
        /// <para>
        /// Maximum size 5 MB
        /// </para>
        /// 
        /// <para>
        /// You can specify only one of licenseBody and licenseUrl; otherwise, an error results.
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
        /// The name of the application that you want to publish.
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
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReadmeBody. 
        /// <para>
        /// A local text readme file in Markdown language that contains a more detailed description
        /// of the application and how it works. The file has the format file://&lt;path>/&lt;filename>.
        /// </para>
        /// 
        /// <para>
        /// Maximum size 5 MB
        /// </para>
        /// 
        /// <para>
        /// You can specify only one of readmeBody and readmeUrl; otherwise, an error results.
        /// </para>
        /// </summary>
        public string ReadmeBody { get; set; }

        /// <summary>
        /// Checks to see if the ReadmeBody property is set.
        /// </summary>
        internal bool IsSetReadmeBody() => this.ReadmeBody != null;

        /// <summary>
        /// Gets and sets the property ReadmeUrl. 
        /// <para>
        /// A link to the S3 object in Markdown language that contains a more detailed description
        /// of the application and how it works.
        /// </para>
        /// 
        /// <para>
        /// Maximum size 5 MB
        /// </para>
        /// 
        /// <para>
        /// You can specify only one of readmeBody and readmeUrl; otherwise, an error results.
        /// </para>
        /// </summary>
        public string ReadmeUrl { get; set; }

        /// <summary>
        /// Checks to see if the ReadmeUrl property is set.
        /// </summary>
        internal bool IsSetReadmeUrl() => this.ReadmeUrl != null;

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The semantic version of the application:
        /// </para>
        /// 
        /// <para>
        ///  <a href="https://semver.org/">https://semver.org/</a> 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SpdxLicenseId. 
        /// <para>
        /// A valid identifier from <a href="https://spdx.org/licenses/">https://spdx.org/licenses/</a>.
        /// </para>
        /// </summary>
        public string SpdxLicenseId { get; set; }

        /// <summary>
        /// Checks to see if the SpdxLicenseId property is set.
        /// </summary>
        internal bool IsSetSpdxLicenseId() => this.SpdxLicenseId != null;

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The local raw packaged AWS SAM template file of your application. The file has the
        /// format file://&lt;path>/&lt;filename>.
        /// </para>
        /// 
        /// <para>
        /// You can specify only one of templateBody and templateUrl; otherwise an error results.
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
        /// A link to the S3 object containing the packaged AWS SAM template of your application.
        /// </para>
        /// 
        /// <para>
        /// You can specify only one of templateBody and templateUrl; otherwise an error results.
        /// </para>
        /// </summary>
        public string TemplateUrl { get; set; }

        /// <summary>
        /// Checks to see if the TemplateUrl property is set.
        /// </summary>
        internal bool IsSetTemplateUrl() => this.TemplateUrl != null;
    }
}
