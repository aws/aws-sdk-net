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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeProductAsAdmin operation.
    /// Gets information about the specified product. This operation is run with administrator
    /// access.
    /// </summary>
    public partial class DescribeProductAsAdminRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _id;
        private string _name;
        private string _sourcePortfolioId;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>jp</code> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh</code> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=100)]
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The product name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
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
        [AWSProperty(Min=1, Max=100)]
        public string SourcePortfolioId
        {
            get { return this._sourcePortfolioId; }
            set { this._sourcePortfolioId = value; }
        }

        // Check to see if SourcePortfolioId property is set
        internal bool IsSetSourcePortfolioId()
        {
            return this._sourcePortfolioId != null;
        }

    }
}