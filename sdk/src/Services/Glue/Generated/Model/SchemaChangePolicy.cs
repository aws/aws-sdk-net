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
    /// A policy that specifies update and deletion behaviors for the crawler.
    /// </summary>
    public partial class SchemaChangePolicy
    {
        private DeleteBehavior _deleteBehavior;
        private UpdateBehavior _updateBehavior;

        /// <summary>
        /// Gets and sets the property DeleteBehavior. 
        /// <para>
        /// The deletion behavior when the crawler finds a deleted object.
        /// </para>
        /// </summary>
        public DeleteBehavior DeleteBehavior
        {
            get { return this._deleteBehavior; }
            set { this._deleteBehavior = value; }
        }

        // Check to see if DeleteBehavior property is set
        internal bool IsSetDeleteBehavior()
        {
            return this._deleteBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateBehavior. 
        /// <para>
        /// The update behavior when the crawler finds a changed schema.
        /// </para>
        /// </summary>
        public UpdateBehavior UpdateBehavior
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