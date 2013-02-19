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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>A description of the app.</para>
    /// </summary>
    public class App
    {
        
        private string appId;
        private string stackId;
        private string name;
        private string description;
        private string type;
        private Source appSource;
        private List<string> domains = new List<string>();
        private bool? enableSsl;
        private SslConfiguration sslConfiguration;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();
        private string createdAt;

        /// <summary>
        /// The app ID.
        ///  
        /// </summary>
        public string AppId
        {
            get { return this.appId; }
            set { this.appId = value; }
        }

        /// <summary>
        /// Sets the AppId property
        /// </summary>
        /// <param name="appId">The value to set for the AppId property </param>
        /// <returns>this instance</returns>
        public App WithAppId(string appId)
        {
            this.appId = appId;
            return this;
        }
            

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this.appId != null;
        }

        /// <summary>
        /// The app stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        public App WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The app name.
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
        public App WithName(string name)
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
        /// A description of the app.
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
        public App WithDescription(string description)
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
        /// The app type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>rails, php, nodejs, static, other</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        public App WithType(string type)
        {
            this.type = type;
            return this;
        }
            

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }

        /// <summary>
        /// A <c>Source</c> object that describes the app repository.
        ///  
        /// </summary>
        public Source AppSource
        {
            get { return this.appSource; }
            set { this.appSource = value; }
        }

        /// <summary>
        /// Sets the AppSource property
        /// </summary>
        /// <param name="appSource">The value to set for the AppSource property </param>
        /// <returns>this instance</returns>
        public App WithAppSource(Source appSource)
        {
            this.appSource = appSource;
            return this;
        }
            

        // Check to see if AppSource property is set
        internal bool IsSetAppSource()
        {
            return this.appSource != null;
        }

        /// <summary>
        /// The app vhost settings, with multiple domains separated by commas. For example: <c>'www.mysite.com, mysite.com'</c>
        ///  
        /// </summary>
        public List<string> Domains
        {
            get { return this.domains; }
            set { this.domains = value; }
        }
        /// <summary>
        /// Adds elements to the Domains collection
        /// </summary>
        /// <param name="domains">The values to add to the Domains collection </param>
        /// <returns>this instance</returns>
        public App WithDomains(params string[] domains)
        {
            foreach (string element in domains)
            {
                this.domains.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Domains collection
        /// </summary>
        /// <param name="domains">The values to add to the Domains collection </param>
        /// <returns>this instance</returns>
        public App WithDomains(IEnumerable<string> domains)
        {
            foreach (string element in domains)
            {
                this.domains.Add(element);
            }

            return this;
        }

        // Check to see if Domains property is set
        internal bool IsSetDomains()
        {
            return this.domains.Count > 0;
        }

        /// <summary>
        /// Whether to enable SSL for the app.
        ///  
        /// </summary>
        public bool EnableSsl
        {
            get { return this.enableSsl ?? default(bool); }
            set { this.enableSsl = value; }
        }

        /// <summary>
        /// Sets the EnableSsl property
        /// </summary>
        /// <param name="enableSsl">The value to set for the EnableSsl property </param>
        /// <returns>this instance</returns>
        public App WithEnableSsl(bool enableSsl)
        {
            this.enableSsl = enableSsl;
            return this;
        }
            

        // Check to see if EnableSsl property is set
        internal bool IsSetEnableSsl()
        {
            return this.enableSsl.HasValue;
        }

        /// <summary>
        /// An <c>SslConfiguration</c> object with the SSL configuration.
        ///  
        /// </summary>
        public SslConfiguration SslConfiguration
        {
            get { return this.sslConfiguration; }
            set { this.sslConfiguration = value; }
        }

        /// <summary>
        /// Sets the SslConfiguration property
        /// </summary>
        /// <param name="sslConfiguration">The value to set for the SslConfiguration property </param>
        /// <returns>this instance</returns>
        public App WithSslConfiguration(SslConfiguration sslConfiguration)
        {
            this.sslConfiguration = sslConfiguration;
            return this;
        }
            

        // Check to see if SslConfiguration property is set
        internal bool IsSetSslConfiguration()
        {
            return this.sslConfiguration != null;
        }

        /// <summary>
        /// The contents of the stack attributes bag.
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Attributes dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Attributes dictionary.</param>
        /// <returns>this instance</returns>
        public App WithAttributes(params KeyValuePair<string, string>[] pairs)
        {
            foreach (KeyValuePair<string, string> pair in pairs)
            {
                this.Attributes[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }

        /// <summary>
        /// When the app was created.
        ///  
        /// </summary>
        public string CreatedAt
        {
            get { return this.createdAt; }
            set { this.createdAt = value; }
        }

        /// <summary>
        /// Sets the CreatedAt property
        /// </summary>
        /// <param name="createdAt">The value to set for the CreatedAt property </param>
        /// <returns>this instance</returns>
        public App WithCreatedAt(string createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }
            

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this.createdAt != null;
        }
    }
}
