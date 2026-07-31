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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Topic reference.
    /// </summary>
    public partial class TopicReference
    {
        private string _topicArn;
        private string _topicPlaceholder;

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// Topic Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

        /// <summary>
        /// Gets and sets the property TopicPlaceholder. 
        /// <para>
        /// Topic placeholder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TopicPlaceholder
        {
            get { return this._topicPlaceholder; }
            set { this._topicPlaceholder = value; }
        }

        // Check to see if TopicPlaceholder property is set
        internal bool IsSetTopicPlaceholder()
        {
            return this._topicPlaceholder != null;
        }

    }
}