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
    /// Specifies details of the scheduled Auto-Tune action. See the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
    /// target="_blank">Developer Guide</a> for more information.
    /// </summary>
    public partial class ScheduledAutoTuneDetails
    {
        private string _action;
        private ScheduledAutoTuneActionType _actionType;
        private DateTime? _date;
        private ScheduledAutoTuneSeverityType _severity;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies Auto-Tune action description. 
        /// </para>
        /// </summary>
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// Specifies Auto-Tune action type. Valid values are JVM_HEAP_SIZE_TUNING and JVM_YOUNG_GEN_TUNING.
        /// 
        /// </para>
        /// </summary>
        public ScheduledAutoTuneActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// Specifies timestamp for the Auto-Tune action scheduled for the domain. 
        /// </para>
        /// </summary>
        public DateTime? Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// Specifies Auto-Tune action severity. Valid values are LOW, MEDIUM and HIGH. 
        /// </para>
        /// </summary>
        public ScheduledAutoTuneSeverityType Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

    }
}