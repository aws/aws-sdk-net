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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the indicators that include a set of signals observed in
    /// an attack sequence.
    /// </summary>
    public partial class Indicator
    {
        private IndicatorType _key;
        private string _title;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Specific indicator keys observed in the attack sequence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IndicatorType Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Title describing the indicator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// Values associated with each indicator key. For example, if the indicator key is <c>SUSPICIOUS_NETWORK</c>,
        /// then the value will be the name of the network. If the indicator key is <c>ATTACK_TACTIC</c>,
        /// then the value will be one of the MITRE tactics. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the values associated with the key, see GuardDuty Extended
        /// Threat Detection in the <i>GuardDuty User Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=400)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}