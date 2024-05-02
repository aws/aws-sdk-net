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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// The container for the <a>EventTriggerDefinition$EventResourceARN</a>.
    /// </summary>
    public partial class EventTriggerDefinition
    {
        private string _eventResourceARN;

        /// <summary>
        /// Gets and sets the property EventResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for any local Amazon S3 resource that is an Lambda
        /// function's event trigger associated with this job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string EventResourceARN
        {
            get { return this._eventResourceARN; }
            set { this._eventResourceARN = value; }
        }

        // Check to see if EventResourceARN property is set
        internal bool IsSetEventResourceARN()
        {
            return this._eventResourceARN != null;
        }

    }
}