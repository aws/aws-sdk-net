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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Determine whether your data volume persists on the host container instance and where
    /// it's stored. If this parameter is empty, then the Docker daemon assigns a host path
    /// for your data volume. However, the data isn't guaranteed to persist after the containers
    /// that are associated with it stop running.
    /// </summary>
    public partial class Host
    {
        private string _sourcePath;

        /// <summary>
        /// Gets and sets the property SourcePath. 
        /// <para>
        /// The path on the host container instance that's presented to the container. If this
        /// parameter is empty, then the Docker daemon has assigned a host path for you. If this
        /// parameter contains a file location, then the data volume persists at the specified
        /// location on the host container instance until you delete it manually. If the source
        /// path location doesn't exist on the host container instance, the Docker daemon creates
        /// it. If the location does exist, the contents of the source path folder are exported.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that run on Fargate resources. Don't provide
        /// this for these jobs.
        /// </para>
        ///  </note>
        /// </summary>
        public string SourcePath
        {
            get { return this._sourcePath; }
            set { this._sourcePath = value; }
        }

        // Check to see if SourcePath property is set
        internal bool IsSetSourcePath()
        {
            return this._sourcePath != null;
        }

    }
}