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
    /// A collection of Amazon Q feature configurations in an embedded QuickSight console.
    /// </summary>
    public partial class AmazonQInQuickSightConsoleConfigurations
    {
        private DataQnAConfigurations _dataQnA;
        private DataStoriesConfigurations _dataStories;
        private ExecutiveSummaryConfigurations _executiveSummary;
        private GenerativeAuthoringConfigurations _generativeAuthoring;

        /// <summary>
        /// Gets and sets the property DataQnA. 
        /// <para>
        /// Adds generative Q&amp;A capabilitiees to an embedded QuickSight console.
        /// </para>
        /// </summary>
        public DataQnAConfigurations DataQnA
        {
            get { return this._dataQnA; }
            set { this._dataQnA = value; }
        }

        // Check to see if DataQnA property is set
        internal bool IsSetDataQnA()
        {
            return this._dataQnA != null;
        }

        /// <summary>
        /// Gets and sets the property DataStories. 
        /// <para>
        /// Adds the data stories feature to an embedded QuickSight console.
        /// </para>
        /// </summary>
        public DataStoriesConfigurations DataStories
        {
            get { return this._dataStories; }
            set { this._dataStories = value; }
        }

        // Check to see if DataStories property is set
        internal bool IsSetDataStories()
        {
            return this._dataStories != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutiveSummary. 
        /// <para>
        /// Adds the executive summaries feature to an embedded QuickSight console.
        /// </para>
        /// </summary>
        public ExecutiveSummaryConfigurations ExecutiveSummary
        {
            get { return this._executiveSummary; }
            set { this._executiveSummary = value; }
        }

        // Check to see if ExecutiveSummary property is set
        internal bool IsSetExecutiveSummary()
        {
            return this._executiveSummary != null;
        }

        /// <summary>
        /// Gets and sets the property GenerativeAuthoring. 
        /// <para>
        /// Adds the generative BI authoring experience to an embedded QuickSight console.
        /// </para>
        /// </summary>
        public GenerativeAuthoringConfigurations GenerativeAuthoring
        {
            get { return this._generativeAuthoring; }
            set { this._generativeAuthoring = value; }
        }

        // Check to see if GenerativeAuthoring property is set
        internal bool IsSetGenerativeAuthoring()
        {
            return this._generativeAuthoring != null;
        }

    }
}