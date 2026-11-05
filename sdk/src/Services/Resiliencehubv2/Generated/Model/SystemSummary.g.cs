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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains summary information about a system.
    /// </summary>
    public partial class SystemSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the system was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 60)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// Displayed only if caller has access.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property OuId. 
        /// <para>
        /// Displayed only if caller has access.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 68)]
        public string OuId { get; set; }

        /// <summary>
        /// Checks to see if the OuId property is set.
        /// </summary>
        internal bool IsSetOuId() => this.OuId != null;

        /// <summary>
        /// Gets and sets the property ServicesCount. 
        /// <para>
        /// The number of services in the system.
        /// </para>
        /// </summary>
        public int? ServicesCount { get; set; }

        /// <summary>
        /// Checks to see if the ServicesCount property is set.
        /// </summary>
        internal bool IsSetServicesCount() => this.ServicesCount.HasValue;

        /// <summary>
        /// Gets and sets the property SystemArn.
        /// </summary>
        [AWSProperty(Min = 31)]
        public string SystemArn { get; set; }

        /// <summary>
        /// Checks to see if the SystemArn property is set.
        /// </summary>
        internal bool IsSetSystemArn() => this.SystemArn != null;

        /// <summary>
        /// Gets and sets the property SystemId.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SystemId { get; set; }

        /// <summary>
        /// Checks to see if the SystemId property is set.
        /// </summary>
        internal bool IsSetSystemId() => this.SystemId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the system was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UserJourneysCount. 
        /// <para>
        /// The number of user journeys in the system.
        /// </para>
        /// </summary>
        public int? UserJourneysCount { get; set; }

        /// <summary>
        /// Checks to see if the UserJourneysCount property is set.
        /// </summary>
        internal bool IsSetUserJourneysCount() => this.UserJourneysCount.HasValue;
    }
}
