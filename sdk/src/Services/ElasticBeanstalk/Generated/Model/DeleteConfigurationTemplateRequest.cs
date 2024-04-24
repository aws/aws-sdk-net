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
    /// Container for the parameters to the DeleteConfigurationTemplate operation.
    /// Deletes the specified configuration template.
    /// 
    ///  <note> 
    /// <para>
    /// When you launch an environment using a configuration template, the environment gets
    /// a copy of the template. You can delete or modify the environment's copy of the template
    /// without affecting the running environment.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteConfigurationTemplateRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _templateName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteConfigurationTemplateRequest() { }

        /// <summary>
        /// Instantiates DeleteConfigurationTemplateRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application to delete the configuration template from.</param>
        /// <param name="templateName">The name of the configuration template to delete.</param>
        public DeleteConfigurationTemplateRequest(string applicationName, string templateName)
        {
            _applicationName = applicationName;
            _templateName = templateName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to delete the configuration template from.
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
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the configuration template to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}