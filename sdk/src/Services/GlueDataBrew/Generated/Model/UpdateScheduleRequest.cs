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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSchedule operation.
    /// Modifies the definition of an existing AWS Glue DataBrew schedule in the current AWS
    /// account.
    /// </summary>
    public partial class UpdateScheduleRequest : AmazonGlueDataBrewRequest
    {
        private string _cronExpression;
        private List<string> _jobNames = new List<string>();
        private string _name;

        /// <summary>
        /// Gets and sets the property CronExpression. 
        /// <para>
        /// The date or dates and time or times, in <code>cron</code> format, when the jobs are
        /// to be run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string CronExpression
        {
            get { return this._cronExpression; }
            set { this._cronExpression = value; }
        }

        // Check to see if CronExpression property is set
        internal bool IsSetCronExpression()
        {
            return this._cronExpression != null;
        }

        /// <summary>
        /// Gets and sets the property JobNames. 
        /// <para>
        /// The name or names of one or more jobs to be run for this schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> JobNames
        {
            get { return this._jobNames; }
            set { this._jobNames = value; }
        }

        // Check to see if JobNames property is set
        internal bool IsSetJobNames()
        {
            return this._jobNames != null && this._jobNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the schedule to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}