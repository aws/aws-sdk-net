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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Specifies a condition for filtering capacity data based on dimension values. Used
    /// to create precise filters for metric queries and dimension lookups.
    /// </summary>
    public partial class DimensionCondition
    {
        private Comparison _comparison;
        private FilterByDimension _dimension;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        ///  The comparison operator to use for the filter. 
        /// </para>
        /// </summary>
        public Comparison Comparison
        {
            get { return this._comparison; }
            set { this._comparison = value; }
        }

        // Check to see if Comparison property is set
        internal bool IsSetComparison()
        {
            return this._comparison != null;
        }

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        ///  The name of the dimension to filter by. 
        /// </para>
        /// </summary>
        public FilterByDimension Dimension
        {
            get { return this._dimension; }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        ///  The list of values to match against the specified dimension. For 'equals' comparison,
        /// only the first value is used. For 'in' comparison, any matching value will satisfy
        /// the condition. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}