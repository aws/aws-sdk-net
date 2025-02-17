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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Indicates if the access location is restricted. Index correlates to that of an access
    /// point and indicates if access through this point has some form of restriction.
    /// </summary>
    public partial class AccessRestriction
    {
        private List<Category> _categories = AWSConfigs.InitializeCollections ? new List<Category>() : null;
        private bool? _restricted;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// Categories of results that results must belong too.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<Category> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Restricted. 
        /// <para>
        /// The restriction.
        /// </para>
        /// </summary>
        public bool Restricted
        {
            get { return this._restricted.GetValueOrDefault(); }
            set { this._restricted = value; }
        }

        // Check to see if Restricted property is set
        internal bool IsSetRestricted()
        {
            return this._restricted.HasValue; 
        }

    }
}