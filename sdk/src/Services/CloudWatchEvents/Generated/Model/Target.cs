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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Targets are the resources that can be invoked when a rule is triggered. For example,
    /// AWS Lambda functions, Amazon Kinesis streams, and built-in targets.
    /// 
    ///  
    /// <para>
    /// <b>Input</b> and <b>InputPath</b> are mutually-exclusive and optional parameters of
    /// a target. When a rule is triggered due to a matched event, if for a target:
    /// </para>
    ///  <ul> <li>Neither <b>Input</b> nor <b>InputPath</b> is specified, then the entire
    /// event is passed to the target in JSON form.</li> <li><b>InputPath</b> is specified
    /// in the form of JSONPath (e.g. <b>$.detail</b>), then only the part of the event specified
    /// in the path is passed to the target (e.g. only the detail part of the event is passed).
    /// </li> <li><b>Input</b> is specified in the form of a valid JSON, then the matched
    /// event is overridden with this constant.</li> </ul>
    /// </summary>
    public partial class Target
    {
        private string _arn;
        private string _id;
        private string _input;
        private string _inputPath;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated of the target.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique target assignment ID.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Valid JSON text passed to the target. For more information about JSON text, see <a
        /// href="http://www.rfc-editor.org/rfc/rfc7159.txt">The JavaScript Object Notation (JSON)
        /// Data Interchange Format</a>.
        /// </para>
        /// </summary>
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property InputPath. 
        /// <para>
        /// The value of the JSONPath that is used for extracting part of the matched event when
        /// passing it to the target. For more information about JSON paths, see <a href="http://goessner.net/articles/JsonPath/">JSONPath</a>.
        /// </para>
        /// </summary>
        public string InputPath
        {
            get { return this._inputPath; }
            set { this._inputPath = value; }
        }

        // Check to see if InputPath property is set
        internal bool IsSetInputPath()
        {
            return this._inputPath != null;
        }

    }
}