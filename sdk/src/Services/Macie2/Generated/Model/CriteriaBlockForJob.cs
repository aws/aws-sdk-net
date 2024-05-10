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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies one or more property- and tag-based conditions that define criteria for
    /// including or excluding S3 buckets from a classification job.
    /// </summary>
    public partial class CriteriaBlockForJob
    {
        private List<CriteriaForJob> _and = AWSConfigs.InitializeCollections ? new List<CriteriaForJob>() : null;

        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// An array of conditions, one for each condition that determines which buckets to include
        /// or exclude from the job. If you specify more than one condition, Amazon Macie uses
        /// AND logic to join the conditions.
        /// </para>
        /// </summary>
        public List<CriteriaForJob> And
        {
            get { return this._and; }
            set { this._and = value; }
        }

        // Check to see if And property is set
        internal bool IsSetAnd()
        {
            return this._and != null && (this._and.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}