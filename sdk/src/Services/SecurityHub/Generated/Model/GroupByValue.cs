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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Represents individual aggregated results when grouping security findings for each
    /// <c>GroupByField</c>.
    /// </summary>
    public partial class GroupByValue
    {
        private int? _count;
        private string _fieldValue;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of findings for a specific <c>FieldValue</c> and <c>GroupByField</c>.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FieldValue. 
        /// <para>
        /// The value of the field by which findings are grouped.
        /// </para>
        /// </summary>
        public string FieldValue
        {
            get { return this._fieldValue; }
            set { this._fieldValue = value; }
        }

        // Check to see if FieldValue property is set
        internal bool IsSetFieldValue()
        {
            return this._fieldValue != null;
        }

    }
}