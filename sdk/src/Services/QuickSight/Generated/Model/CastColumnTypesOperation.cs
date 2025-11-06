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
    /// A transform operation that changes the data types of one or more columns in the dataset.
    /// </summary>
    public partial class CastColumnTypesOperation
    {
        private string _alias;
        private List<CastColumnTypeOperation> _castColumnTypeOperations = AWSConfigs.InitializeCollections ? new List<CastColumnTypeOperation>() : null;
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
        /// Gets and sets the property CastColumnTypeOperations. 
        /// <para>
        /// The list of column type casting operations to perform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public List<CastColumnTypeOperation> CastColumnTypeOperations
        {
            get { return this._castColumnTypeOperations; }
            set { this._castColumnTypeOperations = value; }
        }

        // Check to see if CastColumnTypeOperations property is set
        internal bool IsSetCastColumnTypeOperations()
        {
            return this._castColumnTypeOperations != null && (this._castColumnTypeOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source transform operation that provides input data for the type casting.
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