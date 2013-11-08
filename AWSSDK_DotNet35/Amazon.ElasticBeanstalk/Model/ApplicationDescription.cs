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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Describes the properties of an application.</para>
    /// </summary>
    public class ApplicationDescription
    {
        
        private string applicationName;
        private string description;
        private DateTime? dateCreated;
        private DateTime? dateUpdated;
        private List<string> versions = new List<string>();
        private List<string> configurationTemplates = new List<string>();

        /// <summary>
        /// The name of the application.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this.applicationName != null;
        }

        /// <summary>
        /// User-defined description of the application.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 200</description>
        ///     </item>
        /// </list>
        /// </para>
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
        /// The date when the application was created.
        ///  
        /// </summary>
        public DateTime DateCreated
        {
            get { return this.dateCreated ?? default(DateTime); }
            set { this.dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this.dateCreated.HasValue;
        }

        /// <summary>
        /// The date when the application was last modified.
        ///  
        /// </summary>
        public DateTime DateUpdated
        {
            get { return this.dateUpdated ?? default(DateTime); }
            set { this.dateUpdated = value; }
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this.dateUpdated.HasValue;
        }

        /// <summary>
        /// The names of the versions for this application.
        ///  
        /// </summary>
        public List<string> Versions
        {
            get { return this.versions; }
            set { this.versions = value; }
        }

        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this.versions.Count > 0;
        }

        /// <summary>
        /// The names of the configuration templates associated with this application.
        ///  
        /// </summary>
        public List<string> ConfigurationTemplates
        {
            get { return this.configurationTemplates; }
            set { this.configurationTemplates = value; }
        }

        // Check to see if ConfigurationTemplates property is set
        internal bool IsSetConfigurationTemplates()
        {
            return this.configurationTemplates.Count > 0;
        }
    }
}
