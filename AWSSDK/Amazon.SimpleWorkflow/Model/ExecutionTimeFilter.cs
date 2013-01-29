/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Used to filter the workflow executions in visibility APIs by various time-based rules. Each parameter, if specified, defines a rule
    /// that must be satisfied by each returned query result. The parameter values are in the Unix Time format. For example: "oldestDate":
    /// 1325376070. </para>
    /// </summary>
    public class ExecutionTimeFilter
    {
        
        private DateTime? oldestDate;
        private DateTime? latestDate;

        /// <summary>
        /// Specifies the oldest start or close date and time to return.
        ///  
        /// </summary>
        public DateTime OldestDate
        {
            get { return this.oldestDate ?? default(DateTime); }
            set { this.oldestDate = value; }
        }

        /// <summary>
        /// Sets the OldestDate property
        /// </summary>
        /// <param name="oldestDate">The value to set for the OldestDate property </param>
        /// <returns>this instance</returns>
        public ExecutionTimeFilter WithOldestDate(DateTime oldestDate)
        {
            this.oldestDate = oldestDate;
            return this;
        }
            

        // Check to see if OldestDate property is set
        internal bool IsSetOldestDate()
        {
            return this.oldestDate.HasValue;
        }

        /// <summary>
        /// Specifies the latest start or close date and time to return.
        ///  
        /// </summary>
        public DateTime LatestDate
        {
            get { return this.latestDate ?? default(DateTime); }
            set { this.latestDate = value; }
        }

        /// <summary>
        /// Sets the LatestDate property
        /// </summary>
        /// <param name="latestDate">The value to set for the LatestDate property </param>
        /// <returns>this instance</returns>
        public ExecutionTimeFilter WithLatestDate(DateTime latestDate)
        {
            this.latestDate = latestDate;
            return this;
        }
            

        // Check to see if LatestDate property is set
        internal bool IsSetLatestDate()
        {
            return this.latestDate.HasValue;
        }
    }
}
