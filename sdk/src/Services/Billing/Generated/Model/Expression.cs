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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// See <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_billing_Expression.html">Expression</a>.
    /// Billing view only supports <c>LINKED_ACCOUNT</c> and <c>Tags</c>.
    /// </summary>
    public partial class Expression
    {
        private DimensionValues _dimensions;
        private TagValues _tags;
        private TimeRange _timeRange;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        ///  The specific <c>Dimension</c> to use for <c>Expression</c>. 
        /// </para>
        /// </summary>
        public DimensionValues Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The specific <c>Tag</c> to use for <c>Expression</c>. 
        /// </para>
        /// </summary>
        public TagValues Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        ///  Specifies a time range filter for the billing view data. 
        /// </para>
        /// </summary>
        public TimeRange TimeRange
        {
            get { return this._timeRange; }
            set { this._timeRange = value; }
        }

        // Check to see if TimeRange property is set
        internal bool IsSetTimeRange()
        {
            return this._timeRange != null;
        }

    }
}