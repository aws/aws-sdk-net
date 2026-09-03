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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A price increase percentage range with minimum, maximum, and default values.
    /// </summary>
    public partial class PercentageRange
    {
        private string _defaultValue;
        private string _maximumValue;
        private string _minimumValue;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The percentage increase applied by default when no other value is finalized before
        /// the adjustment deadline. Falls between <c>minimumValue</c> and <c>maximumValue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumValue. 
        /// <para>
        /// The maximum percentage by which the price can increase at each renewal cycle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string MaximumValue
        {
            get { return this._maximumValue; }
            set { this._maximumValue = value; }
        }

        // Check to see if MaximumValue property is set
        internal bool IsSetMaximumValue()
        {
            return this._maximumValue != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumValue. 
        /// <para>
        /// The minimum percentage by which the price can increase at each renewal cycle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string MinimumValue
        {
            get { return this._minimumValue; }
            set { this._minimumValue = value; }
        }

        // Check to see if MinimumValue property is set
        internal bool IsSetMinimumValue()
        {
            return this._minimumValue != null;
        }

    }
}