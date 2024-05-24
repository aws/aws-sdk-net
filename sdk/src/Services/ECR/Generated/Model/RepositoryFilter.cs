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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// The filter settings used with image replication. Specifying a repository filter to
    /// a replication rule provides a method for controlling which repositories in a private
    /// registry are replicated. If no filters are added, the contents of all repositories
    /// are replicated.
    /// </summary>
    public partial class RepositoryFilter
    {
        private string _filter;
        private RepositoryFilterType _filterType;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The repository filter details. When the <c>PREFIX_MATCH</c> filter type is specified,
        /// this value is required and should be the repository name prefix to configure replication
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=256)]
        public string Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The repository filter type. The only supported value is <c>PREFIX_MATCH</c>, which
        /// is a repository name prefix specified with the <c>filter</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RepositoryFilterType FilterType
        {
            get { return this._filterType; }
            set { this._filterType = value; }
        }

        // Check to see if FilterType property is set
        internal bool IsSetFilterType()
        {
            return this._filterType != null;
        }

    }
}