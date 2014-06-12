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
    /// Container for the parameters to the CreateApp operation.
    /// Creates an app for a specified stack. For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html">Creating
    /// Apps</a>.
    /// 
    ///     
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached       policy that explicitly grants permissions.
    /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class CreateAppRequest : AmazonOpsWorksRequest
    {
        private Source _appSource;
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private List<DataSource> _dataSources = new List<DataSource>();
        private string _description;
        private List<string> _domains = new List<string>();
        private bool? _enableSsl;
        private string _name;
        private string _shortname;
        private SslConfiguration _sslConfiguration;
        private string _stackId;
        private AppType _type;


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

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// The app's data source.
        /// </para>
        /// </summary>
        public List<DataSource> DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
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

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property Domains. 
        /// <para>
        /// The app virtual host settings, with multiple domains separated by commas. For example:
        /// <code>'www.example.com, example.com'</code>
        /// </para>
        /// </summary>
        public List<string> Domains
        {
            get { return this._domains; }
            set { this._domains = value; }
        }

        // Check to see if Domains property is set
        internal bool IsSetDomains()
        {
            return this._domains != null && this._domains.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property EnableSsl. 
        /// <para>
        /// Whether to enable SSL for the app.
        /// </para>
        /// </summary>
        public bool EnableSsl
        {
            get { return this._enableSsl.GetValueOrDefault(); }
            set { this._enableSsl = value; }
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

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property Shortname. 
        /// <para>
        /// The app's short name.
        /// </para>
        /// </summary>
        public string Shortname
        {
            get { return this._shortname; }
            set { this._shortname = value; }
        }

        // Check to see if Shortname property is set
        internal bool IsSetShortname()
        {
            return this._shortname != null;
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

        // Check to see if SslConfiguration property is set
        internal bool IsSetSslConfiguration()
        {
            return this._sslConfiguration != null;
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }


        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The app type. Each supported type is associated with a particular layer. For example,
        /// PHP applications are associated with a PHP layer.         AWS OpsWorks deploys an
        /// application to those instances that are members of the corresponding layer.
        /// </para>
        /// </summary>
        public AppType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}