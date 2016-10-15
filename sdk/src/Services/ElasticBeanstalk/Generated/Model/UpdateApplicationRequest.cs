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
    /// Container for the parameters to the UpdateApplication operation.
    /// Updates the specified application to have the specified properties.
    /// 
    ///  <note> 
    /// <para>
    /// If a property (for example, <code>description</code>) is not provided, the value remains
    /// unchanged. To clear these properties, specify an empty string.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _description;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateApplicationRequest() { }

        /// <summary>
        /// Instantiates UpdateApplicationRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application to update. If no such application is found, <code>UpdateApplication</code> returns an <code>InvalidParameterValue</code> error. </param>
        public UpdateApplicationRequest(string applicationName)
        {
            _applicationName = applicationName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to update. If no such application is found, <code>UpdateApplication</code>
        /// returns an <code>InvalidParameterValue</code> error. 
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
        /// A new description for the application.
        /// </para>
        ///  
        /// <para>
        /// Default: If not specified, AWS Elastic Beanstalk does not update the description.
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