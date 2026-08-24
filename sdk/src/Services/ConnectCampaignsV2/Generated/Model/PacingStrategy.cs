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
    /// Pacing constraint the dialer may enforce.
    /// </summary>
    public partial class PacingStrategy
    {
        private AbandonmentRatePacingConfig _abandonmentRate;

        /// <summary>
        /// Gets and sets the property AbandonmentRate.
        /// </summary>
        public AbandonmentRatePacingConfig AbandonmentRate
        {
            get { return this._abandonmentRate; }
            set { this._abandonmentRate = value; }
        }

        // Check to see if AbandonmentRate property is set
        internal bool IsSetAbandonmentRate()
        {
            return this._abandonmentRate != null;
        }

    }
}