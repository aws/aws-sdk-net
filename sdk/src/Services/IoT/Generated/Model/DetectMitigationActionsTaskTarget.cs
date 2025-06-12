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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The target of a mitigation action task.
    /// </summary>
    public partial class DetectMitigationActionsTaskTarget
    {
        private string _behaviorName;
        private string _securityProfileName;
        private List<string> _violationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BehaviorName. 
        /// <para>
        ///  The name of the behavior. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BehaviorName
        {
            get { return this._behaviorName; }
            set { this._behaviorName = value; }
        }

        // Check to see if BehaviorName property is set
        internal bool IsSetBehaviorName()
        {
            return this._behaviorName != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        ///  The name of the security profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SecurityProfileName
        {
            get { return this._securityProfileName; }
            set { this._securityProfileName = value; }
        }

        // Check to see if SecurityProfileName property is set
        internal bool IsSetSecurityProfileName()
        {
            return this._securityProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationIds. 
        /// <para>
        ///  The unique identifiers of the violations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> ViolationIds
        {
            get { return this._violationIds; }
            set { this._violationIds = value; }
        }

        // Check to see if ViolationIds property is set
        internal bool IsSetViolationIds()
        {
            return this._violationIds != null && (this._violationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}