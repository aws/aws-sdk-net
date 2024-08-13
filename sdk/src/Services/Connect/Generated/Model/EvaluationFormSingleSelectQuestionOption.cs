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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the automation configuration in single select questions.
    /// </summary>
    public partial class EvaluationFormSingleSelectQuestionOption
    {
        private bool? _automaticFail;
        private string _refId;
        private int? _score;
        private string _text;

        /// <summary>
        /// Gets and sets the property AutomaticFail. 
        /// <para>
        /// The flag to mark the option as automatic fail. If an automatic fail answer is provided,
        /// the overall evaluation gets a score of 0.
        /// </para>
        /// </summary>
        public bool? AutomaticFail
        {
            get { return this._automaticFail; }
            set { this._automaticFail = value; }
        }

        // Check to see if AutomaticFail property is set
        internal bool IsSetAutomaticFail()
        {
            return this._automaticFail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RefId. 
        /// <para>
        /// The identifier of the answer option. An identifier must be unique within the question.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string RefId
        {
            get { return this._refId; }
            set { this._refId = value; }
        }

        // Check to see if RefId property is set
        internal bool IsSetRefId()
        {
            return this._refId != null;
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The score assigned to the answer option.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int? Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The title of the answer option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}