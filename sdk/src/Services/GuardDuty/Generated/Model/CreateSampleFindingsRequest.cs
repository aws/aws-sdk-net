/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSampleFindings operation.
    /// Generates example findings of types specified by the list of finding types. If 'NULL'
    /// is specified for findingTypes, the API generates example findings of all supported
    /// finding types.
    /// </summary>
    public partial class CreateSampleFindingsRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;
        private List<string> _findingTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property DetectorId. The ID of the detector to create sample findings
        /// for.
        /// </summary>
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property FindingTypes. Types of sample findings that you want to
        /// generate.
        /// </summary>
        public List<string> FindingTypes
        {
            get { return this._findingTypes; }
            set { this._findingTypes = value; }
        }

        // Check to see if FindingTypes property is set
        internal bool IsSetFindingTypes()
        {
            return this._findingTypes != null && this._findingTypes.Count > 0; 
        }

    }
}