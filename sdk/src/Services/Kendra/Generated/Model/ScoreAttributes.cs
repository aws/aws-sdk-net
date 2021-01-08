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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides a relative ranking that indicates how confident Amazon Kendra is that the
    /// response matches the query.
    /// </summary>
    public partial class ScoreAttributes
    {
        private ScoreConfidence _scoreConfidence;

        /// <summary>
        /// Gets and sets the property ScoreConfidence. 
        /// <para>
        /// A relative ranking for how well the response matches the query.
        /// </para>
        /// </summary>
        public ScoreConfidence ScoreConfidence
        {
            get { return this._scoreConfidence; }
            set { this._scoreConfidence = value; }
        }

        // Check to see if ScoreConfidence property is set
        internal bool IsSetScoreConfidence()
        {
            return this._scoreConfidence != null;
        }

    }
}