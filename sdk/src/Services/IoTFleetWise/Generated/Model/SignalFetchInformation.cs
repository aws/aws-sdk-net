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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about the signal to be fetched.
    /// 
    ///  <important> 
    /// <para>
    /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
    /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
    /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
    /// FleetWise Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class SignalFetchInformation
    {
        private List<string> _actions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _conditionLanguageVersion;
        private string _fullyQualifiedName;
        private SignalFetchConfig _signalFetchConfig;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions to be performed by the signal fetch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConditionLanguageVersion. 
        /// <para>
        /// The version of the condition language used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public int? ConditionLanguageVersion
        {
            get { return this._conditionLanguageVersion; }
            set { this._conditionLanguageVersion = value; }
        }

        // Check to see if ConditionLanguageVersion property is set
        internal bool IsSetConditionLanguageVersion()
        {
            return this._conditionLanguageVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullyQualifiedName. 
        /// <para>
        /// The fully qualified name of the signal to be fetched.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public string FullyQualifiedName
        {
            get { return this._fullyQualifiedName; }
            set { this._fullyQualifiedName = value; }
        }

        // Check to see if FullyQualifiedName property is set
        internal bool IsSetFullyQualifiedName()
        {
            return this._fullyQualifiedName != null;
        }

        /// <summary>
        /// Gets and sets the property SignalFetchConfig. 
        /// <para>
        /// The configuration of the signal fetch operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SignalFetchConfig SignalFetchConfig
        {
            get { return this._signalFetchConfig; }
            set { this._signalFetchConfig = value; }
        }

        // Check to see if SignalFetchConfig property is set
        internal bool IsSetSignalFetchConfig()
        {
            return this._signalFetchConfig != null;
        }

    }
}