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
    /// An object that provides information about the configuration of a Generative Q&amp;A
    /// experience.
    /// </summary>
    public partial class RegisteredUserGenerativeQnAEmbeddingConfiguration
    {
        private string _initialTopicId;

        /// <summary>
        /// Gets and sets the property InitialTopicId. 
        /// <para>
        /// The ID of the new Q reader experience topic that you want to make the starting topic
        /// in the Generative Q&amp;A experience. You can find a topic ID by navigating to the
        /// Topics pane in the QuickSight application and opening a topic. The ID is in the URL
        /// for the topic that you open.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an initial topic or you specify a legacy topic, a list of all
        /// shared new reader experience topics is shown in the Generative Q&amp;A experience
        /// for your readers. When you select an initial new reader experience topic, you can
        /// specify whether or not readers are allowed to select other new reader experience topics
        /// from the available ones in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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