/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Details of the current stage of a replication run.
    /// </summary>
    public partial class ReplicationRunStageDetails
    {
        private string _stage;
        private string _stageProgress;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// String describing the current stage of a replication run.
        /// </para>
        /// </summary>
        public string Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property StageProgress. 
        /// <para>
        /// String describing the progress of the current stage of a replication run.
        /// </para>
        /// </summary>
        public string StageProgress
        {
            get { return this._stageProgress; }
            set { this._stageProgress = value; }
        }

        // Check to see if StageProgress property is set
        internal bool IsSetStageProgress()
        {
            return this._stageProgress != null;
        }

    }
}