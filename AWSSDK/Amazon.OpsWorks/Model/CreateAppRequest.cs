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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApp operation.
    /// <para>Creates an app for a specified stack. For more information, see Creating Apps.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateApp"/>
    public class CreateAppRequest : AmazonWebServiceRequest
    {
        private string stackId;
        private string shortname;
        private string name;
        private string description;
        private string type;
        private Source appSource;
        private List<string> domains = new List<string>();
        private bool? enableSsl;
        private SslConfiguration sslConfiguration;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();

        /// <summary>
        /// The stack ID.
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
        public CreateAppRequest WithStackId(string stackId)
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
        /// The app's short name.
        ///  
        /// </summary>
        public string Shortname
        {
            get { return this.shortname; }
            set { this.shortname = value; }
        }

        /// <summary>
        /// Sets the Shortname property
        /// </summary>
        /// <param name="shortname">The value to set for the Shortname property </param>
        /// <returns>this instance</returns>
        public CreateAppRequest WithShortname(string shortname)
        {
            this.shortname = shortname;
            return this;
        }
            

        // Check to see if Shortname property is set
        internal bool IsSetShortname()
        {
            return this.shortname != null;
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
        public CreateAppRequest WithName(string name)
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
        public CreateAppRequest WithDescription(string description)
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
        /// The app type. Each supported type is associated with a particular layer. For example, PHP applications are associated with a PHP layer.
        /// OpsWorks deploys an application to those instances that are members of the corresponding layer.
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
        public CreateAppRequest WithType(string type)
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
        /// A <c>Source</c> object that specifies the app repository.
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
        public CreateAppRequest WithAppSource(Source appSource)
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
        /// The app virtual host settings, with multiple domains separated by commas. For example: <c>'www.example.com, example.com'</c>
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
        public CreateAppRequest WithDomains(params string[] domains)
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
        public CreateAppRequest WithDomains(IEnumerable<string> domains)
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
        public CreateAppRequest WithEnableSsl(bool enableSsl)
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
        public CreateAppRequest WithSslConfiguration(SslConfiguration sslConfiguration)
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
        /// One or more user-defined key/value pairs to be added to the stack attributes bag.
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
        public CreateAppRequest WithAttributes(params KeyValuePair<string, string>[] pairs)
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
    }
}
    
