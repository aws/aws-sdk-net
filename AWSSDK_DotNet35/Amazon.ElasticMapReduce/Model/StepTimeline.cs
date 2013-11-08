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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>The timeline of the cluster step lifecycle. </para>
    /// </summary>
    public class StepTimeline
    {
        
        private DateTime? creationDateTime;
        private DateTime? startDateTime;
        private DateTime? endDateTime;


        /// <summary>
        /// The date and time when the cluster step was created.
        ///  
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this.creationDateTime ?? default(DateTime); }
            set { this.creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this.creationDateTime.HasValue;
        }

        /// <summary>
        /// The date and time when the cluster step execution started. Due to delays in step status reporting, this can display a time which pre-dates a
        /// previous call to DescribeStep that indicated the step was not yet running.
        ///  
        /// </summary>
        public DateTime StartDateTime
        {
            get { return this.startDateTime ?? default(DateTime); }
            set { this.startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this.startDateTime.HasValue;
        }

        /// <summary>
        /// The date and time when the cluster step execution completed or failed. This can display a time that pre-dates a call to DescribeStep that
        /// indicates the step is running, due to delays in step status reporting.
        ///  
        /// </summary>
        public DateTime EndDateTime
        {
            get { return this.endDateTime ?? default(DateTime); }
            set { this.endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this.endDateTime.HasValue;
        }
    }
}
