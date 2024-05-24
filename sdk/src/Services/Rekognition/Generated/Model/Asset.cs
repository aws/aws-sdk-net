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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Assets are the images that you use to train and evaluate a model version. Assets can
    /// also contain validation information that you use to debug a failed model training.
    /// </summary>
    public partial class Asset
    {
        private GroundTruthManifest _groundTruthManifest;

        /// <summary>
        /// Gets and sets the property GroundTruthManifest.
        /// </summary>
        public GroundTruthManifest GroundTruthManifest
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