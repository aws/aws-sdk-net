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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Information about the location of a manifest file that Amazon Lookout for Vision uses
    /// to to create a dataset.
    /// </summary>
    public partial class DatasetSource
    {
        private DatasetGroundTruthManifest _groundTruthManifest;

        /// <summary>
        /// Gets and sets the property GroundTruthManifest. 
        /// <para>
        /// Location information for the manifest file.
        /// </para>
        /// </summary>
        public DatasetGroundTruthManifest GroundTruthManifest
        {
            get { return this._groundTruthManifest; }
            set { this._groundTruthManifest = value; }
        }

        // Check to see if GroundTruthManifest property is set
        internal bool IsSetGroundTruthManifest()
        {
            return this._groundTruthManifest != null;
        }

    }
}