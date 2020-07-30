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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Specifies restrictions for the batch build.
    /// </summary>
    public partial class BatchRestrictions
    {
        private List<string> _computeTypesAllowed = new List<string>();
        private int? _maximumBuildsAllowed;

        /// <summary>
        /// Gets and sets the property ComputeTypesAllowed. 
        /// <para>
        /// An array of strings that specify the compute types that are allowed for the batch
        /// build. See <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html">Build
        /// environment compute types</a> in the <i>AWS CodeBuild User Guide</i> for these values.
        /// 
        /// </para>
        /// </summary>
        public List<string> ComputeTypesAllowed
        {
            get { return this._computeTypesAllowed; }
            set { this._computeTypesAllowed = value; }
        }

        // Check to see if ComputeTypesAllowed property is set
        internal bool IsSetComputeTypesAllowed()
        {
            return this._computeTypesAllowed != null && this._computeTypesAllowed.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaximumBuildsAllowed. 
        /// <para>
        /// Specifies the maximum number of builds allowed.
        /// </para>
        /// </summary>
        public int MaximumBuildsAllowed
        {
            get { return this._maximumBuildsAllowed.GetValueOrDefault(); }
            set { this._maximumBuildsAllowed = value; }
        }

        // Check to see if MaximumBuildsAllowed property is set
        internal bool IsSetMaximumBuildsAllowed()
        {
            return this._maximumBuildsAllowed.HasValue; 
        }

    }
}