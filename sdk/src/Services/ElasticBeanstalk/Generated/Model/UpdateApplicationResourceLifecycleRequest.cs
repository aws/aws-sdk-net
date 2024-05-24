/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplicationResourceLifecycle operation.
    /// Modifies lifecycle settings for an application.
    /// </summary>
    public partial class UpdateApplicationResourceLifecycleRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private ApplicationResourceLifecycleConfig _resourceLifecycleConfig;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property ResourceLifecycleConfig. 
        /// <para>
        /// The lifecycle configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationResourceLifecycleConfig ResourceLifecycleConfig
        {
            get { return this._resourceLifecycleConfig; }
            set { this._resourceLifecycleConfig = value; }
        }

        // Check to see if ResourceLifecycleConfig property is set
        internal bool IsSetResourceLifecycleConfig()
        {
            return this._resourceLifecycleConfig != null;
        }

    }
}