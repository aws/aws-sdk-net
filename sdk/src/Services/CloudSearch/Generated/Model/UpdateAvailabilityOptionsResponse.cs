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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The result of a <c>UpdateAvailabilityOptions</c> request. Contains the status of the
    /// domain's availability options.
    /// </summary>
    public partial class UpdateAvailabilityOptionsResponse : AmazonWebServiceResponse
    {
        private AvailabilityOptionsStatus _availabilityOptions;

        /// <summary>
        /// Gets and sets the property AvailabilityOptions. 
        /// <para>
        /// The newly-configured availability options. Indicates whether Multi-AZ is enabled for
        /// the domain. 
        /// </para>
        /// </summary>
        public AvailabilityOptionsStatus AvailabilityOptions
        {
            get { return this._availabilityOptions; }
            set { this._availabilityOptions = value; }
        }

        // Check to see if AvailabilityOptions property is set
        internal bool IsSetAvailabilityOptions()
        {
            return this._availabilityOptions != null;
        }

    }
}