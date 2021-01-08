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
    /// This is the response object from the DetectCustomLabels operation.
    /// </summary>
    public partial class DetectCustomLabelsResponse : AmazonWebServiceResponse
    {
        private List<CustomLabel> _customLabels = new List<CustomLabel>();

        /// <summary>
        /// Gets and sets the property CustomLabels. 
        /// <para>
        /// An array of custom labels detected in the input image.
        /// </para>
        /// </summary>
        public List<CustomLabel> CustomLabels
        {
            get { return this._customLabels; }
            set { this._customLabels = value; }
        }

        // Check to see if CustomLabels property is set
        internal bool IsSetCustomLabels()
        {
            return this._customLabels != null && this._customLabels.Count > 0; 
        }

    }
}