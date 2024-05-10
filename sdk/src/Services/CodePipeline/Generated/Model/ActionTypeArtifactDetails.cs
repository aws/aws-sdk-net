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
    /// Information about parameters for artifacts associated with the action type, such as
    /// the minimum and maximum artifacts allowed.
    /// </summary>
    public partial class ActionTypeArtifactDetails
    {
        private int? _maximumCount;
        private int? _minimumCount;

        /// <summary>
        /// Gets and sets the property MaximumCount. 
        /// <para>
        /// The maximum number of artifacts that can be used with the actiontype. For example,
        /// you should specify a minimum and maximum of zero input artifacts for an action type
        /// with a category of <c>source</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public int? MaximumCount
        {
            get { return this._maximumCount; }
            set { this._maximumCount = value; }
        }

        // Check to see if MaximumCount property is set
        internal bool IsSetMaximumCount()
        {
            return this._maximumCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumCount. 
        /// <para>
        /// The minimum number of artifacts that can be used with the action type. For example,
        /// you should specify a minimum and maximum of zero input artifacts for an action type
        /// with a category of <c>source</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public int? MinimumCount
        {
            get { return this._minimumCount; }
            set { this._minimumCount = value; }
        }

        // Check to see if MinimumCount property is set
        internal bool IsSetMinimumCount()
        {
            return this._minimumCount.HasValue; 
        }

    }
}