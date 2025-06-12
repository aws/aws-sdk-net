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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Information about the gateway's automatic tape creation policies, including the automatic
    /// tape creation rules and the gateway that is using the policies.
    /// </summary>
    public partial class AutomaticTapeCreationPolicyInfo
    {
        private List<AutomaticTapeCreationRule> _automaticTapeCreationRules = AWSConfigs.InitializeCollections ? new List<AutomaticTapeCreationRule>() : null;
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property AutomaticTapeCreationRules. 
        /// <para>
        /// An automatic tape creation policy consists of a list of automatic tape creation rules.
        /// This returns the rules that determine when and how to automatically create new tapes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<AutomaticTapeCreationRule> AutomaticTapeCreationRules
        {
            get { return this._automaticTapeCreationRules; }
            set { this._automaticTapeCreationRules = value; }
        }

        // Check to see if AutomaticTapeCreationRules property is set
        internal bool IsSetAutomaticTapeCreationRules()
        {
            return this._automaticTapeCreationRules != null && (this._automaticTapeCreationRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

    }
}