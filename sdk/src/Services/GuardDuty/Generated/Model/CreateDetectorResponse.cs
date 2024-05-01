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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// This is the response object from the CreateDetector operation.
    /// </summary>
    public partial class CreateDetectorResponse : AmazonWebServiceResponse
    {
        private string _detectorId;
        private UnprocessedDataSourcesResult _unprocessedDataSources;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the created detector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property UnprocessedDataSources. 
        /// <para>
        /// Specifies the data sources that couldn't be enabled when GuardDuty was enabled for
        /// the first time.
        /// </para>
        /// </summary>
        public UnprocessedDataSourcesResult UnprocessedDataSources
        {
            get { return this._unprocessedDataSources; }
            set { this._unprocessedDataSources = value; }
        }

        // Check to see if UnprocessedDataSources property is set
        internal bool IsSetUnprocessedDataSources()
        {
            return this._unprocessedDataSources != null;
        }

    }
}