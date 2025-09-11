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
    /// The settings that you want to use for the Generative Q&amp;A experience.
    /// </summary>
    public partial class AnonymousUserGenerativeQnAEmbeddingConfiguration
    {
        private string _initialTopicId;

        /// <summary>
        /// Gets and sets the property InitialTopicId. 
        /// <para>
        /// The QuickSight Q topic ID of the new reader experience topic that you want the anonymous
        /// user to see first. This ID is included in the output URL. When the URL in response
        /// is accessed, QuickSight renders the Generative Q&amp;A experience with this new reader
        /// experience topic pre selected.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Resource Name (ARN) of this Q new reader experience topic must be included
        /// in the <c>AuthorizedResourceArns</c> parameter. Otherwise, the request fails with
        /// an <c>InvalidParameterValueException</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string InitialTopicId
        {
            get { return this._initialTopicId; }
            set { this._initialTopicId = value; }
        }

        // Check to see if InitialTopicId property is set
        internal bool IsSetInitialTopicId()
        {
            return this._initialTopicId != null;
        }

    }
}