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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Specifies the Auto-Tune type and Auto-Tune action details.
    /// </summary>
    public partial class AutoTune
    {
        private AutoTuneDetails _autoTuneDetails;
        private AutoTuneType _autoTuneType;

        /// <summary>
        /// Gets and sets the property AutoTuneDetails. 
        /// <para>
        /// Specifies details about the Auto-Tune action. See <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html"
        /// target="_blank"> Auto-Tune for Amazon OpenSearch Service </a> for more information.
        /// 
        /// </para>
        /// </summary>
        public AutoTuneDetails AutoTuneDetails
        {
            get { return this._autoTuneDetails; }
            set { this._autoTuneDetails = value; }
        }

        // Check to see if AutoTuneDetails property is set
        internal bool IsSetAutoTuneDetails()
        {
            return this._autoTuneDetails != null;
        }

        /// <summary>
        /// Gets and sets the property AutoTuneType. 
        /// <para>
        /// Specifies the Auto-Tune type. Valid value is SCHEDULED_ACTION.
        /// </para>
        /// </summary>
        public AutoTuneType AutoTuneType
        {
            get { return this._autoTuneType; }
            set { this._autoTuneType = value; }
        }

        // Check to see if AutoTuneType property is set
        internal bool IsSetAutoTuneType()
        {
            return this._autoTuneType != null;
        }

    }
}