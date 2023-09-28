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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration details about the monitoring schedule.
    /// </summary>
    public partial class ScheduleConfig
    {
        private string _dataAnalysisEndTime;
        private string _dataAnalysisStartTime;
        private string _scheduleExpression;

        /// <summary>
        /// Gets and sets the property DataAnalysisEndTime. 
        /// <para>
        /// Sets the end time for a monitoring job window. Express this time as an offset to the
        /// times that you schedule your monitoring jobs to run. You schedule monitoring jobs
        /// with the <code>ScheduleExpression</code> parameter. Specify this offset in ISO 8601
        /// duration format. For example, if you want to end the window one hour before the start
        /// of each monitoring job, you would specify: <code>"-PT1H"</code>.
        /// </para>
        ///  
        /// <para>
        /// The end time that you specify must not follow the start time that you specify by more
        /// than 24 hours. You specify the start time with the <code>DataAnalysisStartTime</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If you set <code>ScheduleExpression</code> to <code>NOW</code>, this parameter is
        /// required.
        /// </para>
        /// </summary>
        public string DataAnalysisEndTime
        {
            get { return this._dataAnalysisEndTime; }
            set { this._dataAnalysisEndTime = value; }
        }

        // Check to see if DataAnalysisEndTime property is set
        internal bool IsSetDataAnalysisEndTime()
        {
            return this._dataAnalysisEndTime != null;
        }

        /// <summary>
        /// Gets and sets the property DataAnalysisStartTime. 
        /// <para>
        /// Sets the start time for a monitoring job window. Express this time as an offset to
        /// the times that you schedule your monitoring jobs to run. You schedule monitoring jobs
        /// with the <code>ScheduleExpression</code> parameter. Specify this offset in ISO 8601
        /// duration format. For example, if you want to monitor the five hours of data in your
        /// dataset that precede the start of each monitoring job, you would specify: <code>"-PT5H"</code>.
        /// </para>
        ///  
        /// <para>
        /// The start time that you specify must not precede the end time that you specify by
        /// more than 24 hours. You specify the end time with the <code>DataAnalysisEndTime</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If you set <code>ScheduleExpression</code> to <code>NOW</code>, this parameter is
        /// required.
        /// </para>
        /// </summary>
        public string DataAnalysisStartTime
        {
            get { return this._dataAnalysisStartTime; }
            set { this._dataAnalysisStartTime = value; }
        }

        // Check to see if DataAnalysisStartTime property is set
        internal bool IsSetDataAnalysisStartTime()
        {
            return this._dataAnalysisStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A cron expression that describes details about the monitoring schedule.
        /// </para>
        ///  
        /// <para>
        /// The supported cron expressions are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you want to set the job to start every hour, use the following:
        /// </para>
        ///  
        /// <para>
        ///  <code>Hourly: cron(0 * ? * * *)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you want to start the job daily:
        /// </para>
        ///  
        /// <para>
        ///  <code>cron(0 [00-23] ? * * *)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you want to run the job one time, immediately, use the following keyword:
        /// </para>
        ///  
        /// <para>
        ///  <code>NOW</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, the following are valid cron expressions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Daily at noon UTC: <code>cron(0 12 ? * * *)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Daily at midnight UTC: <code>cron(0 0 ? * * *)</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To support running every 6, 12 hours, the following are also supported:
        /// </para>
        ///  
        /// <para>
        ///  <code>cron(0 [00-23]/[01-24] ? * * *)</code> 
        /// </para>
        ///  
        /// <para>
        /// For example, the following are valid cron expressions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Every 12 hours, starting at 5pm UTC: <code>cron(0 17/12 ? * * *)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Every two hours starting at midnight: <code>cron(0 0/2 ? * * *)</code> 
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// Even though the cron expression is set to start at 5PM UTC, note that there could
        /// be a delay of 0-20 minutes from the actual requested time to run the execution. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// We recommend that if you would like a daily schedule, you do not provide this parameter.
        /// Amazon SageMaker will pick a time for running every day.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// You can also specify the keyword <code>NOW</code> to run the monitoring job immediately,
        /// one time, without recurring.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

    }
}