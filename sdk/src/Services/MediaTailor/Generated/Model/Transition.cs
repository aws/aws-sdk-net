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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Program transition configuration.
    /// </summary>
    public partial class Transition
    {
        private RelativePosition _relativePosition;
        private string _relativeProgram;
        private string _type;

        /// <summary>
        /// Gets and sets the property RelativePosition. 
        /// <para>
        /// The position where this program will be inserted relative to the RelativeProgram.
        /// Possible values are: AFTER_PROGRAM, and BEFORE_PROGRAM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelativePosition RelativePosition
        {
            get { return this._relativePosition; }
            set { this._relativePosition = value; }
        }

        // Check to see if RelativePosition property is set
        internal bool IsSetRelativePosition()
        {
            return this._relativePosition != null;
        }

        /// <summary>
        /// Gets and sets the property RelativeProgram. 
        /// <para>
        /// The name of the program that this program will be inserted next to, as defined by
        /// RelativePosition.
        /// </para>
        /// </summary>
        public string RelativeProgram
        {
            get { return this._relativeProgram; }
            set { this._relativeProgram = value; }
        }

        // Check to see if RelativeProgram property is set
        internal bool IsSetRelativeProgram()
        {
            return this._relativeProgram != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// When the program should be played. RELATIVE means that programs will be played back-to-back.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}