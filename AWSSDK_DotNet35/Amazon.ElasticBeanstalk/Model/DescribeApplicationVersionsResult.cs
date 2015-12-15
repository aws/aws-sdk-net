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
    /// Result message wrapping a list of application version descriptions.
    /// </summary>
    public partial class DescribeApplicationVersionsResult : AmazonWebServiceResponse
    {
        private List<ApplicationVersionDescription> _applicationVersions = new List<ApplicationVersionDescription>();

        /// <summary>
        /// Gets and sets the property ApplicationVersions. 
        /// <para>
        /// List of <code>ApplicationVersionDescription</code> objects sorted by order of creation.
        /// </para>
        /// </summary>
        public List<ApplicationVersionDescription> ApplicationVersions
        {
            get { return this._applicationVersions; }
            set { this._applicationVersions = value; }
        }

        // Check to see if ApplicationVersions property is set
        internal bool IsSetApplicationVersions()
        {
            return this._applicationVersions != null && this._applicationVersions.Count > 0; 
        }

    }
}