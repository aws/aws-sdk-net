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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the GetCapacityAssignmentConfiguration operation.
    /// Gets the capacity assignment configuration for a capacity reservation, if one exists.
    /// </summary>
    public partial class GetCapacityAssignmentConfigurationRequest : AmazonAthenaRequest
    {
        private string _capacityReservationName;

        /// <summary>
        /// Gets and sets the property CapacityReservationName. 
        /// <para>
        /// The name of the capacity reservation to retrieve the capacity assignment configuration
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CapacityReservationName
        {
            get { return this._capacityReservationName; }
            set { this._capacityReservationName = value; }
        }

        // Check to see if CapacityReservationName property is set
        internal bool IsSetCapacityReservationName()
        {
            return this._capacityReservationName != null;
        }

    }
}