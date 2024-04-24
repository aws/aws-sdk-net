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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Details about the content data.
    /// </summary>
    public partial class ContentDataDetails
    {
        private RankingData _rankingData;
        private TextData _textData;

        /// <summary>
        /// Gets and sets the property RankingData. 
        /// <para>
        /// Details about the content ranking data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RankingData RankingData
        {
            get { return this._rankingData; }
            set { this._rankingData = value; }
        }

        // Check to see if RankingData property is set
        internal bool IsSetRankingData()
        {
            return this._rankingData != null;
        }

        /// <summary>
        /// Gets and sets the property TextData. 
        /// <para>
        /// Details about the content text data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TextData TextData
        {
            get { return this._textData; }
            set { this._textData = value; }
        }

        // Check to see if TextData property is set
        internal bool IsSetTextData()
        {
            return this._textData != null;
        }

    }
}