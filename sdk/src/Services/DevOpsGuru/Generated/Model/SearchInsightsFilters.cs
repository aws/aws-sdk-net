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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Specifies values used to filter responses when searching for insights. You can use
    /// a <code>ResourceCollection</code>, <code>ServiceCollection</code>, array of severities,
    /// and an array of status values. Each filter type contains one or more values to search
    /// for. If you specify multiple filter types, the filter types are joined with an <code>AND</code>,
    /// and the request returns only results that match all of the specified filters.
    /// </summary>
    public partial class SearchInsightsFilters
    {
        private ResourceCollection _resourceCollection;
        private ServiceCollection _serviceCollection;
        private List<string> _severities = new List<string>();
        private List<string> _statuses = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection
        {
            get { return this._resourceCollection; }
            set { this._resourceCollection = value; }
        }

        // Check to see if ResourceCollection property is set
        internal bool IsSetResourceCollection()
        {
            return this._resourceCollection != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCollection. 
        /// <para>
        /// A collection of the names of Amazon Web Services services.
        /// </para>
        /// </summary>
        public ServiceCollection ServiceCollection
        {
            get { return this._serviceCollection; }
            set { this._serviceCollection = value; }
        }

        // Check to see if ServiceCollection property is set
        internal bool IsSetServiceCollection()
        {
            return this._serviceCollection != null;
        }

        /// <summary>
        /// Gets and sets the property Severities. 
        /// <para>
        ///  An array of severity values used to search for insights. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> Severities
        {
            get { return this._severities; }
            set { this._severities = value; }
        }

        // Check to see if Severities property is set
        internal bool IsSetSeverities()
        {
            return this._severities != null && this._severities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        ///  An array of status values used to search for insights. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && this._statuses.Count > 0; 
        }

    }
}