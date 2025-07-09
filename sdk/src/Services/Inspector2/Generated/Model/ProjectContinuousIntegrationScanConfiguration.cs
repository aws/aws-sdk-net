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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains the continuous integration scan configuration settings applied to a specific
    /// project.
    /// </summary>
    public partial class ProjectContinuousIntegrationScanConfiguration
    {
        private List<string> _ruleSetCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ContinuousIntegrationScanEvent _supportedEvent;

        /// <summary>
        /// Gets and sets the property RuleSetCategories. 
        /// <para>
        /// The categories of security rules applied during continuous integration scans for the
        /// project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> RuleSetCategories
        {
            get { return this._ruleSetCategories; }
            set { this._ruleSetCategories = value; }
        }

        // Check to see if RuleSetCategories property is set
        internal bool IsSetRuleSetCategories()
        {
            return this._ruleSetCategories != null && (this._ruleSetCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedEvent. 
        /// <para>
        /// The repository event that triggers continuous integration scans for the project.
        /// </para>
        /// </summary>
        public ContinuousIntegrationScanEvent SupportedEvent
        {
            get { return this._supportedEvent; }
            set { this._supportedEvent = value; }
        }

        // Check to see if SupportedEvent property is set
        internal bool IsSetSupportedEvent()
        {
            return this._supportedEvent != null;
        }

    }
}