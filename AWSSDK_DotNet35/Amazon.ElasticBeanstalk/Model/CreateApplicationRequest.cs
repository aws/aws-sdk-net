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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an application that has one configuration         template named
    ///         <code>default</code>         and no application versions.      
    /// 
    ///       The         &lt;code&gt;default&lt;/code&gt;         configuration template
    /// is for a 32-bit version of the         Amazon Linux         operating system running
    /// the Tomcat 6 application container.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _description;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application.
        /// </para>
        ///       
        /// <para>
        ///          Constraint: This name must be unique within your account.         If the
        ///         specified name already exists, the action returns an         <code>InvalidParameterValue</code>
        ///         error.      
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes the application.
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

    }
}