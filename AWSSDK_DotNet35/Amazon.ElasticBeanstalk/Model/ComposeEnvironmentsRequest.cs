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
    /// Container for the parameters to the ComposeEnvironments operation.
    /// Create or update a group of environments that each run a separate component of a single
    /// application. Takes a list of version labels that specify application source bundles
    /// for each of the environments to create or update. The name of each environment and
    /// other required information must be included in the source bundles in an environment
    /// manifest named <code>env.yaml</code>. See <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-mgmt-compose.html">Compose
    /// Environments</a> for details.
    /// </summary>
    public partial class ComposeEnvironmentsRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _groupName;
        private List<string> _versionLabels = new List<string>();

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to which the specified source bundles belong.
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group to which the target environments belong. Specify a group name
        /// only if the environment name defined in each target environment's manifest ends with
        /// a + (plus) character. See <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-mgmt-compose.html#environment-mgmt-compose-envyaml">Environment
        /// Manifest (env.yaml)</a> for details.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionLabels. 
        /// <para>
        /// A list of version labels, specifying one or more application source bundles that belong
        /// to the target application. Each source bundle must include an environment manifest
        /// that specifies the name of the environment and the name of the solution stack to use,
        /// and optionally can specify environment links to create.
        /// </para>
        /// </summary>
        public List<string> VersionLabels
        {
            get { return this._versionLabels; }
            set { this._versionLabels = value; }
        }

        // Check to see if VersionLabels property is set
        internal bool IsSetVersionLabels()
        {
            return this._versionLabels != null && this._versionLabels.Count > 0; 
        }

    }
}