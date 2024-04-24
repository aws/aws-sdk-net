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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains information about whether assisted slot resolution is turned on for the slot
    /// or not.
    /// </summary>
    public partial class SlotResolutionSetting
    {
        private SlotResolutionStrategy _slotResolutionStrategy;

        /// <summary>
        /// Gets and sets the property SlotResolutionStrategy. 
        /// <para>
        /// Specifies whether assisted slot resolution is turned on for the slot or not. If the
        /// value is <c>EnhancedFallback</c>, assisted slot resolution is activated when Amazon
        /// Lex defaults to the <c>AMAZON.FallbackIntent</c>. If the value is <c>Default</c>,
        /// assisted slot resolution is turned off.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlotResolutionStrategy SlotResolutionStrategy
        {
            get { return this._slotResolutionStrategy; }
            set { this._slotResolutionStrategy = value; }
        }

        // Check to see if SlotResolutionStrategy property is set
        internal bool IsSetSlotResolutionStrategy()
        {
            return this._slotResolutionStrategy != null;
        }

    }
}