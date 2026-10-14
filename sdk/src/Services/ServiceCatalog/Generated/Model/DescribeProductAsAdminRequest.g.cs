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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeProductAsAdmin operation. Gets information
    /// about the specified product. This operation is run with administrator access.
    /// </summary>
    public partial class DescribeProductAsAdminRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AcceptLanguage property is set.
        /// </summary>
        internal bool IsSetAcceptLanguage() => this.AcceptLanguage != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The product name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SourcePortfolioId. 
        /// <para>
        /// The unique identifier of the shared portfolio that the specified product is associated
        /// with.
        /// </para>
        ///  
        /// <para>
        /// You can provide this parameter to retrieve the shared TagOptions associated with the
        /// product. If this parameter is provided and if TagOptions sharing is enabled in the
        /// portfolio share, the API returns both local and shared TagOptions associated with
        /// the product. Otherwise only local TagOptions will be returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string SourcePortfolioId { get; set; }

        /// <summary>
        /// Checks to see if the SourcePortfolioId property is set.
        /// </summary>
        internal bool IsSetSourcePortfolioId() => this.SourcePortfolioId != null;
    }
}
