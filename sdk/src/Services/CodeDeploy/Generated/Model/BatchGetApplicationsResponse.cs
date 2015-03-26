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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Represents the output of a batch get applications operation.
    /// </summary>
    public partial class BatchGetApplicationsResponse : AmazonWebServiceResponse
    {
        private List<ApplicationInfo> _applicationsInfo = new List<ApplicationInfo>();

        /// <summary>
        /// Gets and sets the property ApplicationsInfo. 
        /// <para>
        /// Information about the applications.
        /// </para>
        /// </summary>
        public List<ApplicationInfo> ApplicationsInfo
        {
            get { return this._applicationsInfo; }
            set { this._applicationsInfo = value; }
        }

        // Check to see if ApplicationsInfo property is set
        internal bool IsSetApplicationsInfo()
        {
            return this._applicationsInfo != null && this._applicationsInfo.Count > 0; 
        }

    }
}