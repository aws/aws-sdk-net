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
    /// <para>Contains information about a resource identified by a Trusted Advisor check. </para>
    /// </summary>
    public class TrustedAdvisorResourceDetail
    {
        
        private string status;
        private string region;
        private string resourceId;
        private bool? isSuppressed;
        private List<string> metadata = new List<string>();


        /// <summary>
        /// The status code for the resource identified in the Trusted Advisor check.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The AWS region in which the identified resource is located.
        ///  
        /// </summary>
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;
        }

        /// <summary>
        /// The unique identifier for the identified resource.
        ///  
        /// </summary>
        public string ResourceId
        {
            get { return this.resourceId; }
            set { this.resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this.resourceId != null;
        }

        /// <summary>
        /// Specifies whether the AWS resource was ignored by Trusted Advisor because it was marked as suppressed by the user.
        ///  
        /// </summary>
        public bool IsSuppressed
        {
            get { return this.isSuppressed ?? default(bool); }
            set { this.isSuppressed = value; }
        }

        // Check to see if IsSuppressed property is set
        internal bool IsSetIsSuppressed()
        {
            return this.isSuppressed.HasValue;
        }

        /// <summary>
        /// Additional information about the identified resource. The exact metadata and its order can be obtained by inspecting the
        /// <a>TrustedAdvisorCheckDescription</a> object returned by the call to <a>DescribeTrustedAdvisorChecks</a>.
        ///  
        /// </summary>
        public List<string> Metadata
        {
            get { return this.metadata; }
            set { this.metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this.metadata.Count > 0;
        }
    }
}
