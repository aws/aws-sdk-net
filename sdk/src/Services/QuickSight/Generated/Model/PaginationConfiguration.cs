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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The pagination configuration for a table visual or boxplot.
    /// </summary>
    public partial class PaginationConfiguration
    {
        private long? _pageNumber;
        private long? _pageSize;

        /// <summary>
        /// Gets and sets the property PageNumber. 
        /// <para>
        /// Indicates the page number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long PageNumber
        {
            get { return this._pageNumber.GetValueOrDefault(); }
            set { this._pageNumber = value; }
        }

        // Check to see if PageNumber property is set
        internal bool IsSetPageNumber()
        {
            return this._pageNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// Indicates how many items render in one page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

    }
}