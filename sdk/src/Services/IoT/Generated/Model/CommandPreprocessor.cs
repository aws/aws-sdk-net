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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Configuration that determines how the <c>payloadTemplate</c> is processed by the service
    /// to generate the final payload sent to devices at <c>StartCommandExecution</c> API
    /// invocation.
    /// </summary>
    public partial class CommandPreprocessor
    {
        private AwsJsonSubstitutionCommandPreprocessorConfig _awsJsonSubstitution;

        /// <summary>
        /// Gets and sets the property AwsJsonSubstitution. 
        /// <para>
        /// Configuration for the JSON substitution preprocessor.
        /// </para>
        /// </summary>
        public AwsJsonSubstitutionCommandPreprocessorConfig AwsJsonSubstitution
        {
            get { return this._awsJsonSubstitution; }
            set { this._awsJsonSubstitution = value; }
        }

        // Check to see if AwsJsonSubstitution property is set
        internal bool IsSetAwsJsonSubstitution()
        {
            return this._awsJsonSubstitution != null;
        }

    }
}