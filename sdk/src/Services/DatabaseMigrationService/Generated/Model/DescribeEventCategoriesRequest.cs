/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEventCategories operation.
    /// Lists categories for all event source types, or, if specified, for a specified source
    /// type. You can see a list of the event categories and source types in <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">
    /// Working with Events and Notifications </a> in the AWS Database Migration Service User
    /// Guide.
    /// </summary>
    public partial class DescribeEventCategoriesRequest : AmazonDatabaseMigrationServiceRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private string _sourceType;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters applied to the action.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        ///  The type of AWS DMS resource that generates events. 
        /// </para>
        ///  
        /// <para>
        /// Valid values: replication-instance | migration-task
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}