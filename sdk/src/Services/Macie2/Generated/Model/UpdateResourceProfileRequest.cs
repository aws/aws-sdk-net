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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResourceProfile operation.
    /// Updates the sensitivity score for an S3 bucket.
    /// </summary>
    public partial class UpdateResourceProfileRequest : AmazonMacie2Request
    {
        private string _resourceArn;
        private int? _sensitivityScoreOverride;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket that the request applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SensitivityScoreOverride. 
        /// <para>
        /// The new sensitivity score for the bucket. Valid values are: 100, assign the maximum
        /// score and apply the <i>Sensitive</i> label to the bucket; and, null (empty), assign
        /// a score that Amazon Macie calculates automatically after you submit the request.
        /// </para>
        /// </summary>
        public int SensitivityScoreOverride
        {
            get { return this._sensitivityScoreOverride.GetValueOrDefault(); }
            set { this._sensitivityScoreOverride = value; }
        }

        // Check to see if SensitivityScoreOverride property is set
        internal bool IsSetSensitivityScoreOverride()
        {
            return this._sensitivityScoreOverride.HasValue; 
        }

    }
}