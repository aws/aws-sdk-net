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
    /// </summary>
    public partial class CopyStepDetails
    {
        private InputFileLocation _destinationFileLocation;
        private string _name;
        private OverwriteExisting _overwriteExisting;
        private string _sourceFileLocation;

        /// <summary>
        /// Gets and sets the property DestinationFileLocation. 
        /// <para>
        /// Specifies the location for the file being copied. Use <code>${Transfer:username}</code>
        /// or <code>${Transfer:UploadDate}</code> in this field to parametrize the destination
        /// prefix by username or uploaded date.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set the value of <code>DestinationFileLocation</code> to <code>${Transfer:username}</code>
        /// to copy uploaded files to an Amazon S3 bucket that is prefixed with the name of the
        /// Transfer Family user that uploaded the file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set the value of <code>DestinationFileLocation</code> to <code>${Transfer:UploadDate}</code>
        /// to copy uploaded files to an Amazon S3 bucket that is prefixed with the date of the
        /// upload.
        /// </para>
        ///  <note> 
        /// <para>
        /// The system resolves <code>UploadDate</code> to a date format of <i>YYYY-MM-DD</i>,
        /// based on the date the file is uploaded.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public InputFileLocation DestinationFileLocation
        {
            get { return this._destinationFileLocation; }
            set { this._destinationFileLocation = value; }
        }

        // Check to see if DestinationFileLocation property is set
        internal bool IsSetDestinationFileLocation()
        {
            return this._destinationFileLocation != null;
        }

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
        /// Gets and sets the property OverwriteExisting. 
        /// <para>
        /// A flag that indicates whether to overwrite an existing file of the same name. The
        /// default is <code>FALSE</code>.
        /// </para>
        /// </summary>
        public OverwriteExisting OverwriteExisting
        {
            get { return this._overwriteExisting; }
            set { this._overwriteExisting = value; }
        }

        // Check to see if OverwriteExisting property is set
        internal bool IsSetOverwriteExisting()
        {
            return this._overwriteExisting != null;
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

    }
}