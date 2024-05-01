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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
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
namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// The request entry for Recommendation Resource exclusion. Each entry is a combination
    /// of Recommendation Resource ARN and corresponding exclusion status
    /// </summary>
    public partial class RecommendationResourceExclusion
    {
        private string _arn;
        private bool? _isExcluded;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Recommendation Resource
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property IsExcluded. 
        /// <para>
        /// The exclusion status
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsExcluded
        {
            get { return this._isExcluded; }
            set { this._isExcluded = value; }
        }

        // Check to see if IsExcluded property is set
        internal bool IsSetIsExcluded()
        {
            return this._isExcluded.HasValue; 
        }

    }
}