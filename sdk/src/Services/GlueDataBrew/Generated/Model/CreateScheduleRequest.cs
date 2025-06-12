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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSchedule operation.
    /// Creates a new schedule for one or more DataBrew jobs. Jobs can be run at a specific
    /// date and time, or at regular intervals.
    /// </summary>
    public partial class CreateScheduleRequest : AmazonGlueDataBrewRequest
    {
        private string _cronExpression;
        private List<string> _jobNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CronExpression. 
        /// <para>
        /// The date or dates and time or times when the jobs are to be run. For more information,
        /// see <a href="https://docs.aws.amazon.com/databrew/latest/dg/jobs.cron.html">Cron expressions</a>
        /// in the <i>Glue DataBrew Developer Guide</i>.
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
        /// The name or names of one or more jobs to be run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._jobNames != null && (this._jobNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the schedule. Valid characters are alphanumeric (A-Z, a-z, 0-9),
        /// hyphen (-), period (.), and space.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata tags to apply to this schedule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}