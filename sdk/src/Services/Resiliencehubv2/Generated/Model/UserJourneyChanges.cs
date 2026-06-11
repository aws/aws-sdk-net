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
    /// Describes changes made to a user journey.
    /// </summary>
    public partial class UserJourneyChanges
    {
        private ServiceReferenceChanges _associatedServices;
        private StringChange _journeyDescription;

        /// <summary>
        /// Gets and sets the property AssociatedServices. 
        /// <para>
        /// Changes to the services associated with the user journey.
        /// </para>
        /// </summary>
        public ServiceReferenceChanges AssociatedServices
        {
            get { return this._associatedServices; }
            set { this._associatedServices = value; }
        }

        // Check to see if AssociatedServices property is set
        internal bool IsSetAssociatedServices()
        {
            return this._associatedServices != null;
        }

        /// <summary>
        /// Gets and sets the property JourneyDescription. 
        /// <para>
        /// Changes to the user journey description.
        /// </para>
        /// </summary>
        public StringChange JourneyDescription
        {
            get { return this._journeyDescription; }
            set { this._journeyDescription = value; }
        }

        // Check to see if JourneyDescription property is set
        internal bool IsSetJourneyDescription()
        {
            return this._journeyDescription != null;
        }

    }
}