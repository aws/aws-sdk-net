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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information on the IMDS configuration of the notebook instance
    /// </summary>
    public partial class InstanceMetadataServiceConfiguration
    {
        private string _minimumInstanceMetadataServiceVersion;

        /// <summary>
        /// Gets and sets the property MinimumInstanceMetadataServiceVersion. 
        /// <para>
        /// Indicates the minimum IMDS version that the notebook instance supports. When passed
        /// as part of <c>CreateNotebookInstance</c>, if no value is selected, then it defaults
        /// to IMDSv1. This means that both IMDSv1 and IMDSv2 are supported. If passed as part
        /// of <c>UpdateNotebookInstance</c>, there is no default.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public string MinimumInstanceMetadataServiceVersion
        {
            get { return this._minimumInstanceMetadataServiceVersion; }
            set { this._minimumInstanceMetadataServiceVersion = value; }
        }

        // Check to see if MinimumInstanceMetadataServiceVersion property is set
        internal bool IsSetMinimumInstanceMetadataServiceVersion()
        {
            return this._minimumInstanceMetadataServiceVersion != null;
        }

    }
}