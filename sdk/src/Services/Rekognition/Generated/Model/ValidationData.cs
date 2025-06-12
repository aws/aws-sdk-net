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
    /// Contains the Amazon S3 bucket location of the validation data for a model training
    /// job. 
    /// 
    ///  
    /// <para>
    /// The validation data includes error information for individual JSON Lines in the dataset.
    /// For more information, see <i>Debugging a Failed Model Training</i> in the Amazon Rekognition
    /// Custom Labels Developer Guide. 
    /// </para>
    ///  
    /// <para>
    /// You get the <c>ValidationData</c> object for the training dataset (<a>TrainingDataResult</a>)
    /// and the test dataset (<a>TestingDataResult</a>) by calling <a>DescribeProjectVersions</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// The assets array contains a single <a>Asset</a> object. The <a>GroundTruthManifest</a>
    /// field of the Asset object contains the S3 bucket location of the validation data.
    /// 
    /// </para>
    /// </summary>
    public partial class ValidationData
    {
        private List<Asset> _assets = AWSConfigs.InitializeCollections ? new List<Asset>() : null;

        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// The assets that comprise the validation data. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Asset> Assets
        {
            get { return this._assets; }
            set { this._assets = value; }
        }

        // Check to see if Assets property is set
        internal bool IsSetAssets()
        {
            return this._assets != null && (this._assets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}