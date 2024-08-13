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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about GuardDuty coverage statistics for members in your Amazon Web Services
    /// organization.
    /// </summary>
    public partial class OrganizationDetails
    {
        private OrganizationStatistics _organizationStatistics;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property OrganizationStatistics. 
        /// <para>
        /// Information about the GuardDuty coverage statistics for members in your Amazon Web
        /// Services organization.
        /// </para>
        /// </summary>
        public OrganizationStatistics OrganizationStatistics
        {
            get { return this._organizationStatistics; }
            set { this._organizationStatistics = value; }
        }

        // Check to see if OrganizationStatistics property is set
        internal bool IsSetOrganizationStatistics()
        {
            return this._organizationStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the organization statistics was last updated. This is in UTC
        /// format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}