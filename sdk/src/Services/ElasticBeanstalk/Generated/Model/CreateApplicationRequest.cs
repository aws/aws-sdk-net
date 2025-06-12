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
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an application that has one configuration template named <c>default</c> and
    /// no application versions.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _description;
        private ApplicationResourceLifecycleConfig _resourceLifecycleConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateApplicationRequest() { }

        /// <summary>
        /// Instantiates CreateApplicationRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application. Must be unique within your account.</param>
        public CreateApplicationRequest(string applicationName)
        {
            _applicationName = applicationName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application. Must be unique within your account.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Your description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
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
        /// Gets and sets the property ResourceLifecycleConfig. 
        /// <para>
        /// Specifies an application resource lifecycle configuration to prevent your application
        /// from accumulating too many versions.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the tags applied to the application.
        /// </para>
        ///  
        /// <para>
        /// Elastic Beanstalk applies these tags only to the application. Environments that you
        /// create in the application don't inherit the tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}