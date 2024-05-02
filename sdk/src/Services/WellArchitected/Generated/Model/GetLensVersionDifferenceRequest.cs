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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the GetLensVersionDifference operation.
    /// Get lens version differences.
    /// </summary>
    public partial class GetLensVersionDifferenceRequest : AmazonWellArchitectedRequest
    {
        private string _baseLensVersion;
        private string _lensAlias;
        private string _targetLensVersion;

        /// <summary>
        /// Gets and sets the property BaseLensVersion. 
        /// <para>
        /// The base version of the lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string BaseLensVersion
        {
            get { return this._baseLensVersion; }
            set { this._baseLensVersion = value; }
        }

        // Check to see if BaseLensVersion property is set
        internal bool IsSetBaseLensVersion()
        {
            return this._baseLensVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string LensAlias
        {
            get { return this._lensAlias; }
            set { this._lensAlias = value; }
        }

        // Check to see if LensAlias property is set
        internal bool IsSetLensAlias()
        {
            return this._lensAlias != null;
        }

        /// <summary>
        /// Gets and sets the property TargetLensVersion. 
        /// <para>
        /// The lens version to target a difference for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string TargetLensVersion
        {
            get { return this._targetLensVersion; }
            set { this._targetLensVersion = value; }
        }

        // Check to see if TargetLensVersion property is set
        internal bool IsSetTargetLensVersion()
        {
            return this._targetLensVersion != null;
        }

    }
}