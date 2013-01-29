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
    /// <para> Status information about an activity task. </para>
    /// </summary>
    public class ActivityTaskStatus
    {
        
        private bool? cancelRequested;

        /// <summary>
        /// Set to <c>true</c> if cancellation of the task is requested.
        ///  
        /// </summary>
        public bool CancelRequested
        {
            get { return this.cancelRequested ?? default(bool); }
            set { this.cancelRequested = value; }
        }

        /// <summary>
        /// Sets the CancelRequested property
        /// </summary>
        /// <param name="cancelRequested">The value to set for the CancelRequested property </param>
        /// <returns>this instance</returns>
        public ActivityTaskStatus WithCancelRequested(bool cancelRequested)
        {
            this.cancelRequested = cancelRequested;
            return this;
        }
            

        // Check to see if CancelRequested property is set
        internal bool IsSetCancelRequested()
        {
            return this.cancelRequested.HasValue;
        }
    }
}
