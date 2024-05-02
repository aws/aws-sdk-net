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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the GetTelemetryMetadata operation.
    /// Information about the data that is collected for the specified assessment run.
    /// </summary>
    public partial class GetTelemetryMetadataRequest : AmazonInspectorRequest
    {
        private string _assessmentRunArn;

        /// <summary>
        /// Gets and sets the property AssessmentRunArn. 
        /// <para>
        /// The ARN that specifies the assessment run that has the telemetry data that you want
        /// to obtain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string AssessmentRunArn
        {
            get { return this._assessmentRunArn; }
            set { this._assessmentRunArn = value; }
        }

        // Check to see if AssessmentRunArn property is set
        internal bool IsSetAssessmentRunArn()
        {
            return this._assessmentRunArn != null;
        }

    }
}