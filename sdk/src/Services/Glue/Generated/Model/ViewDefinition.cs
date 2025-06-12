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
    /// A structure containing details for representations.
    /// </summary>
    public partial class ViewDefinition
    {
        private string _definer;
        private bool? _isProtected;
        private List<ViewRepresentation> _representations = AWSConfigs.InitializeCollections ? new List<ViewRepresentation>() : null;
        private List<string> _subObjects = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Definer. 
        /// <para>
        /// The definer of a view in SQL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Definer
        {
            get { return this._definer; }
            set { this._definer = value; }
        }

        // Check to see if Definer property is set
        internal bool IsSetDefiner()
        {
            return this._definer != null;
        }

        /// <summary>
        /// Gets and sets the property IsProtected. 
        /// <para>
        /// You can set this flag as true to instruct the engine not to push user-provided operations
        /// into the logical plan of the view during query planning. However, setting this flag
        /// does not guarantee that the engine will comply. Refer to the engine's documentation
        /// to understand the guarantees provided, if any.
        /// </para>
        /// </summary>
        public bool? IsProtected
        {
            get { return this._isProtected; }
            set { this._isProtected = value; }
        }

        // Check to see if IsProtected property is set
        internal bool IsSetIsProtected()
        {
            return this._isProtected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Representations. 
        /// <para>
        /// A list of representations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<ViewRepresentation> Representations
        {
            get { return this._representations; }
            set { this._representations = value; }
        }

        // Check to see if Representations property is set
        internal bool IsSetRepresentations()
        {
            return this._representations != null && (this._representations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubObjects. 
        /// <para>
        /// A list of table Amazon Resource Names (ARNs).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> SubObjects
        {
            get { return this._subObjects; }
            set { this._subObjects = value; }
        }

        // Check to see if SubObjects property is set
        internal bool IsSetSubObjects()
        {
            return this._subObjects != null && (this._subObjects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}