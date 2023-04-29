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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MultiMeasureMappings
    {
        private List<MultiMeasureAttributeMapping> _multiMeasureAttributeMappings = new List<MultiMeasureAttributeMapping>();
        private string _targetMultiMeasureName;

        /// <summary>
        /// Gets and sets the property MultiMeasureAttributeMappings.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<MultiMeasureAttributeMapping> MultiMeasureAttributeMappings
        {
            get { return this._multiMeasureAttributeMappings; }
            set { this._multiMeasureAttributeMappings = value; }
        }

        // Check to see if MultiMeasureAttributeMappings property is set
        internal bool IsSetMultiMeasureAttributeMappings()
        {
            return this._multiMeasureAttributeMappings != null && this._multiMeasureAttributeMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetMultiMeasureName.
        /// </summary>
        [AWSProperty(Min=1)]
        public string TargetMultiMeasureName
        {
            get { return this._targetMultiMeasureName; }
            set { this._targetMultiMeasureName = value; }
        }

        // Check to see if TargetMultiMeasureName property is set
        internal bool IsSetTargetMultiMeasureName()
        {
            return this._targetMultiMeasureName != null;
        }

    }
}