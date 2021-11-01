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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// The dataset used for testing. Optionally, if <code>AutoCreate</code> is set, Amazon
    /// Rekognition Custom Labels uses the training dataset to create a test dataset with
    /// a temporary split of the training dataset.
    /// </summary>
    public partial class TestingData
    {
        private List<Asset> _assets = new List<Asset>();
        private bool? _autoCreate;

        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// The assets used for testing.
        /// </para>
        /// </summary>
        public List<Asset> Assets
        {
            get { return this._assets; }
            set { this._assets = value; }
        }

        // Check to see if Assets property is set
        internal bool IsSetAssets()
        {
            return this._assets != null && this._assets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoCreate. 
        /// <para>
        /// If specified, Amazon Rekognition Custom Labels temporarily splits the training dataset
        /// (80%) to create a test dataset (20%) for the training job. After training completes,
        /// the test dataset is not stored and the training dataset reverts to its previous size.
        /// </para>
        /// </summary>
        public bool AutoCreate
        {
            get { return this._autoCreate.GetValueOrDefault(); }
            set { this._autoCreate = value; }
        }

        // Check to see if AutoCreate property is set
        internal bool IsSetAutoCreate()
        {
            return this._autoCreate.HasValue; 
        }

    }
}