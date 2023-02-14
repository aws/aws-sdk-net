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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Each step type has its own <code>StepDetails</code> structure.
    /// 
    ///  
    /// <para>
    /// The key/value pairs used to tag a file during the execution of a workflow step.
    /// </para>
    /// </summary>
    public partial class TagStepDetails
    {
        private string _name;
        private string _sourceFileLocation;
        private List<S3Tag> _tags = new List<S3Tag>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the step, used as an identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFileLocation. 
        /// <para>
        /// Specifies which file to use as input to the workflow step: either the output from
        /// the previous step, or the originally uploaded file for the workflow.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To use the previous file as the input, enter <code>${previous.file}</code>. In this
        /// case, this workflow step uses the output file from the previous workflow step as input.
        /// This is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To use the originally uploaded file location as input for this step, enter <code>${original.file}</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SourceFileLocation
        {
            get { return this._sourceFileLocation; }
            set { this._sourceFileLocation = value; }
        }

        // Check to see if SourceFileLocation property is set
        internal bool IsSetSourceFileLocation()
        {
            return this._sourceFileLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Array that contains from 1 to 10 key/value pairs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<S3Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}