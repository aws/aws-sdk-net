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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// The catalog data for a repository. This data is publicly visible in the Amazon ECR
    /// Public Gallery.
    /// </summary>
    public partial class RepositoryCatalogData
    {
        private string _aboutText;
        private List<string> _architectures = new List<string>();
        private string _description;
        private string _logoUrl;
        private bool? _marketplaceCertified;
        private List<string> _operatingSystems = new List<string>();
        private string _usageText;

        /// <summary>
        /// Gets and sets the property AboutText. 
        /// <para>
        /// The longform description of the contents of the repository. This text appears in the
        /// repository details on the Amazon ECR Public Gallery.
        /// </para>
        /// </summary>
        [AWSProperty(Max=25600)]
        public string AboutText
        {
            get { return this._aboutText; }
            set { this._aboutText = value; }
        }

        // Check to see if AboutText property is set
        internal bool IsSetAboutText()
        {
            return this._aboutText != null;
        }

        /// <summary>
        /// Gets and sets the property Architectures. 
        /// <para>
        /// The architecture tags that are associated with the repository.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only supported operating system tags appear publicly in the Amazon ECR Public Gallery.
        /// For more information, see <a>RepositoryCatalogDataInput</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> Architectures
        {
            get { return this._architectures; }
            set { this._architectures = value; }
        }

        // Check to see if Architectures property is set
        internal bool IsSetArchitectures()
        {
            return this._architectures != null && this._architectures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The short description of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property LogoUrl. 
        /// <para>
        /// The URL that contains the logo that's associated with the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string LogoUrl
        {
            get { return this._logoUrl; }
            set { this._logoUrl = value; }
        }

        // Check to see if LogoUrl property is set
        internal bool IsSetLogoUrl()
        {
            return this._logoUrl != null;
        }

        /// <summary>
        /// Gets and sets the property MarketplaceCertified. 
        /// <para>
        /// Indicates whether the repository is certified by Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public bool MarketplaceCertified
        {
            get { return this._marketplaceCertified.GetValueOrDefault(); }
            set { this._marketplaceCertified = value; }
        }

        // Check to see if MarketplaceCertified property is set
        internal bool IsSetMarketplaceCertified()
        {
            return this._marketplaceCertified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperatingSystems. 
        /// <para>
        /// The operating system tags that are associated with the repository.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only supported operating system tags appear publicly in the Amazon ECR Public Gallery.
        /// For more information, see <a>RepositoryCatalogDataInput</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> OperatingSystems
        {
            get { return this._operatingSystems; }
            set { this._operatingSystems = value; }
        }

        // Check to see if OperatingSystems property is set
        internal bool IsSetOperatingSystems()
        {
            return this._operatingSystems != null && this._operatingSystems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UsageText. 
        /// <para>
        /// The longform usage details of the contents of the repository. The usage text provides
        /// context for users of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Max=25600)]
        public string UsageText
        {
            get { return this._usageText; }
            set { this._usageText = value; }
        }

        // Check to see if UsageText property is set
        internal bool IsSetUsageText()
        {
            return this._usageText != null;
        }

    }
}