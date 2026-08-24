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
    /// Framework-specific filters used to scope <c>ListAssessments</c> results. Set exactly
    /// one member, corresponding to the framework you want to filter by.
    /// </summary>
    public partial class FrameworkFilters
    {
        private AMISecurityFilters _amiSecurityFilters;
        private ContainerSecurityFilters _containerSecurityFilters;

        /// <summary>
        /// Gets and sets the property AMISecurityFilters. 
        /// <para>
        /// Filters that apply to assessments performed against the AMI Security framework.
        /// </para>
        /// </summary>
        public AMISecurityFilters AMISecurityFilters
        {
            get { return this._amiSecurityFilters; }
            set { this._amiSecurityFilters = value; }
        }

        // Check to see if AMISecurityFilters property is set
        internal bool IsSetAMISecurityFilters()
        {
            return this._amiSecurityFilters != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerSecurityFilters. 
        /// <para>
        /// Filters that apply to assessments performed against the Container Security framework.
        /// </para>
        /// </summary>
        public ContainerSecurityFilters ContainerSecurityFilters
        {
            get { return this._containerSecurityFilters; }
            set { this._containerSecurityFilters = value; }
        }

        // Check to see if ContainerSecurityFilters property is set
        internal bool IsSetContainerSecurityFilters()
        {
            return this._containerSecurityFilters != null;
        }

    }
}