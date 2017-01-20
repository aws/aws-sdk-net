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

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
    /// The resource lifecycle configuration for an application. Defines lifecycle settings
    /// for resources that belong to the application, and the service role that Elastic Beanstalk
    /// assumes in order to apply lifecycle settings. The version lifecycle configuration
    /// defines lifecycle settings for application versions.
    /// </summary>
    public partial class ApplicationResourceLifecycleConfig
    {
        private string _serviceRole;
        private ApplicationVersionLifecycleConfig _versionLifecycleConfig;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The ARN of an IAM service role that Elastic Beanstalk has permission to assume.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property VersionLifecycleConfig. 
        /// <para>
        /// The application version lifecycle configuration.
        /// </para>
        /// </summary>
        public ApplicationVersionLifecycleConfig VersionLifecycleConfig
        {
            get { return this._versionLifecycleConfig; }
            set { this._versionLifecycleConfig = value; }
        }

        // Check to see if VersionLifecycleConfig property is set
        internal bool IsSetVersionLifecycleConfig()
        {
            return this._versionLifecycleConfig != null;
        }

    }
}