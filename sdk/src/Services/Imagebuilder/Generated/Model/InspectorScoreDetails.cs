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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Information about the factors that influenced the score that Amazon Inspector assigned
    /// for a finding.
    /// </summary>
    public partial class InspectorScoreDetails
    {
        private CvssScoreDetails _adjustedCvss;

        /// <summary>
        /// Gets and sets the property AdjustedCvss. 
        /// <para>
        /// An object that contains details about an adjustment that Amazon Inspector made to
        /// the CVSS score for the finding.
        /// </para>
        /// </summary>
        public CvssScoreDetails AdjustedCvss
        {
            get { return this._adjustedCvss; }
            set { this._adjustedCvss = value; }
        }

        // Check to see if AdjustedCvss property is set
        internal bool IsSetAdjustedCvss()
        {
            return this._adjustedCvss != null;
        }

    }
}