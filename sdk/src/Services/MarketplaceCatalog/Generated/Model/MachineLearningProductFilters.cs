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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// The filters that you can use with the ListEntities operation to filter machine learning
    /// products. You can filter by EntityId, LastModifiedDate, ProductTitle, and Visibility.
    /// </summary>
    public partial class MachineLearningProductFilters
    {
        private MachineLearningProductEntityIdFilter _entityId;
        private MachineLearningProductLastModifiedDateFilter _lastModifiedDate;
        private MachineLearningProductTitleFilter _productTitle;
        private MachineLearningProductVisibilityFilter _visibility;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Filter machine learning products by their entity IDs.
        /// </para>
        /// </summary>
        public MachineLearningProductEntityIdFilter EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Filter machine learning products by their last modified date.
        /// </para>
        /// </summary>
        public MachineLearningProductLastModifiedDateFilter LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property ProductTitle. 
        /// <para>
        /// Filter machine learning products by their product titles.
        /// </para>
        /// </summary>
        public MachineLearningProductTitleFilter ProductTitle
        {
            get { return this._productTitle; }
            set { this._productTitle = value; }
        }

        // Check to see if ProductTitle property is set
        internal bool IsSetProductTitle()
        {
            return this._productTitle != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Filter machine learning products by their visibility status.
        /// </para>
        /// </summary>
        public MachineLearningProductVisibilityFilter Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}