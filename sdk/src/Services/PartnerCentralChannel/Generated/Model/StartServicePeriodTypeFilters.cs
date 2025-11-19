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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Filters specific to start service period handshakes.
    /// </summary>
    public partial class StartServicePeriodTypeFilters
    {
        private List<string> _servicePeriodTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ServicePeriodTypes. 
        /// <para>
        /// Filter by service period types.
        /// </para>
        /// </summary>
        public List<string> ServicePeriodTypes
        {
            get { return this._servicePeriodTypes; }
            set { this._servicePeriodTypes = value; }
        }

        // Check to see if ServicePeriodTypes property is set
        internal bool IsSetServicePeriodTypes()
        {
            return this._servicePeriodTypes != null && (this._servicePeriodTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}