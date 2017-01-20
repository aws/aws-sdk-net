/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Identifies
    /// </summary>
    public partial class LambdaResource
    {
        private List<EventTriggerDefinition> _eventTriggers = new List<EventTriggerDefinition>();
        private string _lambdaArn;

        /// <summary>
        /// Gets and sets the property EventTriggers. 
        /// <para>
        /// The array of ARNs for <a>S3Resource</a> objects to trigger the <a>LambdaResource</a>
        /// objects associated with this job.
        /// </para>
        /// </summary>
        public List<EventTriggerDefinition> EventTriggers
        {
            get { return this._eventTriggers; }
            set { this._eventTriggers = value; }
        }

        // Check to see if EventTriggers property is set
        internal bool IsSetEventTriggers()
        {
            return this._eventTriggers != null && this._eventTriggers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that represents an AWS Lambda function to be triggered
        /// by PUT object actions on the associated local Amazon S3 resource.
        /// </para>
        /// </summary>
        public string LambdaArn
        {
            get { return this._lambdaArn; }
            set { this._lambdaArn = value; }
        }

        // Check to see if LambdaArn property is set
        internal bool IsSetLambdaArn()
        {
            return this._lambdaArn != null;
        }

    }
}