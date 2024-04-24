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
 * Do not modify this file. This file is generated from the connect-contact-lens-2020-08-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// Potential issues that are detected based on an artificial intelligence analysis of
    /// each turn in the conversation.
    /// </summary>
    public partial class IssueDetected
    {
        private CharacterOffsets _characterOffsets;

        /// <summary>
        /// Gets and sets the property CharacterOffsets. 
        /// <para>
        /// The offset for when the issue was detected in the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CharacterOffsets CharacterOffsets
        {
            get { return this._characterOffsets; }
            set { this._characterOffsets = value; }
        }

        // Check to see if CharacterOffsets property is set
        internal bool IsSetCharacterOffsets()
        {
            return this._characterOffsets != null;
        }

    }
}