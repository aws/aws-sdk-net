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
    /// Result message containing a description of the requested environment info.
    /// </summary>
    public partial class RetrieveEnvironmentInfoResponse : AmazonWebServiceResponse
    {
        private List<EnvironmentInfoDescription> _environmentInfo = new List<EnvironmentInfoDescription>();

        /// <summary>
        /// Gets and sets the property EnvironmentInfo. 
        /// <para>
        ///  The <a>EnvironmentInfoDescription</a> of the environment. 
        /// </para>
        /// </summary>
        public List<EnvironmentInfoDescription> EnvironmentInfo
        {
            get { return this._environmentInfo; }
            set { this._environmentInfo = value; }
        }

        // Check to see if EnvironmentInfo property is set
        internal bool IsSetEnvironmentInfo()
        {
            return this._environmentInfo != null && this._environmentInfo.Count > 0; 
        }

    }
}