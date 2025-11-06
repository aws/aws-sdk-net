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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A transform operation that applies one or more filter conditions.
    /// </summary>
    public partial class FiltersOperation
    {
        private string _alias;
        private List<FilterOperation> _filterOperations = AWSConfigs.InitializeCollections ? new List<FilterOperation>() : null;
        private TransformOperationSource _source;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property FilterOperations. 
        /// <para>
        /// The list of filter operations to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public List<FilterOperation> FilterOperations
        {
            get { return this._filterOperations; }
            set { this._filterOperations = value; }
        }

        // Check to see if FilterOperations property is set
        internal bool IsSetFilterOperations()
        {
            return this._filterOperations != null && (this._filterOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source transform operation that provides input data for filtering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformOperationSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}