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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Details about AWS resources that were analyzed in a call to Trusted Advisor DescribeTrustedAdvisorCheckSummaries. </para>
    /// </summary>
    public class TrustedAdvisorResourcesSummary
    {
        
        private long? resourcesProcessed;
        private long? resourcesFlagged;
        private long? resourcesIgnored;
        private long? resourcesSuppressed;


        /// <summary>
        /// The number of AWS resources that were analyzed by the Trusted Advisor check.
        ///  
        /// </summary>
        public long ResourcesProcessed
        {
            get { return this.resourcesProcessed ?? default(long); }
            set { this.resourcesProcessed = value; }
        }

        // Check to see if ResourcesProcessed property is set
        internal bool IsSetResourcesProcessed()
        {
            return this.resourcesProcessed.HasValue;
        }

        /// <summary>
        /// The number of AWS resources that were flagged (listed) by the Trusted Advisor check.
        ///  
        /// </summary>
        public long ResourcesFlagged
        {
            get { return this.resourcesFlagged ?? default(long); }
            set { this.resourcesFlagged = value; }
        }

        // Check to see if ResourcesFlagged property is set
        internal bool IsSetResourcesFlagged()
        {
            return this.resourcesFlagged.HasValue;
        }

        /// <summary>
        /// The number of AWS resources ignored by Trusted Advisor because information was unavailable.
        ///  
        /// </summary>
        public long ResourcesIgnored
        {
            get { return this.resourcesIgnored ?? default(long); }
            set { this.resourcesIgnored = value; }
        }

        // Check to see if ResourcesIgnored property is set
        internal bool IsSetResourcesIgnored()
        {
            return this.resourcesIgnored.HasValue;
        }

        /// <summary>
        /// The number of AWS resources ignored by Trusted Advisor because they were marked as suppressed by the user.
        ///  
        /// </summary>
        public long ResourcesSuppressed
        {
            get { return this.resourcesSuppressed ?? default(long); }
            set { this.resourcesSuppressed = value; }
        }

        // Check to see if ResourcesSuppressed property is set
        internal bool IsSetResourcesSuppressed()
        {
            return this.resourcesSuppressed.HasValue;
        }
    }
}
