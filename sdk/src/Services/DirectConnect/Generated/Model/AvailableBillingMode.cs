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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about a billing mode available at an Direct Connect location.
    /// </summary>
    public partial class AvailableBillingMode
    {
        private List<string> _availablePortSpeeds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private BillingMode _billingMode;
        private List<string> _includedRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AvailablePortSpeeds. 
        /// <para>
        /// The port speeds available for the billing mode.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailablePortSpeeds
        {
            get { return this._availablePortSpeeds; }
            set { this._availablePortSpeeds = value; }
        }

        // Check to see if AvailablePortSpeeds property is set
        internal bool IsSetAvailablePortSpeeds()
        {
            return this._availablePortSpeeds != null && (this._availablePortSpeeds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// The billing mode.
        /// </para>
        /// </summary>
        public BillingMode BillingMode
        {
            get { return this._billingMode; }
            set { this._billingMode = value; }
        }

        // Check to see if BillingMode property is set
        internal bool IsSetBillingMode()
        {
            return this._billingMode != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedRegions. 
        /// <para>
        /// The Amazon Web Services Regions included with the billing mode.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IncludedRegions
        {
            get { return this._includedRegions; }
            set { this._includedRegions = value; }
        }

        // Check to see if IncludedRegions property is set
        internal bool IsSetIncludedRegions()
        {
            return this._includedRegions != null && (this._includedRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}