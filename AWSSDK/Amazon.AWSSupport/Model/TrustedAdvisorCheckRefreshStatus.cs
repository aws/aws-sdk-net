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
    /// <para>The refresh status of a Trusted Advisor check. </para>
    /// </summary>
    public partial class TrustedAdvisorCheckRefreshStatus
    {
        
        private string checkId;
        private string status;
        private long? millisUntilNextRefreshable;

        /// <summary>
        /// The unique identifier for the Trusted Advisor check.
        ///  
        /// </summary>
        public string CheckId
        {
            get { return this.checkId; }
            set { this.checkId = value; }
        }

        /// <summary>
        /// Sets the CheckId property
        /// </summary>
        /// <param name="checkId">The value to set for the CheckId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckRefreshStatus WithCheckId(string checkId)
        {
            this.checkId = checkId;
            return this;
        }
            

        // Check to see if CheckId property is set
        internal bool IsSetCheckId()
        {
            return this.checkId != null;
        }

        /// <summary>
        /// The status of the Trusted Advisor check for which a refresh has been requested: "none", "enqueued", "processing", "success", or "abandoned".
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckRefreshStatus WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The amount of time, in milliseconds, until the Trusted Advisor check is eligible for refresh.
        ///  
        /// </summary>
        public long MillisUntilNextRefreshable
        {
            get { return this.millisUntilNextRefreshable ?? default(long); }
            set { this.millisUntilNextRefreshable = value; }
        }

        /// <summary>
        /// Sets the MillisUntilNextRefreshable property
        /// </summary>
        /// <param name="millisUntilNextRefreshable">The value to set for the MillisUntilNextRefreshable property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckRefreshStatus WithMillisUntilNextRefreshable(long millisUntilNextRefreshable)
        {
            this.millisUntilNextRefreshable = millisUntilNextRefreshable;
            return this;
        }
            

        // Check to see if MillisUntilNextRefreshable property is set
        internal bool IsSetMillisUntilNextRefreshable()
        {
            return this.millisUntilNextRefreshable.HasValue;
        }
    }
}
