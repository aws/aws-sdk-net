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
    /// <para>Description of each check returned by <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorChecks.html" >DescribeTrustedAdvisorChecks</a>
    /// .</para>
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

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this.category != null;
        }

        /// <summary>
        /// List of metadata returned in <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorResourceDetail.html"
        /// title="TrustedAdvisorResourceDetail">TrustedAdvisorResourceDetail</a> objects for a Trusted Advisor check.
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
