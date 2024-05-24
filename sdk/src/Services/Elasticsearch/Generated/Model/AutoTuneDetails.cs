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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies details of the Auto-Tune action. See the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
    /// target="_blank">Developer Guide</a> for more information.
    /// </summary>
    public partial class AutoTuneDetails
    {
        private ScheduledAutoTuneDetails _scheduledAutoTuneDetails;

        /// <summary>
        /// Gets and sets the property ScheduledAutoTuneDetails.
        /// </summary>
        public ScheduledAutoTuneDetails ScheduledAutoTuneDetails
        {
            get { return this._scheduledAutoTuneDetails; }
            set { this._scheduledAutoTuneDetails = value; }
        }

        // Check to see if ScheduledAutoTuneDetails property is set
        internal bool IsSetScheduledAutoTuneDetails()
        {
            return this._scheduledAutoTuneDetails != null;
        }

    }
}