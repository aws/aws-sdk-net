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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The conditions for making checks for entry to a stage. For more information about
    /// conditions, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/stage-conditions.html">Stage
    /// conditions</a> and <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/concepts-how-it-works-conditions.html">How
    /// do stage conditions work?</a>.
    /// </summary>
    public partial class BeforeEntryConditions
    {
        private List<Condition> _conditions = AWSConfigs.InitializeCollections ? new List<Condition>() : null;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// The conditions that are configured as entry conditions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<Condition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && (this._conditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}