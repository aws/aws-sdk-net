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
    /// Specifies one or more severity values and one or more status values that are used
    /// to search for insights.
    /// </summary>
    public partial class SearchInsightsFilters
    {
        private ResourceCollection _resourceCollection;
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