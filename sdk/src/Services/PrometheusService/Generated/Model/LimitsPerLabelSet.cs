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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// This structure defines one label set used to enforce active time series limits for
    /// the workspace, and defines the limit for that label set.
    /// 
    ///  
    /// <para>
    /// A label set is a unique combination of label-value pairs. Use them to control time
    /// series limits and to monitor usage by specific label groups. Example label sets might
    /// be <c>team:finance</c> or <c>env:prod</c> 
    /// </para>
    /// </summary>
    public partial class LimitsPerLabelSet
    {
        private Dictionary<string, string> _labelSet = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private LimitsPerLabelSetEntry _limits;

        /// <summary>
        /// Gets and sets the property LabelSet. 
        /// <para>
        /// This defines one label set that will have an enforced active time series limit. 
        /// </para>
        ///  
        /// <para>
        /// Label values accept ASCII characters and must contain at least one character that
        /// isn't whitespace. ASCII control characters are not accepted. If the label name is
        /// metric name label <c>__<i>name</i>__</c>, then the <i>metric</i> part of the name
        /// must conform to the following pattern: <c>[a-zA-Z_:][a-zA-Z0-9_:]*</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> LabelSet
        {
            get { return this._labelSet; }
            set { this._labelSet = value; }
        }

        // Check to see if LabelSet property is set
        internal bool IsSetLabelSet()
        {
            return this._labelSet != null && (this._labelSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// This structure contains the information about the limits that apply to time series
        /// that match this label set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LimitsPerLabelSetEntry Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }

        // Check to see if Limits property is set
        internal bool IsSetLimits()
        {
            return this._limits != null;
        }

    }
}