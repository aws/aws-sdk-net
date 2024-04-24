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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The structure representing the updateProfilingGroupResponse.
    /// </summary>
    public partial class UpdateProfilingGroupResponse : AmazonWebServiceResponse
    {
        private ProfilingGroupDescription _profilingGroup;

        /// <summary>
        /// Gets and sets the property ProfilingGroup. 
        /// <para>
        ///  A <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingGroupDescription.html">
        /// <c>ProfilingGroupDescription</c> </a> that contains information about the returned
        /// updated profiling group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProfilingGroupDescription ProfilingGroup
        {
            get { return this._profilingGroup; }
            set { this._profilingGroup = value; }
        }

        // Check to see if ProfilingGroup property is set
        internal bool IsSetProfilingGroup()
        {
            return this._profilingGroup != null;
        }

    }
}