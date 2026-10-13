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

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// An object that contains the catalog data for a repository. This data is publicly visible
    /// in the Amazon ECR Public Gallery.
    /// </summary>
    public partial class RepositoryCatalogDataInput
    {
        /// <summary>
        /// Gets and sets the property AboutText. 
        /// <para>
        /// A detailed description of the contents of the repository. It's publicly visible in
        /// the Amazon ECR Public Gallery. The text must be in markdown format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 25600)]
        public string AboutText { get; set; }

        /// <summary>
        /// Checks to see if the AboutText property is set.
        /// </summary>
        internal bool IsSetAboutText() => this.AboutText != null;

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
        ///  <c>ARM</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARM 64</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x86</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x86-64</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> Architectures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Architectures property is set.
        /// </summary>
        internal bool IsSetArchitectures() => this.Architectures != null && (this.Architectures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short description of the contents of the repository. This text appears in both the
        /// image details and also when searching for repositories on the Amazon ECR Public Gallery.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        [AWSProperty(Min = 0, Max = 512000)]
        public MemoryStream LogoImageBlob { get; set; }

        /// <summary>
        /// Checks to see if the LogoImageBlob property is set.
        /// </summary>
        internal bool IsSetLogoImageBlob() => this.LogoImageBlob != null;

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
        ///  <c>Linux</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Windows</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> OperatingSystems { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OperatingSystems property is set.
        /// </summary>
        internal bool IsSetOperatingSystems() => this.OperatingSystems != null && (this.OperatingSystems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsageText. 
        /// <para>
        /// Detailed information about how to use the contents of the repository. It's publicly
        /// visible in the Amazon ECR Public Gallery. The usage text provides context, support
        /// information, and additional usage details for users of the repository. The text must
        /// be in markdown format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 25600)]
        public string UsageText { get; set; }

        /// <summary>
        /// Checks to see if the UsageText property is set.
        /// </summary>
        internal bool IsSetUsageText() => this.UsageText != null;
    }
}
