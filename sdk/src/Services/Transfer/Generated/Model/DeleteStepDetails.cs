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
    /// The name of the step, used to identify the delete step.
    /// </summary>
    public partial class DeleteStepDetails
    {
        private string _name;
        private string _sourceFileLocation;

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
        /// Enter <code>${previous.file}</code> to use the previous file as the input. In this
        /// case, this workflow step uses the output file from the previous workflow step as input.
        /// This is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enter <code>${original.file}</code> to use the originally-uploaded file location as
        /// input for this step.
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

    }
}