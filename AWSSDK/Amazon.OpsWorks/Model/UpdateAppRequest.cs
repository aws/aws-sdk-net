/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the UpdateApp operation.
    /// Updates a specified app.
    /// 
    ///     
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Deploy or
    /// Manage permissions level for the stack,      or an attached policy that explicitly
    /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class UpdateAppRequest : AmazonWebServiceRequest
    {
        private string _appId;
        private Source _appSource;
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private List<DataSource> _dataSources = new List<DataSource>();
        private string _description;
        private List<string> _domains = new List<string>();
        private bool? _enableSsl;
        private string _name;
        private SslConfiguration _sslConfiguration;
        private string _type;


        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }


        /// <summary>
        /// Sets the AppId property
        /// </summary>
        /// <param name="appId">The value to set for the AppId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithAppId(string appId)
        {
            this._appId = appId;
            return this;
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }


        /// <summary>
        /// Gets and sets the property AppSource. 
        /// <para>
        /// A <code>Source</code> object that specifies the app repository.
        /// </para>
        /// </summary>
        public Source AppSource
        {
            get { return this._appSource; }
            set { this._appSource = value; }
        }


        /// <summary>
        /// Sets the AppSource property
        /// </summary>
        /// <param name="appSource">The value to set for the AppSource property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithAppSource(Source appSource)
        {
            this._appSource = appSource;
            return this;
        }

        // Check to see if AppSource property is set
        internal bool IsSetAppSource()
        {
            return this._appSource != null;
        }


        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more user-defined key/value pairs to be added to the stack attributes.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Attributes dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Attributes dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithAttributes(params KeyValuePair<string, string>[] pairs)
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
            return this._attributes != null && this._attributes.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// The app's data sources.
        /// </para>
        /// </summary>
        public List<DataSource> DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        /// <summary>
        /// Sets the DataSources property
        /// </summary>
        /// <param name="dataSources">The values to add to the DataSources collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithDataSources(params DataSource[] dataSources)
        {
            foreach (var element in dataSources)
            {
                this._dataSources.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the DataSources property
        /// </summary>
        /// <param name="dataSources">The values to add to the DataSources collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithDataSources(IEnumerable<DataSource> dataSources)
        {
            foreach (var element in dataSources)
            {
                this._dataSources.Add(element);
            }
            return this;
        }
        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null && this._dataSources.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the app.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property Domains. 
        /// <para>
        /// The app's virtual host settings, with multiple domains separated by commas. For example:
        /// <code>'www.example.com, example.com'</code>
        /// </para>
        /// </summary>
        public List<string> Domains
        {
            get { return this._domains; }
            set { this._domains = value; }
        }

        /// <summary>
        /// Sets the Domains property
        /// </summary>
        /// <param name="domains">The values to add to the Domains collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithDomains(params string[] domains)
        {
            foreach (var element in domains)
            {
                this._domains.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Domains property
        /// </summary>
        /// <param name="domains">The values to add to the Domains collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithDomains(IEnumerable<string> domains)
        {
            foreach (var element in domains)
            {
                this._domains.Add(element);
            }
            return this;
        }
        // Check to see if Domains property is set
        internal bool IsSetDomains()
        {
            return this._domains != null && this._domains.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property EnableSsl. 
        /// <para>
        /// Whether SSL is enabled for the app.
        /// </para>
        /// </summary>
        public bool EnableSsl
        {
            get { return this._enableSsl.GetValueOrDefault(); }
            set { this._enableSsl = value; }
        }


        /// <summary>
        /// Sets the EnableSsl property
        /// </summary>
        /// <param name="enableSsl">The value to set for the EnableSsl property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithEnableSsl(bool enableSsl)
        {
            this._enableSsl = enableSsl;
            return this;
        }

        // Check to see if EnableSsl property is set
        internal bool IsSetEnableSsl()
        {
            return this._enableSsl.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The app name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property SslConfiguration. 
        /// <para>
        /// An <code>SslConfiguration</code> object with the SSL configuration.
        /// </para>
        /// </summary>
        public SslConfiguration SslConfiguration
        {
            get { return this._sslConfiguration; }
            set { this._sslConfiguration = value; }
        }


        /// <summary>
        /// Sets the SslConfiguration property
        /// </summary>
        /// <param name="sslConfiguration">The value to set for the SslConfiguration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithSslConfiguration(SslConfiguration sslConfiguration)
        {
            this._sslConfiguration = sslConfiguration;
            return this;
        }

        // Check to see if SslConfiguration property is set
        internal bool IsSetSslConfiguration()
        {
            return this._sslConfiguration != null;
        }


        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The app type.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }


        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAppRequest WithType(string type)
        {
            this._type = type;
            return this;
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}