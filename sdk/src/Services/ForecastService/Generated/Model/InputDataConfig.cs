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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The data used to train a predictor. The data includes a dataset group and any supplementary
    /// features. You specify this object in the <a>CreatePredictor</a> request.
    /// </summary>
    public partial class InputDataConfig
    {
        private string _datasetGroupArn;
        private List<SupplementaryFeature> _supplementaryFeatures = new List<SupplementaryFeature>();

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property SupplementaryFeatures. 
        /// <para>
        /// An array of supplementary features. The only supported feature is a holiday calendar.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<SupplementaryFeature> SupplementaryFeatures
        {
            get { return this._supplementaryFeatures; }
            set { this._supplementaryFeatures = value; }
        }

        // Check to see if SupplementaryFeatures property is set
        internal bool IsSetSupplementaryFeatures()
        {
            return this._supplementaryFeatures != null && this._supplementaryFeatures.Count > 0; 
        }

    }
}