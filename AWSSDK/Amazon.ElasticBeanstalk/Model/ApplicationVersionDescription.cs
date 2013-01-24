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
    /// <para> Describes the properties of an application version. </para>
    /// </summary>
    public class ApplicationVersionDescription  
    {
        
        private string applicationName;
        private string description;
        private string versionLabel;
        private S3Location sourceBundle;
        private DateTime? dateCreated;
        private DateTime? dateUpdated;

        /// <summary>
        /// The name of the application associated with this release.
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
        public ApplicationVersionDescription WithApplicationName(string applicationName)
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
        /// The description of this application version.
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
        public ApplicationVersionDescription WithDescription(string description)
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
        /// A label uniquely identifying the version for the associated application.
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
        public string VersionLabel
        {
            get { return this.versionLabel; }
            set { this.versionLabel = value; }
        }

        /// <summary>
        /// Sets the VersionLabel property
        /// </summary>
        /// <param name="versionLabel">The value to set for the VersionLabel property </param>
        /// <returns>this instance</returns>
        public ApplicationVersionDescription WithVersionLabel(string versionLabel)
        {
            this.versionLabel = versionLabel;
            return this;
        }
            

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this.versionLabel != null;       
        }

        /// <summary>
        /// The location where the source bundle is located for this version.
        ///  
        /// </summary>
        public S3Location SourceBundle
        {
            get { return this.sourceBundle; }
            set { this.sourceBundle = value; }
        }

        /// <summary>
        /// Sets the SourceBundle property
        /// </summary>
        /// <param name="sourceBundle">The value to set for the SourceBundle property </param>
        /// <returns>this instance</returns>
        public ApplicationVersionDescription WithSourceBundle(S3Location sourceBundle)
        {
            this.sourceBundle = sourceBundle;
            return this;
        }
            

        // Check to see if SourceBundle property is set
        internal bool IsSetSourceBundle()
        {
            return this.sourceBundle != null;       
        }

        /// <summary>
        /// The creation date of the application version.
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
        public ApplicationVersionDescription WithDateCreated(DateTime dateCreated)
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
        /// The last modified date of the application version.
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
        public ApplicationVersionDescription WithDateUpdated(DateTime dateUpdated)
        {
            this.dateUpdated = dateUpdated;
            return this;
        }
            

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this.dateUpdated.HasValue;       
        }
    }
}
