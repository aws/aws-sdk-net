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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Indicates the sorting order of the fields in the metrics.
    /// </summary>
    public partial class Sort
    {
        private bool? _ascending;
        private string _field;

        /// <summary>
        /// Gets and sets the property Ascending. 
        /// <para>
        /// Indicates the name or identifier of the field or attribute that should be used as
        /// the basis for sorting the metrics.
        /// </para>
        /// </summary>
        public bool? Ascending
        {
            get { return this._ascending; }
            set { this._ascending = value; }
        }

        // Check to see if Ascending property is set
        internal bool IsSetAscending()
        {
            return this._ascending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// Indicates the order in which you want to sort the metrics. By default, the list is
        /// sorted in ascending order. To sort the list in descending order, set this field to
        /// False.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

    }
}