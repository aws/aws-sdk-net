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
    /// Container for the parameters to the UpdateApplicationVersion operation.
    /// Updates the specified application version to have the specified properties.
    /// 
    ///  <note> 
    /// <para>
    /// If a property (for example, <c>description</c>) is not provided, the value remains
    /// unchanged. To clear properties, specify an empty string.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateApplicationVersionRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _description;
        private string _versionLabel;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateApplicationVersionRequest() { }

        /// <summary>
        /// Instantiates UpdateApplicationVersionRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application associated with this version.  If no application is found with this name, <c>UpdateApplication</c> returns an <c>InvalidParameterValue</c> error.</param>
        /// <param name="versionLabel">The name of the version to update. If no application version is found with this label, <c>UpdateApplication</c> returns an <c>InvalidParameterValue</c> error. </param>
        public UpdateApplicationVersionRequest(string applicationName, string versionLabel)
        {
            _applicationName = applicationName;
            _versionLabel = versionLabel;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application associated with this version.
        /// </para>
        ///  
        /// <para>
        ///  If no application is found with this name, <c>UpdateApplication</c> returns an <c>InvalidParameterValue</c>
        /// error.
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
        /// A new description for this version.
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
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The name of the version to update.
        /// </para>
        ///  
        /// <para>
        /// If no application version is found with this label, <c>UpdateApplication</c> returns
        /// an <c>InvalidParameterValue</c> error. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}