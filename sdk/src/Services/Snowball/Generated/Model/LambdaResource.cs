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
    /// Identifies
    /// </summary>
    public partial class LambdaResource
    {
        private List<EventTriggerDefinition> _eventTriggers = AWSConfigs.InitializeCollections ? new List<EventTriggerDefinition>() : null;
        private string _lambdaArn;

        /// <summary>
        /// Gets and sets the property EventTriggers. 
        /// <para>
        /// The array of ARNs for <a>S3Resource</a> objects to trigger the <a>LambdaResource</a>
        /// objects associated with this job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EventTriggerDefinition> EventTriggers
        {
            get { return this._eventTriggers; }
            set { this._eventTriggers = value; }
        }

        // Check to see if EventTriggers property is set
        internal bool IsSetEventTriggers()
        {
            return this._eventTriggers != null && (this._eventTriggers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that represents an Lambda function to be triggered by
        /// PUT object actions on the associated local Amazon S3 resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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