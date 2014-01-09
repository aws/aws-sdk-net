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
    /// <para>The description and metadata for a Trusted Advisor check.</para>
    /// </summary>
    public class TrustedAdvisorCheckDescription
    {
        
        private string id;
        private string name;
        private string description;
        private string category;
        private List<string> metadata = new List<string>();


        /// <summary>
        /// The unique identifier for the Trusted Advisor check.
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
        /// The display name for the Trusted Advisor check.
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
        /// The description of the Trusted Advisor check, which includes the alert criteria and recommended actions (contains HTML markup).
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
        /// The category of the Trusted Advisor check.
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
        /// The column headings for the data returned by the Trusted Advisor check. The order of the headings corresponds to the order of the data in
        /// the <b>Metadata</b> element of the <a>TrustedAdvisorResourceDetail</a> for the check.
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
