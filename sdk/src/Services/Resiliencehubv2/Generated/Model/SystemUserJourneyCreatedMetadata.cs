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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
    /// Metadata for a system user journey created event.
    /// </summary>
    public partial class SystemUserJourneyCreatedMetadata
    {
        private List<ServiceReference> _associatedServices = AWSConfigs.InitializeCollections ? new List<ServiceReference>() : null;
        private string _userJourneyName;

        /// <summary>
        /// Gets and sets the property AssociatedServices. 
        /// <para>
        /// The services associated with the created user journey.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceReference> AssociatedServices
        {
            get { return this._associatedServices; }
            set { this._associatedServices = value; }
        }

        // Check to see if AssociatedServices property is set
        internal bool IsSetAssociatedServices()
        {
            return this._associatedServices != null && (this._associatedServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserJourneyName. 
        /// <para>
        /// The name of the created user journey.
        /// </para>
        /// </summary>
        public string UserJourneyName
        {
            get { return this._userJourneyName; }
            set { this._userJourneyName = value; }
        }

        // Check to see if UserJourneyName property is set
        internal bool IsSetUserJourneyName()
        {
            return this._userJourneyName != null;
        }

    }
}