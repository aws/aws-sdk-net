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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// A collection of Amazon Web Services resources supported by DevOps Guru. The one type
    /// of Amazon Web Services resource collection supported is Amazon Web Services CloudFormation
    /// stacks. DevOps Guru can be configured to analyze only the Amazon Web Services resources
    /// that are defined in the stacks. You can specify up to 500 Amazon Web Services CloudFormation
    /// stacks.
    /// </summary>
    public partial class ResourceCollection
    {
        private CloudFormationCollection _cloudFormation;

        /// <summary>
        /// Gets and sets the property CloudFormation. 
        /// <para>
        ///  An array of the names of Amazon Web Services CloudFormation stacks. The stacks define
        /// Amazon Web Services resources that DevOps Guru analyzes. You can specify up to 500
        /// Amazon Web Services CloudFormation stacks. 
        /// </para>
        /// </summary>
        public CloudFormationCollection CloudFormation
        {
            get { return this._cloudFormation; }
            set { this._cloudFormation = value; }
        }

        // Check to see if CloudFormation property is set
        internal bool IsSetCloudFormation()
        {
            return this._cloudFormation != null;
        }

    }
}