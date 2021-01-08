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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// This is the response object from the DescribeFeatureTransformation operation.
    /// </summary>
    public partial class DescribeFeatureTransformationResponse : AmazonWebServiceResponse
    {
        private FeatureTransformation _featureTransformation;

        /// <summary>
        /// Gets and sets the property FeatureTransformation. 
        /// <para>
        /// A listing of the FeatureTransformation properties.
        /// </para>
        /// </summary>
        public FeatureTransformation FeatureTransformation
        {
            get { return this._featureTransformation; }
            set { this._featureTransformation = value; }
        }

        // Check to see if FeatureTransformation property is set
        internal bool IsSetFeatureTransformation()
        {
            return this._featureTransformation != null;
        }

    }
}