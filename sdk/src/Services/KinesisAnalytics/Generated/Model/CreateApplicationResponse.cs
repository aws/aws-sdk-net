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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// TBD
    /// </summary>
    public partial class CreateApplicationResponse : AmazonWebServiceResponse
    {
        private ApplicationSummary _applicationSummary;

        /// <summary>
        /// Gets and sets the property ApplicationSummary. 
        /// <para>
        /// In response to your <c>CreateApplication</c> request, Amazon Kinesis Analytics returns
        /// a response with a summary of the application it created, including the application
        /// Amazon Resource Name (ARN), name, and status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationSummary ApplicationSummary
        {
            get { return this._applicationSummary; }
            set { this._applicationSummary = value; }
        }

        // Check to see if ApplicationSummary property is set
        internal bool IsSetApplicationSummary()
        {
            return this._applicationSummary != null;
        }

    }
}