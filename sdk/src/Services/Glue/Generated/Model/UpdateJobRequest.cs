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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateJob operation.
    /// Updates an existing job definition. The previous job definition is completely overwritten
    /// by this information.
    /// </summary>
    public partial class UpdateJobRequest : AmazonGlueRequest
    {
        private string _jobName;
        private JobUpdate _jobUpdate;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job definition to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobUpdate. 
        /// <para>
        /// Specifies the values with which to update the job definition. Unspecified configuration
        /// is removed or reset to default values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobUpdate JobUpdate
        {
            get { return this._jobUpdate; }
            set { this._jobUpdate = value; }
        }

        // Check to see if JobUpdate property is set
        internal bool IsSetJobUpdate()
        {
            return this._jobUpdate != null;
        }

    }
}