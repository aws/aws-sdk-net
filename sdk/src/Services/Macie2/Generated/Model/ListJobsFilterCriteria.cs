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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies criteria for filtering the results of a request for information about classification
    /// jobs.
    /// </summary>
    public partial class ListJobsFilterCriteria
    {
        private List<ListJobsFilterTerm> _excludes = AWSConfigs.InitializeCollections ? new List<ListJobsFilterTerm>() : null;
        private List<ListJobsFilterTerm> _includes = AWSConfigs.InitializeCollections ? new List<ListJobsFilterTerm>() : null;

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// An array of objects, one for each condition that determines which jobs to exclude
        /// from the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListJobsFilterTerm> Excludes
        {
            get { return this._excludes; }
            set { this._excludes = value; }
        }

        // Check to see if Excludes property is set
        internal bool IsSetExcludes()
        {
            return this._excludes != null && (this._excludes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// An array of objects, one for each condition that determines which jobs to include
        /// in the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListJobsFilterTerm> Includes
        {
            get { return this._includes; }
            set { this._includes = value; }
        }

        // Check to see if Includes property is set
        internal bool IsSetIncludes()
        {
            return this._includes != null && (this._includes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}