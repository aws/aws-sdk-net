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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// The profile choice.
    /// </summary>
    public partial class ProfileChoice
    {
        private string _choiceDescription;
        private string _choiceId;
        private string _choiceTitle;

        /// <summary>
        /// Gets and sets the property ChoiceDescription.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ChoiceDescription
        {
            get { return this._choiceDescription; }
            set { this._choiceDescription = value; }
        }

        // Check to see if ChoiceDescription property is set
        internal bool IsSetChoiceDescription()
        {
            return this._choiceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ChoiceId.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ChoiceId
        {
            get { return this._choiceId; }
            set { this._choiceId = value; }
        }

        // Check to see if ChoiceId property is set
        internal bool IsSetChoiceId()
        {
            return this._choiceId != null;
        }

        /// <summary>
        /// Gets and sets the property ChoiceTitle.
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ChoiceTitle
        {
            get { return this._choiceTitle; }
            set { this._choiceTitle = value; }
        }

        // Check to see if ChoiceTitle property is set
        internal bool IsSetChoiceTitle()
        {
            return this._choiceTitle != null;
        }

    }
}