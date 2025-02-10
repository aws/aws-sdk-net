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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Communication Limit
    /// </summary>
    public partial class CommunicationLimit
    {
        private int? _frequency;
        private int? _maxCountPerRecipient;
        private CommunicationLimitTimeUnit _unit;

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The number of days to consider with regards to this limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public int? Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCountPerRecipient. 
        /// <para>
        /// Maximum number of contacts allowed for a given target within the given frequency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? MaxCountPerRecipient
        {
            get { return this._maxCountPerRecipient; }
            set { this._maxCountPerRecipient = value; }
        }

        // Check to see if MaxCountPerRecipient property is set
        internal bool IsSetMaxCountPerRecipient()
        {
            return this._maxCountPerRecipient.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit.
        /// </summary>
        [AWSProperty(Required=true)]
        public CommunicationLimitTimeUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}