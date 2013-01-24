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

        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        public ApplicationDescription WithApplicationName(string applicationName)
        {
            this.applicationName = applicationName;
            return this;
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

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public ApplicationDescription WithDescription(string description)
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
        /// The date when the application was created.
        ///  
        /// </summary>
        public DateTime DateCreated
        {
            get { return this.dateCreated ?? default(DateTime); }
            set { this.dateCreated = value; }
        }

        /// <summary>
        /// Sets the DateCreated property
        /// </summary>
        /// <param name="dateCreated">The value to set for the DateCreated property </param>
        /// <returns>this instance</returns>
        public ApplicationDescription WithDateCreated(DateTime dateCreated)
        {
            this.dateCreated = dateCreated;
            return this;
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

        /// <summary>
        /// Sets the DateUpdated property
        /// </summary>
        /// <param name="dateUpdated">The value to set for the DateUpdated property </param>
        /// <returns>this instance</returns>
        public ApplicationDescription WithDateUpdated(DateTime dateUpdated)
        {
            this.dateUpdated = dateUpdated;
            return this;
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
        /// <summary>
        /// Adds elements to the Versions collection
        /// </summary>
        /// <param name="versions">The values to add to the Versions collection </param>
        /// <returns>this instance</returns>
        public ApplicationDescription WithVersions(params string[] versions)
        {
            foreach (string element in versions)
            {
                this.versions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Versions collection
        /// </summary>
        /// <param name="versions">The values to add to the Versions collection </param>
        /// <returns>this instance</returns>
        public ApplicationDescription WithVersions(IEnumerable<string> versions)
        {
            foreach (string element in versions)
            {
                this.versions.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the ConfigurationTemplates collection
        /// </summary>
        /// <param name="configurationTemplates">The values to add to the ConfigurationTemplates collection </param>
        /// <returns>this instance</returns>
        public ApplicationDescription WithConfigurationTemplates(params string[] configurationTemplates)
        {
            foreach (string element in configurationTemplates)
            {
                this.configurationTemplates.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ConfigurationTemplates collection
        /// </summary>
        /// <param name="configurationTemplates">The values to add to the ConfigurationTemplates collection </param>
        /// <returns>this instance</returns>
        public ApplicationDescription WithConfigurationTemplates(IEnumerable<string> configurationTemplates)
        {
            foreach (string element in configurationTemplates)
            {
                this.configurationTemplates.Add(element);
            }

            return this;
        }

        // Check to see if ConfigurationTemplates property is set
        internal bool IsSetConfigurationTemplates()
        {
            return this.configurationTemplates.Count > 0;       
        }
    }
}
