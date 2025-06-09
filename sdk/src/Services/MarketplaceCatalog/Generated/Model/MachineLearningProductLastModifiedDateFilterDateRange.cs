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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// A date range for filtering machine learning products by their last modified date.
    /// </summary>
    public partial class MachineLearningProductLastModifiedDateFilterDateRange
    {
        private string _afterValue;
        private string _beforeValue;

        /// <summary>
        /// Gets and sets the property AfterValue. 
        /// <para>
        /// The start date (inclusive) of the date range. The operation returns machine learning
        /// products with last modified dates on or after this date.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string AfterValue
        {
            get { return this._afterValue; }
            set { this._afterValue = value; }
        }

        // Check to see if AfterValue property is set
        internal bool IsSetAfterValue()
        {
            return this._afterValue != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeValue. 
        /// <para>
        /// The end date (inclusive) of the date range. The operation returns machine learning
        /// products with last modified dates on or before this date.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string BeforeValue
        {
            get { return this._beforeValue; }
            set { this._beforeValue = value; }
        }

        // Check to see if BeforeValue property is set
        internal bool IsSetBeforeValue()
        {
            return this._beforeValue != null;
        }

    }
}