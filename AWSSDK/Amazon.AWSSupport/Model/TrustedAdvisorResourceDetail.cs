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
    public partial class TrustedAdvisorResourceDetail
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

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorResourceDetail WithStatus(string status)
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
        /// The AWS region in which the identified resource is located.
        ///  
        /// </summary>
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorResourceDetail WithRegion(string region)
        {
            this.region = region;
            return this;
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

        /// <summary>
        /// Sets the ResourceId property
        /// </summary>
        /// <param name="resourceId">The value to set for the ResourceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorResourceDetail WithResourceId(string resourceId)
        {
            this.resourceId = resourceId;
            return this;
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

        /// <summary>
        /// Sets the IsSuppressed property
        /// </summary>
        /// <param name="isSuppressed">The value to set for the IsSuppressed property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorResourceDetail WithIsSuppressed(bool isSuppressed)
        {
            this.isSuppressed = isSuppressed;
            return this;
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
        /// <summary>
        /// Adds elements to the Metadata collection
        /// </summary>
        /// <param name="metadata">The values to add to the Metadata collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorResourceDetail WithMetadata(params string[] metadata)
        {
            foreach (string element in metadata)
            {
                this.metadata.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Metadata collection
        /// </summary>
        /// <param name="metadata">The values to add to the Metadata collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorResourceDetail WithMetadata(IEnumerable<string> metadata)
        {
            foreach (string element in metadata)
            {
                this.metadata.Add(element);
            }

            return this;
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this.metadata.Count > 0;
        }
    }
}
