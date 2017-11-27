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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Contains details about the output groups specified in the job settings.
    /// </summary>
    public partial class OutputGroupDetail
    {
        private List<OutputDetail> _outputDetails = new List<OutputDetail>();

        /// <summary>
        /// Gets and sets the property OutputDetails. Details about the output
        /// </summary>
        public List<OutputDetail> OutputDetails
        {
            get { return this._outputDetails; }
            set { this._outputDetails = value; }
        }

        // Check to see if OutputDetails property is set
        internal bool IsSetOutputDetails()
        {
            return this._outputDetails != null && this._outputDetails.Count > 0; 
        }

    }
}