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
    /// Container for the parameters to the DeleteApplicationVersion operation.
    /// Deletes the specified version from the specified application.
    /// </summary>
    public partial class DeleteApplicationVersionRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private bool? _deleteSourceBundle;
        private string _versionLabel;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteApplicationVersionRequest() { }

        /// <summary>
        /// Instantiates DeleteApplicationVersionRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application to delete releases from.</param>
        /// <param name="versionLabel"> The label of the version to delete. </param>
        public DeleteApplicationVersionRequest(string applicationName, string versionLabel)
        {
            _applicationName = applicationName;
            _versionLabel = versionLabel;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to delete releases from.
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
        /// Gets and sets the property DeleteSourceBundle. 
        /// <para>
        /// Indicates whether to delete the associated source bundle from Amazon S3: 
        /// </para>
        ///  <ul> <li> <code>true</code>: An attempt is made to delete the associated Amazon S3
        /// source bundle specified at time of creation. </li> <li> <code>false</code>: No action
        /// is taken on the Amazon S3 source bundle specified at time of creation. </li> </ul>
        /// 
        /// <para>
        ///  Valid Values: <code>true</code> | <code>false</code> 
        /// </para>
        /// </summary>
        public bool DeleteSourceBundle
        {
            get { return this._deleteSourceBundle.GetValueOrDefault(); }
            set { this._deleteSourceBundle = value; }
        }

        // Check to see if DeleteSourceBundle property is set
        internal bool IsSetDeleteSourceBundle()
        {
            return this._deleteSourceBundle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        ///  The label of the version to delete. 
        /// </para>
        /// </summary>
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