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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
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
namespace Amazon.FIS.Model
{
    /// <summary>
    /// Specifies a stop condition for an experiment template.
    /// </summary>
    public partial class CreateExperimentTemplateStopConditionInput
    {
        private string _source;
        private string _value;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source for the stop condition. Specify <c>aws:cloudwatch:alarm</c> if the stop
        /// condition is defined by a CloudWatch alarm. Specify <c>none</c> if there is no stop
        /// condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch alarm. This is required if the source
        /// is a CloudWatch alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}