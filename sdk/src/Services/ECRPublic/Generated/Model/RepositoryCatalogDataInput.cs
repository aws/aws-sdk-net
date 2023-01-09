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
    /// An object that contains the catalog data for a repository. This data is publicly visible
    /// in the Amazon ECR Public Gallery.
    /// </summary>
    public partial class RepositoryCatalogDataInput
    {
        private string _aboutText;
        private List<string> _architectures = new List<string>();
        private string _description;
        private MemoryStream _logoImageBlob;
        private List<string> _operatingSystems = new List<string>();
        private string _usageText;

        /// <summary>
        /// Gets and sets the property AboutText. 
        /// <para>
        /// A detailed description of the contents of the repository. It's publicly visible in
        /// the Amazon ECR Public Gallery. The text must be in markdown format.
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
        /// The system architecture that the images in the repository are compatible with. On
        /// the Amazon ECR Public Gallery, the following supported architectures appear as badges
        /// on the repository and are used as search filters.
        /// </para>
        ///  <note> 
        /// <para>
        /// If an unsupported tag is added to your repository catalog data, it's associated with
        /// the repository and can be retrieved using the API but isn't discoverable in the Amazon
        /// ECR Public Gallery.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <code>ARM</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ARM 64</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x86</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x86-64</code> 
        /// </para>
        ///  </li> </ul>
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
        /// A short description of the contents of the repository. This text appears in both the
        /// image details and also when searching for repositories on the Amazon ECR Public Gallery.
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
        /// Gets and sets the property LogoImageBlob. 
        /// <para>
        /// The base64-encoded repository logo payload.
        /// </para>
        ///  <note> 
        /// <para>
        /// The repository logo is only publicly visible in the Amazon ECR Public Gallery for
        /// verified accounts.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=512000)]
        public MemoryStream LogoImageBlob
        {
            get { return this._logoImageBlob; }
            set { this._logoImageBlob = value; }
        }

        // Check to see if LogoImageBlob property is set
        internal bool IsSetLogoImageBlob()
        {
            return this._logoImageBlob != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystems. 
        /// <para>
        /// The operating systems that the images in the repository are compatible with. On the
        /// Amazon ECR Public Gallery, the following supported operating systems appear as badges
        /// on the repository and are used as search filters.
        /// </para>
        ///  <note> 
        /// <para>
        /// If an unsupported tag is added to your repository catalog data, it's associated with
        /// the repository and can be retrieved using the API but isn't discoverable in the Amazon
        /// ECR Public Gallery.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <code>Linux</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Windows</code> 
        /// </para>
        ///  </li> </ul>
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
        /// Detailed information about how to use the contents of the repository. It's publicly
        /// visible in the Amazon ECR Public Gallery. The usage text provides context, support
        /// information, and additional usage details for users of the repository. The text must
        /// be in markdown format.
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