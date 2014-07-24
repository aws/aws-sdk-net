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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Details about AWS resources that were analyzed in a call to Trusted Advisor <a>DescribeTrustedAdvisorCheckSummaries</a>.
    /// </summary>
    public partial class TrustedAdvisorResourcesSummary
    {
        private long? _resourcesFlagged;
        private long? _resourcesIgnored;
        private long? _resourcesProcessed;
        private long? _resourcesSuppressed;


        /// <summary>
        /// Gets and sets the property ResourcesFlagged. 
        /// <para>
        /// The number of AWS resources that were flagged (listed) by the Trusted Advisor check.
        /// </para>
        /// </summary>
        public long ResourcesFlagged
        {
            get { return this._resourcesFlagged.GetValueOrDefault(); }
            set { this._resourcesFlagged = value; }
        }

        // Check to see if ResourcesFlagged property is set
        internal bool IsSetResourcesFlagged()
        {
            return this._resourcesFlagged.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ResourcesIgnored. 
        /// <para>
        /// The number of AWS resources ignored by Trusted Advisor because information was unavailable.
        /// </para>
        /// </summary>
        public long ResourcesIgnored
        {
            get { return this._resourcesIgnored.GetValueOrDefault(); }
            set { this._resourcesIgnored = value; }
        }

        // Check to see if ResourcesIgnored property is set
        internal bool IsSetResourcesIgnored()
        {
            return this._resourcesIgnored.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ResourcesProcessed. 
        /// <para>
        /// The number of AWS resources that were analyzed by the Trusted Advisor check.
        /// </para>
        /// </summary>
        public long ResourcesProcessed
        {
            get { return this._resourcesProcessed.GetValueOrDefault(); }
            set { this._resourcesProcessed = value; }
        }

        // Check to see if ResourcesProcessed property is set
        internal bool IsSetResourcesProcessed()
        {
            return this._resourcesProcessed.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ResourcesSuppressed. 
        /// <para>
        /// The number of AWS resources ignored by Trusted Advisor because they were marked as
        /// suppressed by the user.
        /// </para>
        /// </summary>
        public long ResourcesSuppressed
        {
            get { return this._resourcesSuppressed.GetValueOrDefault(); }
            set { this._resourcesSuppressed = value; }
        }

        // Check to see if ResourcesSuppressed property is set
        internal bool IsSetResourcesSuppressed()
        {
            return this._resourcesSuppressed.HasValue; 
        }

    }
}