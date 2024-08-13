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
    /// A <c>CategoryInnerFilter</c> filters text values for the <c>NestedFilter</c>.
    /// </summary>
    public partial class CategoryInnerFilter
    {
        private ColumnIdentifier _column;
        private CategoryFilterConfiguration _configuration;
        private DefaultFilterControlConfiguration _defaultFilterControlConfiguration;

        /// <summary>
        /// Gets and sets the property Column.
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration.
        /// </summary>
        [AWSProperty(Required=true)]
        public CategoryFilterConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultFilterControlConfiguration.
        /// </summary>
        public DefaultFilterControlConfiguration DefaultFilterControlConfiguration
        {
            get { return this._defaultFilterControlConfiguration; }
            set { this._defaultFilterControlConfiguration = value; }
        }

        // Check to see if DefaultFilterControlConfiguration property is set
        internal bool IsSetDefaultFilterControlConfiguration()
        {
            return this._defaultFilterControlConfiguration != null;
        }

    }
}