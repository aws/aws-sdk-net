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
    /// <para>Description of each check returned by DescribeTrustedAdvisorChecks.</para>
    /// </summary>
    public class TrustedAdvisorCheckDescription
    {
        
        private string id;
        private string name;
        private string description;
        private string category;
        private List<string> metadata = new List<string>();

        /// <summary>
        /// Unique identifier for a specific Trusted Advisor check description.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckDescription WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// Display name for the Trusted Advisor check. Corresponds to the display name for the check in the Trusted Advisor user interface.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckDescription WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// Description of the Trusted Advisor check.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckDescription WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// Category to which the Trusted Advisor check belongs.
        ///  
        /// </summary>
        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        /// <summary>
        /// Sets the Category property
        /// </summary>
        /// <param name="category">The value to set for the Category property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCheckDescription WithCategory(string category)
        {
            this.category = category;
            return this;
        }
            

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this.category != null;
        }

        /// <summary>
        /// List of metadata returned in <a href="API_TrustedAdvisorResourceDetail.html"
        /// title="TrustedAdvisorResourceDetail">TrustedAdvisorResourceDetail</a> objects for a Trusted Advisor check.
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
        public TrustedAdvisorCheckDescription WithMetadata(params string[] metadata)
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
        public TrustedAdvisorCheckDescription WithMetadata(IEnumerable<string> metadata)
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
