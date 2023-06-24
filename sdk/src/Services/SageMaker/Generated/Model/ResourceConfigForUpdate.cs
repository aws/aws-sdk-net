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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The <code>ResourceConfig</code> to update <code>KeepAlivePeriodInSeconds</code>. Other
    /// fields in the <code>ResourceConfig</code> cannot be updated.
    /// </summary>
    public partial class ResourceConfigForUpdate
    {
        private int? _keepAlivePeriodInSeconds;

        /// <summary>
        /// Gets and sets the property KeepAlivePeriodInSeconds. 
        /// <para>
        /// The <code>KeepAlivePeriodInSeconds</code> value specified in the <code>ResourceConfig</code>
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=3600)]
        public int KeepAlivePeriodInSeconds
        {
            get { return this._keepAlivePeriodInSeconds.GetValueOrDefault(); }
            set { this._keepAlivePeriodInSeconds = value; }
        }

        // Check to see if KeepAlivePeriodInSeconds property is set
        internal bool IsSetKeepAlivePeriodInSeconds()
        {
            return this._keepAlivePeriodInSeconds.HasValue; 
        }

    }
}