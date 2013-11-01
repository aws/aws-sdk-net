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
    /// <para>The timeline of the instance group lifecycle.</para>
    /// </summary>
    public class InstanceGroupTimeline
    {
        
        private DateTime? creationDateTime;
        private DateTime? readyDateTime;
        private DateTime? endDateTime;


        /// <summary>
        /// The creation date and time of the instance group.
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
        /// The date and time when the instance group became ready to perform tasks.
        ///  
        /// </summary>
        public DateTime ReadyDateTime
        {
            get { return this.readyDateTime ?? default(DateTime); }
            set { this.readyDateTime = value; }
        }

        // Check to see if ReadyDateTime property is set
        internal bool IsSetReadyDateTime()
        {
            return this.readyDateTime.HasValue;
        }

        /// <summary>
        /// The date and time when the instance group terminated.
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
