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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the DescribeSentimentDetectionJob operation.
    /// </summary>
    public partial class DescribeSentimentDetectionJobResponse : AmazonWebServiceResponse
    {
        private SentimentDetectionJobProperties _sentimentDetectionJobProperties;

        /// <summary>
        /// Gets and sets the property SentimentDetectionJobProperties. 
        /// <para>
        /// An object that contains the properties associated with a sentiment detection job.
        /// </para>
        /// </summary>
        public SentimentDetectionJobProperties SentimentDetectionJobProperties
        {
            get { return this._sentimentDetectionJobProperties; }
            set { this._sentimentDetectionJobProperties = value; }
        }

        // Check to see if SentimentDetectionJobProperties property is set
        internal bool IsSetSentimentDetectionJobProperties()
        {
            return this._sentimentDetectionJobProperties != null;
        }

    }
}