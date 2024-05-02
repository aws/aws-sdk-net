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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A policy that specifies update behavior for the crawler.
    /// </summary>
    public partial class CatalogSchemaChangePolicy
    {
        private bool? _enableUpdateCatalog;
        private UpdateCatalogBehavior _updateBehavior;

        /// <summary>
        /// Gets and sets the property EnableUpdateCatalog. 
        /// <para>
        /// Whether to use the specified update behavior when the crawler finds a changed schema.
        /// </para>
        /// </summary>
        public bool? EnableUpdateCatalog
        {
            get { return this._enableUpdateCatalog; }
            set { this._enableUpdateCatalog = value; }
        }

        // Check to see if EnableUpdateCatalog property is set
        internal bool IsSetEnableUpdateCatalog()
        {
            return this._enableUpdateCatalog.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateBehavior. 
        /// <para>
        /// The update behavior when the crawler finds a changed schema.
        /// </para>
        /// </summary>
        public UpdateCatalogBehavior UpdateBehavior
        {
            get { return this._updateBehavior; }
            set { this._updateBehavior = value; }
        }

        // Check to see if UpdateBehavior property is set
        internal bool IsSetUpdateBehavior()
        {
            return this._updateBehavior != null;
        }

    }
}